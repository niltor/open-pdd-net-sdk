namespace App.Models.PddApiResult
{
    
public class SmsCrowsPeopleNumberQueryResponse
{
    public int remain { get; set; }
    public int object_num { get; set; }
}


public class QuerySmsCrowdsPeopleNumberApiResult
{
    public SmsCrowsPeopleNumberQueryResponse sms_crows_people_number_query_response { get; set; }
}

}
