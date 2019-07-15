using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goodsedit
{
    public partial class ChangeGoodsCpsMallUnitRequestModel : PddRequestModel
    {
        /// <summary>
        /// 全店推广计划佣金比（千分比）
        /// </summary>
        [JsonProperty("rate")]
        public int? Rate { get; set; }

    }

}
