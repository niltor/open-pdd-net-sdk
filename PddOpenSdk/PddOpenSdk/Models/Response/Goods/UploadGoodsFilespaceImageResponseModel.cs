using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class UploadGoodsFilespaceImageResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_filespace_image_upload_response")]
        public GoodsFilespaceImageUploadResponseResponseModel GoodsFilespaceImageUploadResponse { get; set; }
        public partial class GoodsFilespaceImageUploadResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 文件id
            /// </summary>
            [JsonProperty("file_id")]
            public long? FileId { get; set; }
            /// <summary>
            /// url
            /// </summary>
            [JsonProperty("url")]
            public string Url { get; set; }

        }

    }

}
