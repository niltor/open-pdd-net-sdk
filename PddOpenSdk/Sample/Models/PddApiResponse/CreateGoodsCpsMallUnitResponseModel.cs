using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class CreateGoodsCpsMallUnitResponseModel : PddResponseModel
    {
        /// <summary>
/// 是否设置成功
/// </summary>
[JsonProperty("is_create_success")]
public bool IsCreateSuccess {get;set;}

}
}
