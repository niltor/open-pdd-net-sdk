namespace PddOpenSdk.Models.Response.MallShop;
public partial class GetMallInfoResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("mall_info_get_response")]
    public MallInfoGetResponseResponse MallInfoGetResponse { get; set; }
    public partial class MallInfoGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 店铺logo
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 店铺描述
        /// </summary>
        [JsonPropertyName("mall_desc")]
        public string MallDesc { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [JsonPropertyName("mall_id")]
        public long? MallId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonPropertyName("mall_name")]
        public string MallName { get; set; }

        /// <summary>
        /// 店铺类型,1:个人 2:企业 3:旗舰店 4:专卖店 5:专营店 6:普通店
        /// </summary>
        [JsonPropertyName("merchant_type")]
        public int? MerchantType { get; set; }

        /// <summary>
        /// 店铺身份,0:厂商 1:分销商 2:都不是 3:都是
        /// </summary>
        [JsonPropertyName("mall_character")]
        public int? MallCharacter { get; set; }

    }

}

