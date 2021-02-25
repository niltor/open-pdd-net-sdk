using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class ContentAdApiUnitCreativeUpdateRequestModel : PddRequestModel
    {
        /// <summary>
        /// 创意更新输入
        /// </summary>
        [JsonProperty("adCreativeUpdateMessage")]
        public AdCreativeUpdateMessageRequestModel AdCreativeUpdateMessage { get; set; }
        /// <summary>
        /// 创意单元Id
        /// </summary>
        [JsonProperty("unitCreativeId")]
        public long UnitCreativeId { get; set; }
        public partial class AdCreativeUpdateMessageRequestModel : PddRequestModel
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
            /// 创意规格Id，6-轮播图，7-长图
            /// </summary>
            [JsonProperty("creativeSpecificationId")]
            public long CreativeSpecificationId { get; set; }
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
                /// 标题文字
                /// </summary>
                [JsonProperty("text")]
                public string Text { get; set; }

            }

        }

    }

}
