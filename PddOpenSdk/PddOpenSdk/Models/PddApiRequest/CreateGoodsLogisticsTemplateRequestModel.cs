using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class CreateGoodsLogisticsTemplateRequestModel : PddRequestModel
    {
        /// <summary>
        /// 非包邮模版列表
        /// </summary>
        [JsonProperty("cost_template_list")]
        public object CostTemplateList { get; set; }
        /// <summary>
        /// 包邮地区
        /// </summary>
        [JsonProperty("free_province_list")]
        public object FreeProvinceList { get; set; }
        /// <summary>
        /// 送货入户区域
        /// </summary>
        [JsonProperty("free_deliver_house_area_list")]
        public object FreeDeliverHouseAreaList { get; set; }
        /// <summary>
        /// 计费方式，0-按件计费，1-按重量计费
        /// </summary>
        [JsonProperty("cost_type")]
        public int CostType { get; set; }
        /// <summary>
        /// 是否送货入户
        /// </summary>
        [JsonProperty("free_deliver_house")]
        public bool FreeDeliverHouse { get; set; }
        /// <summary>
        /// 运费模板名称
        /// </summary>
        [JsonProperty("template_name")]
        public object TemplateName { get; set; }

        public partial class CostTemplateListRequestModel : PddRequestModel
        {

        }

        public partial class FreeProvinceListRequestModel : PddRequestModel
        {

        }

        public partial class FreeDeliverHouseAreaListRequestModel : PddRequestModel
        {

        }

    }
}
