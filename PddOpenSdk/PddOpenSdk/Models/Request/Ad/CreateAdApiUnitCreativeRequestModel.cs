using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class CreateAdApiUnitCreativeRequestModel : PddRequestModel
    {
        /// <summary>
        /// 创意列表
        /// </summary>
        [JsonProperty("adCreativeCreateMessage")]
        public AdCreativeCreateMessageRequestModel AdCreativeCreateMessage { get; set; }
        /// <summary>
        /// 广告单元Id
        /// </summary>
        [JsonProperty("adId")]
        public long AdId { get; set; }
        public partial class AdCreativeCreateMessageRequestModel : PddRequestModel
        {
            /// <summary>
            /// 创意图片列表
            /// </summary>
            [JsonProperty("adImageVOList")]
            public List<AdImageVOListRequestModel> AdImageVOList { get; set; }
            /// <summary>
            /// 创意标题列表
            /// </summary>
            [JsonProperty("adTextVOList")]
            public List<AdTextVOListRequestModel> AdTextVOList { get; set; }
            /// <summary>
            /// 创意规格，6：商品轮播图，7：商品长图，其余规格暂不支持
            /// </summary>
            [JsonProperty("creativeSpecificationId")]
            public long? CreativeSpecificationId { get; set; }
            public partial class AdImageVOListRequestModel : PddRequestModel
            {
                /// <summary>
                /// 图片链接，可用图片参考以下接口返回：pdd.ad.api.goods.query.gallery.images（轮播图），pdd.ad.api.goods.query.long.images（长图）
                /// </summary>
                [JsonProperty("imageUrl")]
                public string ImageUrl { get; set; }

            }
            public partial class AdTextVOListRequestModel : PddRequestModel
            {
                /// <summary>
                /// 标题
                /// </summary>
                [JsonProperty("text")]
                public string Text { get; set; }

            }

        }

    }

}
