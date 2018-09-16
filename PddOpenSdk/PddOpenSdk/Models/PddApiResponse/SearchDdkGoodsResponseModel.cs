using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class SearchDdkGoodsResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回商品总数
/// </summary>
[JsonProperty("total_count")]
public object TotalCount {get;set;}
/// <summary>
/// 多多进宝商品对象列表
/// </summary>
[JsonProperty("duoduojinbao_goods_list")]
public object DuoduojinbaoGoodsList {get;set;}
/// <summary>
/// 该商品所在店铺是否参与全店推广，0：否，1：是
/// </summary>
[JsonProperty("mall_cps")]
public int MallCps {get;set;}

    public partial class DuoduojinbaoGoodsListResponseModel : PddResponseModel
    {
        
}

}
}
