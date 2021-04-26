using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class UpdateDdkCashgiftStatusRequestModel : PddRequestModel
    {
        /// <summary>
        /// 多多礼金ID
        /// </summary>
        [JsonProperty("cash_gift_id")]
        public long CashGiftId { get; set; }
        /// <summary>
        /// 礼金更新类型：0-停止礼金推广，1-恢复礼金推广
        /// </summary>
        [JsonProperty("update_type")]
        public int UpdateType { get; set; }

    }

}
