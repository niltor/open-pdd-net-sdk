using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Mall
{
    public class MallInfoGetResponse
    {

        /// <summary>
        /// Examples: "http://imsproductionimg.yangkeduo.com/78186d4b00b2bba243ec1d31e19a2d76.jpg"
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// Examples: "sss"
        /// </summary>
        [JsonProperty("mall_name")]
        public string MallName { get; set; }

        /// <summary>
        /// Examples: "dqw"
        /// </summary>
        [JsonProperty("mall_desc")]
        public string MallDesc { get; set; }
    }

    public class GetMallInfoResponseModel
    {

        /// <summary>
        /// Examples: {"logo":"http://imsproductionimg.yangkeduo.com/78186d4b00b2bba243ec1d31e19a2d76.jpg","mall_name":"sss","mall_desc":"dqw"}
        /// </summary>
        [JsonProperty("mall_info_get_response")]
        public MallInfoGetResponse MallInfoGetResponse { get; set; }
    }


}
