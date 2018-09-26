using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class GetDdkThemeListRequestModel : PddRequestModel
    {
        /// <summary>
        /// 该值固定为：pdd.ddk.theme.list.get
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// 返回的一页数据数量
        /// </summary>
        [JsonProperty("page_size")]
        public int? PageSize { get; set; }
        /// <summary>
        /// 返回的页码
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

    }

}
