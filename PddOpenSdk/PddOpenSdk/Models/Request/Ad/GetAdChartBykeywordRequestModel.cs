using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class GetAdChartBykeywordRequestModel : PddRequestModel {
        /// <summary>
        /// 报表日期，仅能查询近30天的报表数据，格式为：YYYY-MM-DD
        /// </summary>
        [JsonProperty ("date")]
        public string Date { get; set; }
        /// <summary>
        /// 返回页数，默认1页
        /// </summary>
        [JsonProperty ("page")]
        public int Page { get; set; }
        /// <summary>
        /// 每页返回条数，默认20条
        /// </summary>
        [JsonProperty ("page_size")]
        public int PageSize { get; set; }

    }

}