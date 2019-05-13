using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class GetGoodsCatTemplateResponseModel : PddResponseModel
    {
        /// <summary>
        /// 属性信息
        /// </summary>
        [JsonProperty("open_api_response")]
        public OpenApiResponseResponseModel OpenApiResponse { get; set; }
        public partial class OpenApiResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 模板允许的最大的自定义规格数量
            /// </summary>
            [JsonProperty("input_max_spec_num")]
            public long? InputMaxSpecNum { get; set; }
            /// <summary>
            /// 限定规格不支持部分选取，为true时限定规格要么全选要么全不选
            /// </summary>
            [JsonProperty("choose_all_qualify_spec")]
            public bool? ChooseAllQualifySpec { get; set; }
            /// <summary>
            /// 单个自定义规格值上限
            /// </summary>
            [JsonProperty("single_spec_value_num")]
            public long? SingleSpecValueNum { get; set; }
            /// <summary>
            /// 最大sku数目上限
            /// </summary>
            [JsonProperty("max_sku_num")]
            public long? MaxSkuNum { get; set; }
            /// <summary>
            /// 属性信息
            /// </summary>
            [JsonProperty("properties")]
            public List<PropertiesResponseModel> Properties { get; set; }
            public partial class PropertiesResponseModel : PddResponseModel
            {
                /// <summary>
                /// 模板属性id
                /// </summary>
                [JsonProperty("id")]
                public long? Id { get; set; }
                /// <summary>
                /// 属性别名
                /// </summary>
                [JsonProperty("name_alias")]
                public string NameAlias { get; set; }
                /// <summary>
                /// 属性名称
                /// </summary>
                [JsonProperty("name")]
                public string Name { get; set; }
                /// <summary>
                /// 属性值单位
                /// </summary>
                [JsonProperty("value_unit")]
                public string ValueUnit { get; set; }
                /// <summary>
                /// 小数点允许最大精度,为0时代表不允许输入小数
                /// </summary>
                [JsonProperty("value_precision")]
                public int? ValuePrecision { get; set; }
                /// <summary>
                /// 输入最大值：文本类型代表文本最长长度、 数值类型代表数字最大值、时间类型代表时间最大值
                /// </summary>
                [JsonProperty("max_value")]
                public string MaxValue { get; set; }
                /// <summary>
                /// 输入最小值：文本类型代表文本最小长度、数值类型代表数字最小值、时间类型代表时间最小值
                /// </summary>
                [JsonProperty("min_value")]
                public string MinValue { get; set; }
                /// <summary>
                /// 是否必填
                /// </summary>
                [JsonProperty("required")]
                public bool? Required { get; set; }
                /// <summary>
                /// 控件类型（0-可输入、1-可勾选、3-可输入又可勾选、5-单项时间选择器-年月日、6-双项时间选择器-年月日、7-单项时间选择器-年月、8-双项时间选择器-年月）9-调色盘、10-尺码选择器、11-输入数值范围、12-输入数值乘积-2维、13-输入数值乘积-3维
                /// </summary>
                [JsonProperty("control_type")]
                public int? ControlType { get; set; }
                /// <summary>
                /// 属性值类型（0-文本、1-数值、4-绝对时间、5-相对时间）
                /// </summary>
                [JsonProperty("value_type")]
                public int? ValueType { get; set; }
                /// <summary>
                /// 最大可勾选数目,为0时代表不限
                /// </summary>
                [JsonProperty("choose_max_num")]
                public int? ChooseMaxNum { get; set; }
                /// <summary>
                /// 最大可输入数目,为0时代表不可输入，非销售属性为null
                /// </summary>
                [JsonProperty("input_max_num")]
                public int? InputMaxNum { get; set; }
                /// <summary>
                /// 父属性id
                /// </summary>
                [JsonProperty("parent_id")]
                public long? ParentId { get; set; }
                /// <summary>
                /// 是否销售属性
                /// </summary>
                [JsonProperty("is_sale")]
                public bool? IsSale { get; set; }
                /// <summary>
                /// 是否允许填写备注
                /// </summary>
                [JsonProperty("can_note")]
                public bool? CanNote { get; set; }
                /// <summary>
                /// 销售属性规格id，非销售属性为null
                /// </summary>
                [JsonProperty("spec_id")]
                public long? SpecId { get; set; }
                /// <summary>
                /// 属性特性:0普通，1颜色，2尺码
                /// </summary>
                [JsonProperty("feature")]
                public int? Feature { get; set; }
                /// <summary>
                /// 是否父属性
                /// </summary>
                [JsonProperty("is_parent")]
                public bool? IsParent { get; set; }
                /// <summary>
                /// 引用属性id
                /// </summary>
                [JsonProperty("ref_pid")]
                public long? RefPid { get; set; }
                /// <summary>
                /// 属性值列表
                /// </summary>
                [JsonProperty("values")]
                public List<ValuesResponseModel> Values { get; set; }
                /// <summary>
                /// 是否按条件展示
                /// </summary>
                [JsonProperty("is_condition_show")]
                public bool? IsConditionShow { get; set; }
                /// <summary>
                /// 若属性按条件展示,则只有show_vids中的值被选择时属性才可使用
                /// </summary>
                [JsonProperty("show_vids")]
                public List<long?> ShowVids { get; set; }
                public partial class ValuesResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 基础属性值id
                    /// </summary>
                    [JsonProperty("vid")]
                    public long? Vid { get; set; }
                    /// <summary>
                    /// 属性值
                    /// </summary>
                    [JsonProperty("value")]
                    public string Value { get; set; }
                    /// <summary>
                    /// 分组信息，非销售属性为null
                    /// </summary>
                    [JsonProperty("group")]
                    public GroupResponseModel Group { get; set; }
                    /// <summary>
                    /// 扩展信息，颜色的话色号在这里,ARGB，非销售属性为null
                    /// </summary>
                    [JsonProperty("extend_info")]
                    public string ExtendInfo { get; set; }
                    /// <summary>
                    /// 规格id,非销售属性为null
                    /// </summary>
                    [JsonProperty("spec_id")]
                    public long? SpecId { get; set; }
                    /// <summary>
                    /// 是否父属性值
                    /// </summary>
                    [JsonProperty("is_parent")]
                    public bool? IsParent { get; set; }
                    /// <summary>
                    /// 对应的父属性值id
                    /// </summary>
                    [JsonProperty("parent_vids")]
                    public List<long?> ParentVids { get; set; }
                    public partial class GroupResponseModel : PddResponseModel
                    {
                        /// <summary>
                        /// 组id
                        /// </summary>
                        [JsonProperty("id")]
                        public int? Id { get; set; }
                        /// <summary>
                        /// 组名称
                        /// </summary>
                        [JsonProperty("name")]
                        public string Name { get; set; }

                    }

                }

            }

        }

    }

}
