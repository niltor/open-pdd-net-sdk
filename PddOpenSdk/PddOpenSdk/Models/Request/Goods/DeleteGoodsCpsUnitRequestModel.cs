using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class DeleteGoodsCpsUnitRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("goods_id")]
        public long GoodsId { get; set; }

    }

}
