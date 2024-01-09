namespace PddOpenSdk.Models.Request.LogisticsCompany;
public partial class NotifyLogisticsTicket
{

    /// <summary>
    /// 附件url,示例：["http://testimg.yangkeduo.com/pdd_oms/2018-01-16/411068e948835ae053a86c13f8ebb5ee.jpg"]
    /// </summary>
    [JsonPropertyName("attach_path_list")]
    public List<string> AttachPathList { get; set; }

    /// <summary>
    /// 赔付金额(单位:分)
    /// </summary>
    [JsonPropertyName("compensate_amount")]
    public long CompensateAmount { get; set; }

    /// <summary>
    /// 是否赔付，0:默认,1:未赔付,2:已赔付
    /// </summary>
    [JsonPropertyName("compensate_state")]
    public int CompensateState { get; set; }

    /// <summary>
    /// 责任方，0:默认, 1:消费者,2:商家,3:快递公司,4:其他
    /// </summary>
    [JsonPropertyName("duty")]
    public int? Duty { get; set; }

    /// <summary>
    /// 处理人
    /// </summary>
    [JsonPropertyName("express_dealer")]
    public string ExpressDealer { get; set; }

    /// <summary>
    /// 处理人联系方式
    /// </summary>
    [JsonPropertyName("express_dealer_contact")]
    public string ExpressDealerContact { get; set; }

    /// <summary>
    /// 处理结果
    /// </summary>
    [JsonPropertyName("handle_result")]
    public string HandleResult { get; set; }

    /// <summary>
    /// 电联结果，当reply_type=2时，为必填项，同时该字段的值为一个json格式的字符串，格式参考示例 示例：{"call_result":1,"call_timestamp":"1688283125000","caller_name":"小张","caller_contract":"15067188888"} call_result:电联结果（int,必填） 取值如下：1：停机/空号、2：电话占线、3：无人接听、4：接通后非本人、5：接通但反馈没投诉过 call_timestamp:电联时间戳（long ,必填） caller_name:回拨人姓名（String,必填） caller_contract:回拨联系方式（String,必填）
    /// </summary>
    [JsonPropertyName("reply_call_result")]
    public string ReplyCallResult { get; set; }

    /// <summary>
    /// 回复类型，1:回复工单处理结果，2:回复电联结果，当为空时，默认赋值1
    /// </summary>
    [JsonPropertyName("reply_type")]
    public int? ReplyType { get; set; }

    /// <summary>
    /// 签收状态，0:默认,1:未签收,2:已签收
    /// </summary>
    [JsonPropertyName("sign_state")]
    public int SignState { get; set; }

    /// <summary>
    /// 工单id
    /// </summary>
    [JsonPropertyName("ticket_id")]
    public long TicketId { get; set; }

    /// <summary>
    /// 运单号
    /// </summary>
    [JsonPropertyName("waybill_no")]
    public string WaybillNo { get; set; }

}

