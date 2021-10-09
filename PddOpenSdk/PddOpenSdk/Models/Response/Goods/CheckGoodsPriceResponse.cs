namespace PddOpenSdk.Models.Response.Goods;
public partial class CheckGoodsPriceResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("goodsid_price_check_response")]
    public GoodsidPriceCheckResponseResponse GoodsidPriceCheckResponse { get; set; }
    public partial class GoodsidPriceCheckResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("result")]
        public long? Result { get; set; }

    }

}

