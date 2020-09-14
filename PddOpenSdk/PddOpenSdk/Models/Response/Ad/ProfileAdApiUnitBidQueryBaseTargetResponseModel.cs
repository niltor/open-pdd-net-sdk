using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class ProfileAdApiUnitBidQueryBaseTargetResponseModel : PddResponseModel
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
            [JsonProperty("errorCode")]
            public int? ErrorCode { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("errorMsg")]
            public string ErrorMsg { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("result")]
            public List<ResultResponseModel> Result { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("success")]
            public bool? Success { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 定向类型描述
                /// </summary>
                [JsonProperty("targetName")]
                public string TargetName { get; set; }
                /// <summary>
                /// 定向类型
                /// </summary>
                [JsonProperty("targetType")]
                public int? TargetType { get; set; }
                /// <summary>
                /// 用户数量预估
                /// </summary>
                [JsonProperty("uvString")]
                public string UvString { get; set; }

            }

        }

    }

}
