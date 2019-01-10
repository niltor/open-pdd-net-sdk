using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class GetGoodsSoldCountAuditRequestModel : PddRequestModel
    {
        /// <summary>
        /// 申请标号
        /// </summary>
        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }

    }

}
