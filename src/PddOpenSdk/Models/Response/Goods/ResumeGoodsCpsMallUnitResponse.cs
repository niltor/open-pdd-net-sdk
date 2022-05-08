namespace PddOpenSdk.Models.Response.Goods;
public partial class ResumeGoodsCpsMallUnitResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_cps_mall_unit_resume_response")]
    public GoodsCpsMallUnitResumeResponseResponse GoodsCpsMallUnitResumeResponse { get; set; }
    public partial class GoodsCpsMallUnitResumeResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public bool? Result { get; set; }

    }

}

