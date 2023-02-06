namespace PddOpenSdk.Models.Request.WayBill;
public partial class QueryCloudPrintTask
{

    /// <summary>
    /// 云打印任务查询请求
    /// </summary>
    [JsonPropertyName("cloud_print_task_query")]
    public CloudPrintTaskQueryModel CloudPrintTaskQuery { get; set; }
    public partial class CloudPrintTaskQueryModel
    {

        /// <summary>
        /// 打印序号，非必填，填了则只查询列表内的任务
        /// </summary>
        [JsonPropertyName("print_sequence_list")]
        public List<int?> PrintSequenceList { get; set; }

        /// <summary>
        /// 打印任务id
        /// </summary>
        [JsonPropertyName("print_task_id")]
        public string PrintTaskId { get; set; }

        /// <summary>
        /// 打印机id
        /// </summary>
        [JsonPropertyName("printer_id")]
        public string PrinterId { get; set; }

        /// <summary>
        /// 共享码
        /// </summary>
        [JsonPropertyName("share_code")]
        public string ShareCode { get; set; }

    }

}

