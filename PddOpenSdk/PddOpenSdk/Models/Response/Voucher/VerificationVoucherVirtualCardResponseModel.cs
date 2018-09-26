using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Voucher
{
    public class VoucherList
    {

        /// <summary>
        /// Examples: "bbb"
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// Examples: "0b5a9f5227af0797ac8002904d0e2704"
        /// </summary>
        [JsonProperty("card_code")]
        public string CardCode { get; set; }

        /// <summary>
        /// Examples: "***2"
        /// </summary>
        [JsonProperty("mark_password")]
        public string MarkPassword { get; set; }

        /// <summary>
        /// Examples: 2
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("refund_status")]
        public int RefundStatus { get; set; }

        /// <summary>
        /// Examples: 1535705009
        /// </summary>
        [JsonProperty("verification_at")]
        public int VerificationAt { get; set; }
    }

    public class VoucherVoucherInfoVerifyResponse
    {

        /// <summary>
        /// Examples: "180831-453362319373520"
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

        /// <summary>
        /// Examples: 2417903054
        /// </summary>
        [JsonProperty("goods_id")]
        public long GoodsId { get; set; }

        /// <summary>
        /// Examples: 48506631925
        /// </summary>
        [JsonProperty("sku_id")]
        public long SkuId { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("mall_id")]
        public int MallId { get; set; }

        /// <summary>
        /// Examples: [{"card_no":"bbb","card_code":"0b5a9f5227af0797ac8002904d0e2704","mark_password":"***2","status":2,"refund_status":0,"verification_at":1535705009}]
        /// </summary>
        [JsonProperty("voucher_list")]
        public IList<VoucherList> VoucherList { get; set; }
    }

    public class VerificationVoucherVirtualCardResponseModel
    {

        /// <summary>
        /// Examples: {"order_sn":"180831-453362319373520","goods_id":2417903054,"sku_id":48506631925,"mall_id":1,"voucher_list":[{"card_no":"bbb","card_code":"0b5a9f5227af0797ac8002904d0e2704","mark_password":"***2","status":2,"refund_status":0,"verification_at":1535705009}]}
        /// </summary>
        [JsonProperty("voucher_voucher_info_verify_response")]
        public VoucherVoucherInfoVerifyResponse VoucherVoucherInfoVerifyResponse { get; set; }
    }


}
