using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class ListDdkLiveRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品数量，默认3，最多5个
        /// </summary>
        [JsonProperty("goods_page_size")]
        public int? GoodsPageSize { get; set; }
        /// <summary>
        /// 是否返回商品信息，默认false
        /// </summary>
        [JsonProperty("need_goods_info")]
        public bool? NeedGoodsInfo { get; set; }
        /// <summary>
        /// 分页数
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }
        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonProperty("page_size")]
        public int? PageSize { get; set; }

    }

}
