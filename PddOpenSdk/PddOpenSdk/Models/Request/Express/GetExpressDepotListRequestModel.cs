using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Express
{
    public partial class GetExpressDepotListRequestModel : PddRequestModel
    {
        /// <summary>
        /// 分页数据起始位置
        /// </summary>
        [JsonProperty("start")]
        public long Start { get; set; }
        /// <summary>
        /// 分页数据size
        /// </summary>
        [JsonProperty("length")]
        public long Length { get; set; }

    }

}
