using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
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
            /// 推广单元基本信息
            /// </summary>
            [JsonProperty("unit_base_info_list")]
            public List<UnitBaseInfoListResponseModel> UnitBaseInfoList { get; set; }
            public partial class UnitBaseInfoListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 关键词个数
                /// </summary>
                [JsonProperty("keyword_count")]
                public long? KeywordCount { get; set; }
                /// <summary>
                /// 商品id
                /// </summary>
                [JsonProperty("goods_id")]
                public long? GoodsId { get; set; }
                /// <summary>
                /// 单元状态。1表示推广中，2表示手动暂停，3表示商品售罄，4表示商品下架，5表示限制推广，6表示已删除，7表示审核中，8表示无推广中创意，9表示审核驳回，10表示品牌词重审驳回
                /// </summary>
                [JsonProperty("unit_status")]
                public int? UnitStatus { get; set; }
                /// <summary>
                /// 单元id
                /// </summary>
                [JsonProperty("unit_id")]
                public long? UnitId { get; set; }

            }

        }

    }

}
