using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Logisticscs
{
    public class LogisticsTicketList
    {

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Examples: "催件/延误"
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Examples: "test001"
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("source")]
        public int Source { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("duty")]
        public int Duty { get; set; }

        /// <summary>
        /// Examples: 6371869
        /// </summary>
        [JsonProperty("ticket_id")]
        public int TicketId { get; set; }

        /// <summary>
        /// Examples: "490852672110"
        /// </summary>
        [JsonProperty("waybill_no")]
        public string WaybillNo { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("urgent_type")]
        public int UrgentType { get; set; }

        /// <summary>
        /// Examples: 334
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; set; }

        /// <summary>
        /// Examples: ["http://imgt.pinduoduo.com/pdd_ticket_image/2018-05-03/2abc157042fafce2db59f42b8d532b01.jpeg"]
        /// </summary>
        [JsonProperty("attach_url")]
        public IList<string> AttachUrl { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("retreat_count")]
        public int RetreatCount { get; set; }

        /// <summary>
        /// Examples: "test001"
        /// </summary>
        [JsonProperty("receive_name")]
        public string ReceiveName { get; set; }

        /// <summary>
        /// Examples: "test001"
        /// </summary>
        [JsonProperty("receive_contact")]
        public string ReceiveContact { get; set; }

        /// <summary>
        /// Examples: 1525354853
        /// </summary>
        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        /// <summary>
        /// Examples: 1525354886
        /// </summary>
        [JsonProperty("updated_at")]
        public int UpdatedAt { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("handle_result")]
        public string HandleResult { get; set; }

        /// <summary>
        /// Examples: 115
        /// </summary>
        [JsonProperty("express_company_id")]
        public int ExpressCompanyId { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("compensate_state")]
        public int CompensateState { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("compensate_amount")]
        public int CompensateAmount { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("express_attachment")]
        public object ExpressAttachment { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("sign_state")]
        public int SignState { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("express_dealer")]
        public string ExpressDealer { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("express_dealer_contact")]
        public string ExpressDealerContact { get; set; }
    }

    public class LogisticsTicketGetResponse
    {

        /// <summary>
        /// Examples: [{"status":0,"title":"催件/延误","description":"test001","source":0,"duty":0,"ticket_id":6371869,"waybill_no":"490852672110","urgent_type":1,"type_id":334,"attach_url":["http://imgt.pinduoduo.com/pdd_ticket_image/2018-05-03/2abc157042fafce2db59f42b8d532b01.jpeg"],"retreat_count":0,"receive_name":"test001","receive_contact":"test001","created_at":1525354853,"updated_at":1525354886,"handle_result":"","express_company_id":115,"compensate_state":0,"compensate_amount":0,"express_attachment":null,"sign_state":0,"express_dealer":"","express_dealer_contact":""}]
        /// </summary>
        [JsonProperty("logistics_ticket_list")]
        public IList<LogisticsTicketList> LogisticsTicketList { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class GetLogisticsTicketResponseModel
    {

        /// <summary>
        /// Examples: {"logistics_ticket_list":[{"status":0,"title":"催件/延误","description":"test001","source":0,"duty":0,"ticket_id":6371869,"waybill_no":"490852672110","urgent_type":1,"type_id":334,"attach_url":["http://imgt.pinduoduo.com/pdd_ticket_image/2018-05-03/2abc157042fafce2db59f42b8d532b01.jpeg"],"retreat_count":0,"receive_name":"test001","receive_contact":"test001","created_at":1525354853,"updated_at":1525354886,"handle_result":"","express_company_id":115,"compensate_state":0,"compensate_amount":0,"express_attachment":null,"sign_state":0,"express_dealer":"","express_dealer_contact":""}],"total_count":1}
        /// </summary>
        [JsonProperty("logistics_ticket_get_response")]
        public LogisticsTicketGetResponse LogisticsTicketGetResponse { get; set; }
    }


}
