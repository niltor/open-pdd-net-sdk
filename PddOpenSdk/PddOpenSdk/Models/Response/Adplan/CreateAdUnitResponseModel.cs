using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Adplan
{
    public partial class CreateAdUnitResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("ad_unit_create_response")]
        public AdUnitCreateResponseResponseModel AdUnitCreateResponse { get; set; }
        public partial class AdUnitCreateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 单元id
            /// </summary>
            [JsonProperty("unit_id")]
            public long? UnitId { get; set; }
            /// <summary>
            /// 是否成功
            /// </summary>
            [JsonProperty("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}
