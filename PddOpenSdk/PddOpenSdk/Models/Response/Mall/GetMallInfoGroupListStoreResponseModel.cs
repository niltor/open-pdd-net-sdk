using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Mall
{
    public partial class GetMallInfoGroupListStoreResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mall_info_group_list_store_get_response")]
        public MallInfoGroupListStoreGetResponseResponseModel MallInfoGroupListStoreGetResponse { get; set; }
        public partial class MallInfoGroupListStoreGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 门店列表
            /// </summary>
            [JsonProperty("mall_store_final_vo_list")]
            public List<MallStoreFinalVoListResponseModel> MallStoreFinalVoList { get; set; }
            /// <summary>
            /// 总数
            /// </summary>
            [JsonProperty("total")]
            public int? Total { get; set; }
            public partial class MallStoreFinalVoListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 门店经营状态
                /// </summary>
                [JsonProperty("businessStatus")]
                public int? BusinessStatus { get; set; }
                /// <summary>
                /// 省市区三级地址-市
                /// </summary>
                [JsonProperty("city")]
                public string City { get; set; }
                /// <summary>
                /// 省市区三级地址-区
                /// </summary>
                [JsonProperty("district")]
                public string District { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("exists")]
                public bool? Exists { get; set; }
                /// <summary>
                /// 省市区三级地址-省
                /// </summary>
                [JsonProperty("province")]
                public string Province { get; set; }
                /// <summary>
                /// 门店地址
                /// </summary>
                [JsonProperty("storeAddress")]
                public string StoreAddress { get; set; }
                /// <summary>
                /// 门店ID
                /// </summary>
                [JsonProperty("storeId")]
                public long? StoreId { get; set; }
                /// <summary>
                /// 店铺名称
                /// </summary>
                [JsonProperty("storeName")]
                public string StoreName { get; set; }
                /// <summary>
                /// 门店自有编号
                /// </summary>
                [JsonProperty("storeNumber")]
                public string StoreNumber { get; set; }

            }

        }

    }

}
