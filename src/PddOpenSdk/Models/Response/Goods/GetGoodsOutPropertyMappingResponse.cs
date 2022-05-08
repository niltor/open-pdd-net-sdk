namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsOutPropertyMappingResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("out_property_mapping_get_response")]
    public OutPropertyMappingGetResponseResponse OutPropertyMappingGetResponse { get; set; }
    public partial class OutPropertyMappingGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("property")]
        public List<PropertyResponse> Property { get; set; }
        public partial class PropertyResponse : PddResponseModel
        {

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("out_property_name")]
            public string OutPropertyName { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("out_property_value_name")]
            public string OutPropertyValueName { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("property_value_id")]
            public long? PropertyValueId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("property_value_name")]
            public string PropertyValueName { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("ref_property_id")]
            public long? RefPropertyId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("ref_property_name")]
            public string RefPropertyName { get; set; }

        }

    }

}

