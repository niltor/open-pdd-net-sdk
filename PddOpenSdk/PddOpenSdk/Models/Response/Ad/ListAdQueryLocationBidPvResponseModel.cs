using System.Collections.Generic;
using Newtonsoft.Json;
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
            /// 资源位类型描述
            /// </summary>
            [JsonProperty("location_type_desc")]
            public string LocationTypeDesc { get; set; }
            /// <summary>
            /// 资源位类型。0表示基础流量包，1表示类目商品页，2表示商品详情页，3表示营销活动页，4表示店铺收藏页，5表示订单评价页，6表示优选活动页
            /// </summary>
            [JsonProperty("location_type")]
            public int? LocationType { get; set; }

        }

    }

}
