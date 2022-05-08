namespace PddOpenSdk.Models.Response.Goods;
public partial class CreateGoodsCpsUnitResponse : PddResponseModel
{

    /// <summary>
    /// 失败原因列表对象，创建成功则此参数为空
    /// </summary>
    [JsonPropertyName("failed_vos")]
    public List<FailedVosResponse> FailedVos { get; set; }
    public partial class FailedVosResponse : PddResponseModel
    {

        /// <summary>
        /// 创建失败的商品id
        /// </summary>
        [JsonPropertyName("goods_id")]
        public long? GoodsId { get; set; }

        /// <summary>
        /// 创建失败原因
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

    }

}

