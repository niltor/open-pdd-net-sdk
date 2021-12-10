namespace PddOpenSdk.Models.Request.Goods;
public partial class CreateGoodsLogisticsTemplate
{

    /// <summary>
    /// 非包邮模版列表
    /// </summary>
    [JsonPropertyName("cost_template_list")]
    public List<CostTemplateListModel> CostTemplateList { get; set; }

    /// <summary>
    /// 包邮地区
    /// </summary>
    [JsonPropertyName("free_province_list")]
    public List<FreeProvinceListModel> FreeProvinceList { get; set; }

    /// <summary>
    /// 计费方式，0-按件计费，1-按重量计费
    /// </summary>
    [JsonPropertyName("cost_type")]
    public int CostType { get; set; }

    /// <summary>
    /// 运费模板名称
    /// </summary>
    [JsonPropertyName("template_name")]
    public string TemplateName { get; set; }

    /// <summary>
    /// 发货地省份id
    /// </summary>
    [JsonPropertyName("province_id")]
    public int ProvinceId { get; set; }

    /// <summary>
    /// 发货地城市id
    /// </summary>
    [JsonPropertyName("city_id")]
    public int CityId { get; set; }

    /// <summary>
    /// 发货地区id
    /// </summary>
    [JsonPropertyName("district_id")]
    public int DistrictId { get; set; }
    public partial class CostTemplateListModel
    {

        /// <summary>
        /// 首件
        /// </summary>
        [JsonPropertyName("first_standard")]
        public long FirstStandard { get; set; }

        /// <summary>
        /// 首件或首重价格，单位为分
        /// </summary>
        [JsonPropertyName("first_cost")]
        public long FirstCost { get; set; }

        /// <summary>
        /// 续重或续件，续重时单位为克且数值须为1000的整数倍
        /// </summary>
        [JsonPropertyName("add_standard")]
        public long AddStandard { get; set; }

        /// <summary>
        /// 续件或续重价格，单位为分
        /// </summary>
        [JsonPropertyName("add_cost")]
        public long AddCost { get; set; }

        /// <summary>
        /// 对不包邮地区，true-若要包邮须满足件数包邮，false-不开启满足件数包邮
        /// </summary>
        [JsonPropertyName("is_have_free_min_count")]
        public bool IsHaveFreeMinCount { get; set; }

        /// <summary>
        /// 对不包邮地区，满足指定件数包邮，该值为商家设置的指定件数，若为-1则商家没有开启满足件数包邮
        /// </summary>
        [JsonPropertyName("have_free_min_count")]
        public int HaveFreeMinCount { get; set; }

        /// <summary>
        /// 对不包邮地区，true-若要包邮须满足指定价格则可以包邮，false-不开启满足指定价格包邮
        /// </summary>
        [JsonPropertyName("is_have_free_min_amount")]
        public bool IsHaveFreeMinAmount { get; set; }

        /// <summary>
        /// 对不包邮地区，满足指定价格包邮，该值为商家设置的指定订单金额，若为-1则商家没有开启满足指定价格包邮，注意，单位为分
        /// </summary>
        [JsonPropertyName("have_free_min_amount")]
        public long HaveFreeMinAmount { get; set; }

        /// <summary>
        /// 省份列表
        /// </summary>
        [JsonPropertyName("cost_province_list")]
        public List<CostProvinceListModel> CostProvinceList { get; set; }
        public partial class CostProvinceListModel
        {

            /// <summary>
            /// 省份ID
            /// </summary>
            [JsonPropertyName("province_id")]
            public int ProvinceId { get; set; }

        }

    }
    public partial class FreeProvinceListModel
    {

        /// <summary>
        /// 省份ID
        /// </summary>
        [JsonPropertyName("province_id")]
        public int ProvinceId { get; set; }

    }

}

