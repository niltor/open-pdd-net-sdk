using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Ticket
{
    public partial class GetTicketScenicResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response")]
        public ResponseResponseModel Response { get; set; }
        public partial class ResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("area_list")]
            public List<AreaListResponseModel> AreaList { get; set; }
            public partial class AreaListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 纬度
                /// </summary>
                [JsonProperty("latitude")]
                public double? Latitude { get; set; }
                /// <summary>
                /// 定位类型 1.百度 2.google
                /// </summary>
                [JsonProperty("location_type")]
                public int? LocationType { get; set; }
                /// <summary>
                /// 经度
                /// </summary>
                [JsonProperty("longitude")]
                public double? Longitude { get; set; }
                /// <summary>
                /// 拼多多景区编码
                /// </summary>
                [JsonProperty("scenic_id")]
                public long? ScenicId { get; set; }
                /// <summary>
                /// 拼多多景区名称
                /// </summary>
                [JsonProperty("scenic_name")]
                public string ScenicName { get; set; }

            }

        }

    }

}
