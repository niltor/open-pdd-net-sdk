namespace PddOpenSdk.Models.PddApiResult
{
    
public class FreeProvinceList
{
    public string province { get; set; }
    public int province_id { get; set; }
}


public class OneExpressCostTemplateResponse
{
    public int template_id { get; set; }
    public string template_name { get; set; }
    public int cost_type { get; set; }
    public bool free_deliver_house { get; set; }
    public int additional_service_type { get; set; }
    public int sf_free_type { get; set; }
    public List<FreeProvinceList> free_province_list { get; set; }
    public List<object> free_deliver_house_area_list { get; set; }
    public List<object> cost_template_list { get; set; }
}


public class TemplateOneExpressCostApiResult
{
    public OneExpressCostTemplateResponse one_express_cost_template_response { get; set; }
}

}
