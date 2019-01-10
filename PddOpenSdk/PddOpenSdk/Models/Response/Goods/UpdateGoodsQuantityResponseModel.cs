using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class UpdateGoodsQuantityResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_quantity_update_response")]
        public GoodsQuantityUpdateResponseResponseModel GoodsQuantityUpdateResponse { get; set; }
        public partial class GoodsQuantityUpdateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// true
            /// </summary>
            [JsonProperty("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}
