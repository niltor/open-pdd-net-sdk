using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class UploadGoodsImageRequestModel : PddRequestModel
    {
        /// <summary>
        /// 支持格式有：jpg/jpeg、png等图片格式，注意入参图片必须转码为base64编码
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

    }

}
