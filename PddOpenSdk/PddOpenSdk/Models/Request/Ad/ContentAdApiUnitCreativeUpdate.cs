namespace PddOpenSdk.Models.Request.Ad;
public partial class ContentAdApiUnitCreativeUpdate
{

    /// <summary>
    /// 创意更新输入
    /// </summary>
    [JsonPropertyName("adCreativeUpdateMessage")]
    public AdCreativeUpdateMessageModel AdCreativeUpdateMessage { get; set; }

    /// <summary>
    /// 创意单元Id
    /// </summary>
    [JsonPropertyName("unitCreativeId")]
    public long UnitCreativeId { get; set; }
    public partial class AdCreativeUpdateMessageModel
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
        /// 创意规格Id，6-轮播图，7-长图
        /// </summary>
        [JsonPropertyName("creativeSpecificationId")]
        public long CreativeSpecificationId { get; set; }
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
            /// 标题文字
            /// </summary>
            [JsonPropertyName("text")]
            public string Text { get; set; }

        }

    }

}

