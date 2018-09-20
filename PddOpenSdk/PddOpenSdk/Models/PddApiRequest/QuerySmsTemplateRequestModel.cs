using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class QuerySmsTemplateRequestModel : PddRequestModel
    {
        /// <summary>
/// 0, "优惠券", ; 1, "提醒付款", ; 2, "活动营销", ; 3, "召唤买家成团", ; 4, "新客转化", ; 5, "老客召回", ; 6, "流失唤醒", ; 7, "用户自定义", ; 8, "个性化营销", ; 9, "精准客户推送"
/// </summary>
[JsonProperty("scene")]
public int Scene {get;set;}

}
}
