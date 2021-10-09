namespace PddOpenSdk.Models.Response.Goods;
public partial class UploadGoodsImageResponse : PddResponseModel
{

    /// <summary>
    /// 商品图片上传响应对象
    /// </summary>
    [JsonPropertyName("goods_image_upload_response")]
    public GoodsImageUploadResponseResponse GoodsImageUploadResponse { get; set; }
    public partial class GoodsImageUploadResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 返回图片url
        /// </summary>
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

    }

}

