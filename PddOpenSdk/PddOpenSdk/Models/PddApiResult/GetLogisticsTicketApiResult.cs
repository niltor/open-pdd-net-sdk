namespace App.Models.PddApiResult
{
    
public class LogisticsTicketList
{
    public int status { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public int source { get; set; }
    public int duty { get; set; }
    public int ticket_id { get; set; }
    public string waybill_no { get; set; }
    public int urgent_type { get; set; }
    public int type_id { get; set; }
    public List<string> attach_url { get; set; }
    public int retreat_count { get; set; }
    public string receive_name { get; set; }
    public string receive_contact { get; set; }
    public int created_at { get; set; }
    public int updated_at { get; set; }
    public string handle_result { get; set; }
    public int express_company_id { get; set; }
    public int compensate_state { get; set; }
    public int compensate_amount { get; set; }
    public object express_attachment { get; set; }
    public int sign_state { get; set; }
    public string express_dealer { get; set; }
    public string express_dealer_contact { get; set; }
}


public class LogisticsTicketGetResponse
{
    public List<LogisticsTicketList> logistics_ticket_list { get; set; }
    public int total_count { get; set; }
}


public class GetLogisticsTicketApiResult
{
    public LogisticsTicketGetResponse logistics_ticket_get_response { get; set; }
}

}
