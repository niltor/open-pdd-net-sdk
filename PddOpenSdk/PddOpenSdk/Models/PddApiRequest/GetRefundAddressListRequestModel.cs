using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
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
