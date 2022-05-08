namespace PddOpenSdk.Models.Request.Voucher;
public partial class VerificationVoucherOtaCard
{

    /// <summary>
    /// 待核销的券码
    /// </summary>
    [JsonPropertyName("card_no")]
    public string CardNo { get; set; }

    /// <summary>
    /// 核销门店id
    /// </summary>
    [JsonPropertyName("store_id")]
    public long StoreId { get; set; }

    /// <summary>
    /// 核销门店名称
    /// </summary>
    [JsonPropertyName("store_name")]
    public string StoreName { get; set; }

    /// <summary>
    /// 拼多多订单编号
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

}

