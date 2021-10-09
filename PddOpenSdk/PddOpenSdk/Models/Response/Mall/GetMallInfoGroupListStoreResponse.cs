namespace PddOpenSdk.Models.Response.Mall;
public partial class GetMallInfoGroupListStoreResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("mall_info_group_list_store_get_response")]
    public MallInfoGroupListStoreGetResponseResponse MallInfoGroupListStoreGetResponse { get; set; }
    public partial class MallInfoGroupListStoreGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 门店列表
        /// </summary>
        [JsonPropertyName("mall_store_final_vo_list")]
        public List<MallStoreFinalVoListResponse> MallStoreFinalVoList { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("total")]
        public int? Total { get; set; }
        public partial class MallStoreFinalVoListResponse : PddResponseModel
        {

            /// <summary>
            /// 门店经营状态
            /// </summary>
            [JsonPropertyName("businessStatus")]
            public int? BusinessStatus { get; set; }

            /// <summary>
            /// 省市区三级地址-市
            /// </summary>
            [JsonPropertyName("city")]
            public string City { get; set; }

            /// <summary>
            /// 省市区三级地址-区
            /// </summary>
            [JsonPropertyName("district")]
            public string District { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("exists")]
            public bool? Exists { get; set; }

            /// <summary>
            /// 省市区三级地址-省
            /// </summary>
            [JsonPropertyName("province")]
            public string Province { get; set; }

            /// <summary>
            /// 门店地址
            /// </summary>
            [JsonPropertyName("storeAddress")]
            public string StoreAddress { get; set; }

            /// <summary>
            /// 门店ID
            /// </summary>
            [JsonPropertyName("storeId")]
            public long? StoreId { get; set; }

            /// <summary>
            /// 店铺名称
            /// </summary>
            [JsonPropertyName("storeName")]
            public string StoreName { get; set; }

            /// <summary>
            /// 门店自有编号
            /// </summary>
            [JsonPropertyName("storeNumber")]
            public string StoreNumber { get; set; }

        }

    }

}

