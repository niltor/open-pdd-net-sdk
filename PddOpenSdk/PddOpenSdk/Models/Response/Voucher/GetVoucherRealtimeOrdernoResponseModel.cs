using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Voucher
{
    public partial class GetVoucherRealtimeOrdernoResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response")]
        public ResponseResponseModel Response { get; set; }
        public partial class ResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("code")]
            public int? Code { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("message")]
            public string Message { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("result")]
            public List<ResultResponseModel> Result { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("external_order_no")]
                public string ExternalOrderNo { get; set; }

            }

        }

    }

}
