using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Promotion
{
    public class CouponBatchList
    {

        /// <summary>
        /// Examples: 9251417707
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Examples: "满3减2"
        /// </summary>
        [JsonProperty("batch_name")]
        public string BatchName { get; set; }

        /// <summary>
        /// Examples: "123456"
        /// </summary>
        [JsonProperty("batch_desc")]
        public string BatchDesc { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("discount_type")]
        public object DiscountType { get; set; }

        /// <summary>
        /// Examples: 200
        /// </summary>
        [JsonProperty("discount_param")]
        public int DiscountParam { get; set; }

        /// <summary>
        /// Examples: 1000
        /// </summary>
        [JsonProperty("init_quantity")]
        public int InitQuantity { get; set; }

        /// <summary>
        /// Examples: 998
        /// </summary>
        [JsonProperty("remain_quantity")]
        public int RemainQuantity { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("used_quantity")]
        public int UsedQuantity { get; set; }

        /// <summary>
        /// Examples: 3
        /// </summary>
        [JsonProperty("user_limit")]
        public int UserLimit { get; set; }

        /// <summary>
        /// Examples: 2147483647
        /// </summary>
        [JsonProperty("max_discount_amount")]
        public long MaxDiscountAmount { get; set; }

        /// <summary>
        /// Examples: 23
        /// </summary>
        [JsonProperty("duration")]
        public int Duration { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("period_type")]
        public int PeriodType { get; set; }

        /// <summary>
        /// Examples: 1528300800000
        /// </summary>
        [JsonProperty("batch_start_time")]
        public long BatchStartTime { get; set; }

        /// <summary>
        /// Examples: 1530374399000
        /// </summary>
        [JsonProperty("batch_end_time")]
        public long BatchEndTime { get; set; }

        /// <summary>
        /// Examples: 16
        /// </summary>
        [JsonProperty("source_type")]
        public int SourceType { get; set; }

        /// <summary>
        /// Examples: 8
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Examples: "{\"mallId\":[1],\"priceRange\":[300,2147483647]}"
        /// </summary>
        [JsonProperty("rules")]
        public string Rules { get; set; }

        /// <summary>
        /// Examples: 8
        /// </summary>
        [JsonProperty("display_type")]
        public int DisplayType { get; set; }

        /// <summary>
        /// Examples: 1528362083000
        /// </summary>
        [JsonProperty("created_at")]
        public long CreatedAt { get; set; }
    }

    public class MerchantCouponBatchListResponse
    {

        /// <summary>
        /// Examples: 99
        /// </summary>
        [JsonProperty("total_size")]
        public int TotalSize { get; set; }

        /// <summary>
        /// Examples: [{"id":9251417707,"batch_name":"满3减2","batch_desc":"123456","discount_type":null,"discount_param":200,"init_quantity":1000,"remain_quantity":998,"used_quantity":0,"user_limit":3,"max_discount_amount":2147483647,"duration":23,"period_type":1,"batch_start_time":1528300800000,"batch_end_time":1530374399000,"source_type":16,"type":8,"status":1,"rules":"{\"mallId\":[1],\"priceRange\":[300,2147483647]}","display_type":8,"created_at":1528362083000}]
        /// </summary>
        [JsonProperty("coupon_batch_list")]
        public IList<CouponBatchList> CouponBatchList { get; set; }
    }

    public class GetPromotionMerchantCouponListResponseModel
    {

        /// <summary>
        /// Examples: {"total_size":99,"coupon_batch_list":[{"id":9251417707,"batch_name":"满3减2","batch_desc":"123456","discount_type":null,"discount_param":200,"init_quantity":1000,"remain_quantity":998,"used_quantity":0,"user_limit":3,"max_discount_amount":2147483647,"duration":23,"period_type":1,"batch_start_time":1528300800000,"batch_end_time":1530374399000,"source_type":16,"type":8,"status":1,"rules":"{\"mallId\":[1],\"priceRange\":[300,2147483647]}","display_type":8,"created_at":1528362083000}]}
        /// </summary>
        [JsonProperty("merchant_coupon_batch_list_response")]
        public MerchantCouponBatchListResponse MerchantCouponBatchListResponse { get; set; }
    }


}
