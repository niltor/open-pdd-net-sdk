using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class CreateGoodsCpsUnitRequestModel : PddRequestModel {
        /// <summary>
        /// 批量设置商品字符串，按照此格式来填写，具体参数见下。注意：创建优惠券时，必须优惠券几个参数都填，否则商品能创建成功,但是默认没有优惠券：[{"goods_id":10000,"rate":2,"coupon_id":123456,"coupon_start_time":1572345,"coupon_end_time":1576482,"discount":300,"init_quantity":600,"remain_quantity":560},{...}........]
        /// </summary>
        [JsonProperty ("units")]
        public List<UnitsRequestModel> Units { get; set; }
        public partial class UnitsRequestModel : PddRequestModel {
            /// <summary>
            /// 商品id
            /// </summary>
            [JsonProperty ("goods_id")]
            public long GoodsId { get; set; }
            /// <summary>
            /// 佣金比例（千分比）
            /// </summary>
            [JsonProperty ("rate")]
            public long Rate { get; set; }
            /// <summary>
            /// 优惠券id
            /// </summary>
            [JsonProperty ("coupon_id")]
            public long? CouponId { get; set; }
            /// <summary>
            /// 优惠券开始时间
            /// </summary>
            [JsonProperty ("coupon_start_time")]
            public string CouponStartTime { get; set; }
            /// <summary>
            /// 优惠券结束时间
            /// </summary>
            [JsonProperty ("coupon_end_time")]
            public string CouponEndTime { get; set; }
            /// <summary>
            /// 优惠券面额（单位为分）
            /// </summary>
            [JsonProperty ("discount")]
            public long? Discount { get; set; }
            /// <summary>
            /// 设置的优惠券张数
            /// </summary>
            [JsonProperty ("init_quantity")]
            public long? InitQuantity { get; set; }
            /// <summary>
            /// 剩余的优惠券张数
            /// </summary>
            [JsonProperty ("remain_quantity")]
            public long? RemainQuantity { get; set; }

        }

    }

}