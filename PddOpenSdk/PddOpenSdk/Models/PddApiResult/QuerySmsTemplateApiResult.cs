namespace App.Models.PddApiResult
{
    
public class List
{
    public int code { get; set; }
    public string desc { get; set; }
}


public class SmsTemplateQueryResponse
{
    public List<List> list { get; set; }
}


public class QuerySmsTemplateApiResult
{
    public SmsTemplateQueryResponse sms_template_query_response { get; set; }
}

}
