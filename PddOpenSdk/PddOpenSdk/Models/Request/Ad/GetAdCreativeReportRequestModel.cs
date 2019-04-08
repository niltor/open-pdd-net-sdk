using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class GetAdCreativeReportRequestModel : PddRequestModel {
        /// <summary>
        /// 开始时间 2018-01-01
        /// </summary>
        [JsonProperty ("begin_date")]
        public string BeginDate { get; set; }
        /// <summary>
        /// 结束时间 2018-01-01
        /// </summary>
        [JsonProperty ("end_date")]
        public string EndDate { get; set; }
        /// <summary>
        /// 页面大小,默认100
        /// </summary>
        [JsonProperty ("page_size")]
        public int PageSize { get; set; }
        /// <summary>
        /// 页面数,默认1
        /// </summary>
        [JsonProperty ("page_number")]
        public int PageNumber { get; set; }

    }

}