namespace PddOpenSdk.Models.Response.Voucher;
public partial class VerificationVoucherOtaCardPrepareResponse : PddResponseModel
{

    /// <summary>
    /// 响应体
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("errorMsg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 卡密和订单信息
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 卡券信息
            /// </summary>
            [JsonPropertyName("card_vo")]
            public CardVoResponse CardVo { get; set; }

            /// <summary>
            /// 商品信息
            /// </summary>
            [JsonPropertyName("order_goods_vo")]
            public OrderGoodsVoResponse OrderGoodsVo { get; set; }

            /// <summary>
            /// 订单信息
            /// </summary>
            [JsonPropertyName("order_vo")]
            public OrderVoResponse OrderVo { get; set; }
            public partial class CardVoResponse : PddResponseModel
            {

                /// <summary>
                /// 卡券有效期结束时间，单位秒
                /// </summary>
                [JsonPropertyName("available_end_time")]
                public long? AvailableEndTime { get; set; }

                /// <summary>
                /// 卡券有效期开始时间，单位秒
                /// </summary>
                [JsonPropertyName("available_start_time")]
                public long? AvailableStartTime { get; set; }

                /// <summary>
                /// 打码卡密
                /// </summary>
                [JsonPropertyName("mask_card_no")]
                public string MaskCardNo { get; set; }

                /// <summary>
                /// 剩余可用次数
                /// </summary>
                [JsonPropertyName("remain_times")]
                public int? RemainTimes { get; set; }

                /// <summary>
                /// 券状态码。1-未核销，2-已核销， 3-已过期，4-已销毁
                /// </summary>
                [JsonPropertyName("status")]
                public int? Status { get; set; }

                /// <summary>
                /// 状态文案
                /// </summary>
                [JsonPropertyName("status_tips")]
                public string StatusTips { get; set; }

                /// <summary>
                /// 总次数
                /// </summary>
                [JsonPropertyName("total_times")]
                public int? TotalTimes { get; set; }

            }
            public partial class OrderGoodsVoResponse : PddResponseModel
            {

                /// <summary>
                /// 商品标题
                /// </summary>
                [JsonPropertyName("goods_name")]
                public string GoodsName { get; set; }

                /// <summary>
                /// 购买商品数
                /// </summary>
                [JsonPropertyName("goods_number")]
                public int? GoodsNumber { get; set; }

                /// <summary>
                /// 外部商品编码
                /// </summary>
                [JsonPropertyName("out_goods_sn")]
                public string OutGoodsSn { get; set; }

                /// <summary>
                /// 外部sku编码
                /// </summary>
                [JsonPropertyName("out_sku_sn")]
                public string OutSkuSn { get; set; }

                /// <summary>
                /// 规格
                /// </summary>
                [JsonPropertyName("spec")]
                public string Spec { get; set; }

            }
            public partial class OrderVoResponse : PddResponseModel
            {

                /// <summary>
                /// 用户实付金额
                /// </summary>
                [JsonPropertyName("order_amount_fen")]
                public long? OrderAmountFen { get; set; }

                /// <summary>
                /// 订单编号
                /// </summary>
                [JsonPropertyName("order_sn")]
                public string OrderSn { get; set; }

            }

        }

    }

}

