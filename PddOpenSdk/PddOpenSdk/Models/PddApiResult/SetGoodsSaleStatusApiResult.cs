namespace App.Models.PddApiResult
{
    
public class GoodsSaleStatusSetResponse
{
    public bool is_success { get; set; }
}


public class SetGoodsSaleStatusApiResult
{
    public GoodsSaleStatusSetResponse goods_sale_status_set_response { get; set; }
}

}
