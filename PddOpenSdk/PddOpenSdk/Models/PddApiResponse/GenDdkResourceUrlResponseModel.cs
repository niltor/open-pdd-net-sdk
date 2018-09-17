using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GenDdkResourceUrlResponseModel : PddResponseModel
    {
        /// <summary>
        /// 单人团链接
        /// </summary>
        [JsonProperty("single_url_list")]
        public object SingleUrlList { get; set; }
        /// <summary>
        /// 多人团链接
        /// </summary>
        [JsonProperty("multi_url_list")]
        public object MultiUrlList { get; set; }
        /// <summary>
        /// 自定义参数
        /// </summary>
        [JsonProperty("sign")]
        public object Sign { get; set; }

        public partial class SingleUrlListResponseModel : PddResponseModel
        {

        }

        public partial class MultiUrlListResponseModel : PddResponseModel
        {

        }

    }
}
