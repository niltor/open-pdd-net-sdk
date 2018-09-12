using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class AccountsBalance
{
    public int mall_id { get; set; }
    public int account_type { get; set; }
    public int balance { get; set; }
}


public class AdBalanceGetResponse
{
    public int mall_id { get; set; }
    public int advertiser_balance { get; set; }
    public List<AccountsBalance> accounts_balance { get; set; }
}


public class GetAdBalanceApiResult
{
    public AdBalanceGetResponse ad_balance_get_response { get; set; }
}

}
