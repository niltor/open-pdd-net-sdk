using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Logistics
{
    public partial class GetLogisticsAddressResponseModel : PddResponseModel {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty ("logistics_address_get_response")]
        public LogisticsAddressGetResponseResponseModel LogisticsAddressGetResponse { get; set; }
        public partial class LogisticsAddressGetResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 地址对象列表
            /// </summary>
            [JsonProperty ("logistics_address_list")]
            public List<LogisticsAddressListResponseModel> LogisticsAddressList { get; set; }
            public partial class LogisticsAddressListResponseModel : PddResponseModel {
                /// <summary>
                /// 是否有效，0-无效，1-有效
                /// </summary>
                [JsonProperty ("is_enabled")]
                public int IsEnabled { get; set; }
                /// <summary>
                /// 地区邮编
                /// </summary>
                [JsonProperty ("national_code")]
                public string NationalCode { get; set; }
                /// <summary>
                /// 地区层级，1-省份，2-市级，3-区级
                /// </summary>
                [JsonProperty ("region_type")]
                public int RegionType { get; set; }
                /// <summary>
                /// 地区名称
                /// </summary>
                [JsonProperty ("region_name")]
                public string RegionName { get; set; }
                /// <summary>
                /// 父地区ID，顶点id为0
                /// </summary>
                [JsonProperty ("parent_id")]
                public long? ParentId { get; set; }
                /// <summary>
                /// 地区ID
                /// </summary>
                [JsonProperty ("id")]
                public long? Id { get; set; }

            }

        }

    }

}