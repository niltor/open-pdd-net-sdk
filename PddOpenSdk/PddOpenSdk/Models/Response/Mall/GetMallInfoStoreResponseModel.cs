using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Mall
{
    public partial class GetMallInfoStoreResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回结构体
        /// </summary>
        [JsonProperty("res")]
        public ResResponseModel Res { get; set; }
        public partial class ResResponseModel : PddResponseModel
        {
            /// <summary>
            /// 返回结构体
            /// </summary>
            [JsonProperty("mallStoreVOList")]
            public List<MallStoreVOListResponseModel> MallStoreVOList { get; set; }
            public partial class MallStoreVOListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 审核状态
                /// </summary>
                [JsonProperty("audit_status")]
                public int? AuditStatus { get; set; }
                /// <summary>
                /// 市
                /// </summary>
                [JsonProperty("city")]
                public string City { get; set; }
                /// <summary>
                /// 区
                /// </summary>
                [JsonProperty("district")]
                public string District { get; set; }
                /// <summary>
                /// 店铺id
                /// </summary>
                [JsonProperty("mall_id")]
                public long? MallId { get; set; }
                /// <summary>
                /// 门店纬度
                /// </summary>
                [JsonProperty("poi_latitude")]
                public double? PoiLatitude { get; set; }
                /// <summary>
                /// 门店经度
                /// </summary>
                [JsonProperty("poi_longitude")]
                public double? PoiLongitude { get; set; }
                /// <summary>
                /// 省
                /// </summary>
                [JsonProperty("province")]
                public string Province { get; set; }
                /// <summary>
                /// 门店详细地址
                /// </summary>
                [JsonProperty("store_address")]
                public string StoreAddress { get; set; }
                /// <summary>
                /// 门店id
                /// </summary>
                [JsonProperty("store_id")]
                public long? StoreId { get; set; }
                /// <summary>
                /// 门店名称
                /// </summary>
                [JsonProperty("store_name")]
                public string StoreName { get; set; }
                /// <summary>
                /// 门店自有编号
                /// </summary>
                [JsonProperty("store_number")]
                public string StoreNumber { get; set; }

            }

        }

    }

}
