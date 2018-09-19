using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetDdkMallGoodsListResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回商品总数
/// </summary>
[JsonProperty("total")]
public object Total {get;set;}
/// <summary>
/// 商品信息列表，具体信息见下（注：目前仅返回商品基础信息，其余为空，凡示例中为null的目前均返回为空，获取这些字段请调用pdd.ddk.goods,detail接口）
/// </summary>
[JsonProperty("goods_list")]
public object GoodsList {get;set;}

    public partial class GoodsListResponseModel : PddResponseModel
    {
        
}

}
}
