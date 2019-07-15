using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Utildivide
{
    public partial class ImageUtilDivideBase64RequestModel : PddRequestModel
    {
        /// <summary>
        /// 支持格式有：jpg/jpeg、png等图片格式，入参为图片的base64编码，最大支持2M
        /// </summary>
        [JsonProperty("img_data")]
        public string ImgData { get; set; }

    }

}
