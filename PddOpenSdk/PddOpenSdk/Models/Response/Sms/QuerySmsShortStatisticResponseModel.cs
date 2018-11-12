using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Sms
{
    public partial class QuerySmsShortStatisticResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("sms_short_msg_statistic_query_response")]
        public SmsShortMsgStatisticQueryResponseResponseModel SmsShortMsgStatisticQueryResponse { get; set; }
        public partial class SmsShortMsgStatisticQueryResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// return
            /// </summary>
            [JsonProperty("setting_and_crowd_return_vo")]
            public SettingAndCrowdReturnVoResponseModel SettingAndCrowdReturnVo { get; set; }
            /// <summary>
            /// statistic_vo
            /// </summary>
            [JsonProperty("statistic_vo")]
            public StatisticVoResponseModel StatisticVo { get; set; }
            public partial class SettingAndCrowdReturnVoResponseModel : PddResponseModel
            {
                /// <summary>
                /// 人群id
                /// </summary>
                [JsonProperty("id")]
                public long? Id { get; set; }
                /// <summary>
                /// 人群名称
                /// </summary>
                [JsonProperty("name")]
                public string Name { get; set; }
                /// <summary>
                /// 人群数量
                /// </summary>
                [JsonProperty("people_num")]
                public long? PeopleNum { get; set; }
                /// <summary>
                /// 发送时间
                /// </summary>
                [JsonProperty("send_time")]
                public long? SendTime { get; set; }

            }
            public partial class StatisticVoResponseModel : PddResponseModel
            {
                /// <summary>
                /// 商家店铺id
                /// </summary>
                [JsonProperty("mall_id")]
                public long? MallId { get; set; }
                /// <summary>
                /// 批次id
                /// </summary>
                [JsonProperty("setting_id")]
                public long? SettingId { get; set; }
                /// <summary>
                /// 场景id
                /// </summary>
                [JsonProperty("scene")]
                public long? Scene { get; set; }
                /// <summary>
                /// 成功触达人数
                /// </summary>
                [JsonProperty("sms_succ_cnt_1d")]
                public long? SmsSuccCnt1D { get; set; }
                /// <summary>
                /// 进店人数
                /// </summary>
                [JsonProperty("online_mall_cnt")]
                public long? OnlineMallCnt { get; set; }
                /// <summary>
                /// 支付订单数量
                /// </summary>
                [JsonProperty("pay_mall_cnt")]
                public long? PayMallCnt { get; set; }
                /// <summary>
                /// 支付订单数
                /// </summary>
                [JsonProperty("pay_mall_amt")]
                public double? PayMallAmt { get; set; }
                /// <summary>
                /// 支付订单金额
                /// </summary>
                [JsonProperty("online_mall_rto")]
                public double? OnlineMallRto { get; set; }
                /// <summary>
                /// 进店转化率
                /// </summary>
                [JsonProperty("pay_mall_rto")]
                public double? PayMallRto { get; set; }

            }

        }

    }

}
