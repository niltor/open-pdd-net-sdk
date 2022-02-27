namespace PddOpenSdk.Models.Response.Goods;
public partial class UploadGoodsImgResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("goods_img_upload_response")]
    public GoodsImgUploadResponseResponse GoodsImgUploadResponse { get; set; }
    public partial class GoodsImgUploadResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

    }

}

