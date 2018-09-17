using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetGoodsFabricResponseModel : PddResponseModel
    {
        /// <summary>
        /// 服饰面料对象列表
        /// </summary>
        [JsonProperty("goods_fabric_list")]
        public object GoodsFabricList { get; set; }

        public partial class GoodsFabricListResponseModel : PddResponseModel
        {

        }

    }
}
