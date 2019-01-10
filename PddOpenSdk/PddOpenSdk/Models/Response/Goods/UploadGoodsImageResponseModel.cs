using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class UploadGoodsImageResponseModel : PddResponseModel
    {
        /// <summary>
        /// 商品图片上传响应对象
        /// </summary>
        [JsonProperty("goods_image_upload_response")]
        public GoodsImageUploadResponseResponseModel GoodsImageUploadResponse { get; set; }
        public partial class GoodsImageUploadResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 返回图片url
            /// </summary>
            [JsonProperty("image_url")]
            public string ImageUrl { get; set; }

        }

    }

}
