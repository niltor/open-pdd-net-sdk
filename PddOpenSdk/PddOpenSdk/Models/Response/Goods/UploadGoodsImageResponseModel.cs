using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class GoodsImageUploadResponse
    {

        /// <summary>
        /// Examples: "http://testimg.yangkeduo.com/pdd_oms/2018-01-16/188be92f3f494e41e5980c9ec5a5c711.png"
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
    }

    public class UploadGoodsImageResponseModel
    {

        /// <summary>
        /// Examples: {"image_url":"http://testimg.yangkeduo.com/pdd_oms/2018-01-16/188be92f3f494e41e5980c9ec5a5c711.png"}
        /// </summary>
        [JsonProperty("goods_image_upload_response")]
        public GoodsImageUploadResponse GoodsImageUploadResponse { get; set; }
    }


}
