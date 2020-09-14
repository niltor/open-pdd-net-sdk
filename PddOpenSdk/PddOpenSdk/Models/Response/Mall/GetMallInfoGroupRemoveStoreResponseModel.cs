using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Mall
{
    public partial class GetMallInfoGroupRemoveStoreResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mall_info_group_remove_store_get_response")]
        public MallInfoGroupRemoveStoreGetResponseResponseModel MallInfoGroupRemoveStoreGetResponse { get; set; }
        public partial class MallInfoGroupRemoveStoreGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}
