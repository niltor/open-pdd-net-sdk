using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetGoodsCatsResponseModel : PddResponseModel
    {
        /// <summary>
        /// 类目树对象
        /// </summary>
        [JsonProperty("goods_cats_list")]
        public object GoodsCatsList { get; set; }

        public partial class GoodsCatsListResponseModel : PddResponseModel
        {

        }

    }
}
