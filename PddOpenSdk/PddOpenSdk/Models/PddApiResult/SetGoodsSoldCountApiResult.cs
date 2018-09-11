namespace PddOpenSdk.Models.PddApiResult
{
    
public class GoodsSoldCountSetResponse
{
    public string serial_number { get; set; }
}


public class SetGoodsSoldCountApiResult
{
    public GoodsSoldCountSetResponse goods_sold_count_set_response { get; set; }
}

}
