using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Fds
{
    public partial class GetFdsOrderListResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("pdd_fds_order_list_get_response")]
        public PddFdsOrderListGetResponseResponseModel PddFdsOrderListGetResponse { get; set; }
        public partial class PddFdsOrderListGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 订单列表
            /// </summary>
            [JsonProperty("order_list")]
            public List<OrderListResponseModel> OrderList { get; set; }
            /// <summary>
            /// 订单总数
            /// </summary>
            [JsonProperty("total")]
            public int? Total { get; set; }
            public partial class OrderListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 分配时间,毫秒
                /// </summary>
                [JsonProperty("allow_time")]
                public long? AllowTime { get; set; }
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
                /// 商品名称
                /// </summary>
                [JsonProperty("goods_name")]
                public string GoodsName { get; set; }
                /// <summary>
                /// 商品数量
                /// </summary>
                [JsonProperty("goods_number")]
                public int? GoodsNumber { get; set; }
                /// <summary>
                /// 规格
                /// </summary>
                [JsonProperty("goods_spec")]
                public string GoodsSpec { get; set; }
                /// <summary>
                /// 代打店铺id
                /// </summary>
                [JsonProperty("mall_mask_id")]
                public string MallMaskId { get; set; }
                /// <summary>
                /// 代打店铺自定义名称
                /// </summary>
                [JsonProperty("mall_mask_name")]
                public string MallMaskName { get; set; }
                /// <summary>
                /// 代打订单号
                /// </summary>
                [JsonProperty("order_mask_sn")]
                public string OrderMaskSn { get; set; }
                /// <summary>
                /// 省
                /// </summary>
                [JsonProperty("province")]
                public string Province { get; set; }
                /// <summary>
                /// 卖家备注
                /// </summary>
                [JsonProperty("remark")]
                public string Remark { get; set; }
                /// <summary>
                /// 分配状态 0：取消分配 1：已分配
                /// </summary>
                [JsonProperty("status")]
                public int? Status { get; set; }
                /// <summary>
                /// 货号
                /// </summary>
                [JsonProperty("product_sn")]
                public string ProductSn { get; set; }
                /// <summary>
                /// 结算价格，单位：分
                /// </summary>
                [JsonProperty("product_price")]
                public int? ProductPrice { get; set; }
                /// <summary>
                /// 收件人姓名+电话+地址相同,receiver_id字段相同，该功能上线前字段为""
                /// </summary>
                [JsonProperty("receiver_id")]
                public string ReceiverId { get; set; }
                /// <summary>
                /// 商家配置的sku编码
                /// </summary>
                [JsonProperty("out_sku_sn")]
                public string OutSkuSn { get; set; }
                /// <summary>
                /// 加价发顺丰状态 0：不是 1：是
                /// </summary>
                [JsonProperty("sf_only")]
                public int? SfOnly { get; set; }
                /// <summary>
                /// 运单回传状态 0：未回传 1：已回传
                /// </summary>
                [JsonProperty("return_status")]
                public int? ReturnStatus { get; set; }

            }

        }

    }

}
