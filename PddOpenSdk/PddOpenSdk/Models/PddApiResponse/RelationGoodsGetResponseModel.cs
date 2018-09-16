using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class RelationGoodsGetResponseModel : PddResponseModel
    {
        /// <summary>
/// 映射关系查询返回对象列表
/// </summary>
[JsonProperty("query_goods_relation_response")]
public object QueryGoodsRelationResponse {get;set;}

    public partial class QueryGoodsRelationResponseResponseModel : PddResponseModel
    {
        
}

}
}
