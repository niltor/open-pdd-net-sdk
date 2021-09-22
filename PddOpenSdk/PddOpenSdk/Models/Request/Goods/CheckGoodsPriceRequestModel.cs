using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class CheckGoodsPriceRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品id，long值，大于0
        /// </summary>
        [JsonProperty("goodsId")]
        public long GoodsId { get; set; }

    }

}
