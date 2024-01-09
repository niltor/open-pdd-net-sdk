namespace PddOpenSdk.Models.Response.Goods;
public partial class UploadGoodsVideoResponse : PddResponseModel
{

    /// <summary>
    /// 1
    /// </summary>
    [JsonPropertyName("goods_video_upload_response")]
    public GoodsVideoUploadResponseResponse GoodsVideoUploadResponse { get; set; }
    public partial class GoodsVideoUploadResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 文件id
        /// </summary>
        [JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 文件url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }

    }

}

