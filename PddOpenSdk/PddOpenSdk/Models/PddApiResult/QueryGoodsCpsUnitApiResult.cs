namespace App.Models.PddApiResult
{
    
public class QueryGoodsCpsUnitApiResult
{
    public int unit_id { get; set; }
    public int goods_id { get; set; }
    public int rate { get; set; }
    public object rate_to_be { get; set; }
    public int status { get; set; }
    public object status_to_be { get; set; }
    public object coupon_vo { get; set; }
}

}
