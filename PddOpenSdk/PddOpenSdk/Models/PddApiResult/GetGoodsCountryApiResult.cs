namespace App.Models.PddApiResult
{
    
public class CountryList
{
    public int country_id { get; set; }
    public string country_name { get; set; }
}


public class GoodsCountryGetResponse
{
    public List<CountryList> country_list { get; set; }
}


public class GetGoodsCountryApiResult
{
    public GoodsCountryGetResponse goods_country_get_response { get; set; }
}

}
