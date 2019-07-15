using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Goodsedit
{
    public partial class RelationGoodsGetRequestModel : PddRequestModel
    {
        /// <summary>
        /// 拼多多商品id
        /// </summary>
        [JsonProperty("pdd_goods_id")]
        public List<long> PddGoodsId { get; set; }

    }

}
