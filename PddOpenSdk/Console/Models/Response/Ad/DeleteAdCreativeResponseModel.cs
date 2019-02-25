using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
{
public partial class DeleteAdCreativeResponseModel : PddResponseModel
{
/// <summary>
/// true or false
/// </summary>
[JsonProperty("open_api_response")]
public bool? OpenApiResponse {get;set;}

}

}
