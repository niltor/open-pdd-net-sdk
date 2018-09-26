using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class AccountsBalance
    {

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("mall_id")]
        public int MallId { get; set; }

        /// <summary>
        /// Examples: 1, 2
        /// </summary>
        [JsonProperty("account_type")]
        public int AccountType { get; set; }

        /// <summary>
        /// Examples: 0, 1200000
        /// </summary>
        [JsonProperty("balance")]
        public int Balance { get; set; }
    }

    public class AdBalanceGetResponse
    {

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("mall_id")]
        public int MallId { get; set; }

        /// <summary>
        /// Examples: 1200000
        /// </summary>
        [JsonProperty("advertiser_balance")]
        public int AdvertiserBalance { get; set; }

        /// <summary>
        /// Examples: [{"mall_id":1,"account_type":1,"balance":0},{"mall_id":1,"account_type":2,"balance":1200000}]
        /// </summary>
        [JsonProperty("accounts_balance")]
        public IList<AccountsBalance> AccountsBalance { get; set; }
    }

    public class GetAdBalanceResponseModel
    {

        /// <summary>
        /// Examples: {"mall_id":1,"advertiser_balance":1200000,"accounts_balance":[{"mall_id":1,"account_type":1,"balance":0},{"mall_id":1,"account_type":2,"balance":1200000}]}
        /// </summary>
        [JsonProperty("ad_balance_get_response")]
        public AdBalanceGetResponse AdBalanceGetResponse { get; set; }
    }


}
