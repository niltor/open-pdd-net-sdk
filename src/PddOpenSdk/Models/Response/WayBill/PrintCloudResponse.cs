namespace PddOpenSdk.Models.Response.WayBill;
public partial class PrintCloudResponse : PddResponseModel
{

    /// <summary>
    /// 云打印响应
    /// </summary>
    [JsonPropertyName("cloud_print_response")]
    public CloudPrintResponseResponse CloudPrintResponse { get; set; }
    public partial class CloudPrintResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 云打印结果列表
            /// </summary>
            [JsonPropertyName("print_result_list")]
            public List<PrintResultListResponse> PrintResultList { get; set; }
            public partial class PrintResultListResponse : PddResponseModel
            {

                /// <summary>
                /// 失败原因
                /// </summary>
                [JsonPropertyName("fail_reason")]
                public string FailReason { get; set; }

                /// <summary>
                /// 序号
                /// </summary>
                [JsonPropertyName("print_sequence")]
                public long? PrintSequence { get; set; }

                /// <summary>
                /// 打印任务Id
                /// </summary>
                [JsonPropertyName("print_task_id")]
                public string PrintTaskId { get; set; }

                /// <summary>
                /// 是否打印成功
                /// </summary>
                [JsonPropertyName("result")]
                public bool? Result { get; set; }

            }

        }

    }

}

