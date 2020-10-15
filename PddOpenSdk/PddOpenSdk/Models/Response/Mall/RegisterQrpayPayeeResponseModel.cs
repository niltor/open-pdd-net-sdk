using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Mall
{
    public partial class RegisterQrpayPayeeResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("qrpay_payee_register_response")]
        public QrpayPayeeRegisterResponseResponseModel QrpayPayeeRegisterResponse { get; set; }
        public partial class QrpayPayeeRegisterResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 参数注册结果
            /// </summary>
            [JsonProperty("payee_result_list")]
            public List<PayeeResultListResponseModel> PayeeResultList { get; set; }
            public partial class PayeeResultListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 参数名
                /// </summary>
                [JsonProperty("payee")]
                public string Payee { get; set; }
                /// <summary>
                /// 参数id
                /// </summary>
                [JsonProperty("payee_id")]
                public long? PayeeId { get; set; }
                /// <summary>
                /// 交易二维码图片UR
                /// </summary>
                [JsonProperty("qr_image_url")]
                public string QrImageUrl { get; set; }
                /// <summary>
                /// 交易二维码页面URL
                /// </summary>
                [JsonProperty("qr_pay_page_url")]
                public string QrPayPageUrl { get; set; }

            }

        }

    }

}
