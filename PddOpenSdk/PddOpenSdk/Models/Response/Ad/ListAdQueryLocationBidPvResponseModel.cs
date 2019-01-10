using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class ListAdQueryLocationBidPvResponseModel : PddResponseModel
    {
        /// <summary>
        /// 开平出参
        /// </summary>
        [JsonProperty("open_api_response")]
        public List<OpenApiResponseResponseModel> OpenApiResponse { get; set; }
        public partial class OpenApiResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 日均可竞流量
            /// </summary>
            [JsonProperty("location_pv")]
            public long? LocationPv { get; set; }
            /// <summary>
            /// 资源位类型
            /// </summary>
            [JsonProperty("location_type_desc")]
            public string LocationTypeDesc { get; set; }
            /// <summary>
            /// 资源位类型（1：类目商品页，2：商品详情页，3：营销活动页）
            /// </summary>
            [JsonProperty("location_type")]
            public int? LocationType { get; set; }

        }

    }

}
