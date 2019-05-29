using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class QueryDdkCouponInfoRequestModel : PddRequestModel
    {
        /// <summary>
        /// 优惠券id
        /// </summary>
        [JsonProperty("coupon_ids")]
        public List<string> CouponIds { get; set; }

    }

}
