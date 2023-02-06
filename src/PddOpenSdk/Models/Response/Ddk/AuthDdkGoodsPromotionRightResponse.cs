namespace PddOpenSdk.Models.Response.Ddk;
public partial class AuthDdkGoodsPromotionRightResponse : PddResponseModel
{

    /// <summary>
    /// 返回结果
    /// </summary>
    [JsonPropertyName("goods_promotion_right_auth_response")]
    public GoodsPromotionRightAuthResponseResponse GoodsPromotionRightAuthResponse { get; set; }
    public partial class GoodsPromotionRightAuthResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 备案失败原因
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 备案结果
        /// </summary>
        [JsonPropertyName("result")]
        public bool? Result { get; set; }

    }

}

