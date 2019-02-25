using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class GetGoodsOuterCatMappingRequestModel : PddRequestModel
    {
        /// <summary>
        /// 外部叶子类目id
        /// </summary>
        [JsonProperty("outer_cat_id")]
        public long OuterCatId { get; set; }
        /// <summary>
        /// 外部叶子类目名称
        /// </summary>
        [JsonProperty("outer_cat_name")]
        public string OuterCatName { get; set; }
        /// <summary>
        /// 外部商品名称
        /// </summary>
        [JsonProperty("outer_goods_name")]
        public string OuterGoodsName { get; set; }

    }

}
