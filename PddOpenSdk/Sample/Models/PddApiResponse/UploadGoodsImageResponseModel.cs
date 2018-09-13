using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class UploadGoodsImageResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品图片上传响应对象
/// </summary>
[JsonProperty("商品图片上传响应对象")]
public List<GoodsImageUploadResponse> GoodsImageUploadResponse {get;set;}
/// <summary>
/// 返回图片url
/// </summary>
[JsonProperty("返回图片url")]
public string ImageUrl {get;set;}
}
}

    public partial class GoodsImageUploadResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回图片url
/// </summary>
[JsonProperty("返回图片url")]
public string ImageUrl {get;set;}
}


