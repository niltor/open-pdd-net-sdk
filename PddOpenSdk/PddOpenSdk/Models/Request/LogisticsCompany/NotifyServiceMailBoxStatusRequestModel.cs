using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.LogisticsCompany
{
    public partial class NotifyServiceMailBoxStatusRequestModel : PddRequestModel
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        [JsonProperty("request")]
        public RequestRequestModel Request { get; set; }
        public partial class RequestRequestModel : PddRequestModel
        {
            /// <summary>
            /// 柜子编号列表
            /// </summary>
            [JsonProperty("expressBoxList")]
            public List<ExpressBoxListRequestModel> ExpressBoxList { get; set; }
            public partial class ExpressBoxListRequestModel : PddRequestModel
            {
                /// <summary>
                /// 柜子所在的详细地址
                /// </summary>
                [JsonProperty("address")]
                public string Address { get; set; }
                /// <summary>
                /// 扩展信息，json格式
                /// </summary>
                [JsonProperty("attributes")]
                public string Attributes { get; set; }
                /// <summary>
                /// 柜子所在的市
                /// </summary>
                [JsonProperty("cityName")]
                public string CityName { get; set; }
                /// <summary>
                /// 坐标系类型，wgs84，gcj02，bd09
                /// </summary>
                [JsonProperty("coordinateType")]
                public string CoordinateType { get; set; }
                /// <summary>
                /// 柜子所在的区
                /// </summary>
                [JsonProperty("districtName")]
                public string DistrictName { get; set; }
                /// <summary>
                /// 柜子编号
                /// </summary>
                [JsonProperty("expressBoxCode")]
                public string ExpressBoxCode { get; set; }
                /// <summary>
                /// 大格是否有空余柜口
                /// </summary>
                [JsonProperty("hasBigBox")]
                public bool? HasBigBox { get; set; }
                /// <summary>
                /// 中格是否有空余柜口
                /// </summary>
                [JsonProperty("hasMidBox")]
                public bool? HasMidBox { get; set; }
                /// <summary>
                /// 小格是否有空余柜口
                /// </summary>
                [JsonProperty("hasSmallBox")]
                public bool? HasSmallBox { get; set; }
                /// <summary>
                /// 是否可用
                /// </summary>
                [JsonProperty("inUse")]
                public bool? InUse { get; set; }
                /// <summary>
                /// 柜子所在的维度
                /// </summary>
                [JsonProperty("lat")]
                public string Lat { get; set; }
                /// <summary>
                /// 柜子所在的经度
                /// </summary>
                [JsonProperty("lng")]
                public string Lng { get; set; }
                /// <summary>
                /// 柜子所在的省
                /// </summary>
                [JsonProperty("provName")]
                public string ProvName { get; set; }
                /// <summary>
                /// 柜子所在的街道乡镇
                /// </summary>
                [JsonProperty("streetName")]
                public string StreetName { get; set; }
                /// <summary>
                /// 是否支持寄件业务
                /// </summary>
                [JsonProperty("supportMail")]
                public bool? SupportMail { get; set; }

            }

        }

    }

}
