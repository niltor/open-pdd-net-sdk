using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class GetGoodsOutPropertyMappingResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("out_property_mapping_get_response")]
        public OutPropertyMappingGetResponseResponseModel OutPropertyMappingGetResponse { get; set; }
        public partial class OutPropertyMappingGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("property")]
            public List<PropertyResponseModel> Property { get; set; }
            public partial class PropertyResponseModel : PddResponseModel
            {
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("out_property_name")]
                public string OutPropertyName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("out_property_value_name")]
                public string OutPropertyValueName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("property_value_id")]
                public long? PropertyValueId { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("property_value_name")]
                public string PropertyValueName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("ref_property_id")]
                public long? RefPropertyId { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("ref_property_name")]
                public string RefPropertyName { get; set; }

            }

        }

    }

}
