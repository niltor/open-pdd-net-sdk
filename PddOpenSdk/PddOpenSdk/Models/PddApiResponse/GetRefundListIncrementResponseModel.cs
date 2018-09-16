using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetRefundListIncrementResponseModel : PddResponseModel
    {
        /// <summary>
/// 售后增量订单列表对象
/// </summary>
[JsonProperty("refund_increment_get_response")]
public object RefundIncrementGetResponse {get;set;}

    public partial class RefundIncrementGetResponseResponseModel : PddResponseModel
    {
        
}

}
}
