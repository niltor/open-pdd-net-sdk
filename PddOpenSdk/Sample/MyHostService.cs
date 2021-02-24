using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MSDev.PddOpenSdk.AspNetCore;
using MSDev.PddOpenSdk.Models;
using Newtonsoft.Json;
using PddOpenSdk.AspNetCore;
using System;

namespace Sample
{
    public class MyHostService : PddSocketHostServiceBase
    {
        public MyHostService(ILogger<MyHostService> logger, IServiceProvider services, IOptions<PddOptions> options) : base(logger, services, options)
        {

        }

        public override void OnMessage()
        {
            // 接收信息
            connection.On<string, string>("ReceiveMessage", (user, message) =>
             {
                 _logger.LogInformation("收到信息:" + message);
                 var msg = JsonConvert.DeserializeObject<SocketMessageModel>(message);
                 if (msg.CommandType.ToLower().Equals("heartbeat"))
                 {
                     // 心跳报文不处理
                 }
                 else
                 {
                     _logger.LogInformation("报文:" + msg.Message.Content);
                     // 你可能会进行数据库的操作，可以先获取数据库上下文服务
                     using (var scope = Services.CreateScope())
                     {
                         //var context = scope.ServiceProvider.GetRequiredService<DbContext>();

                     }
                 }

             });
        }

    }
}
