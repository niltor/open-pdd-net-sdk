using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Voucher
{
    public partial class AddVoucherVirtualCardBatchRequestModel : PddRequestModel
    {
        /// <summary>
        /// 业务数据
        /// </summary>
        [JsonProperty("data")]
        public DataRequestModel Data { get; set; }
        public partial class DataRequestModel : PddRequestModel
        {
            /// <summary>
            /// 充值地址
            /// </summary>
            [JsonProperty("chargeAddress")]
            public string ChargeAddress { get; set; }
            /// <summary>
            /// 卡密信息列表，一次请求最多5000条卡密
            /// </summary>
            [JsonProperty("dataList")]
            public List<DataListRequestModel> DataList { get; set; }
            /// <summary>
            /// 商品Id
            /// </summary>
            [JsonProperty("goodsId")]
            public long GoodsId { get; set; }
            /// <summary>
            /// skuId
            /// </summary>
            [JsonProperty("skuId")]
            public long SkuId { get; set; }
            public partial class DataListRequestModel : PddRequestModel
            {
                /// <summary>
                /// 卡密卡号，商家卡密必填
                /// </summary>
                [JsonProperty("cardNo")]
                public string CardNo { get; set; }
                /// <summary>
                /// 用户核销卡密加密串，加密所使用public key向对接小二获取（加密算法"RSA"，填充方式"RSA/ECB/PKCS1Padding"）
                /// </summary>
                [JsonProperty("encryptPassword")]
                public string EncryptPassword { get; set; }

            }

        }

    }

}
