using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetGoodsTemplateSubPropertyResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("template_sub_property_get_response")]
        public TemplateSubPropertyGetResponseResponseModel TemplateSubPropertyGetResponse { get; set; }

        public partial class TemplateSubPropertyGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 模板属性列表
            /// </summary>
            [JsonProperty("template_module_list")]
            public TemplateModuleListResponseModel TemplateModuleList { get; set; }

            public partial class TemplateModuleListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 模板模块id
                /// </summary>
                [JsonProperty("id")]
                public int Id { get; set; }
                /// <summary>
                /// 属性
                /// </summary>
                [JsonProperty("propertys")]
                public PropertysResponseModel Propertys { get; set; }

                public partial class PropertysResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 属性值可填最小范围
                    /// </summary>
                    [JsonProperty("min_value")]
                    public int MinValue { get; set; }
                    /// <summary>
                    /// 属性值可填最大范围
                    /// </summary>
                    [JsonProperty("max_value")]
                    public int MaxValue { get; set; }
                    /// <summary>
                    /// control_type=1、3时校验选择数目是否超过最大值
                    /// </summary>
                    [JsonProperty("choose_max_num")]
                    public int ChooseMaxNum { get; set; }
                    /// <summary>
                    /// 值输入类型（0-文本、1-数值、4-绝对时间、5-相对时间）
                    /// </summary>
                    [JsonProperty("value_type")]
                    public int ValueType { get; set; }
                    /// <summary>
                    /// 控件类型（0-可输入、1-可勾选、3-可输入又可勾选、5-单项时间选择器-年月日、6-双项时间选择器-年月日、7-单项时间选择器-年月、8-双项时间选择器-年月）
                    /// </summary>
                    [JsonProperty("control_type")]
                    public int ControlType { get; set; }
                    /// <summary>
                    /// 属性名称
                    /// </summary>
                    [JsonProperty("name_alias")]
                    public string NameAlias { get; set; }
                    /// <summary>
                    /// 是否必填true/false
                    /// </summary>
                    [JsonProperty("required")]
                    public bool Required { get; set; }
                    /// <summary>
                    /// 模板属性id
                    /// </summary>
                    [JsonProperty("id")]
                    public int Id { get; set; }
                    /// <summary>
                    /// 属性id
                    /// </summary>
                    [JsonProperty("pid")]
                    public int Pid { get; set; }
                    /// <summary>
                    /// 属性单位
                    /// </summary>
                    [JsonProperty("value_unit")]
                    public string ValueUnit { get; set; }
                    /// <summary>
                    /// 属性值
                    /// </summary>
                    [JsonProperty("values")]
                    public ValuesResponseModel Values { get; set; }

                    public partial class ValuesResponseModel : PddResponseModel
                    {
                        /// <summary>
                        /// 内容
                        /// </summary>
                        [JsonProperty("content")]
                        public ContentResponseModel Content { get; set; }

                        public partial class ContentResponseModel : PddResponseModel
                        {
                            /// <summary>
                            /// id
                            /// </summary>
                            [JsonProperty("id")]
                            public int Id { get; set; }
                            /// <summary>
                            /// 属性值id
                            /// </summary>
                            [JsonProperty("vid")]
                            public int Vid { get; set; }
                            /// <summary>
                            /// 属性值
                            /// </summary>
                            [JsonProperty("value")]
                            public string Value { get; set; }

                        }

                    }

                }

            }

        }

    }
}
