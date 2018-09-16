using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetLogisticsAddressResponseModel : PddResponseModel
    {
        /// <summary>
/// 地址对象列表
/// </summary>
[JsonProperty("address_list")]
public object AddressList {get;set;}

    public partial class AddressListResponseModel : PddResponseModel
    {
        
}

}
}
