using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Finance
{
public partial class GetFinanceBalanceDailyBillUrlResponseModel : PddResponseModel
{
/// <summary>
/// response
/// </summary>
[JsonProperty("finance_balance_daily_bill_url_get_response")]
public FinanceBalanceDailyBillUrlGetResponseResponseModel FinanceBalanceDailyBillUrlGetResponse {get;set;}
public partial class FinanceBalanceDailyBillUrlGetResponseResponseModel : PddResponseModel
{
/// <summary>
/// 货款账单下载 URL
/// </summary>
[JsonProperty("download_url")]
public string DownloadUrl {get;set;}

}

}

}
