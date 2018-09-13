using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GetAdBalanceResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("ad_balance_get_response")]
public object AdBalanceGetResponse {get;set;}
/// <summary>
/// 账户列表
/// </summary>
[JsonProperty("accounts_balance")]
public object AccountsBalance {get;set;}
/// <summary>
/// 总余额，单位厘
/// </summary>
[JsonProperty("advertiser_balance")]
public int AdvertiserBalance {get;set;}
/// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public int MallId {get;set;}
/// <summary>
/// 1 - 现金 2 - 红包
/// </summary>
[JsonProperty("account_type")]
public int AccountType {get;set;}
/// <summary>
/// 余额
/// </summary>
[JsonProperty("balance")]
public object Balance {get;set;}
/// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public int MallId {get;set;}

    public partial class AdBalanceGetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 账户列表
/// </summary>
[JsonProperty("accounts_balance")]
public object AccountsBalance {get;set;}
/// <summary>
/// 总余额，单位厘
/// </summary>
[JsonProperty("advertiser_balance")]
public int AdvertiserBalance {get;set;}
/// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public int MallId {get;set;}

}

    public partial class AccountsBalanceResponseModel : PddResponseModel
    {
        /// <summary>
/// 1 - 现金 2 - 红包
/// </summary>
[JsonProperty("account_type")]
public int AccountType {get;set;}
/// <summary>
/// 余额
/// </summary>
[JsonProperty("balance")]
public object Balance {get;set;}
/// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public int MallId {get;set;}

}

}
}
