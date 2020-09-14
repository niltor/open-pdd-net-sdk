using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class UploadGoodsFilespaceImageRequestModel : PddRequestModel
    {
        /// <summary>
        /// 图片文件流
        /// </summary>
        [JsonProperty("file_path")]
        public string FilePath { get; set; }

    }

}
