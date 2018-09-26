using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class QueryGoodsCpsUnitResponseModel
    {

        /// <summary>
        /// Examples: 118121
        /// </summary>
        [JsonProperty("unit_id")]
        public int UnitId { get; set; }

        /// <summary>
        /// Examples: 10083346
        /// </summary>
        [JsonProperty("goods_id")]
        public int GoodsId { get; set; }

        /// <summary>
        /// Examples: 260
        /// </summary>
        [JsonProperty("rate")]
        public int Rate { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("rate_to_be")]
        public object RateToBe { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("status_to_be")]
        public object StatusToBe { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("coupon_vo")]
        public object CouponVo { get; set; }
    }


}
