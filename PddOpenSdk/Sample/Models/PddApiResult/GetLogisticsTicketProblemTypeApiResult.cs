using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class LogisticsProblemTypeList
{
    public int id { get; set; }
    public string type_desc { get; set; }
}


public class LogisticsProblemTypeGetResponse
{
    public List<LogisticsProblemTypeList> logistics_problem_type_list { get; set; }
}


public class GetLogisticsTicketProblemTypeApiResult
{
    public LogisticsProblemTypeGetResponse logistics_problem_type_get_response { get; set; }
}

}
