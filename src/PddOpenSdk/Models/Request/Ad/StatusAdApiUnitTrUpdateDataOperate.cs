namespace PddOpenSdk.Models.Request.Ad;
public partial class StatusAdApiUnitTrUpdateDataOperate
{

    /// <summary>
    /// 商家操作状态：1-启动 2-暂停
    /// </summary>
    [JsonPropertyName("dataOperateStatus")]
    public int DataOperateStatus { get; set; }

    /// <summary>
    /// 商品id列表
    /// </summary>
    [JsonPropertyName("goodsIds")]
    public List<long> GoodsIds { get; set; }

}

