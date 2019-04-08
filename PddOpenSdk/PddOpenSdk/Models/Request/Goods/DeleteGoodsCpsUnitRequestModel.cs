using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class DeleteGoodsCpsUnitRequestModel : PddRequestModel {
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty ("goods_id")]
        public long GoodsId { get; set; }

    }

}