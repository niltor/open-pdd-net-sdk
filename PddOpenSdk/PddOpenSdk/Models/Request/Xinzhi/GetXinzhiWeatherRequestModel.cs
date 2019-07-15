using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Xinzhi
{
    public partial class GetXinzhiWeatherRequestModel : PddRequestModel
    {
        /// <summary>
        /// 对应地址，可以是：城市、ip等
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }
        /// <summary>
        /// 对应语言
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }
        /// <summary>
        /// 对应单位表达
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }

    }

}
