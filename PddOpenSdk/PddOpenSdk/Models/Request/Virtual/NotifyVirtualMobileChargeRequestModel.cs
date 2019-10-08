using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Virtual
{
    public partial class NotifyVirtualMobileChargeRequestModel : PddRequestModel
    {
        /// <summary>
        /// 加油卡业务对象数组
        /// </summary>
        [JsonProperty("charge_certi")]
        public List<ChargeCertiRequestModel> ChargeCerti { get; set; }
        /// <summary>
        /// 拼多多订单编码
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }
        /// <summary>
        /// 11122dafa 外部系统订单编码
        /// </summary>
        [JsonProperty("outer_order_sn")]
        public string OuterOrderSn { get; set; }
        /// <summary>
        /// 虚拟系统充值结果，SUCCESS-充值成功，FAIL-充值失败
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
        public partial class ChargeCertiRequestModel : PddRequestModel
        {
            /// <summary>
            /// 中石化充值金额(单位：分，默认0
            /// </summary>
            [JsonProperty("charge_certi_amount")]
            public int? ChargeCertiAmount { get; set; }
            /// <summary>
            /// 中石化充值成功时间 （yyyy-MM-dd HH:mm:ss格式）
            /// </summary>
            [JsonProperty("charge_certi_date")]
            public string ChargeCertiDate { get; set; }
            /// <summary>
            /// 中石化充值卡号尾号（最大64字符）
            /// </summary>
            [JsonProperty("charge_certi_mobile_tail")]
            public string ChargeCertiMobileTail { get; set; }
            /// <summary>
            /// 中石化充值单号（最大1024字符）
            /// </summary>
            [JsonProperty("charge_certi_order_sn")]
            public string ChargeCertiOrderSn { get; set; }
            /// <summary>
            /// 中石化短信原文(最大1024字符)
            /// </summary>
            [JsonProperty("charge_certi_text")]
            public string ChargeCertiText { get; set; }

        }

    }

}
