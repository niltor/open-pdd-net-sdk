namespace PddOpenSdk.Models.Response.Goods;
public partial class ChangeGoodsCpsMallUnitResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_cps_mall_unit_change_response")]
    public GoodsCpsMallUnitChangeResponseResponse GoodsCpsMallUnitChangeResponse { get; set; }
    public partial class GoodsCpsMallUnitChangeResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("result")]
        public bool? Result { get; set; }

    }

}

