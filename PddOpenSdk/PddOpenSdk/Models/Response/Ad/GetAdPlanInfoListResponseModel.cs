using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class GetAdPlanInfoListResponseModel : PddResponseModel
    {
        /// <summary>
        /// 计划基础信息表
        /// </summary>
        [JsonProperty("ad_plan_info_list_response")]
        public AdPlanInfoListResponseResponseModel AdPlanInfoListResponse { get; set; }
        public partial class AdPlanInfoListResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 计划基础信息对象
            /// </summary>
            [JsonProperty("plan_info_list")]
            public List<PlanInfoListResponseModel> PlanInfoList { get; set; }
            public partial class PlanInfoListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 推广单元个数
                /// </summary>
                [JsonProperty("unit_num")]
                public long? UnitNum { get; set; }
                /// <summary>
                /// 计划日限额，单位厘
                /// </summary>
                [JsonProperty("max_cost")]
                public long? MaxCost { get; set; }
                /// <summary>
                /// 1 - 余额充足 2 - 余额不足 3 - 超出消耗上限
                /// </summary>
                [JsonProperty("merchant_account_status")]
                public int? MerchantAccountStatus { get; set; }
                /// <summary>
                /// 1 - 已启用 2 - 已暂停
                /// </summary>
                [JsonProperty("merchant_operate_status")]
                public int? MerchantOperateStatus { get; set; }
                /// <summary>
                /// 0 - 搜索广告
                /// </summary>
                [JsonProperty("scene_type")]
                public int? SceneType { get; set; }
                /// <summary>
                /// 计划名
                /// </summary>
                [JsonProperty("plan_name")]
                public string PlanName { get; set; }
                /// <summary>
                /// 计划id
                /// </summary>
                [JsonProperty("plan_id")]
                public long? PlanId { get; set; }

            }

        }

    }

}
