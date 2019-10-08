using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
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
        /// 外部平台枚举值， 0-淘宝/天猫 ，1-京东，2-1688，3-唯品会，4-苏宁，5-亚马逊，6-网易，8-微店，9-网商园，10-蘑菇街，11-vvic搜款网，12-搜鞋网，13-一起做网店17zwd，14-杭州女装网，15-折800，16-当当，17-青创网，18-开山网，19-新款网
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
