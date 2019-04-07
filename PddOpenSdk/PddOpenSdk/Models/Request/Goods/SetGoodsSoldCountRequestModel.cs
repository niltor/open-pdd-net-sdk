using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class SetGoodsSoldCountRequestModel : PddRequestModel {
        /// <summary>
        /// 拼多多商品id
        /// </summary>
        [JsonProperty ("pdd_goods_id")]
        public long PddGoodsId { get; set; }
        /// <summary>
        /// 第三方商品id
        /// </summary>
        [JsonProperty ("out_goods_id")]
        public string OutGoodsId { get; set; }
        /// <summary>
        /// 第三方月销量
        /// </summary>
        [JsonProperty ("out_sold_count_month")]
        public long OutSoldCountMonth { get; set; }
        /// <summary>
        /// 第三方总销量
        /// </summary>
        [JsonProperty ("out_sold_count_total")]
        public long OutSoldCountTotal { get; set; }
        /// <summary>
        /// 第三方店铺名称
        /// </summary>
        [JsonProperty ("out_mall_name")]
        public string OutMallName { get; set; }
        /// <summary>
        /// 商品来源平台，0，1，2，3，4，5，6，7
        /// </summary>
        [JsonProperty ("out_source_type")]
        public int OutSourceType { get; set; }

    }

}