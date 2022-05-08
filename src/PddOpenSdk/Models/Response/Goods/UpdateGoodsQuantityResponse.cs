namespace PddOpenSdk.Models.Response.Goods;
public partial class UpdateGoodsQuantityResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_quantity_update_response")]
    public GoodsQuantityUpdateResponseResponse GoodsQuantityUpdateResponse { get; set; }
    public partial class GoodsQuantityUpdateResponseResponse : PddResponseModel
    {

        /// <summary>
        /// true
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }

    }

}

