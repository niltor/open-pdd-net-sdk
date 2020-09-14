using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Stock
{
    public partial class ListStockWareInfoRequestModel : PddRequestModel
    {
        /// <summary>
        /// 货品编码集合
        /// </summary>
        [JsonProperty("ware_sn_list")]
        public List<string> WareSnList { get; set; }

    }

}
