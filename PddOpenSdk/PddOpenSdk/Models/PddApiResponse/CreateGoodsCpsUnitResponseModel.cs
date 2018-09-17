using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class CreateGoodsCpsUnitResponseModel : PddResponseModel
    {
        /// <summary>
        /// 失败原因列表对象，创建成功则此参数为空
        /// </summary>
        [JsonProperty("failed_vos")]
        public object FailedVos { get; set; }

        public partial class FailedVosResponseModel : PddResponseModel
        {

        }

    }
}
