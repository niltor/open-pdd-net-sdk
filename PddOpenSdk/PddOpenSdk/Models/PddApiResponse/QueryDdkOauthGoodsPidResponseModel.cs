using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QueryDdkOauthGoodsPidResponseModel : PddResponseModel
    {
        /// <summary>
        /// 多多进宝推广位对象列表
        /// </summary>
        [JsonProperty("p_id_list")]
        public PIdListResponseModel PIdList { get; set; }
        /// <summary>
        /// 返回推广位总数
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        public partial class PIdListResponseModel : PddResponseModel
        {
            /// <summary>
            /// 推广位生成时间
            /// </summary>
            [JsonProperty("create_time")]
            public string CreateTime { get; set; }
            /// <summary>
            /// 推广位ID
            /// </summary>
            [JsonProperty("p_id")]
            public string PId { get; set; }

        }

    }
}
