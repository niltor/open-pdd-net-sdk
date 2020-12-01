using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Promotion
{
    public partial class GetPromotionLimitedQualifiedGoodsRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品id列表
        /// </summary>
        [JsonProperty("goods_id_list")]
        public List<long?> GoodsIdList { get; set; }
        /// <summary>
        /// TRUE-仅查询可选商品（满足活动资格商品）数据；FALSE-查询不可选商品数据
        /// </summary>
        [JsonProperty("is_valid")]
        public bool IsValid { get; set; }
        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page_no")]
        public int? PageNo { get; set; }
        /// <summary>
        /// 每页查询数
        /// </summary>
        [JsonProperty("page_size")]
        public int? PageSize { get; set; }

    }

}
