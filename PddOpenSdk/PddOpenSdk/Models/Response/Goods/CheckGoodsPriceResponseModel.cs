using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class CheckGoodsPriceResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("goodsid_price_check_response")]
        public GoodsidPriceCheckResponseResponseModel GoodsidPriceCheckResponse { get; set; }
        public partial class GoodsidPriceCheckResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("result")]
            public long? Result { get; set; }

        }

    }

}
