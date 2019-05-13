using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class PauseGoodsCpsMallUnitResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_cps_mall_unit_query_response")]
        public GoodsCpsMallUnitQueryResponseResponseModel GoodsCpsMallUnitQueryResponse { get; set; }
        public partial class GoodsCpsMallUnitQueryResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 是否成功
            /// </summary>
            [JsonProperty("result")]
            public bool? Result { get; set; }

        }

    }

}
