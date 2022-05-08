namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsCatTemplateResponse : PddResponseModel
{

    /// <summary>
    /// 属性信息
    /// </summary>
    [JsonPropertyName("open_api_response")]
    public OpenApiResponseResponse OpenApiResponse { get; set; }
    public partial class OpenApiResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 限定规格不支持部分选取，为true时限定规格要么全选要么全不选
        /// </summary>
        [JsonPropertyName("choose_all_qualify_spec")]
        public bool? ChooseAllQualifySpec { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 模板允许的最大的自定义规格数量
        /// </summary>
        [JsonPropertyName("input_max_spec_num")]
        public long? InputMaxSpecNum { get; set; }

        /// <summary>
        /// is_single_item
        /// </summary>
        [JsonPropertyName("is_single_item")]
        public bool? IsSingleItem { get; set; }

        /// <summary>
        /// 最大sku数目上限
        /// </summary>
        [JsonPropertyName("max_sku_num")]
        public long? MaxSkuNum { get; set; }

        /// <summary>
        /// 属性信息
        /// </summary>
        [JsonPropertyName("properties")]
        public List<PropertiesResponse> Properties { get; set; }

        /// <summary>
        /// 单个自定义规格值上限
        /// </summary>
        [JsonPropertyName("single_spec_value_num")]
        public long? SingleSpecValueNum { get; set; }
        public partial class PropertiesResponse : PddResponseModel
        {

            /// <summary>
            /// 是否允许填写备注
            /// </summary>
            [JsonPropertyName("can_note")]
            public bool? CanNote { get; set; }

            /// <summary>
            /// 最大可勾选数目,为0时代表不限
            /// </summary>
            [JsonPropertyName("choose_max_num")]
            public int? ChooseMaxNum { get; set; }

            /// <summary>
            /// 控件类型（0-可输入、1-可勾选、3-可输入又可勾选、5-单项时间选择器-年月日、6-双项时间选择器-年月日、7-单项时间选择器-年月、8-双项时间选择器-年月）9-调色盘、10-尺码选择器、11-输入数值范围、12-输入数值乘积-2维、13-输入数值乘积-3维
            /// </summary>
            [JsonPropertyName("control_type")]
            public int? ControlType { get; set; }

            /// <summary>
            /// 属性特性:0普通，1颜色，2尺码
            /// </summary>
            [JsonPropertyName("feature")]
            public int? Feature { get; set; }

            /// <summary>
            /// 模板属性id
            /// </summary>
            [JsonPropertyName("id")]
            public long? Id { get; set; }

            /// <summary>
            /// 最大可输入数目,为0时代表不可输入，非销售属性为null
            /// </summary>
            [JsonPropertyName("input_max_num")]
            public int? InputMaxNum { get; set; }

            /// <summary>
            /// 是否按条件展示
            /// </summary>
            [JsonPropertyName("is_condition_show")]
            public bool? IsConditionShow { get; set; }

            /// <summary>
            /// is_key
            /// </summary>
            [JsonPropertyName("is_key")]
            public bool? IsKey { get; set; }

            /// <summary>
            /// 是否父属性
            /// </summary>
            [JsonPropertyName("is_parent")]
            public bool? IsParent { get; set; }

            /// <summary>
            /// 是否销售属性
            /// </summary>
            [JsonPropertyName("is_sale")]
            public bool? IsSale { get; set; }

            /// <summary>
            /// 输入最大值：文本类型代表文本最长长度、 数值类型代表数字最大值、时间类型代表时间最大值
            /// </summary>
            [JsonPropertyName("max_value")]
            public string MaxValue { get; set; }

            /// <summary>
            /// 输入最小值：文本类型代表文本最小长度、数值类型代表数字最小值、时间类型代表时间最小值
            /// </summary>
            [JsonPropertyName("min_value")]
            public string MinValue { get; set; }

            /// <summary>
            /// 属性名称
            /// </summary>
            [JsonPropertyName("name")]
            public string Name { get; set; }

            /// <summary>
            /// 属性别名
            /// </summary>
            [JsonPropertyName("name_alias")]
            public string NameAlias { get; set; }

            /// <summary>
            /// 父属性id
            /// </summary>
            [JsonPropertyName("parent_id")]
            public long? ParentId { get; set; }

            /// <summary>
            /// 引用属性id
            /// </summary>
            [JsonPropertyName("ref_pid")]
            public long? RefPid { get; set; }

            /// <summary>
            /// 是否必填
            /// </summary>
            [JsonPropertyName("required")]
            public bool? Required { get; set; }

            /// <summary>
            /// 必填规则具体内容，当required=true且required_rule_type=1时该字段有效，表示当出现哪些属性/属性值时，该属性需要必填，json格式，两层List结构，外层list代表"或"关系，内层list代表"且"关系，例如：[[{\"ref_pid\":123,\"vid\":123}]]
            /// </summary>
            [JsonPropertyName("required_rule")]
            public string RequiredRule { get; set; }

            /// <summary>
            /// required=true时，该字段有效，为“0”时表示当前属性必填，不受其他属性影响，为“1”时表示当前属性是否必填由已填写的其他属性值决定
            /// </summary>
            [JsonPropertyName("required_rule_type")]
            public int? RequiredRuleType { get; set; }

            /// <summary>
            /// show_only_standard
            /// </summary>
            [JsonPropertyName("show_only_standard")]
            public bool? ShowOnlyStandard { get; set; }

            /// <summary>
            /// 若属性按条件展示,则只有show_vids中的值被选择时属性才可使用
            /// </summary>
            [JsonPropertyName("show_vids")]
            public List<long?> ShowVids { get; set; }

            /// <summary>
            /// 销售属性规格id，非销售属性为null
            /// </summary>
            [JsonPropertyName("spec_id")]
            public long? SpecId { get; set; }

            /// <summary>
            /// 属性值列表
            /// </summary>
            [JsonPropertyName("values")]
            public List<ValuesResponse> Values { get; set; }

            /// <summary>
            /// 小数点允许最大精度,为0时代表不允许输入小数
            /// </summary>
            [JsonPropertyName("value_precision")]
            public int? ValuePrecision { get; set; }

            /// <summary>
            /// 属性值类型（0-文本、1-数值、4-绝对时间、5-相对时间）
            /// </summary>
            [JsonPropertyName("value_type")]
            public int? ValueType { get; set; }

            /// <summary>
            /// 属性值单位
            /// </summary>
            [JsonPropertyName("value_unit")]
            public string ValueUnit { get; set; }
            public partial class ValuesResponse : PddResponseModel
            {

                /// <summary>
                /// 扩展信息，颜色的话色号在这里,ARGB，非销售属性为null
                /// </summary>
                [JsonPropertyName("extend_info")]
                public string ExtendInfo { get; set; }

                /// <summary>
                /// 分组信息，非销售属性为null
                /// </summary>
                [JsonPropertyName("group")]
                public GroupResponse Group { get; set; }

                /// <summary>
                /// 是否父属性值
                /// </summary>
                [JsonPropertyName("is_parent")]
                public bool? IsParent { get; set; }

                /// <summary>
                /// 对应的父属性值id
                /// </summary>
                [JsonPropertyName("parent_vids")]
                public List<long?> ParentVids { get; set; }

                /// <summary>
                /// 规格id,非销售属性为null
                /// </summary>
                [JsonPropertyName("spec_id")]
                public long? SpecId { get; set; }

                /// <summary>
                /// 属性值
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; }

                /// <summary>
                /// 基础属性值id
                /// </summary>
                [JsonPropertyName("vid")]
                public long? Vid { get; set; }
                public partial class GroupResponse : PddResponseModel
                {

                    /// <summary>
                    /// 组id
                    /// </summary>
                    [JsonPropertyName("id")]
                    public int? Id { get; set; }

                    /// <summary>
                    /// 组名称
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string Name { get; set; }

                }

            }

        }

    }

}

