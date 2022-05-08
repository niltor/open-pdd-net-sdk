namespace PddOpenSdk.Models.Response.Goods;
public partial class PauseGoodsCpsMallUnitResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_cps_mall_unit_pause_response")]
    public GoodsCpsMallUnitPauseResponseResponse GoodsCpsMallUnitPauseResponse { get; set; }
    public partial class GoodsCpsMallUnitPauseResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("result")]
        public bool? Result { get; set; }

    }

}

