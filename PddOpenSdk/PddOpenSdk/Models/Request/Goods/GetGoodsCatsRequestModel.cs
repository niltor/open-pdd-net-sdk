using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class GetGoodsCatsRequestModel : PddRequestModel
    {
        /// <summary>
        /// 值=0时为顶点cat_id,通过树顶级节点获取cat树
        /// </summary>
        [JsonProperty("parent_cat_id")]
        public long ParentCatId { get; set; }

    }

}
