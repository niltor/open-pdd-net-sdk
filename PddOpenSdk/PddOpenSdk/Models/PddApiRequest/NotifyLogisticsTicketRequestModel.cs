using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class NotifyLogisticsTicketRequestModel : PddRequestModel
    {
        /// <summary>
/// 附件url,示例：["http://testimg.yangkeduo.com/pdd_oms/2018-01-16/411068e948835ae053a86c13f8ebb5ee.jpg"]
/// </summary>
[JsonProperty("attach_path_list")]
public object AttachPathList {get;set;}
/// <summary>
/// 工单id
/// </summary>
[JsonProperty("ticket_id")]
public int TicketId {get;set;}
/// <summary>
/// 运单号
/// </summary>
[JsonProperty("waybill_no")]
public object WaybillNo {get;set;}
/// <summary>
/// 处理结果
/// </summary>
[JsonProperty("handle_result")]
public object HandleResult {get;set;}
/// <summary>
/// 签收状态，0:默认,1:未签收,2:已签收
/// </summary>
[JsonProperty("sign_state")]
public int SignState {get;set;}
/// <summary>
/// 是否赔付，0:默认,1:未赔付,2:已赔付
/// </summary>
[JsonProperty("compensate_state")]
public int CompensateState {get;set;}
/// <summary>
/// 赔付金额(单位:分)
/// </summary>
[JsonProperty("compensate_amount")]
public int CompensateAmount {get;set;}
/// <summary>
/// 责任方，0:默认, 1:消费者,2:商家,3:快递公司,4:其他
/// </summary>
[JsonProperty("duty")]
public int? Duty {get;set;}
/// <summary>
/// 处理人
/// </summary>
[JsonProperty("express_dealer")]
public object ExpressDealer {get;set;}
/// <summary>
/// 处理人联系方式
/// </summary>
[JsonProperty("express_dealer_contact")]
public object ExpressDealerContact {get;set;}

}
}
