using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Util
{
public partial class BatchOpenDecryptMaskRequestModel : PddRequestModel
{
/// <summary>
/// 数据列表, 默认列表大小不超过100
/// </summary>
[JsonProperty("data_list")]
public List<DataListRequestModel> DataList {get;set;}
public partial class DataListRequestModel : PddRequestModel
{
/// <summary>
/// 解密tag，对于订单数据是订单号
/// </summary>
[JsonProperty("data_tag")]
public string DataTag {get;set;}
/// <summary>
/// 密文
/// </summary>
[JsonProperty("encrypted_data")]
public string EncryptedData {get;set;}

}

}

}
