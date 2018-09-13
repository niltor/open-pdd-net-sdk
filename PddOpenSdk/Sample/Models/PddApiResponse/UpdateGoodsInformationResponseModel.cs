using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class UpdateGoodsInformationResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("返回response")]
public object GoodsUpdateResponse {get;set;}
/// <summary>
/// 提交申请的序列id
/// </summary>
[JsonProperty("提交申请的序列id")]
public int GoodsCommitId {get;set;}
/// <summary>
/// 是否修改成功
/// </summary>
[JsonProperty("是否修改成功")]
public bool IsSuccess {get;set;}
}
}

    public partial class GoodsUpdateResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 提交申请的序列id
/// </summary>
[JsonProperty("提交申请的序列id")]
public int GoodsCommitId {get;set;}
/// <summary>
/// 是否修改成功
/// </summary>
[JsonProperty("是否修改成功")]
public bool IsSuccess {get;set;}
}


