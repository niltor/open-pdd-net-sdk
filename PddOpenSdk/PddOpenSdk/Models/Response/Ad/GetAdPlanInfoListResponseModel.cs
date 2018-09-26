using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class PlanInfoList
    {

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("plan_id")]
        public object PlanId { get; set; }

        /// <summary>
        /// Examples: "计划-搜索1-改", "计划1"
        /// </summary>
        [JsonProperty("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("scene_type")]
        public int SceneType { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("merchant_operate_status")]
        public int MerchantOperateStatus { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("merchant_account_status")]
        public int MerchantAccountStatus { get; set; }

        /// <summary>
        /// Examples: 1000000000
        /// </summary>
        [JsonProperty("max_cost")]
        public int MaxCost { get; set; }

        /// <summary>
        /// Examples: null, 1
        /// </summary>
        [JsonProperty("unit_num")]
        public int? UnitNum { get; set; }
    }

    public class AdPlanInfoListResponse
    {

        /// <summary>
        /// Examples: [{"plan_id":null,"plan_name":"计划-搜索1-改","scene_type":0,"merchant_operate_status":1,"merchant_account_status":1,"max_cost":1000000000,"unit_num":1},{"plan_id":null,"plan_name":"计划1","scene_type":0,"merchant_operate_status":1,"merchant_account_status":1,"max_cost":1000000000,"unit_num":null}]
        /// </summary>
        [JsonProperty("plan_info_list")]
        public IList<PlanInfoList> PlanInfoList { get; set; }
    }

    public class GetAdPlanInfoListResponseModel
    {

        /// <summary>
        /// Examples: {"plan_info_list":[{"plan_id":null,"plan_name":"计划-搜索1-改","scene_type":0,"merchant_operate_status":1,"merchant_account_status":1,"max_cost":1000000000,"unit_num":1},{"plan_id":null,"plan_name":"计划1","scene_type":0,"merchant_operate_status":1,"merchant_account_status":1,"max_cost":1000000000,"unit_num":null}]}
        /// </summary>
        [JsonProperty("ad_plan_info_list_response")]
        public AdPlanInfoListResponse AdPlanInfoListResponse { get; set; }
    }


}
