using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetGoodsLogisticsTemplateResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回的运费模板总数
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
        /// <summary>
        /// 商家运费模板对象列表
        /// </summary>
        [JsonProperty("logistics_template_list")]
        public LogisticsTemplateListResponseModel LogisticsTemplateList { get; set; }

        public partial class LogisticsTemplateListResponseModel : PddResponseModel
        {
            /// <summary>
            /// 不包邮区域/需要买家付邮费区域
            /// </summary>
            [JsonProperty("cost_template_list")]
            public CostTemplateListResponseModel CostTemplateList { get; set; }
            /// <summary>
            /// template_id
            /// </summary>
            [JsonProperty("template_id")]
            public object TemplateId { get; set; }
            /// <summary>
            /// 运费模板名称
            /// </summary>
            [JsonProperty("template_name")]
            public string TemplateName { get; set; }
            /// <summary>
            /// 计费方式，0-按件计费，1-按重量计费
            /// </summary>
            [JsonProperty("cost_type")]
            public int CostType { get; set; }
            /// <summary>
            /// 是否送货上门，对于包邮地区：true-商品包邮且送货上门，false-商品包邮但不送货上门
            /// </summary>
            [JsonProperty("free_deliver_house")]
            public bool FreeDeliverHouse { get; set; }
            /// <summary>
            /// 送货上门地区列表
            /// </summary>
            [JsonProperty("free_deliver_house_area_list")]
            public FreeDeliverHouseAreaListResponseModel FreeDeliverHouseAreaList { get; set; }
            /// <summary>
            /// 包邮省份对象
            /// </summary>
            [JsonProperty("free_province_list")]
            public FreeProvinceListResponseModel FreeProvinceList { get; set; }

            public partial class CostTemplateListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 不包邮的区域
                /// </summary>
                [JsonProperty("cost_province_list")]
                public CostProvinceListResponseModel CostProvinceList { get; set; }
                /// <summary>
                /// 首件
                /// </summary>
                [JsonProperty("first_standard")]
                public object FirstStandard { get; set; }
                /// <summary>
                /// 首件或首重价格，单位为分
                /// </summary>
                [JsonProperty("first_cost")]
                public int FirstCost { get; set; }
                /// <summary>
                /// 续重或续件
                /// </summary>
                [JsonProperty("add_standard")]
                public int AddStandard { get; set; }
                /// <summary>
                /// 续件或续重价格，单位为分
                /// </summary>
                [JsonProperty("add_cost")]
                public int AddCost { get; set; }
                /// <summary>
                /// 对不包邮地区，true-若要包邮须满足件数包邮，false-不开启满足件数包邮
                /// </summary>
                [JsonProperty("is_have_free_min_count")]
                public bool IsHaveFreeMinCount { get; set; }
                /// <summary>
                /// 对不包邮地区，满足指定件数包邮，该值为商家设置的指定件数，若为-1则商家没有开启满足件数包邮
                /// </summary>
                [JsonProperty("have_free_min_count")]
                public int HaveFreeMinCount { get; set; }
                /// <summary>
                /// 对不包邮地区，true-若要包邮须满足指定价格则可以包邮，false-不开启满足指定价格包邮
                /// </summary>
                [JsonProperty("is_have_free_min_amount")]
                public bool IsHaveFreeMinAmount { get; set; }
                /// <summary>
                /// 对不包邮地区，满足指定价格包邮，该值为商家设置的指定订单金额，若为-1则商家没有开启满足指定价格包邮，注意，单位为分
                /// </summary>
                [JsonProperty("have_free_min_amount")]
                public int HaveFreeMinAmount { get; set; }

                public partial class CostProvinceListResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 省份
                    /// </summary>
                    [JsonProperty("province")]
                    public object Province { get; set; }
                    /// <summary>
                    /// 不包邮区域的ID
                    /// </summary>
                    [JsonProperty("province_id")]
                    public object ProvinceId { get; set; }

                }

            }

            public partial class FreeDeliverHouseAreaListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 包邮送货上门的城区ID
                /// </summary>
                [JsonProperty("town_id")]
                public string TownId { get; set; }
                /// <summary>
                /// 包邮送货上门的城市ID
                /// </summary>
                [JsonProperty("city_id")]
                public string CityId { get; set; }
                /// <summary>
                /// 包邮送货上门的省份ID
                /// </summary>
                [JsonProperty("province_id")]
                public string ProvinceId { get; set; }
                /// <summary>
                /// 包邮送货上门的省份
                /// </summary>
                [JsonProperty("province")]
                public string Province { get; set; }
                /// <summary>
                /// 包邮送货上门的城市
                /// </summary>
                [JsonProperty("city")]
                public string City { get; set; }
                /// <summary>
                /// 包邮送货上门的城区
                /// </summary>
                [JsonProperty("town")]
                public string Town { get; set; }

            }

            public partial class FreeProvinceListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 省份
                /// </summary>
                [JsonProperty("province")]
                public string Province { get; set; }

            }

        }

    }
}
