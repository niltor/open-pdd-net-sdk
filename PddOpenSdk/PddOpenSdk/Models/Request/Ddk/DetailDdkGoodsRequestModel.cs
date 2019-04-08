using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class DetailDdkGoodsRequestModel : PddRequestModel {
        /// <summary>
        /// 商品ID，仅支持单个查询。例如：[123456]
        /// </summary>
        [JsonProperty ("goods_id_list")]
        public List<long> GoodsIdList { get; set; }
        /// <summary>
        /// 推广位id
        /// </summary>
        [JsonProperty ("pid")]
        public string Pid { get; set; }
        /// <summary>
        /// 自定义参数
        /// </summary>
        [JsonProperty ("custom_parameters")]
        public string CustomParameters { get; set; }
        /// <summary>
        /// 招商多多客ID
        /// </summary>
        [JsonProperty ("zs_duo_id")]
        public long? ZsDuoId { get; set; }
        /// <summary>
        /// 佣金优惠券对应推广类型，3：专属 4：招商
        /// </summary>
        [JsonProperty ("plan_type")]
        public int PlanType { get; set; }

    }

}