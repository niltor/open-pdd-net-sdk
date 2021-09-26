using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.MallShop
{
    public partial class InfoTraceSourceQueryGoodsResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回参数
        /// </summary>
        [JsonProperty("response")]
        public string Response { get; set; }

    }

}
