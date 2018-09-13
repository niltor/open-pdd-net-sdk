using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class CreateGoodsLogisticsTemplateResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回resposne
/// </summary>
[JsonProperty("返回resposne")]
public  GoodsLogisticsTemplateCreateResponse {get;set;}
/// <summary>
/// 模版id
/// </summary>
[JsonProperty("模版id")]
public  TemplateId {get;set;}
}
}

    public partial class GoodsLogisticsTemplateCreateResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 模版id
/// </summary>
[JsonProperty("模版id")]
public  TemplateId {get;set;}
}


