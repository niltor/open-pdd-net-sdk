using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSDev.PddOpenSdk.Models
{
    public class SocketMessageModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("commandType")]
        public string CommandType { get; set; }
        [JsonProperty("time")]
        public long Time { get; set; } = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        [JsonProperty("message")]
        public Message Message { get; set; }
        [JsonProperty("sendTime")]
        public long SendTime { get; set; }



        public SocketMessageModel()
        {
        }

        public SocketMessageModel(string commandType)
        {
            CommandType = commandType;
        }
    }
    public class Message
    {
        /**  
	     * 消息类型  
	     */
        [JsonProperty("type")]
        public string Type { get; set; }
        /**  
	     * 商户ID  
	     */
        [JsonProperty("mallID")]
        public long MallID { get; set; }
        /**  
	     * 消息属性内容  
	     */
        [JsonProperty("content")]
        public string Content { get; set; }
    }

}
