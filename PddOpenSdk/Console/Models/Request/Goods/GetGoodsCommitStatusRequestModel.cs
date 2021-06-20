using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
public partial class GetGoodsCommitStatusRequestModel : PddRequestModel
{
/// <summary>
/// goods_commit_id列表
/// </summary>
[JsonProperty("goods_commit_id_list")]
public List<long> GoodsCommitIdList {get;set;}

}

}
