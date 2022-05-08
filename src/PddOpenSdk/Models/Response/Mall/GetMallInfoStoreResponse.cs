namespace PddOpenSdk.Models.Response.Mall;
public partial class GetMallInfoStoreResponse : PddResponseModel
{

    /// <summary>
    /// 返回结构体
    /// </summary>
    [JsonPropertyName("res")]
    public ResResponse Res { get; set; }
    public partial class ResResponse : PddResponseModel
    {

        /// <summary>
        /// 返回结构体
        /// </summary>
        [JsonPropertyName("mallStoreVOList")]
        public List<MallStoreVOListResponse> MallStoreVOList { get; set; }
        public partial class MallStoreVOListResponse : PddResponseModel
        {

            /// <summary>
            /// 审核状态
            /// </summary>
            [JsonPropertyName("audit_status")]
            public int? AuditStatus { get; set; }

            /// <summary>
            /// 市
            /// </summary>
            [JsonPropertyName("city")]
            public string City { get; set; }

            /// <summary>
            /// 区
            /// </summary>
            [JsonPropertyName("district")]
            public string District { get; set; }

            /// <summary>
            /// 店铺id
            /// </summary>
            [JsonPropertyName("mall_id")]
            public long? MallId { get; set; }

            /// <summary>
            /// 门店纬度
            /// </summary>
            [JsonPropertyName("poi_latitude")]
            public double? PoiLatitude { get; set; }

            /// <summary>
            /// 门店经度
            /// </summary>
            [JsonPropertyName("poi_longitude")]
            public double? PoiLongitude { get; set; }

            /// <summary>
            /// 省
            /// </summary>
            [JsonPropertyName("province")]
            public string Province { get; set; }

            /// <summary>
            /// 门店详细地址
            /// </summary>
            [JsonPropertyName("store_address")]
            public string StoreAddress { get; set; }

            /// <summary>
            /// 门店id
            /// </summary>
            [JsonPropertyName("store_id")]
            public long? StoreId { get; set; }

            /// <summary>
            /// 门店名称
            /// </summary>
            [JsonPropertyName("store_name")]
            public string StoreName { get; set; }

            /// <summary>
            /// 门店自有编号
            /// </summary>
            [JsonPropertyName("store_number")]
            public string StoreNumber { get; set; }

        }

    }

}

