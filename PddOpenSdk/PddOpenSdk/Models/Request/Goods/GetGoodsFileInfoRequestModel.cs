using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class GetGoodsFileInfoRequestModel : PddRequestModel
    {
        /// <summary>
        /// url列表
        /// </summary>
        [JsonProperty("url_list")]
        public List<string> UrlList { get; set; }

    }

}
