using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public partial class ListDdkLiveResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("live_list_get_response")]
        public LiveListGetResponseResponseModel LiveListGetResponse { get; set; }
        public partial class LiveListGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 直播间列表
            /// </summary>
            [JsonProperty("room_info_list")]
            public List<RoomInfoListResponseModel> RoomInfoList { get; set; }
            /// <summary>
            /// 直播间数量
            /// </summary>
            [JsonProperty("total")]
            public int? Total { get; set; }
            public partial class RoomInfoListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 商品列表
                /// </summary>
                [JsonProperty("goods_info_list")]
                public List<GoodsInfoListResponseModel> GoodsInfoList { get; set; }
                /// <summary>
                /// 商品总数
                /// </summary>
                [JsonProperty("goods_total")]
                public int? GoodsTotal { get; set; }
                /// <summary>
                /// 直播间信息
                /// </summary>
                [JsonProperty("live_show_info")]
                public LiveShowInfoResponseModel LiveShowInfo { get; set; }
                public partial class GoodsInfoListResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 券面额
                    /// </summary>
                    [JsonProperty("coupon_discount")]
                    public long? CouponDiscount { get; set; }
                    /// <summary>
                    /// 券失效时间
                    /// </summary>
                    [JsonProperty("coupon_end_time")]
                    public long? CouponEndTime { get; set; }
                    /// <summary>
                    /// 券门槛价格
                    /// </summary>
                    [JsonProperty("coupon_min_order_amount")]
                    public long? CouponMinOrderAmount { get; set; }
                    /// <summary>
                    /// 券剩余数量
                    /// </summary>
                    [JsonProperty("coupon_remain_quantity")]
                    public long? CouponRemainQuantity { get; set; }
                    /// <summary>
                    /// 券生效时间
                    /// </summary>
                    [JsonProperty("coupon_start_time")]
                    public long? CouponStartTime { get; set; }
                    /// <summary>
                    /// 优惠券总数量
                    /// </summary>
                    [JsonProperty("coupon_total_quantity")]
                    public long? CouponTotalQuantity { get; set; }
                    /// <summary>
                    /// 商品Id
                    /// </summary>
                    [JsonProperty("goods_id")]
                    public long? GoodsId { get; set; }
                    /// <summary>
                    /// 商品名称
                    /// </summary>
                    [JsonProperty("goods_name")]
                    public string GoodsName { get; set; }
                    /// <summary>
                    /// 商品缩略图
                    /// </summary>
                    [JsonProperty("goods_thumbnail_url")]
                    public string GoodsThumbnailUrl { get; set; }
                    /// <summary>
                    /// 最小拼团价格
                    /// </summary>
                    [JsonProperty("min_group_price")]
                    public long? MinGroupPrice { get; set; }
                    /// <summary>
                    /// 商品标签 ID
                    /// </summary>
                    [JsonProperty("opt_id")]
                    public long? OptId { get; set; }
                    /// <summary>
                    /// 佣金比例
                    /// </summary>
                    [JsonProperty("promotion_rate")]
                    public long? PromotionRate { get; set; }
                    /// <summary>
                    /// 招商团长ID
                    /// </summary>
                    [JsonProperty("zs_duo_id")]
                    public long? ZsDuoId { get; set; }
                    /// <summary>
                    /// 商品主图
                    /// </summary>
                    [JsonProperty("goods_image_url")]
                    public string GoodsImageUrl { get; set; }

                }
                public partial class LiveShowInfoResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 直播间观看人次
                    /// </summary>
                    [JsonProperty("audience_count")]
                    public int? AudienceCount { get; set; }
                    /// <summary>
                    /// 直播封面
                    /// </summary>
                    [JsonProperty("live_image")]
                    public string LiveImage { get; set; }
                    /// <summary>
                    /// 直播间标题
                    /// </summary>
                    [JsonProperty("live_title")]
                    public string LiveTitle { get; set; }
                    /// <summary>
                    /// 直播间信息
                    /// </summary>
                    [JsonProperty("room_id")]
                    public string RoomId { get; set; }
                    /// <summary>
                    /// 当前直播状态；0-未开始，1-直播中
                    /// </summary>
                    [JsonProperty("status")]
                    public int? Status { get; set; }

                }

            }

        }

    }

}
