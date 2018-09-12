using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class Content
{
    public int id { get; set; }
    public int vid { get; set; }
    public string value { get; set; }
}


public class Pageable
{
    public int page_number { get; set; }
    public int page_size { get; set; }
    public int offset { get; set; }
}


public class Values
{
    public List<Content> content { get; set; }
    public int total { get; set; }
    public Pageable pageable { get; set; }
    public int total_pages { get; set; }
    public bool first_page { get; set; }
    public bool last_page { get; set; }
    public int size { get; set; }
    public int number { get; set; }
}


public class Property
{
    public int id { get; set; }
    public string name_alias { get; set; }
    public object name { get; set; }
    public int pid { get; set; }
    public object parent_pid { get; set; }
    public int control_type { get; set; }
    public int value_type { get; set; }
    public string value_unit { get; set; }
    public int value_precision { get; set; }
    public string max_value { get; set; }
    public string min_value { get; set; }
    public string top_tip { get; set; }
    public string bottom_tip { get; set; }
    public int sort_order { get; set; }
    public bool required { get; set; }
    public int status { get; set; }
    public int show_type { get; set; }
    public int choose_max_num { get; set; }
    public int ref_pid { get; set; }
    public Values values { get; set; }
    public List<object> show_values { get; set; }
    public List<object> goods_properties { get; set; }
    public object input_type { get; set; }
    public object value_format { get; set; }
}


public class TemplateModuleList
{
    public int id { get; set; }
    public int module_id { get; set; }
    public string name { get; set; }
    public int sort_order { get; set; }
    public int status { get; set; }
    public List<Property> propertys { get; set; }
}


public class TemplateSubPropertyGetResponse
{
    public List<TemplateModuleList> template_module_list { get; set; }
}


public class GetGoodsTemplateSubPropertyApiResult
{
    public TemplateSubPropertyGetResponse template_sub_property_get_response { get; set; }
}

}
