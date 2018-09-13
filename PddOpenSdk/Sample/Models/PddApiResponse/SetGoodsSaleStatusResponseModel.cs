using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class SetGoodsSaleStatusResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("返回response")]
public object GoodsSaleStatusSetResponse {get;set;}
/// <summary>
/// 是否修改成功
/// </summary>
[JsonProperty("是否修改成功")]
public bool IsSuccess {get;set;}
}
}

    public partial class GoodsSaleStatusSetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 是否修改成功
/// </summary>
[JsonProperty("是否修改成功")]
public bool IsSuccess {get;set;}
}


