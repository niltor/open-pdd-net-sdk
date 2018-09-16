using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class GetRefundAddressListRequestModel : PddRequestModel
    {
        /// <summary>
/// 该值为：pdd.refund.address.list.get
/// </summary>
[JsonProperty("type")]
public object Type {get;set;}

}
}
