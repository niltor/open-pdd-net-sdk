using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetGoodsFabricResponseModel : PddResponseModel
    {
        /// <summary>
/// 服饰面料对象列表
/// </summary>
[JsonProperty("服饰面料对象列表")]
public goods_fabric_list GoodsFabricList[] {get;set;}
/// <summary>
/// 服饰面料对应的ID，用于入参
/// </summary>
[JsonProperty("服饰面料对应的ID，用于入参")]
public int Code {get;set;}
/// <summary>
/// 对应ID下的服饰面料描述
/// </summary>
[JsonProperty("对应ID下的服饰面料描述")]
public string Desc {get;set;}
}
}

    public partial class GoodsFabricList[]ResponseModel : PddResponseModel
    {
        /// <summary>
/// 服饰面料对应的ID，用于入参
/// </summary>
[JsonProperty("服饰面料对应的ID，用于入参")]
public int Code {get;set;}
/// <summary>
/// 对应ID下的服饰面料描述
/// </summary>
[JsonProperty("对应ID下的服饰面料描述")]
public string Desc {get;set;}
}


