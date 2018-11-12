using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class CommitDeleteGoodsRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品id 列表(List<Long>) json string，例：[1,2]，一次操作数量请小于50
        /// </summary>
        [JsonProperty("goods_ids")]
        public List<long> GoodsIds { get; set; }

    }

}
