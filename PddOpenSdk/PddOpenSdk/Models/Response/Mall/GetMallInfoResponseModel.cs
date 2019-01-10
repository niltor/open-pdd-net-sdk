using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Mall
{
    public partial class GetMallInfoResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("mall_info_get_response")]
        public MallInfoGetResponseResponseModel MallInfoGetResponse { get; set; }
        public partial class MallInfoGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 店铺logo
            /// </summary>
            [JsonProperty("logo")]
            public string Logo { get; set; }
            /// <summary>
            /// 店铺名称
            /// </summary>
            [JsonProperty("mall_name")]
            public string MallName { get; set; }
            /// <summary>
            /// 店铺描述
            /// </summary>
            [JsonProperty("mall_desc")]
            public string MallDesc { get; set; }

        }

    }

}
