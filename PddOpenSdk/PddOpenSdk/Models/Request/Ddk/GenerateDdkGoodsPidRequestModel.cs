using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class GenerateDdkGoodsPidRequestModel : PddRequestModel
    {
        /// <summary>
        /// 该值为：pdd.ddk.goods.pid.generate
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// 要生成的推广位数量，默认为10，范围为：1~100
        /// </summary>
        [JsonProperty("number")]
        public int Number { get; set; }
        /// <summary>
        /// 推广位名称，例如["1","2"]
        /// </summary>
        [JsonProperty("p_id_name_list")]
        public string PIdNameList { get; set; }

    }

}
