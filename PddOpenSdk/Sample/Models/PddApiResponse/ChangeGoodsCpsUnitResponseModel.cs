using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class ChangeGoodsCpsUnitResponseModel : PddResponseModel
    {
        /// <summary>
/// 是否修改成功
/// </summary>
[JsonProperty("is_change_success")]
public bool IsChangeSuccess {get;set;}

}
}
