namespace PddOpenSdk.Models.PddApiResult
{
    
public class GoodsZsUnitGenerateResponse
{
    public string url { get; set; }
    public string short_url { get; set; }
    public string mobile_url { get; set; }
    public string mobile_short_url { get; set; }
    public string multi_group_url { get; set; }
    public string multi_group_short_url { get; set; }
    public string multi_group_mobile_url { get; set; }
    public string multi_group_mobile_short_url { get; set; }
}


public class GenDdkOauthGoodsZsUnitUrlApiResult
{
    public GoodsZsUnitGenerateResponse goods_zs_unit_generate_response { get; set; }
}

}
