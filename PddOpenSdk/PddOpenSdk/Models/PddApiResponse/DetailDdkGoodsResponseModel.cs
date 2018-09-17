using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class DetailDdkGoodsResponseModel : PddResponseModel
    {
        /// <summary>
        /// 多多进宝商品对象列表
        /// </summary>
        [JsonProperty("goods_details")]
        public object GoodsDetails { get; set; }

        public partial class GoodsDetailsResponseModel : PddResponseModel
        {

        }

    }
}
