using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetPromotionMerchantCouponListResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回店铺优惠券批次列表
        /// </summary>
        [JsonProperty("merchant_coupon_batch_list_response")]
        public MerchantCouponBatchListResponseResponseModel MerchantCouponBatchListResponse { get; set; }

        public partial class MerchantCouponBatchListResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 返回店铺优惠券批次数量
            /// </summary>
            [JsonProperty("total_size")]
            public object TotalSize { get; set; }
            /// <summary>
            /// 返回店铺优惠券批次对象
            /// </summary>
            [JsonProperty("coupon_batch_list")]
            public CouponBatchListResponseModel CouponBatchList { get; set; }

            public partial class CouponBatchListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 批次ID
                /// </summary>
                [JsonProperty("id")]
                public object Id { get; set; }
                /// <summary>
                /// 批次名
                /// </summary>
                [JsonProperty("batchName")]
                public string Batchname { get; set; }
                /// <summary>
                /// 批次描述
                /// </summary>
                [JsonProperty("batchDesc")]
                public string Batchdesc { get; set; }
                /// <summary>
                /// 折扣类型，1 代表满减券，2 代表折扣券
                /// </summary>
                [JsonProperty("discountType")]
                public int Discounttype { get; set; }
                /// <summary>
                /// 折扣参数，为请求中传入的discountAmount，表示折扣金额，单位: 分
                /// </summary>
                [JsonProperty("discountParam")]
                public int Discountparam { get; set; }
                /// <summary>
                /// 初始数量
                /// </summary>
                [JsonProperty("initQuantity")]
                public object Initquantity { get; set; }
                /// <summary>
                /// 剩余数量
                /// </summary>
                [JsonProperty("remainQuantity")]
                public object Remainquantity { get; set; }
                /// <summary>
                /// 已使用数量
                /// </summary>
                [JsonProperty("usedQuantity")]
                public object Usedquantity { get; set; }
                /// <summary>
                /// 用户限领张数，-1 代表不限制
                /// </summary>
                [JsonProperty("userLimit")]
                public int Userlimit { get; set; }
                /// <summary>
                /// 最大折扣金额
                /// </summary>
                [JsonProperty("maxDiscountAmount")]
                public int Maxdiscountamount { get; set; }
                /// <summary>
                /// 券有效时长
                /// </summary>
                [JsonProperty("duration")]
                public int Duration { get; set; }
                /// <summary>
                /// 券有效期时长的单位，0 代表天，2 代表小时
                /// </summary>
                [JsonProperty("periodType")]
                public int Periodtype { get; set; }
                /// <summary>
                /// 批次开始时间
                /// </summary>
                [JsonProperty("batchStartTime")]
                public object Batchstarttime { get; set; }
                /// <summary>
                /// 批次结束时间
                /// </summary>
                [JsonProperty("batchEndTime")]
                public object Batchendtime { get; set; }
                /// <summary>
                /// 券来源类型，16 店铺直接领券，41 店铺精选评价优惠券，66 商家短信营销优惠券
                /// </summary>
                [JsonProperty("sourceType")]
                public int Sourcetype { get; set; }
                /// <summary>
                /// 券类型，固定为8，代表商家券
                /// </summary>
                [JsonProperty("type")]
                public int Type { get; set; }
                /// <summary>
                /// 批次状态，1 领取中，2 已领完，3 已结束
                /// </summary>
                [JsonProperty("status")]
                public int Status { get; set; }
                /// <summary>
                /// 用券条件
                /// </summary>
                [JsonProperty("rules")]
                public string Rules { get; set; }
                /// <summary>
                /// 券展示类型，固定为8，代表商家券
                /// </summary>
                [JsonProperty("displayType")]
                public int Displaytype { get; set; }
                /// <summary>
                /// 批次创建时间
                /// </summary>
                [JsonProperty("createdAt")]
                public object Createdat { get; set; }

            }

        }

    }
}
