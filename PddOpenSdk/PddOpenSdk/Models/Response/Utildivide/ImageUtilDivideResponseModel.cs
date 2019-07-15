using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Utildivide
{
    public partial class ImageUtilDivideResponseModel : PddResponseModel
    {
        /// <summary>
        /// 切图后的地址列表
        /// </summary>
        [JsonProperty("open_api_response")]
        public List<string> OpenApiResponse { get; set; }

    }

}
