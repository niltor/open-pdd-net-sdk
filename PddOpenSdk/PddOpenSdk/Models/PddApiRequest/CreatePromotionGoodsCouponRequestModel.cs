using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class CreatePromotionGoodsCouponRequestModel : PddRequestModel
    {
        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("batch_desc")]
        public string BatchDesc { get; set; }
        /// <summary>
        /// 开始时间，指到格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)的总毫秒数
        /// </summary>
        [JsonProperty("batch_start_time")]
        public int BatchStartTime { get; set; }
        /// <summary>
        /// 结束时间，指到格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)的总毫秒数
        /// </summary>
        [JsonProperty("batch_end_time")]
        public int BatchEndTime { get; set; }
        /// <summary>
        /// 优惠金额	单位: 分
        /// </summary>
        [JsonProperty("discount")]
        public int Discount { get; set; }
        /// <summary>
        /// 可领取数量
        /// </summary>
        [JsonProperty("init_quantity")]
        public int InitQuantity { get; set; }
        /// <summary>
        /// 每个用户限领张数
        /// </summary>
        [JsonProperty("user_limit")]
        public int UserLimit { get; set; }
        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonProperty("goods_id")]
        public int GoodsId { get; set; }

    }
}
