using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public partial class GetDdkAppNewBillListResponseModel : PddResponseModel
    {
        /// <summary>
        /// 多多客拉新的奖励账单返回对象
        /// </summary>
        [JsonProperty("app_new_bill_list_response")]
        public AppNewBillListResponseResponseModel AppNewBillListResponse { get; set; }
        public partial class AppNewBillListResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 账单列表对象
            /// </summary>
            [JsonProperty("list")]
            public List<ListResponseModel> List { get; set; }
            /// <summary>
            /// 账单总数
            /// </summary>
            [JsonProperty("total_count")]
            public int? TotalCount { get; set; }
            public partial class ListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 推广位ID
                /// </summary>
                [JsonProperty("pid")]
                public string Pid { get; set; }
                /// <summary>
                /// 订单号
                /// </summary>
                [JsonProperty("order_sn")]
                public string OrderSn { get; set; }
                /// <summary>
                /// 商品缩略图
                /// </summary>
                [JsonProperty("goods_thumb_url")]
                public string GoodsThumbUrl { get; set; }
                /// <summary>
                /// 商品id
                /// </summary>
                [JsonProperty("goods_id")]
                public long? GoodsId { get; set; }
                /// <summary>
                /// 商品名
                /// </summary>
                [JsonProperty("goods_name")]
                public string GoodsName { get; set; }
                /// <summary>
                /// 奖励金额
                /// </summary>
                [JsonProperty("money")]
                public long? Money { get; set; }
                /// <summary>
                /// 结算时间
                /// </summary>
                [JsonProperty("pay_time")]
                public long? PayTime { get; set; }
                /// <summary>
                /// 更新时间
                /// </summary>
                [JsonProperty("updated_at")]
                public long? UpdatedAt { get; set; }
                /// <summary>
                /// 审核时间
                /// </summary>
                [JsonProperty("verify_time")]
                public long? VerifyTime { get; set; }
                /// <summary>
                /// 状态：0-未审核、1-审核通过、2-审核失败、3-已结算
                /// </summary>
                [JsonProperty("status")]
                public int? Status { get; set; }
                /// <summary>
                /// 自定义参数
                /// </summary>
                [JsonProperty("custom_parameters")]
                public string CustomParameters { get; set; }

            }

        }

    }

}
