using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class ListAdApiUnitBidQueryTargetingTagResponseModel : PddResponseModel
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
                /// 标签描述
                /// </summary>
                [JsonProperty("description")]
                public string Description { get; set; }
                /// <summary>
                /// 父标签Id
                /// </summary>
                [JsonProperty("parentTagId")]
                public string ParentTagId { get; set; }
                /// <summary>
                /// 标签Id
                /// </summary>
                [JsonProperty("tagId")]
                public string TagId { get; set; }
                /// <summary>
                /// 定向标签类型，1-地域定向
                /// </summary>
                [JsonProperty("tagType")]
                public int? TagType { get; set; }

            }

        }

    }

}
