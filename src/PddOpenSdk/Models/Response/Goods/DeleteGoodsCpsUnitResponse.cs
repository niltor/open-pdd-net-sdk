namespace PddOpenSdk.Models.Response.Goods;
public partial class DeleteGoodsCpsUnitResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_cps_unit_delete_response")]
    public GoodsCpsUnitDeleteResponseResponse GoodsCpsUnitDeleteResponse { get; set; }
    public partial class GoodsCpsUnitDeleteResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }

    }

}

