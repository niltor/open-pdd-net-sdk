using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetGoodsLogisticsTemplateResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回的运费模板总数
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
        /// <summary>
        /// 商家运费模板对象列表
        /// </summary>
        [JsonProperty("logistics_template_list")]
        public object LogisticsTemplateList { get; set; }

        public partial class LogisticsTemplateListResponseModel : PddResponseModel
        {

        }

    }
}
