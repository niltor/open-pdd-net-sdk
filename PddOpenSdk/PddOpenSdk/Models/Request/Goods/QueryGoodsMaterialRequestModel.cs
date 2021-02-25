using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class QueryGoodsMaterialRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品id列表
        /// </summary>
        [JsonProperty("goods_id_list")]
        public List<long> GoodsIdList { get; set; }
        /// <summary>
        /// 素材类型列表
        /// </summary>
        [JsonProperty("type_list")]
        public List<long> TypeList { get; set; }

    }

}
