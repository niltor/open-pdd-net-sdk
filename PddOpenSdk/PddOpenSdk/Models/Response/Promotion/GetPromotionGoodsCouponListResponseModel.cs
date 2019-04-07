using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Promotion
{
    public partial class GetPromotionGoodsCouponListResponseModel : PddResponseModel {
        /// <summary>
        /// 返回商品优惠券批次表
        /// </summary>
        [JsonProperty ("goods_coupon_batch_list_response")]
        public GoodsCouponBatchListResponseResponseModel GoodsCouponBatchListResponse { get; set; }
        public partial class GoodsCouponBatchListResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 返回商品优惠券对象
            /// </summary>
            [JsonProperty ("coupon_batch_list")]
            public List<CouponBatchListResponseModel> CouponBatchList { get; set; }
            /// <summary>
            /// 返回的优惠券总数
            /// </summary>
            [JsonProperty ("total_size")]
            public int TotalSize { get; set; }
            public partial class CouponBatchListResponseModel : PddResponseModel {
                /// <summary>
                /// 批次ID
                /// </summary>
                [JsonProperty ("id")]
                public long? Id { get; set; }
                /// <summary>
                /// 批次描述
                /// </summary>
                [JsonProperty ("batch_desc")]
                public string BatchDesc { get; set; }
                /// <summary>
                /// 折扣参数，为请求中传入的discountAmount，表示折扣金额，单位: 分
                /// </summary>
                [JsonProperty ("discount_param")]
                public long? DiscountParam { get; set; }
                /// <summary>
                /// 最小可用订单金额
                /// </summary>
                [JsonProperty ("min_order_amount")]
                public long? MinOrderAmount { get; set; }
                /// <summary>
                /// 初始数量
                /// </summary>
                [JsonProperty ("init_quantity")]
                public long? InitQuantity { get; set; }
                /// <summary>
                /// 剩余数量
                /// </summary>
                [JsonProperty ("remain_quantity")]
                public long? RemainQuantity { get; set; }
                /// <summary>
                /// 已使用数量
                /// </summary>
                [JsonProperty ("used_quantity")]
                public long? UsedQuantity { get; set; }
                /// <summary>
                /// 用户限领张数，-1 代表不限制
                /// </summary>
                [JsonProperty ("user_limit")]
                public long? UserLimit { get; set; }
                /// <summary>
                /// 批次开始时间
                /// </summary>
                [JsonProperty ("batch_start_time")]
                public long? BatchStartTime { get; set; }
                /// <summary>
                /// 批次结束时间
                /// </summary>
                [JsonProperty ("batch_end_time")]
                public long? BatchEndTime { get; set; }
                /// <summary>
                /// 券来源类型，45 店铺多多进宝商品券，54 无门槛商品券，87 店铺多多进宝大淘客定向商品券，88 店铺多多果园商品券
                /// </summary>
                [JsonProperty ("source_type")]
                public int SourceType { get; set; }
                /// <summary>
                /// 商品ID
                /// </summary>
                [JsonProperty ("goods_id")]
                public long? GoodsId { get; set; }
                /// <summary>
                /// 商品名
                /// </summary>
                [JsonProperty ("goods_name")]
                public string GoodsName { get; set; }
                /// <summary>
                /// 图片URL
                /// </summary>
                [JsonProperty ("image_url")]
                public string ImageUrl { get; set; }
                /// <summary>
                /// 批次状态，1 领取中，2 已领完，3 已结束，4 已暂停
                /// </summary>
                [JsonProperty ("status")]
                public int Status { get; set; }
                /// <summary>
                /// 批次创建时间
                /// </summary>
                [JsonProperty ("created_at")]
                public long? CreatedAt { get; set; }

            }

        }

    }

}