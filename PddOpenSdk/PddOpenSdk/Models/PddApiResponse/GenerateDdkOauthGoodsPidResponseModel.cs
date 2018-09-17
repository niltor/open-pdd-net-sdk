using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GenerateDdkOauthGoodsPidResponseModel : PddResponseModel
    {
        /// <summary>
        /// 多多进宝推广位对象列表
        /// </summary>
        [JsonProperty("p_id_list")]
        public object PIdList { get; set; }

        public partial class PIdListResponseModel : PddResponseModel
        {

        }

    }
}
