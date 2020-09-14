using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class QueryDdkTopGoodsListRequestModel : PddRequestModel
    {
        /// <summary>
        /// 请求数量；默认值 ： 400
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; }
        /// <summary>
        /// 翻页时建议填写前页返回的list_id值
        /// </summary>
        [JsonProperty("list_id")]
        public string ListId { get; set; }
        /// <summary>
        /// 从多少位置开始请求；默认值 ： 0
        /// </summary>
        [JsonProperty("offset")]
        public int? Offset { get; set; }
        /// <summary>
        /// 推广位id
        /// </summary>
        [JsonProperty("p_id")]
        public string PId { get; set; }
        /// <summary>
        /// 1-实时热销榜；2-实时收益榜
        /// </summary>
        [JsonProperty("sort_type")]
        public int? SortType { get; set; }
        /// <summary>
        /// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为： {"uid":"11111","sid":"22222"} ，其中 uid 用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key
        /// </summary>
        [JsonProperty("custom_parameters")]
        public string CustomParameters { get; set; }

    }

}
