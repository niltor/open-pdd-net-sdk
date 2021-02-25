using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.ServiceMarket
{
    public partial class SearchServicemarketContractResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("servicemarket_contract_search_response")]
        public ServicemarketContractSearchResponseResponseModel ServicemarketContractSearchResponse { get; set; }
        public partial class ServicemarketContractSearchResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 授权结束时间
            /// </summary>
            [JsonProperty("endAt")]
            public long? EndAt { get; set; }
            /// <summary>
            /// 订单号列表
            /// </summary>
            [JsonProperty("orderSns")]
            public List<string> OrderSns { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("specValue")]
            public SpecValueResponseModel SpecValue { get; set; }
            /// <summary>
            /// 授权开始时间
            /// </summary>
            [JsonProperty("startAt")]
            public long? StartAt { get; set; }
            public partial class SpecValueResponseModel : PddResponseModel
            {
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("specValueList")]
                public List<SpecValueListResponseModel> SpecValueList { get; set; }
                public partial class SpecValueListResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 规格值id
                    /// </summary>
                    [JsonProperty("id")]
                    public long? Id { get; set; }
                    /// <summary>
                    /// 规格名称
                    /// </summary>
                    [JsonProperty("specName")]
                    public string SpecName { get; set; }
                    /// <summary>
                    /// 规格值名称
                    /// </summary>
                    [JsonProperty("specValue")]
                    public string SpecValue { get; set; }
                    /// <summary>
                    /// 规格时长参数
                    /// </summary>
                    [JsonProperty("timeLengthValue")]
                    public long? TimeLengthValue { get; set; }

                }

            }

        }

    }

}
