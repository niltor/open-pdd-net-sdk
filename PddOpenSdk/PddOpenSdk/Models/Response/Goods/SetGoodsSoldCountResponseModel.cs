using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class SetGoodsSoldCountResponseModel : PddResponseModel
    {
        /// <summary>
        /// 请求response
        /// </summary>
        [JsonProperty("goods_sold_count_set_response")]
        public GoodsSoldCountSetResponseResponseModel GoodsSoldCountSetResponse { get; set; }
        public partial class GoodsSoldCountSetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 申请标号
            /// </summary>
            [JsonProperty("serial_number")]
            public string SerialNumber { get; set; }

        }

    }

}
