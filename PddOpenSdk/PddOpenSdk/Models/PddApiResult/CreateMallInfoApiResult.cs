namespace PddOpenSdk.Models.PddApiResult
{
    
public class MallInfoCreateResponse
{
    public bool success { get; set; }
    public string access_token { get; set; }
    public int mall_id { get; set; }
}


public class CreateMallInfoApiResult
{
    public MallInfoCreateResponse mall_info_create_response { get; set; }
}

}
