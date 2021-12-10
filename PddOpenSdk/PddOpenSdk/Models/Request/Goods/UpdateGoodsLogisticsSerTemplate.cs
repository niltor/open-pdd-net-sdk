namespace PddOpenSdk.Models.Request.Goods;
public partial class UpdateGoodsLogisticsSerTemplate
{

    /// <summary>
    /// 分类目基础价格配置,入参为string，[{ "cat_id4": 1, "cat_id3": 2, "list": [{ "limit_type": 1, "value": 1, "content": [{ "price": 1, "max_pro": 1, "min_pro": 1 }] }] }]
    /// </summary>
    [JsonPropertyName("cat_list")]
    public List<CatListModel> CatList { get; set; }

    /// <summary>
    /// 分地区配置溢价时使用的计价单位：0：价格分，按价格分计算费用；1：百分比，按照基础价格乘以百分比计算费用，除了"买家自提"服务，其他服务类型必传
    /// </summary>
    [JsonPropertyName("price_unit")]
    public int? PriceUnit { get; set; }

    /// <summary>
    /// 服务地区范围配置，此入参为string,[{ "value": 1, "district_id": 2, "city_id": 2, "province_id": 2 }]
    /// </summary>
    [JsonPropertyName("service_area_list")]
    public List<ServiceAreaListModel> ServiceAreaList { get; set; }

    /// <summary>
    /// 模版id
    /// </summary>
    [JsonPropertyName("template_id")]
    public string TemplateId { get; set; }

    /// <summary>
    /// 服务模板名称（不超过50字）
    /// </summary>
    [JsonPropertyName("template_name")]
    public string TemplateName { get; set; }

    /// <summary>
    /// 服务模板类型：2：送货上门 3：送货上门并安装 4：上门安装 5： 买家自提
    /// </summary>
    [JsonPropertyName("template_type")]
    public int TemplateType { get; set; }
    public partial class CatListModel
    {

        /// <summary>
        /// 三级类目id
        /// </summary>
        [JsonPropertyName("cat_id3")]
        public long CatId3 { get; set; }

        /// <summary>
        /// 四级类目id
        /// </summary>
        [JsonPropertyName("cat_id4")]
        public long? CatId4 { get; set; }

        /// <summary>
        /// 类目规则配置
        /// </summary>
        [JsonPropertyName("list")]
        public List<ListModel> List { get; set; }
        public partial class ListModel
        {

            /// <summary>
            /// 按属性收取费用时配置的内容：按属性限价时设置；按件限价时不用传，value和content必须设置一个
            /// </summary>
            [JsonPropertyName("content")]
            public List<ContentModel> Content { get; set; }

            /// <summary>
            /// 分类目收取服务费用方式：1-按件收取费用，2-按属性收取费用
            /// </summary>
            [JsonPropertyName("limit_type")]
            public int LimitType { get; set; }

            /// <summary>
            /// 按“件”收取费用时配置的内容：按件限价时输入数字，表示每件商品附加费用$value分；按属性限价时不用传value和content必须设置一个
            /// </summary>
            [JsonPropertyName("value")]
            public long? Value { get; set; }
            public partial class ContentModel
            {

                /// <summary>
                /// 属性区间大值，-1表示"其他"示例：要配置区间"100-200"的费用，则maxPro输入"200"要配置区间"其他"的费用，则maxPro输入"-1"备注：表示长度时单位为：mm
                /// </summary>
                [JsonPropertyName("max_pro")]
                public long MaxPro { get; set; }

                /// <summary>
                /// 属性区间小值，-1表示"其他"示例：要配置区间"100-200"的费用，则minPro输入"100"要配置区间"其他"的费用，则minPro输入"-1"备注：表示长度时单位为：mm
                /// </summary>
                [JsonPropertyName("min_pro")]
                public long MinPro { get; set; }

                /// <summary>
                /// 价格。单位：分
                /// </summary>
                [JsonPropertyName("price")]
                public long Price { get; set; }

            }

        }

    }
    public partial class ServiceAreaListModel
    {

        /// <summary>
        /// 市id，如果是全省选中，则市id为0
        /// </summary>
        [JsonPropertyName("city_id")]
        public int CityId { get; set; }

        /// <summary>
        /// 区id，如果是全省或全市选中，则区id为0
        /// </summary>
        [JsonPropertyName("district_id")]
        public int DistrictId { get; set; }

        /// <summary>
        /// 省id
        /// </summary>
        [JsonPropertyName("province_id")]
        public int ProvinceId { get; set; }

        /// <summary>
        /// 溢价值：按分溢价时，输入价格分的数字，表示value分；按百分比溢价时，输入0-500之间的数字，表示0%——500%备注：买家自提服务类型时，不用传该字段
        /// </summary>
        [JsonPropertyName("value")]
        public int? Value { get; set; }

    }

}

