using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Mall
{
    public partial class RegisterQrpayPayeeRequestModel : PddRequestModel
    {
        /// <summary>
        /// 参数列表
        /// </summary>
        [JsonProperty("payee_list")]
        public List<PayeeListRequestModel> PayeeList { get; set; }
        public partial class PayeeListRequestModel : PddRequestModel
        {
            /// <summary>
            /// 参数名，用于注册到名单，并生成对应URL
            /// </summary>
            [JsonProperty("payee")]
            public string Payee { get; set; }

        }

    }

}
