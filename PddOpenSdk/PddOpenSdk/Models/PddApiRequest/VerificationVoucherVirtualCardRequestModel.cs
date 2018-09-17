using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class VerificationVoucherVirtualCardRequestModel : PddRequestModel
    {
        /// <summary>
        /// 拼多多订单号
        /// </summary>
        [JsonProperty("order_sn")]
        public object OrderSn { get; set; }
        /// <summary>
        /// 券信息列表
        /// </summary>
        [JsonProperty("voucher_data_list")]
        public object VoucherDataList { get; set; }

        public partial class VoucherDataListRequestModel : PddRequestModel
        {

        }

    }
}
