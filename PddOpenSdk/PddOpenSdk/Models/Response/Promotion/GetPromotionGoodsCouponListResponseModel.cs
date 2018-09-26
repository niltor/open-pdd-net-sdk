using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Promotion
{
    public class CouponBatchList
    {

        /// <summary>
        /// Examples: 9251417714
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Examples: "免拼yinpu1234"
        /// </summary>
        [JsonProperty("batch_desc")]
        public string BatchDesc { get; set; }

        /// <summary>
        /// Examples: 200
        /// </summary>
        [JsonProperty("discount_param")]
        public int DiscountParam { get; set; }

        /// <summary>
        /// Examples: 200
        /// </summary>
        [JsonProperty("min_order_amount")]
        public int MinOrderAmount { get; set; }

        /// <summary>
        /// Examples: 3011
        /// </summary>
        [JsonProperty("init_quantity")]
        public int InitQuantity { get; set; }

        /// <summary>
        /// Examples: 3010
        /// </summary>
        [JsonProperty("remain_quantity")]
        public int RemainQuantity { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("used_quantity")]
        public int UsedQuantity { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("user_limit")]
        public int UserLimit { get; set; }

        /// <summary>
        /// Examples: 1528128000000
        /// </summary>
        [JsonProperty("batch_start_time")]
        public long BatchStartTime { get; set; }

        /// <summary>
        /// Examples: 1528473599000
        /// </summary>
        [JsonProperty("batch_end_time")]
        public long BatchEndTime { get; set; }

        /// <summary>
        /// Examples: 87
        /// </summary>
        [JsonProperty("source_type")]
        public int SourceType { get; set; }

        /// <summary>
        /// Examples: 10079469
        /// </summary>
        [JsonProperty("goods_id")]
        public int GoodsId { get; set; }

        /// <summary>
        /// Examples: "不配送上海"
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// Examples: "http://pddtestimg.yangkeduo.com/test/2018-04-19/b3d3c27d8797ddfd9214cedc4b4a70a8.jpeg"
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Examples: 1528371772000
        /// </summary>
        [JsonProperty("created_at")]
        public long CreatedAt { get; set; }
    }

    public class GoodsCouponBatchListResponse
    {

        /// <summary>
        /// Examples: 89
        /// </summary>
        [JsonProperty("total_size")]
        public int TotalSize { get; set; }

        /// <summary>
        /// Examples: [{"id":9251417714,"batch_desc":"免拼yinpu1234","discount_param":200,"min_order_amount":200,"init_quantity":3011,"remain_quantity":3010,"used_quantity":0,"user_limit":1,"batch_start_time":1528128000000,"batch_end_time":1528473599000,"source_type":87,"goods_id":10079469,"goods_name":"不配送上海","image_url":"http://pddtestimg.yangkeduo.com/test/2018-04-19/b3d3c27d8797ddfd9214cedc4b4a70a8.jpeg","status":1,"created_at":1528371772000}]
        /// </summary>
        [JsonProperty("coupon_batch_list")]
        public IList<CouponBatchList> CouponBatchList { get; set; }
    }

    public class GetPromotionGoodsCouponListResponseModel
    {

        /// <summary>
        /// Examples: {"total_size":89,"coupon_batch_list":[{"id":9251417714,"batch_desc":"免拼yinpu1234","discount_param":200,"min_order_amount":200,"init_quantity":3011,"remain_quantity":3010,"used_quantity":0,"user_limit":1,"batch_start_time":1528128000000,"batch_end_time":1528473599000,"source_type":87,"goods_id":10079469,"goods_name":"不配送上海","image_url":"http://pddtestimg.yangkeduo.com/test/2018-04-19/b3d3c27d8797ddfd9214cedc4b4a70a8.jpeg","status":1,"created_at":1528371772000}]}
        /// </summary>
        [JsonProperty("goods_coupon_batch_list_response")]
        public GoodsCouponBatchListResponse GoodsCouponBatchListResponse { get; set; }
    }


}
