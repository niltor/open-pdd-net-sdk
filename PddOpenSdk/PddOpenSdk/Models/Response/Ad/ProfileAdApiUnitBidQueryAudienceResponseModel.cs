using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class ProfileAdApiUnitBidQueryAudienceResponseModel : PddResponseModel
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
                /// DMP人群Id
                /// </summary>
                [JsonProperty("audienceId")]
                public string AudienceId { get; set; }
                /// <summary>
                /// DMP人群名称
                /// </summary>
                [JsonProperty("audienceName")]
                public string AudienceName { get; set; }
                /// <summary>
                /// DMP人群类型 1 - 自定义人群， 2 - 标签创建人群, 3 - 系统推荐人群
                /// </summary>
                [JsonProperty("audienceType")]
                public int? AudienceType { get; set; }

            }

        }

    }

}
