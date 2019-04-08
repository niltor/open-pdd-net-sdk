using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddkall
{
    public partial class GetDdkAllColorOrderListIncreResponseModel : PddResponseModel
    {
        /// <summary>
        /// order_list_get_response
        /// </summary>
        [JsonProperty("order_list_get_response")]
        public OrderListGetResponseResponseModel OrderListGetResponse { get; set; }
        public partial class OrderListGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 多多进宝推广位对象列表
            /// </summary>
            [JsonProperty("order_list")]
            public List<OrderListResponseModel> OrderList { get; set; }
            /// <summary>
            /// 请求到的结果数
            /// </summary>
            [JsonProperty("total_count")]
            public long? TotalCount { get; set; }
            public partial class OrderListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 审核时间
                /// </summary>
                [JsonProperty("order_verify_time")]
                public long? OrderVerifyTime { get; set; }
                /// <summary>
                /// 支付时间
                /// </summary>
                [JsonProperty("order_pay_time")]
                public long? OrderPayTime { get; set; }
                /// <summary>
                /// 成团时间
                /// </summary>
                [JsonProperty("order_group_success_time")]
                public long? OrderGroupSuccessTime { get; set; }
                /// <summary>
                /// 最后更新时间
                /// </summary>
                [JsonProperty("order_modify_at")]
                public long? OrderModifyAt { get; set; }
                /// <summary>
                /// 订单状态描述
                /// </summary>
                [JsonProperty("order_status_desc")]
                public string OrderStatusDesc { get; set; }
                /// <summary>
                /// 推广位ID
                /// </summary>
                [JsonProperty("p_id")]
                public string PId { get; set; }
                /// <summary>
                /// 订单状态：  -1 未支付; 0-已支付；1-已成团；2-确认收货；3-审核成功；4-审核失败（不可提现）；5-已经结算；8-非多多进宝商品（无佣金订单）
                /// </summary>
                [JsonProperty("order_status")]
                public int? OrderStatus { get; set; }
                /// <summary>
                /// 佣金金额，单位为分
                /// </summary>
                [JsonProperty("promotion_amount")]
                public long? PromotionAmount { get; set; }
                /// <summary>
                /// 佣金比例，千分比
                /// </summary>
                [JsonProperty("promotion_rate")]
                public long? PromotionRate { get; set; }
                /// <summary>
                /// 订单生成时间，UNIX时间戳
                /// </summary>
                [JsonProperty("order_create_time")]
                public long? OrderCreateTime { get; set; }
                /// <summary>
                /// 实际支付金额，单位为分
                /// </summary>
                [JsonProperty("order_amount")]
                public long? OrderAmount { get; set; }
                /// <summary>
                /// 订单中sku的单件价格，单位为分
                /// </summary>
                [JsonProperty("goods_price")]
                public long? GoodsPrice { get; set; }
                /// <summary>
                /// 购买商品的数量
                /// </summary>
                [JsonProperty("goods_quantity")]
                public long? GoodsQuantity { get; set; }
                /// <summary>
                /// 商品缩略图
                /// </summary>
                [JsonProperty("goods_thumbnail_url")]
                public string GoodsThumbnailUrl { get; set; }
                /// <summary>
                /// 商品标题
                /// </summary>
                [JsonProperty("goods_name")]
                public string GoodsName { get; set; }
                /// <summary>
                /// 商品ID
                /// </summary>
                [JsonProperty("goods_id")]
                public long? GoodsId { get; set; }
                /// <summary>
                /// 推广订单编号
                /// </summary>
                [JsonProperty("order_sn")]
                public string OrderSn { get; set; }

            }

        }

    }

}
