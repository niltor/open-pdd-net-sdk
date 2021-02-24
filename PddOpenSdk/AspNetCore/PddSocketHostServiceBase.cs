using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MSDev.PddOpenSdk.Models;
using Newtonsoft.Json;
using PddOpenSdk.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MSDev.PddOpenSdk.AspNetCore
{
    public class PddSocketHostServiceBase : IHostedService, IDisposable
    {
        protected PddOptions _options;
        protected readonly ILogger<PddSocketHostServiceBase> _logger;
        protected Timer _timer; // 定时发送，避免被断开
        protected HubConnection connection;
        public static string socketUrl = "wss://message-api.pinduoduo.com";
        public IServiceProvider Services { get; }
        public PddSocketHostServiceBase(
            ILogger<PddSocketHostServiceBase> logger,
            IServiceProvider services,
            IOptions<PddOptions> options)
        {
            _logger = logger;
            Services = services;
            _options = options.Value;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("socket 线程启动.");
            OpenSocketAsync().Wait();
            _logger.LogInformation("socket 连接.");
            _timer = new Timer(KeepOnline, null, TimeSpan.FromSeconds(10), TimeSpan.FromSeconds(5));
            _logger.LogInformation("socket 心跳定时器运行.");
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("后台服务结束.");
            _timer?.Change(Timeout.Infinite, 0);
            connection.DisposeAsync();
            return Task.CompletedTask;
        }

        /// <summary>
        /// 定时发送，保持在线
        /// </summary>
        /// <param name="state"></param>
        public void KeepOnline(object state)
        {
            var msg = new SocketMessageModel("HeartBeat");
            connection.SendAsync("SendMessage", JsonConvert.SerializeObject(msg)).Wait();
        }

        public async Task OpenSocketAsync()
        {
            // 获取当前时间戳，并构造加密字段
            var currentTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            var digest = Digest(_options.ClientId, _options.ClientSecret, currentTime);
            var url = @$"{socketUrl}/message/{_options.ClientId}/{currentTime}/{digest}";
            // 构建连接 
            connection = new HubConnectionBuilder()
                .WithUrl(new Uri(url))
                .WithAutomaticReconnect()
                .Build();
            // 连接
            try
            {
                await connection.StartAsync();

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
            connection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                _logger.LogInformation("收到信息:" + message);
            });
        }

        /// <summary>
        /// 重新连接的处理
        /// </summary>
        public virtual void OnReconnectiong()
        {
            connection.Reconnecting += error =>
            {
                if (connection.State == HubConnectionState.Reconnecting)
                {
                    _logger.LogInformation("重新连接中...");

                }
                return Task.CompletedTask;
            };
        }

        public string Digest(string clientId, string secret, long sysTime)
        {
            var hash = MD5.Create();
            var data = hash.ComputeHash(Encoding.UTF8.GetBytes(clientId + sysTime.ToString() + secret));
            var sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public void Dispose()
        {
            _timer?.Dispose();
            connection.DisposeAsync();
        }
    }
}
