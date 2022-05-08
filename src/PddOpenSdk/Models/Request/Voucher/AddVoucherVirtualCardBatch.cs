namespace PddOpenSdk.Models.Request.Voucher;
public partial class AddVoucherVirtualCardBatch
{

    /// <summary>
    /// 业务数据
    /// </summary>
    [JsonPropertyName("data")]
    public DataModel Data { get; set; }
    public partial class DataModel
    {

        /// <summary>
        /// 充值地址
        /// </summary>
        [JsonPropertyName("chargeAddress")]
        public string ChargeAddress { get; set; }

        /// <summary>
        /// 卡密信息列表，一次请求最多5000条卡密
        /// </summary>
        [JsonPropertyName("dataList")]
        public List<DataListModel> DataList { get; set; }

        /// <summary>
        /// 商品Id
        /// </summary>
        [JsonPropertyName("goodsId")]
        public long GoodsId { get; set; }

        /// <summary>
        /// skuId
        /// </summary>
        [JsonPropertyName("skuId")]
        public long SkuId { get; set; }
        public partial class DataListModel
        {

            /// <summary>
            /// 卡密卡号，商家卡密必填
            /// </summary>
            [JsonPropertyName("cardNo")]
            public string CardNo { get; set; }

            /// <summary>
            /// 用户核销卡密加密串，加密所使用public key向对接小二获取（加密算法"RSA"，填充方式"RSA/ECB/PKCS1Padding"）
            /// </summary>
            [JsonPropertyName("encryptPassword")]
            public string EncryptPassword { get; set; }

        }

    }

}

