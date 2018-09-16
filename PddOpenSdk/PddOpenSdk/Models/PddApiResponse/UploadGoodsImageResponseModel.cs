using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class UploadGoodsImageResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品图片上传响应对象
/// </summary>
[JsonProperty("goods_image_upload_response")]
public object GoodsImageUploadResponse {get;set;}

    public partial class GoodsImageUploadResponseResponseModel : PddResponseModel
    {
        
}

}
}
