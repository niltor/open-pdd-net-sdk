using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class TemplateOneExpressCostResponseModel : PddResponseModel {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty ("one_express_cost_template_response")]
        public OneExpressCostTemplateResponseResponseModel OneExpressCostTemplateResponse { get; set; }
        public partial class OneExpressCostTemplateResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 发货地省份ID
            /// </summary>
            [JsonProperty ("province_id")]
            public int ProvinceId { get; set; }
            /// <summary>
            /// 发货地城市ID
            /// </summary>
            [JsonProperty ("city_id")]
            public int CityId { get; set; }
            /// <summary>
            /// 发货地区ID
            /// </summary>
            [JsonProperty ("district_id")]
            public int DistrictId { get; set; }
            /// <summary>
            /// 送货入户并安装服务，0-不支持、1-支持送货入户、2-支持送货入户并安装
            /// </summary>
            [JsonProperty ("additional_service_type")]
            public int AdditionalServiceType { get; set; }
            /// <summary>
            /// 是否顺丰包邮
            /// </summary>
            [JsonProperty ("sf_free_type")]
            public int SfFreeType { get; set; }
            /// <summary>
            /// 不包邮区域/需要买家付邮费区域
            /// </summary>
            [JsonProperty ("cost_template_list")]
            public List<CostTemplateListResponseModel> CostTemplateList { get; set; }
            /// <summary>
            /// 运费模板id
            /// </summary>
            [JsonProperty ("template_id")]
            public long? TemplateId { get; set; }
            /// <summary>
            /// 运费模板名称
            /// </summary>
            [JsonProperty ("template_name")]
            public string TemplateName { get; set; }
            /// <summary>
            /// 计费方式，0-按件计费，1-按重量计费
            /// </summary>
            [JsonProperty ("cost_type")]
            public int CostType { get; set; }
            /// <summary>
            /// 是否送货上门，对于包邮地区：true-商品包邮且送货上门，false-商品包邮但不送货上门
            /// </summary>
            [JsonProperty ("free_deliver_house")]
            public bool? FreeDeliverHouse { get; set; }
            /// <summary>
            /// 送货上门地区列表
            /// </summary>
            [JsonProperty ("free_deliver_house_area_list")]
            public List<FreeDeliverHouseAreaListResponseModel> FreeDeliverHouseAreaList { get; set; }
            /// <summary>
            /// 包邮省份对象
            /// </summary>
            [JsonProperty ("free_province_list")]
            public List<FreeProvinceListResponseModel> FreeProvinceList { get; set; }
            public partial class CostTemplateListResponseModel : PddResponseModel {
                /// <summary>
                /// 不包邮的区域
                /// </summary>
                [JsonProperty ("cost_province_list")]
                public List<CostProvinceListResponseModel> CostProvinceList { get; set; }
                /// <summary>
                /// 首件
                /// </summary>
                [JsonProperty ("first_standard")]
                public long? FirstStandard { get; set; }
                /// <summary>
                /// 首件或首重价格，单位为分
                /// </summary>
                [JsonProperty ("first_cost")]
                public long? FirstCost { get; set; }
                /// <summary>
                /// 续重或续件
                /// </summary>
                [JsonProperty ("add_standard")]
                public long? AddStandard { get; set; }
                /// <summary>
                /// 续件或续重价格，单位为分
                /// </summary>
                [JsonProperty ("add_cost")]
                public long? AddCost { get; set; }
                /// <summary>
                /// 对不包邮地区，true-若要包邮须满足件数包邮，false-不开启满足件数包邮
                /// </summary>
                [JsonProperty ("is_have_free_min_count")]
                public bool? IsHaveFreeMinCount { get; set; }
                /// <summary>
                /// 对不包邮地区，满足指定件数包邮，该值为商家设置的指定件数，若为-1则商家没有开启满足件数包邮
                /// </summary>
                [JsonProperty ("have_free_min_count")]
                public long? HaveFreeMinCount { get; set; }
                /// <summary>
                /// 对不包邮地区，true-若要包邮须满足指定价格则可以包邮，false-不开启满足指定价格包邮
                /// </summary>
                [JsonProperty ("is_have_free_min_amount")]
                public bool? IsHaveFreeMinAmount { get; set; }
                /// <summary>
                /// 对不包邮地区，满足指定价格包邮，该值为商家设置的指定订单金额，若为-1则商家没有开启满足指定价格包邮，注意，单位为分
                /// </summary>
                [JsonProperty ("have_free_min_amount")]
                public long? HaveFreeMinAmount { get; set; }
                public partial class CostProvinceListResponseModel : PddResponseModel {
                    /// <summary>
                    /// 省份
                    /// </summary>
                    [JsonProperty ("province")]
                    public string Province { get; set; }
                    /// <summary>
                    /// 不包邮区域的ID
                    /// </summary>
                    [JsonProperty ("province_id")]
                    public int ProvinceId { get; set; }

                }

            }
            public partial class FreeDeliverHouseAreaListResponseModel : PddResponseModel {
                /// <summary>
                /// 包邮送货上门的城区ID
                /// </summary>
                [JsonProperty ("town_id")]
                public int TownId { get; set; }
                /// <summary>
                /// 包邮送货上门的城市ID
                /// </summary>
                [JsonProperty ("city_id")]
                public int CityId { get; set; }
                /// <summary>
                /// 包邮送货上门的省份ID
                /// </summary>
                [JsonProperty ("province_id")]
                public int ProvinceId { get; set; }
                /// <summary>
                /// 包邮送货上门的省份
                /// </summary>
                [JsonProperty ("province")]
                public string Province { get; set; }
                /// <summary>
                /// 包邮送货上门的城市
                /// </summary>
                [JsonProperty ("city")]
                public string City { get; set; }
                /// <summary>
                /// 包邮送货上门的城区
                /// </summary>
                [JsonProperty ("town")]
                public string Town { get; set; }

            }
            public partial class FreeProvinceListResponseModel : PddResponseModel {
                /// <summary>
                /// 省份ID
                /// </summary>
                [JsonProperty ("province_id")]
                public long? ProvinceId { get; set; }
                /// <summary>
                /// 省份
                /// </summary>
                [JsonProperty ("province")]
                public string Province { get; set; }

            }

        }

    }

}