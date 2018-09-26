using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Sms
{
    public partial class QuerySmsCrowdsRequestModel : PddRequestModel
    {
        /// <summary>
        /// //人群类型选择  1-推荐人群（官方）  2-自定义人群  不传-全部
        /// </summary>
        [JsonProperty("crows_type")]
        public int CrowsType { get; set; }
        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page_number")]
        public int? PageNumber { get; set; }
        /// <summary>
        /// 每页条目数
        /// </summary>
        [JsonProperty("page_size")]
        public int? PageSize { get; set; }

    }

}
