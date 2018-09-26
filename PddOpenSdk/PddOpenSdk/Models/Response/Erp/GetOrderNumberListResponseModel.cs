using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Erp
{
    public class OrderSnList
    {

        /// <summary>
        /// Examples: "180227-394702832640993"
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }
    }

    public class OrderSnListGetResponse
    {

        /// <summary>
        /// Examples: [{"order_sn":"180227-394702832640993"}]
        /// </summary>
        [JsonProperty("order_sn_list")]
        public IList<OrderSnList> OrderSnList { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class GetOrderNumberListResponseModel
    {

        /// <summary>
        /// Examples: {"order_sn_list":[{"order_sn":"180227-394702832640993"}],"total_count":1}
        /// </summary>
        [JsonProperty("order_sn_list_get_response")]
        public OrderSnListGetResponse OrderSnListGetResponse { get; set; }
    }


}
