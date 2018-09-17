using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class UploadGoodsImageRequestModel : PddRequestModel
    {
        /// <summary>
        /// 该值为：pdd.goods.image.upload
        /// </summary>
        [JsonProperty("type")]
        public object Type { get; set; }
        /// <summary>
        /// 支持格式有：jpg/jpeg、png等图片格式，注意入参图片必须转码为base64编码
        /// </summary>
        [JsonProperty("image")]
        public object Image { get; set; }

    }
}
