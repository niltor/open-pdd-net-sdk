using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Express
{
    public partial class GetExpressMallDepotSimpleResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("open_api_response")]
        public List<OpenApiResponseResponseModel> OpenApiResponse { get; set; }
        public partial class OpenApiResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 仓库Id
            /// </summary>
            [JsonProperty("depot_id")]
            public long? DepotId { get; set; }
            /// <summary>
            /// 仓库id的string表示
            /// </summary>
            [JsonProperty("depot_str")]
            public string DepotStr { get; set; }
            /// <summary>
            /// 仓库名称
            /// </summary>
            [JsonProperty("name")]
            public string Name { get; set; }
            /// <summary>
            /// 仓库类型(暂时1表示自建仓)
            /// </summary>
            [JsonProperty("depot_type")]
            public int? DepotType { get; set; }

        }

    }

}
