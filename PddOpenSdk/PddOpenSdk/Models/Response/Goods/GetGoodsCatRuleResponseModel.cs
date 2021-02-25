using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class GetGoodsCatRuleResponseModel : PddResponseModel
    {
        /// <summary>
        /// 类目规则
        /// </summary>
        [JsonProperty("cat_rule_get_response")]
        public CatRuleGetResponseResponseModel CatRuleGetResponse { get; set; }
        public partial class CatRuleGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 标品规则
            /// </summary>
            [JsonProperty("spu_rule")]
            public SpuRuleResponseModel SpuRule { get; set; }
            /// <summary>
            /// 类目物流类型规则
            /// </summary>
            [JsonProperty("cat_delivery_type")]
            public List<CatDeliveryTypeResponseModel> CatDeliveryType { get; set; }
            public partial class SpuRuleResponseModel : PddResponseModel
            {
                /// <summary>
                /// 标品管控类型。0=不管控；1=管控，表示商品发布时必须命中标品，且发布成功后不可更改关键属性；2=不可换品，表示发布成功后不可更改关键属性。
                /// </summary>
                [JsonProperty("control_type")]
                public int? ControlType { get; set; }
                /// <summary>
                /// 关键属性
                /// </summary>
                [JsonProperty("key_prop")]
                public List<KeyPropResponseModel> KeyProp { get; set; }
                public partial class KeyPropResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 关键属性名
                    /// </summary>
                    [JsonProperty("pname")]
                    public string Pname { get; set; }
                    /// <summary>
                    /// 关键属性id
                    /// </summary>
                    [JsonProperty("ref_pid")]
                    public long? RefPid { get; set; }

                }

            }
            public partial class CatDeliveryTypeResponseModel : PddResponseModel
            {
                /// <summary>
                /// 是否可选择物流类型
                /// </summary>
                [JsonProperty("can_select_delivery_type")]
                public bool? CanSelectDeliveryType { get; set; }
                /// <summary>
                /// 商品类型
                /// </summary>
                [JsonProperty("goods_type")]
                public int? GoodsType { get; set; }

            }

        }

    }

}
