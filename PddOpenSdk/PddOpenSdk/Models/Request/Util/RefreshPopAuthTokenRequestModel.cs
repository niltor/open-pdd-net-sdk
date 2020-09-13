using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Util
{
public partial class RefreshPopAuthTokenRequestModel : PddRequestModel
{
/// <summary>
/// grantType==refresh_token 时需要
/// </summary>
[JsonProperty("refresh_token")]
public string RefreshToken {get;set;}

}

}
