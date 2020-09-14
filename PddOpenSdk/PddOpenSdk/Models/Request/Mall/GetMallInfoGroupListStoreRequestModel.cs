using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Mall
{
    public partial class GetMallInfoGroupListStoreRequestModel : PddRequestModel
    {
        /// <summary>
        /// 门店组ID
        /// </summary>
        [JsonProperty("group_id")]
        public long GroupId { get; set; }
        /// <summary>
        /// 分页页码
        /// </summary>
        [JsonProperty("page_number")]
        public int PageNumber { get; set; }
        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonProperty("page_size")]
        public int PageSize { get; set; }

    }

}
