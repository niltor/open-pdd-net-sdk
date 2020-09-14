using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class ProfileAdApiUnitBidQueryBaseTargetRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        [JsonProperty("goodsId")]
        public long GoodsId { get; set; }
        /// <summary>
        /// 场景类型，0-搜索，2-展示
        /// </summary>
        [JsonProperty("scenesType")]
        public int ScenesType { get; set; }

    }

}
