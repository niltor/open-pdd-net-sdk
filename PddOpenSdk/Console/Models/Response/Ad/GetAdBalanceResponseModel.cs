using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
{
public partial class GetAdBalanceResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("ad_balance_get_response")]
public AdBalanceGetResponseResponseModel AdBalanceGetResponse {get;set;}
public partial class AdBalanceGetResponseResponseModel : PddResponseModel
{
/// <summary>
/// 账户列表
/// </summary>
[JsonProperty("accounts_balance")]
public List<AccountsBalanceResponseModel> AccountsBalance {get;set;}
/// <summary>
/// 总余额，单位厘
/// </summary>
[JsonProperty("advertiser_balance")]
public long? AdvertiserBalance {get;set;}
/// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public long? MallId {get;set;}
public partial class AccountsBalanceResponseModel : PddResponseModel
{
/// <summary>
/// 1 - 现金 2 - 红包
/// </summary>
[JsonProperty("account_type")]
public int? AccountType {get;set;}
/// <summary>
/// 余额
/// </summary>
[JsonProperty("balance")]
public long? Balance {get;set;}
/// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public long? MallId {get;set;}
/// <summary>
/// 可消费余额
/// </summary>
[JsonProperty("spendable_balance")]
public long? SpendableBalance {get;set;}

}

}

}

}
