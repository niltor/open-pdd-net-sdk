using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Goodsedit
{
    public partial class GetGoodsCommitStatusRequestModel : PddRequestModel
    {
        /// <summary>
        /// goods_commit_id列表
        /// </summary>
        [JsonProperty("goods_commit_id_list")]
        public List<long> GoodsCommitIdList { get; set; }

    }

}
