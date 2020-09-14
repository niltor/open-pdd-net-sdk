using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class GetDdkMallGoodsListRequestModel : PddRequestModel
    {
        /// <summary>
        /// 店铺id
        /// </summary>
        [JsonProperty("mall_id")]
        public long MallId { get; set; }
        /// <summary>
        /// 分页数
        /// </summary>
        [JsonProperty("page_number")]
        public int PageNumber { get; set; }
        /// <summary>
        /// 每页商品数量
        /// </summary>
        [JsonProperty("page_size")]
        public int PageSize { get; set; }
        /// <summary>
        /// 推广位id
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }
        /// <summary>
        /// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为： {"uid":"11111","sid":"22222"} ，其中 uid 用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key
        /// </summary>
        [JsonProperty("custom_parameters")]
        public string CustomParameters { get; set; }

    }

}
