using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Mall
{
    public partial class GetMallInfoStoreRequestModel : PddRequestModel
    {
        /// <summary>
        /// 市
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }
        /// <summary>
        /// 区
        /// </summary>
        [JsonProperty("district")]
        public string District { get; set; }
        /// <summary>
        /// 分页
        /// </summary>
        [JsonProperty("page_number")]
        public int PageNumber { get; set; }
        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonProperty("page_size")]
        public int PageSize { get; set; }
        /// <summary>
        /// 省
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }
        /// <summary>
        /// 门店Id
        /// </summary>
        [JsonProperty("store_id")]
        public long? StoreId { get; set; }
        /// <summary>
        /// 门店名称
        /// </summary>
        [JsonProperty("store_name")]
        public string StoreName { get; set; }
        /// <summary>
        /// 门店自有编号
        /// </summary>
        [JsonProperty("store_number")]
        public string StoreNumber { get; set; }

    }

}
