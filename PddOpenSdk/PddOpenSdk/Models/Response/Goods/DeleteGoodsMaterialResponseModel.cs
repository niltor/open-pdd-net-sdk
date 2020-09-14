using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class DeleteGoodsMaterialResponseModel : PddResponseModel
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("error_code")]
        public int? ErrorCode { get; set; }
        /// <summary>
        /// 错误文案
        /// </summary>
        [JsonProperty("error_msg")]
        public string ErrorMsg { get; set; }
        /// <summary>
        /// 返回非0代表删除成功
        /// </summary>
        [JsonProperty("result")]
        public int? Result { get; set; }
        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonProperty("success")]
        public bool? Success { get; set; }

    }

}
