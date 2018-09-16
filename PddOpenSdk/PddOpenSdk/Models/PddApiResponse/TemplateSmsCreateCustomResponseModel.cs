using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class TemplateSmsCreateCustomResponseModel : PddResponseModel
    {
        /// <summary>
/// 创建结果，为空成功
/// </summary>
[JsonProperty("result")]
public object Result {get;set;}

}
}
