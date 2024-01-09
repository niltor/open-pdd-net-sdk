namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsCatRuleResponse : PddResponseModel
{

    /// <summary>
    /// 类目规则
    /// </summary>
    [JsonPropertyName("cat_rule_get_response")]
    public CatRuleGetResponseResponse CatRuleGetResponse { get; set; }
    public partial class CatRuleGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 商品属性规则
        /// </summary>
        [JsonPropertyName("goods_properties_rule")]
        public GoodsPropertiesRuleResponse GoodsPropertiesRule { get; set; }

        /// <summary>
        /// 商品服务规则
        /// </summary>
        [JsonPropertyName("goods_service_rule")]
        public GoodsServiceRuleResponse GoodsServiceRule { get; set; }

        /// <summary>
        /// sku规则
        /// </summary>
        [JsonPropertyName("goods_sku_rule")]
        public GoodsSkuRuleResponse GoodsSkuRule { get; set; }

        /// <summary>
        /// 标品规则
        /// </summary>
        [JsonPropertyName("spu_rule")]
        public SpuRuleResponse SpuRule { get; set; }

        /// <summary>
        /// 满2件折扣相关规则
        /// </summary>
        [JsonPropertyName("two_pieces_discount_rule")]
        public TwoPiecesDiscountRuleResponse TwoPiecesDiscountRule { get; set; }
        public partial class GoodsPropertiesRuleResponse : PddResponseModel
        {

            /// <summary>
            /// 多个销售属性是否需要同时传
            /// </summary>
            [JsonPropertyName("choose_all_qualify_spec")]
            public bool? ChooseAllQualifySpec { get; set; }

            /// <summary>
            /// 允许自定义的销售属性数量
            /// </summary>
            [JsonPropertyName("input_max_spec_num")]
            public long? InputMaxSpecNum { get; set; }

            /// <summary>
            /// 属性信息
            /// </summary>
            [JsonPropertyName("properties")]
            public List<PropertiesResponse> Properties { get; set; }
            public partial class PropertiesResponse : PddResponseModel
            {

                /// <summary>
                /// 是否允许填写备注，仅当是销售属性时有意义
                /// </summary>
                [JsonPropertyName("can_note")]
                public bool? CanNote { get; set; }

                /// <summary>
                /// 可选择属性值数目，为0时代表不限。包括自定义的属性值和模版中给出的属性值。
                /// </summary>
                [JsonPropertyName("choose_max_num")]
                public int? ChooseMaxNum { get; set; }

                /// <summary>
                /// 可自定义属性值数目，为0时代表不可自定义。
                /// </summary>
                [JsonPropertyName("input_max_num")]
                public int? InputMaxNum { get; set; }

                /// <summary>
                /// 是否重要属性。填写重要属性有更多机会获取搜索、活动等场景流量。
                /// </summary>
                [JsonPropertyName("is_important")]
                public bool? IsImportant { get; set; }

                /// <summary>
                /// 是否销售属性。销售属性需要在发商品时，商品属性上的属性值与规格中中的spec对应。
                /// </summary>
                [JsonPropertyName("is_sale")]
                public bool? IsSale { get; set; }

                /// <summary>
                /// 是否sku属性，sku维度的属性在商品发布时入参在sku对象下
                /// </summary>
                [JsonPropertyName("is_sku")]
                public bool? IsSku { get; set; }

                /// <summary>
                /// 最大值。在不同的属性值类型下有不同的含义。  文本类型时，代表文本最大长度；  数值类型时，代表数字最大值；  时间类型且最大值为时间时，代表时间最大值；  时间类型且最大值为数字时，代表距离今天或者本月往后的天数或月数。
                /// </summary>
                [JsonPropertyName("max_value")]
                public string MaxValue { get; set; }

                /// <summary>
                /// 最小值。在不同的属性值类型下有不同的含义。  文本类型时，代表文本最小长度；  数值类型时，代表数字最小值；  时间类型且最小值为时间时，代表时间最小值；  时间类型且最小值为数字时，代表距离今天或者本月往前的天数或月数。
                /// </summary>
                [JsonPropertyName("min_value")]
                public string MinValue { get; set; }

                /// <summary>
                /// 属性名称
                /// </summary>
                [JsonPropertyName("name")]
                public string Name { get; set; }

                /// <summary>
                /// 销售属性对应的父规格id。
                /// </summary>
                [JsonPropertyName("parent_spec_id")]
                public long? ParentSpecId { get; set; }

                /// <summary>
                /// 属性值类型。在发商品时传自定义的属性值时，有不同的格式。 0=文本; 1=数值，如“100”; 2=数值范围，如“10,20”，表示10到20之间; 3=数值乘积-二维，如“10,10”，表示10*10; 4=数值乘积-三维，如“10,10,10”，表示10*10*10; 5=单项时间选择-年月日，如“2020-05-20”; 6=双项时间选择-年月日，如“2020-05-20,2020-06-20”; 7=单项时间选择-年月，如“2020-05”; 8=双项时间选择-年月，如“2020-05,2020-06”。
                /// </summary>
                [JsonPropertyName("property_value_type")]
                public int? PropertyValueType { get; set; }

                /// <summary>
                /// 属性id
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
                /// 该属性的父属性。只有parent_pid下的show_vids中的值被选择时才可入参该属性。有多组父属性时，为且的关系。
                /// </summary>
                [JsonPropertyName("show_condition")]
                public List<ShowConditionResponse> ShowCondition { get; set; }

                /// <summary>
                /// 小数点允许最大精度，为0时代表不允许输入小数。对数值类属性值限制。
                /// </summary>
                [JsonPropertyName("value_precision")]
                public int? ValuePrecision { get; set; }

                /// <summary>
                /// 可选属性值单位，发商品填写自定义数值属性值时，选择其中之一作为单位。
                /// </summary>
                [JsonPropertyName("value_unit")]
                public List<string> ValueUnit { get; set; }

                /// <summary>
                /// 属性值列表
                /// </summary>
                [JsonPropertyName("values")]
                public List<ValuesResponse> Values { get; set; }
                public partial class ShowConditionResponse : PddResponseModel
                {

                    /// <summary>
                    /// 父属性id。
                    /// </summary>
                    [JsonPropertyName("parent_ref_pid")]
                    public long? ParentRefPid { get; set; }

                    /// <summary>
                    /// 父属性值id。多个值任选其一即可。若为空表示任意值都可以。
                    /// </summary>
                    [JsonPropertyName("parent_vids")]
                    public List<long?> ParentVids { get; set; }

                }
                public partial class ValuesResponse : PddResponseModel
                {

                    /// <summary>
                    /// 扩展信息，表示颜色的色号。格式为ARGB
                    /// </summary>
                    [JsonPropertyName("extend_info")]
                    public string ExtendInfo { get; set; }

                    /// <summary>
                    /// 分组信息
                    /// </summary>
                    [JsonPropertyName("group")]
                    public GroupResponse Group { get; set; }

                    /// <summary>
                    /// 表示对应父属性值id。当其中父属性值被选中时该子属性值才可选。为空则表示无此限制。
                    /// </summary>
                    [JsonPropertyName("parent_vids")]
                    public List<long?> ParentVids { get; set; }

                    /// <summary>
                    /// 规格id，发商品时需要和sku上的spec对应。
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
        public partial class GoodsServiceRuleResponse : PddResponseModel
        {

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("goods_service_rule_map")]
            public Dictionary<string, object> GoodsServiceRuleMap { get; set; }

            /// <summary>
            /// 可选的商品类型列表
            /// </summary>
            [JsonPropertyName("goods_type_list")]
            public List<int?> GoodsTypeList { get; set; }
            public partial class GoodsServiceRuleMapResponse : PddResponseModel
            {

                /// <summary>
                /// 商品类型
                /// </summary>
                [JsonPropertyName("$key")]
                public string Key { get; set; }

                /// <summary>
                /// 
                /// </summary>
                [JsonPropertyName("$value")]
                public ValueResponse Value { get; set; }
                public partial class ValueResponse : PddResponseModel
                {

                    /// <summary>
                    /// 坏了包赔规则：0不可选、1可选、2必选
                    /// </summary>
                    [JsonPropertyName("bad_claim_rule")]
                    public int? BadClaimRule { get; set; }

                    /// <summary>
                    /// 是否可以选择物流方式
                    /// </summary>
                    [JsonPropertyName("can_select_delivery_type")]
                    public bool? CanSelectDeliveryType { get; set; }

                    /// <summary>
                    /// 当日发货规则：0不可选、1可选
                    /// </summary>
                    [JsonPropertyName("delivery_one_day_rule")]
                    public int? DeliveryOneDayRule { get; set; }

                    /// <summary>
                    /// 假一赔十规则：0不可选、1可选、2必选
                    /// </summary>
                    [JsonPropertyName("folt_rule")]
                    public int? FoltRule { get; set; }

                    /// <summary>
                    /// 缺重包退规则：0不可选、1可选、2必选
                    /// </summary>
                    [JsonPropertyName("lack_of_weight_claim_rule")]
                    public int? LackOfWeightClaimRule { get; set; }

                    /// <summary>
                    /// 全国联保规则：0不可选、1可选
                    /// </summary>
                    [JsonPropertyName("quan_guo_lian_bao_rule")]
                    public int? QuanGuoLianBaoRule { get; set; }

                    /// <summary>
                    /// 7天无理由退换货规则：0不可选、1可选、2必选
                    /// </summary>
                    [JsonPropertyName("refundable_rule")]
                    public int? RefundableRule { get; set; }

                    /// <summary>
                    /// 可选承诺发货时间列表，单位：秒
                    /// </summary>
                    [JsonPropertyName("shipment_limit_second_list")]
                    public List<int?> ShipmentLimitSecondList { get; set; }

                    /// <summary>
                    /// 只换不修规则：0不可选、1可选
                    /// </summary>
                    [JsonPropertyName("zhi_huan_bu_xiu_rule")]
                    public int? ZhiHuanBuXiuRule { get; set; }

                }

            }

        }
        public partial class GoodsSkuRuleResponse : PddResponseModel
        {

            /// <summary>
            /// 团购价最高差倍率
            /// </summary>
            [JsonPropertyName("price_range_ratio")]
            public double? PriceRangeRatio { get; set; }

            /// <summary>
            /// 同个商品下规格值的加和数量上限
            /// </summary>
            [JsonPropertyName("spec_num_limit")]
            public int? SpecNumLimit { get; set; }

        }
        public partial class SpuRuleResponse : PddResponseModel
        {

            /// <summary>
            /// 标品管控类型。0=不管控；1=管控，表示商品发布时必须命中标品，且发布成功后不可更改关键属性；2=不可换品，表示发布成功后不可更改关键属性。
            /// </summary>
            [JsonPropertyName("control_type")]
            public int? ControlType { get; set; }

            /// <summary>
            /// 关键属性
            /// </summary>
            [JsonPropertyName("key_prop")]
            public List<KeyPropResponse> KeyProp { get; set; }
            public partial class KeyPropResponse : PddResponseModel
            {

                /// <summary>
                /// 关键属性名
                /// </summary>
                [JsonPropertyName("pname")]
                public string Pname { get; set; }

                /// <summary>
                /// 关键属性id
                /// </summary>
                [JsonPropertyName("ref_pid")]
                public long? RefPid { get; set; }

            }

        }
        public partial class TwoPiecesDiscountRuleResponse : PddResponseModel
        {

            /// <summary>
            /// 是否必须设置
            /// </summary>
            [JsonPropertyName("if_must_two_pieces_discount")]
            public bool? IfMustTwoPiecesDiscount { get; set; }

            /// <summary>
            /// 允许的最大折扣
            /// </summary>
            [JsonPropertyName("max_two_pieces_discount")]
            public int? MaxTwoPiecesDiscount { get; set; }

            /// <summary>
            /// 允许的最小折扣
            /// </summary>
            [JsonPropertyName("min_two_pieces_discount")]
            public int? MinTwoPiecesDiscount { get; set; }

            /// <summary>
            /// 推荐的折扣
            /// </summary>
            [JsonPropertyName("recommend_two_pieces_discount")]
            public int? RecommendTwoPiecesDiscount { get; set; }

        }

    }

}

