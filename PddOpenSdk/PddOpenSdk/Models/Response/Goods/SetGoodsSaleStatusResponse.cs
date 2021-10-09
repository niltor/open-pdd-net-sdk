namespace PddOpenSdk.Models.Response.Goods;
public partial class SetGoodsSaleStatusResponse : PddResponseModel
{

    /// <summary>
    /// 返回response
    /// </summary>
    [JsonPropertyName("goods_sale_status_set_response")]
    public GoodsSaleStatusSetResponseResponse GoodsSaleStatusSetResponse { get; set; }
    public partial class GoodsSaleStatusSetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 是否修改成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }

    }

}

