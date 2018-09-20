using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class IdAdUnitGetByPlanResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("ad_unit_base_info_List_response")]
        public AdUnitBaseInfoListResponseResponseModel AdUnitBaseInfoListResponse { get; set; }

        public partial class AdUnitBaseInfoListResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// unit_base_info_list
            /// </summary>
            [JsonProperty("unit_base_info_list")]
            public UnitBaseInfoListResponseModel UnitBaseInfoList { get; set; }

            public partial class UnitBaseInfoListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 关键词个数
                /// </summary>
                [JsonProperty("keyword_count")]
                public int KeywordCount { get; set; }
                /// <summary>
                /// 商品id
                /// </summary>
                [JsonProperty("goods_id")]
                public int GoodsId { get; set; }
                /// <summary>
                /// 单元状态：1 - 已启用 2 - 已暂停
                /// </summary>
                [JsonProperty("unit_status")]
                public int UnitStatus { get; set; }
                /// <summary>
                /// 单元id
                /// </summary>
                [JsonProperty("unit_id")]
                public int UnitId { get; set; }

            }

        }

    }
}
