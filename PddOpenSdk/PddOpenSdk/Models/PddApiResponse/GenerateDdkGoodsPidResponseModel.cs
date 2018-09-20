using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GenerateDdkGoodsPidResponseModel : PddResponseModel
    {
        /// <summary>
/// 多多进宝推广位对象列表
/// </summary>
[JsonProperty("p_id_list")]
public PIdListResponseModel PIdList {get;set;}

    public partial class PIdListResponseModel : PddResponseModel
    {
        /// <summary>
/// 推广位名称
/// </summary>
[JsonProperty("p_id_name")]
public string PIdName {get;set;}
/// <summary>
/// 调用方推广位ID
/// </summary>
[JsonProperty("p_id")]
public string PId {get;set;}

}

}
}
