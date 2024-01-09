namespace PddOpenSdk.Models.Response.WayBill;
public partial class QueryCloudPrintTaskResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 
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
            /// 云打印任务结果列表
            /// </summary>
            [JsonPropertyName("cloud_print_task_result_list")]
            public List<CloudPrintTaskResultListResponse> CloudPrintTaskResultList { get; set; }
            public partial class CloudPrintTaskResultListResponse : PddResponseModel
            {

                /// <summary>
                /// 失败原因
                /// </summary>
                [JsonPropertyName("fail_reason")]
                public string FailReason { get; set; }

                /// <summary>
                /// 请求云打印时token对应的mallId
                /// </summary>
                [JsonPropertyName("mall_id")]
                public long? MallId { get; set; }

                /// <summary>
                /// 打印序号
                /// </summary>
                [JsonPropertyName("print_sequence")]
                public int? PrintSequence { get; set; }

                /// <summary>
                /// 打印状态 0:打印中 1:打印成功 2:打印失败 3:打印超时
                /// </summary>
                [JsonPropertyName("print_status")]
                public int? PrintStatus { get; set; }

                /// <summary>
                /// 打印任务id
                /// </summary>
                [JsonPropertyName("print_task_id")]
                public string PrintTaskId { get; set; }

                /// <summary>
                /// 是否推送给云打印机，只有打印失败的任务才有值，如果为true，需要重点关注是否打印完成
                /// </summary>
                [JsonPropertyName("pushed_to_printer")]
                public bool? PushedToPrinter { get; set; }

                /// <summary>
                /// 快递公司编码
                /// </summary>
                [JsonPropertyName("ship_code")]
                public string ShipCode { get; set; }

                /// <summary>
                /// 运单号
                /// </summary>
                [JsonPropertyName("waybill_code")]
                public string WaybillCode { get; set; }

            }

        }

    }

}

