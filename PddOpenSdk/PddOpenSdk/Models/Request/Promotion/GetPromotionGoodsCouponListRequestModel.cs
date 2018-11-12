using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Promotion
{
    public partial class GetPromotionGoodsCouponListRequestModel : PddRequestModel
    {
        /// <summary>
        /// 页码，默认1
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }
        /// <summary>
        /// 每页数量，默认100
        /// </summary>
        [JsonProperty("page_size")]
        public int? PageSize { get; set; }
        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonProperty("goods_id")]
        public long? GoodsId { get; set; }
        /// <summary>
        /// 查询范围	0 全部，1 多多进宝券，2 无门槛商品券；默认1
        /// </summary>
        [JsonProperty("query_range")]
        public int? QueryRange { get; set; }
        /// <summary>
        /// 批次状态	1 领取中，2 已领完，3 已结束，4 已暂停
        /// </summary>
        [JsonProperty("batch_status")]
        public int? BatchStatus { get; set; }
        /// <summary>
        /// 排序	1 创建时间正序，2 创建时间倒序，3 开始时间正序，4 开始时间倒序，5 初始数量正序， 6 初始数量倒序，7 领取数量正序，8 领取数量倒序；默认2
        /// </summary>
        [JsonProperty("sort_by")]
        public int? SortBy { get; set; }

    }

}
