using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Sms
{
    public class Content
    {

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// Examples: "短信模板啊啊啊啊啊啊啊啊啊"
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("id")]
        public object Id { get; set; }
    }

    public class Result
    {

        /// <summary>
        /// Examples: 12
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Examples: 26218
        /// </summary>
        [JsonProperty("mall_id")]
        public int MallId { get; set; }

        /// <summary>
        /// Examples: "恰嵩2"
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Examples: 1520927111000
        /// </summary>
        [JsonProperty("updated_time")]
        public long UpdatedTime { get; set; }

        /// <summary>
        /// Examples: [{"type":1,"value":"短信模板啊啊啊啊啊啊啊啊啊","id":null}]
        /// </summary>
        [JsonProperty("content")]
        public IList<Content> Content { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("reason")]
        public object Reason { get; set; }
    }

    public class SmsCustomTemplateListQueryResponse
    {

        /// <summary>
        /// Examples: 18
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// Examples: [{"id":12,"mall_id":26218,"name":"恰嵩2","updated_time":1520927111000,"content":[{"type":1,"value":"短信模板啊啊啊啊啊啊啊啊啊","id":null}],"status":1,"reason":null}]
        /// </summary>
        [JsonProperty("result")]
        public IList<Result> Result { get; set; }
    }

    public class QuerySmsCustomTemplateResponseModel
    {

        /// <summary>
        /// Examples: {"total":18,"result":[{"id":12,"mall_id":26218,"name":"恰嵩2","updated_time":1520927111000,"content":[{"type":1,"value":"短信模板啊啊啊啊啊啊啊啊啊","id":null}],"status":1,"reason":null}]}
        /// </summary>
        [JsonProperty("sms_custom_template_list_query_response")]
        public SmsCustomTemplateListQueryResponse SmsCustomTemplateListQueryResponse { get; set; }
    }


}
