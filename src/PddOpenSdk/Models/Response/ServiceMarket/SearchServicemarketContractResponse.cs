namespace PddOpenSdk.Models.Response.ServiceMarket;
public partial class SearchServicemarketContractResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("servicemarket_contract_search_response")]
    public ServicemarketContractSearchResponseResponse ServicemarketContractSearchResponse { get; set; }
    public partial class ServicemarketContractSearchResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 授权结束时间
        /// </summary>
        [JsonPropertyName("endAt")]
        public long? EndAt { get; set; }

        /// <summary>
        /// 订单号列表
        /// </summary>
        [JsonPropertyName("orderSns")]
        public List<string> OrderSns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("specValue")]
        public SpecValueResponse SpecValue { get; set; }

        /// <summary>
        /// 授权开始时间
        /// </summary>
        [JsonPropertyName("startAt")]
        public long? StartAt { get; set; }
        public partial class SpecValueResponse : PddResponseModel
        {

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("specValueList")]
            public List<SpecValueListResponse> SpecValueList { get; set; }
            public partial class SpecValueListResponse : PddResponseModel
            {

                /// <summary>
                /// 规格值id
                /// </summary>
                [JsonPropertyName("id")]
                public long? Id { get; set; }

                /// <summary>
                /// 规格名称
                /// </summary>
                [JsonPropertyName("specName")]
                public string SpecName { get; set; }

                /// <summary>
                /// 规格值名称
                /// </summary>
                [JsonPropertyName("specValue")]
                public string SpecValue { get; set; }

                /// <summary>
                /// 规格时长参数
                /// </summary>
                [JsonPropertyName("timeLengthValue")]
                public long? TimeLengthValue { get; set; }

            }

        }

    }

}

