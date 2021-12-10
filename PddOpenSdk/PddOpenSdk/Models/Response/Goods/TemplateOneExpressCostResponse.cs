namespace PddOpenSdk.Models.Response.Goods;
public partial class TemplateOneExpressCostResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("one_express_cost_template_response")]
    public OneExpressCostTemplateResponseResponse OneExpressCostTemplateResponse { get; set; }
    public partial class OneExpressCostTemplateResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 发货地省份ID
        /// </summary>
        [JsonPropertyName("province_id")]
        public int? ProvinceId { get; set; }

        /// <summary>
        /// 发货地城市ID
        /// </summary>
        [JsonPropertyName("city_id")]
        public int? CityId { get; set; }

        /// <summary>
        /// 发货地区ID
        /// </summary>
        [JsonPropertyName("district_id")]
        public int? DistrictId { get; set; }

        /// <summary>
        /// 送货入户并安装服务，0-不支持、1-支持送货入户、2-支持送货入户并安装
        /// </summary>
        [JsonPropertyName("additional_service_type")]
        public int? AdditionalServiceType { get; set; }

        /// <summary>
        /// 是否顺丰包邮
        /// </summary>
        [JsonPropertyName("sf_free_type")]
        public int? SfFreeType { get; set; }

        /// <summary>
        /// 不包邮区域/需要买家付邮费区域
        /// </summary>
        [JsonPropertyName("cost_template_list")]
        public List<CostTemplateListResponse> CostTemplateList { get; set; }

        /// <summary>
        /// 运费模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public long? TemplateId { get; set; }

        /// <summary>
        /// 运费模板名称
        /// </summary>
        [JsonPropertyName("template_name")]
        public string TemplateName { get; set; }

        /// <summary>
        /// 计费方式，0-按件计费，1-按重量计费
        /// </summary>
        [JsonPropertyName("cost_type")]
        public int? CostType { get; set; }

        /// <summary>
        /// 是否送货上门，对于包邮地区：true-商品包邮且送货上门，false-商品包邮但不送货上门
        /// </summary>
        [JsonPropertyName("free_deliver_house")]
        public bool? FreeDeliverHouse { get; set; }

        /// <summary>
        /// 送货上门地区列表
        /// </summary>
        [JsonPropertyName("free_deliver_house_area_list")]
        public List<FreeDeliverHouseAreaListResponse> FreeDeliverHouseAreaList { get; set; }

        /// <summary>
        /// 包邮省份对象
        /// </summary>
        [JsonPropertyName("free_province_list")]
        public List<FreeProvinceListResponse> FreeProvinceList { get; set; }
        public partial class CostTemplateListResponse : PddResponseModel
        {

            /// <summary>
            /// 不包邮的区域
            /// </summary>
            [JsonPropertyName("cost_province_list")]
            public List<CostProvinceListResponse> CostProvinceList { get; set; }

            /// <summary>
            /// 首件
            /// </summary>
            [JsonPropertyName("first_standard")]
            public long? FirstStandard { get; set; }

            /// <summary>
            /// 首件或首重价格，单位为分
            /// </summary>
            [JsonPropertyName("first_cost")]
            public long? FirstCost { get; set; }

            /// <summary>
            /// 续重或续件
            /// </summary>
            [JsonPropertyName("add_standard")]
            public long? AddStandard { get; set; }

            /// <summary>
            /// 续件或续重价格，单位为分
            /// </summary>
            [JsonPropertyName("add_cost")]
            public long? AddCost { get; set; }

            /// <summary>
            /// 对不包邮地区，true-若要包邮须满足件数包邮，false-不开启满足件数包邮
            /// </summary>
            [JsonPropertyName("is_have_free_min_count")]
            public bool? IsHaveFreeMinCount { get; set; }

            /// <summary>
            /// 对不包邮地区，满足指定件数包邮，该值为商家设置的指定件数，若为-1则商家没有开启满足件数包邮
            /// </summary>
            [JsonPropertyName("have_free_min_count")]
            public long? HaveFreeMinCount { get; set; }

            /// <summary>
            /// 对不包邮地区，true-若要包邮须满足指定价格则可以包邮，false-不开启满足指定价格包邮
            /// </summary>
            [JsonPropertyName("is_have_free_min_amount")]
            public bool? IsHaveFreeMinAmount { get; set; }

            /// <summary>
            /// 对不包邮地区，满足指定价格包邮，该值为商家设置的指定订单金额，若为-1则商家没有开启满足指定价格包邮，注意，单位为分
            /// </summary>
            [JsonPropertyName("have_free_min_amount")]
            public long? HaveFreeMinAmount { get; set; }
            public partial class CostProvinceListResponse : PddResponseModel
            {

                /// <summary>
                /// 省份
                /// </summary>
                [JsonPropertyName("province")]
                public string Province { get; set; }

                /// <summary>
                /// 不包邮区域的ID
                /// </summary>
                [JsonPropertyName("province_id")]
                public int? ProvinceId { get; set; }

            }

        }
        public partial class FreeDeliverHouseAreaListResponse : PddResponseModel
        {

            /// <summary>
            /// 包邮送货上门的城区ID
            /// </summary>
            [JsonPropertyName("town_id")]
            public int? TownId { get; set; }

            /// <summary>
            /// 包邮送货上门的城市ID
            /// </summary>
            [JsonPropertyName("city_id")]
            public int? CityId { get; set; }

            /// <summary>
            /// 包邮送货上门的省份ID
            /// </summary>
            [JsonPropertyName("province_id")]
            public int? ProvinceId { get; set; }

            /// <summary>
            /// 包邮送货上门的省份
            /// </summary>
            [JsonPropertyName("province")]
            public string Province { get; set; }

            /// <summary>
            /// 包邮送货上门的城市
            /// </summary>
            [JsonPropertyName("city")]
            public string City { get; set; }

            /// <summary>
            /// 包邮送货上门的城区
            /// </summary>
            [JsonPropertyName("town")]
            public string Town { get; set; }

        }
        public partial class FreeProvinceListResponse : PddResponseModel
        {

            /// <summary>
            /// 省份ID
            /// </summary>
            [JsonPropertyName("province_id")]
            public long? ProvinceId { get; set; }

            /// <summary>
            /// 省份
            /// </summary>
            [JsonPropertyName("province")]
            public string Province { get; set; }

        }

    }

}

