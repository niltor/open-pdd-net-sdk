using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goodsedit
{
    public partial class SetGoodsRelationRequestModel : PddRequestModel
    {
        /// <summary>
        /// 拼多多商品id
        /// </summary>
        [JsonProperty("goods_id")]
        public long GoodsId { get; set; }
        /// <summary>
        /// 外部平台商品id
        /// </summary>
        [JsonProperty("out_goods_id")]
        public string OutGoodsId { get; set; }
        /// <summary>
        /// 外部平台商品url
        /// </summary>
        [JsonProperty("out_detail_url")]
        public string OutDetailUrl { get; set; }
        /// <summary>
        /// 外部平台商品最低价，单位：分
        /// </summary>
        [JsonProperty("out_low_goods_price")]
        public long OutLowGoodsPrice { get; set; }
        /// <summary>
        /// 外部平台商品最高价，单位：分
        /// </summary>
        [JsonProperty("out_high_goods_price")]
        public long OutHighGoodsPrice { get; set; }
        /// <summary>
        /// 外部平台枚举值， 淘宝/天猫 0，京东1，1688 2，唯品会3，苏宁4，亚马逊,5，网易6
        /// </summary>
        [JsonProperty("source_type")]
        public int SourceType { get; set; }
        /// <summary>
        /// 邮费
        /// </summary>
        [JsonProperty("postage")]
        public long Postage { get; set; }
        /// <summary>
        /// 外部平台店铺id
        /// </summary>
        [JsonProperty("out_mall_id")]
        public long? OutMallId { get; set; }

    }

}
