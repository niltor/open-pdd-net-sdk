namespace App.Models.PddApiResult
{
    
public class TemplatePropertyValueList
{
    public int id { get; set; }
    public int vid { get; set; }
    public string value { get; set; }
}


public class TemplateValueSearchResponse
{
    public List<TemplatePropertyValueList> template_property_value_list { get; set; }
}


public class SearchGoodsTemplateValueApiResult
{
    public TemplateValueSearchResponse template_value_search_response { get; set; }
}

}
