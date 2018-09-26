using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class Content
    {

        /// <summary>
        /// Examples: 2012, 2013
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Examples: 4210, 4211
        /// </summary>
        [JsonProperty("vid")]
        public int Vid { get; set; }

        /// <summary>
        /// Examples: "r9", "r15"
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Pageable
    {

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("page_number")]
        public int PageNumber { get; set; }

        /// <summary>
        /// Examples: 2
        /// </summary>
        [JsonProperty("page_size")]
        public int PageSize { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }
    }

    public class Values
    {

        /// <summary>
        /// Examples: [{"id":2012,"vid":4210,"value":"r9"},{"id":2013,"vid":4211,"value":"r15"}]
        /// </summary>
        [JsonProperty("content")]
        public IList<Content> Content { get; set; }

        /// <summary>
        /// Examples: 2
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// Examples: {"page_number":1,"page_size":2,"offset":0}
        /// </summary>
        [JsonProperty("pageable")]
        public Pageable Pageable { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("first_page")]
        public bool FirstPage { get; set; }

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("last_page")]
        public bool LastPage { get; set; }

        /// <summary>
        /// Examples: 2
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("number")]
        public int Number { get; set; }
    }

    public class Property
    {

        /// <summary>
        /// Examples: 1117
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Examples: "型号"
        /// </summary>
        [JsonProperty("name_alias")]
        public string NameAlias { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("name")]
        public object Name { get; set; }

        /// <summary>
        /// Examples: 108
        /// </summary>
        [JsonProperty("pid")]
        public int Pid { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("parent_pid")]
        public object ParentPid { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("control_type")]
        public int ControlType { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("value_type")]
        public int ValueType { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("value_unit")]
        public string ValueUnit { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("value_precision")]
        public int ValuePrecision { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("max_value")]
        public string MaxValue { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("min_value")]
        public string MinValue { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("top_tip")]
        public string TopTip { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("bottom_tip")]
        public string BottomTip { get; set; }

        /// <summary>
        /// Examples: 11
        /// </summary>
        [JsonProperty("sort_order")]
        public int SortOrder { get; set; }

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("required")]
        public bool Required { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("show_type")]
        public int ShowType { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("choose_max_num")]
        public int ChooseMaxNum { get; set; }

        /// <summary>
        /// Examples: 265
        /// </summary>
        [JsonProperty("ref_pid")]
        public int RefPid { get; set; }

        /// <summary>
        /// Examples: {"content":[{"id":2012,"vid":4210,"value":"r9"},{"id":2013,"vid":4211,"value":"r15"}],"total":2,"pageable":{"page_number":1,"page_size":2,"offset":0},"total_pages":1,"first_page":true,"last_page":true,"size":2,"number":1}
        /// </summary>
        [JsonProperty("values")]
        public Values Values { get; set; }

        /// <summary>
        /// Examples: []
        /// </summary>
        [JsonProperty("show_values")]
        public IList<object> ShowValues { get; set; }

        /// <summary>
        /// Examples: []
        /// </summary>
        [JsonProperty("goods_properties")]
        public IList<object> GoodsProperties { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("input_type")]
        public object InputType { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("value_format")]
        public object ValueFormat { get; set; }
    }

    public class TemplateModuleList
    {

        /// <summary>
        /// Examples: 242
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Examples: 10
        /// </summary>
        [JsonProperty("module_id")]
        public int ModuleId { get; set; }

        /// <summary>
        /// Examples: "测试模块"
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("sort_order")]
        public int SortOrder { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Examples: [{"id":1117,"name_alias":"型号","name":null,"pid":108,"parent_pid":null,"control_type":1,"value_type":0,"value_unit":"","value_precision":0,"max_value":"","min_value":"","top_tip":"","bottom_tip":"","sort_order":11,"required":true,"status":0,"show_type":1,"choose_max_num":1,"ref_pid":265,"values":{"content":[{"id":2012,"vid":4210,"value":"r9"},{"id":2013,"vid":4211,"value":"r15"}],"total":2,"pageable":{"page_number":1,"page_size":2,"offset":0},"total_pages":1,"first_page":true,"last_page":true,"size":2,"number":1},"show_values":[],"goods_properties":[],"input_type":null,"value_format":null}]
        /// </summary>
        [JsonProperty("propertys")]
        public IList<Property> Propertys { get; set; }
    }

    public class TemplateSubPropertyGetResponse
    {

        /// <summary>
        /// Examples: [{"id":242,"module_id":10,"name":"测试模块","sort_order":1,"status":0,"propertys":[{"id":1117,"name_alias":"型号","name":null,"pid":108,"parent_pid":null,"control_type":1,"value_type":0,"value_unit":"","value_precision":0,"max_value":"","min_value":"","top_tip":"","bottom_tip":"","sort_order":11,"required":true,"status":0,"show_type":1,"choose_max_num":1,"ref_pid":265,"values":{"content":[{"id":2012,"vid":4210,"value":"r9"},{"id":2013,"vid":4211,"value":"r15"}],"total":2,"pageable":{"page_number":1,"page_size":2,"offset":0},"total_pages":1,"first_page":true,"last_page":true,"size":2,"number":1},"show_values":[],"goods_properties":[],"input_type":null,"value_format":null}]}]
        /// </summary>
        [JsonProperty("template_module_list")]
        public IList<TemplateModuleList> TemplateModuleList { get; set; }
    }

    public class GetGoodsTemplateSubPropertyResponseModel
    {

        /// <summary>
        /// Examples: {"template_module_list":[{"id":242,"module_id":10,"name":"测试模块","sort_order":1,"status":0,"propertys":[{"id":1117,"name_alias":"型号","name":null,"pid":108,"parent_pid":null,"control_type":1,"value_type":0,"value_unit":"","value_precision":0,"max_value":"","min_value":"","top_tip":"","bottom_tip":"","sort_order":11,"required":true,"status":0,"show_type":1,"choose_max_num":1,"ref_pid":265,"values":{"content":[{"id":2012,"vid":4210,"value":"r9"},{"id":2013,"vid":4211,"value":"r15"}],"total":2,"pageable":{"page_number":1,"page_size":2,"offset":0},"total_pages":1,"first_page":true,"last_page":true,"size":2,"number":1},"show_values":[],"goods_properties":[],"input_type":null,"value_format":null}]}]}
        /// </summary>
        [JsonProperty("template_sub_property_get_response")]
        public TemplateSubPropertyGetResponse TemplateSubPropertyGetResponse { get; set; }
    }


}
