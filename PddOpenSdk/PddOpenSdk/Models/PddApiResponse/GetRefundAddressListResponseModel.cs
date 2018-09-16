using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetRefundAddressListResponseModel : PddResponseModel
    {
        /// <summary>
/// 退货地址列表
/// </summary>
[JsonProperty("refund_address_list")]
public object RefundAddressList {get;set;}

    public partial class RefundAddressListResponseModel : PddResponseModel
    {
        
}

}
}
