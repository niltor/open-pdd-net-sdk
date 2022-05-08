namespace PddOpenSdk.Models.Request.Ad;
public partial class CreateAdApiUnitCreative
{

    /// <summary>
    /// 创意列表
    /// </summary>
    [JsonPropertyName("adCreativeCreateMessage")]
    public AdCreativeCreateMessageModel AdCreativeCreateMessage { get; set; }

    /// <summary>
    /// 广告单元Id
    /// </summary>
    [JsonPropertyName("adId")]
    public long AdId { get; set; }
    public partial class AdCreativeCreateMessageModel
    {

        /// <summary>
        /// 创意图片列表
        /// </summary>
        [JsonPropertyName("adImageVOList")]
        public List<AdImageVOListModel> AdImageVOList { get; set; }

        /// <summary>
        /// 创意标题列表
        /// </summary>
        [JsonPropertyName("adTextVOList")]
        public List<AdTextVOListModel> AdTextVOList { get; set; }

        /// <summary>
        /// 创意规格，6：商品轮播图，7：商品长图，其余规格暂不支持
        /// </summary>
        [JsonPropertyName("creativeSpecificationId")]
        public long? CreativeSpecificationId { get; set; }
        public partial class AdImageVOListModel
        {

            /// <summary>
            /// 图片链接，可用图片参考以下接口返回：pdd.ad.api.goods.query.gallery.images（轮播图），pdd.ad.api.goods.query.long.images（长图）
            /// </summary>
            [JsonPropertyName("imageUrl")]
            public string ImageUrl { get; set; }

        }
        public partial class AdTextVOListModel
        {

            /// <summary>
            /// 标题
            /// </summary>
            [JsonPropertyName("text")]
            public string Text { get; set; }

        }

    }

}

