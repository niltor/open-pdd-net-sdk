using System.Security.Cryptography;

using Microsoft.Extensions.Hosting;

using Websocket.Client;

namespace PddOpenSdk.AspNetCore;

public class PddSocketHostServiceBase : IHostedService, IDisposable
{
    protected PddOptions _options;
    protected readonly ILogger<PddSocketHostServiceBase> _logger;
    protected Timer _timer; // 定时发送，避免被断开

    protected WebsocketClient client;
    public string socketUrl;

    public int HeartBeatSeconds { get; set; } = 5;
    public IServiceProvider Services { get; }
    public PddSocketHostServiceBase(
        ILogger<PddSocketHostServiceBase> logger,
        IServiceProvider services,
        IOptions<PddOptions> options)
    {
        _logger = logger;
        Services = services;
        _options = options.Value;
        HeartBeatSeconds = _options.HeartBeatSeconds;

        // 获取当前时间戳，并构造加密字段
        var currentTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        var digest = Digest(_options.ClientId, _options.ClientSecret, currentTime);

        socketUrl = string.IsNullOrEmpty(_options.SocketUrl) ? "wss://message-api.pinduoduo.com" : _options.SocketUrl;
        var url = $@"{socketUrl}/message/{_options.ClientId}/{currentTime}/{digest}";

        client = new WebsocketClient(new Uri(url));

    }
    public Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("socket 线程启动.");
        _logger.LogInformation("socket 开始连接.");
        OpenSocketAsync().Wait();
        _timer = new Timer(KeepOnline, null, TimeSpan.FromSeconds(3), TimeSpan.FromSeconds(HeartBeatSeconds));
        _logger.LogInformation("socket 心跳定时器已运行.");
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("后台服务结束.");
        _timer?.Change(Timeout.Infinite, 0);
        return Task.CompletedTask;
    }

    /// <summary>
    /// 定时发送，保持在线
    /// </summary>
    /// <param name="state"></param>
    public void KeepOnline(object state)
    {
        var msg = new SocketMessageModel(CommandType.HeartBeat);
        if (client.IsRunning)
        {
            client.Send(JsonSerializer.Serialize(msg));
        }
    }

    public async Task OpenSocketAsync()
    {
        try
        {
            client.ReconnectTimeout = TimeSpan.FromSeconds(30);
            await client.Start();
        }
        catch (Exception ex)
        {
            _logger.LogInformation("连接失败:" + ex.Message);
        }
        OnMessage();
        OnReconnectiong();
    }


    public virtual void OnMessage()
    {
        // 接收信息
        client.MessageReceived.Subscribe(msg => {
            _logger.LogInformation($"Message received: {msg}");
            var serverMessage = JsonSerializer.Deserialize<SocketMessageModel>(msg.Text);
            AckMessage(serverMessage);
        });
    }


    /// <summary>
    /// 发送ack消息
    /// </summary>
    /// <param name="serverMessage"></param>
    public void AckMessage(SocketMessageModel serverMessage)
    {
        if (client.IsRunning)
        {
            // 构建 ackMessage
            var ackMessage = new AckMessage {
                CommandType = CommandType.Ack,
                Id = serverMessage.Id,
                MallId = serverMessage.Message.MallID,
                SendTime = serverMessage.SendTime,
                Time = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),
                Type = serverMessage.Message.Type
            };

            client.Send(JsonSerializer.Serialize(ackMessage));
        }
    }

    /// <summary>
    /// 重新连接的处理
    /// </summary>
    public virtual void OnReconnectiong()
    {
        client.ReconnectionHappened.Subscribe(info => {
            _logger.LogInformation($"Reconnection happened, type: {info.Type}");
        });

    }

    public string Digest(string clientId, string secret, long sysTime)
    {
        var hash = MD5.Create();
        var data = hash.ComputeHash(Encoding.UTF8.GetBytes(clientId + sysTime.ToString() + secret));
        var sb = new StringBuilder();

        for (var i = 0; i < data.Length; i++)
        {
            sb.Append(data[i].ToString("x2"));
        }
        return Convert.ToBase64String(Encoding.UTF8.GetBytes(sb.ToString()));
    }

    public void Dispose()
    {
        _timer?.Dispose();
        client.Dispose();
        //connection.DisposeAsync();
    }
}

