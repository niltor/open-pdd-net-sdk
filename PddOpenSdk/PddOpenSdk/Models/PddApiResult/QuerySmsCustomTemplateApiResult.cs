namespace PddOpenSdk.Models.PddApiResult
{
    
public class Content
{
    public int type { get; set; }
    public string value { get; set; }
    public object id { get; set; }
}


public class Result
{
    public int id { get; set; }
    public int mall_id { get; set; }
    public string name { get; set; }
    public long updated_time { get; set; }
    public List<Content> content { get; set; }
    public int status { get; set; }
    public object reason { get; set; }
}


public class SmsCustomTemplateListQueryResponse
{
    public int total { get; set; }
    public List<Result> result { get; set; }
}


public class QuerySmsCustomTemplateApiResult
{
    public SmsCustomTemplateListQueryResponse sms_custom_template_list_query_response { get; set; }
}

}
