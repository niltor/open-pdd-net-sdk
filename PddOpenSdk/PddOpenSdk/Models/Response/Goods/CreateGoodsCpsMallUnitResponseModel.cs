using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class CreateGoodsCpsMallUnitResponseModel : PddResponseModel
    {
        /// <summary>
        /// 是否创建成功
        /// </summary>
        [JsonProperty("is_create_success")]
        public bool? IsCreateSuccess { get; set; }

    }

}
