using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Express
{
    public partial class ListStockDepotPriorityResponseModel : PddResponseModel
    {
        /// <summary>
        /// 响应内容
        /// </summary>
        [JsonProperty("open_api_response")]
        public OpenApiResponseResponseModel OpenApiResponse { get; set; }
        public partial class OpenApiResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 总数
            /// </summary>
            [JsonProperty("count")]
            public int? Count { get; set; }
            /// <summary>
            /// 仓库列表
            /// </summary>
            [JsonProperty("depot_list")]
            public List<DepotListResponseModel> DepotList { get; set; }
            public partial class DepotListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 仓库id
                /// </summary>
                [JsonProperty("depot_id")]
                public string DepotId { get; set; }
                /// <summary>
                /// 仓库地址（省编号）
                /// </summary>
                [JsonProperty("province_id")]
                public int? ProvinceId { get; set; }
                /// <summary>
                /// 仓库地址（市编号）
                /// </summary>
                [JsonProperty("city_id")]
                public int? CityId { get; set; }
                /// <summary>
                /// 仓库地址（区编号）
                /// </summary>
                [JsonProperty("district_id")]
                public int? DistrictId { get; set; }
                /// <summary>
                /// 仓库编码
                /// </summary>
                [JsonProperty("depot_code")]
                public string DepotCode { get; set; }
                /// <summary>
                /// 仓库名称
                /// </summary>
                [JsonProperty("depot_name")]
                public string DepotName { get; set; }
                /// <summary>
                /// 优先级
                /// </summary>
                [JsonProperty("priority")]
                public int? Priority { get; set; }

            }

        }

    }

}
