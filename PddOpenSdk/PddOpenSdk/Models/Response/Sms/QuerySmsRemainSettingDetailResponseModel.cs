using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Sms
{
    public class TriggerCondition
    {

        /// <summary>
        /// Examples: 30
        /// </summary>
        [JsonProperty("unpaid_duration")]
        public int UnpaidDuration { get; set; }
    }

    public class Target
    {

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("min_pay_amount")]
        public object MinPayAmount { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("max_pay_amount")]
        public object MaxPayAmount { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("pay_amount_limit")]
        public object PayAmountLimit { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("region_type")]
        public object RegionType { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("region")]
        public object Region { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("goods")]
        public object Goods { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("goods_invert")]
        public object GoodsInvert { get; set; }
    }

    public class SmsRemainSettingResult
    {

        /// <summary>
        /// Examples: 26218
        /// </summary>
        [JsonProperty("mall_id")]
        public int MallId { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("scene")]
        public int Scene { get; set; }

        /// <summary>
        /// Examples: {"unpaid_duration":30}
        /// </summary>
        [JsonProperty("trigger_condition")]
        public TriggerCondition TriggerCondition { get; set; }

        /// <summary>
        /// Examples: {"min_pay_amount":null,"max_pay_amount":null,"pay_amount_limit":null,"region_type":null,"region":null,"goods":null,"goods_invert":null}
        /// </summary>
        [JsonProperty("target")]
        public Target Target { get; set; }

        /// <summary>
        /// Examples: 50
        /// </summary>
        [JsonProperty("template_id")]
        public int TemplateId { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("open")]
        public int Open { get; set; }

        /// <summary>
        /// Examples: 214
        /// </summary>
        [JsonProperty("send_num")]
        public int SendNum { get; set; }

        /// <summary>
        /// Examples: 135
        /// </summary>
        [JsonProperty("send_failed_num")]
        public int SendFailedNum { get; set; }
    }

    public class SmsRemainSettingDetailQueryResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// Examples: 1000000
        /// </summary>
        [JsonProperty("error_code")]
        public int ErrorCode { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("error_msg")]
        public object ErrorMsg { get; set; }

        /// <summary>
        /// Examples: {"mall_id":26218,"scene":1,"trigger_condition":{"unpaid_duration":30},"target":{"min_pay_amount":null,"max_pay_amount":null,"pay_amount_limit":null,"region_type":null,"region":null,"goods":null,"goods_invert":null},"template_id":50,"open":1,"send_num":214,"send_failed_num":135}
        /// </summary>
        [JsonProperty("result")]
        public SmsRemainSettingResult Result { get; set; }
    }

    public class QuerySmsRemainSettingDetailResponseModel
    {

        /// <summary>
        /// Examples: {"success":true,"error_code":1000000,"error_msg":null,"result":{"mall_id":26218,"scene":1,"trigger_condition":{"unpaid_duration":30},"target":{"min_pay_amount":null,"max_pay_amount":null,"pay_amount_limit":null,"region_type":null,"region":null,"goods":null,"goods_invert":null},"template_id":50,"open":1,"send_num":214,"send_failed_num":135}}
        /// </summary>
        [JsonProperty("sms_remain_setting_detail_query_response")]
        public SmsRemainSettingDetailQueryResponse SmsRemainSettingDetailQueryResponse { get; set; }
    }


}
