using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class DeleteAdPlanResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("ad_plan_delete_response")]
        public AdPlanDeleteResponseResponseModel AdPlanDeleteResponse { get; set; }
        public partial class AdPlanDeleteResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 是否成功
            /// </summary>
            [JsonProperty("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}
