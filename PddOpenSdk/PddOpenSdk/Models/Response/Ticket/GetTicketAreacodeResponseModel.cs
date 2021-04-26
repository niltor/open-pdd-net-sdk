using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Ticket
{
    public partial class GetTicketAreacodeResponseModel : PddResponseModel
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
            [JsonProperty("area_list")]
            public List<AreaListResponseModel> AreaList { get; set; }
            public partial class AreaListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("code")]
                public int? Code { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("level")]
                public int? Level { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("name")]
                public string Name { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("parent_code")]
                public int? ParentCode { get; set; }

            }

        }

    }

}
