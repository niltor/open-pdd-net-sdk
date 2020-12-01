using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.ServiceMarket
{
    public partial class SearchVasOrderResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("vas_order_search_response")]
        public VasOrderSearchResponseResponseModel VasOrderSearchResponse { get; set; }
        public partial class VasOrderSearchResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 订单列表
            /// </summary>
            [JsonProperty("orders")]
            public List<OrdersResponseModel> Orders { get; set; }
            /// <summary>
            /// 当前查询条件下所有订单总数
            /// </summary>
            [JsonProperty("totalCount")]
            public int? TotalCount { get; set; }
            public partial class OrdersResponseModel : PddResponseModel
            {
                /// <summary>
                /// 实付价格
                /// </summary>
                [JsonProperty("amount")]
                public long? Amount { get; set; }
                /// <summary>
                /// 订单创建时间
                /// </summary>
                [JsonProperty("create_time")]
                public long? CreateTime { get; set; }
                /// <summary>
                /// 店铺ID
                /// </summary>
                [JsonProperty("mall_id")]
                public long? MallId { get; set; }
                /// <summary>
                /// 服务订单ID
                /// </summary>
                [JsonProperty("order_sn")]
                public string OrderSn { get; set; }
                /// <summary>
                /// 支付状态，枚举值，0-未支付，1-已支付
                /// </summary>
                [JsonProperty("pay_status")]
                public int? PayStatus { get; set; }
                /// <summary>
                /// 支付时间
                /// </summary>
                [JsonProperty("pay_time")]
                public long? PayTime { get; set; }
                /// <summary>
                /// 服务ID
                /// </summary>
                [JsonProperty("service_id")]
                public long? ServiceId { get; set; }
                /// <summary>
                /// 服务名称
                /// </summary>
                [JsonProperty("service_name")]
                public string ServiceName { get; set; }
                /// <summary>
                /// 服务SKUID
                /// </summary>
                [JsonProperty("sku_id")]
                public long? SkuId { get; set; }
                /// <summary>
                /// 服务SKU名称
                /// </summary>
                [JsonProperty("sku_spec")]
                public string SkuSpec { get; set; }
                /// <summary>
                /// 订单来源，0-线上订购，1-线下回流
                /// </summary>
                [JsonProperty("source")]
                public int? Source { get; set; }
                /// <summary>
                /// 订购时长
                /// </summary>
                [JsonProperty("time_length")]
                public long? TimeLength { get; set; }
                /// <summary>
                /// 售后完成时间，如果没有申请过售后则为null
                /// </summary>
                [JsonProperty("refund_finish_time")]
                public long? RefundFinishTime { get; set; }
                /// <summary>
                /// 售后状态，0-未售后，1-已售后
                /// </summary>
                [JsonProperty("refund_status")]
                public int? RefundStatus { get; set; }
                /// <summary>
                /// 店铺名称
                /// </summary>
                [JsonProperty("mall_name")]
                public string MallName { get; set; }

            }

        }

    }

}
