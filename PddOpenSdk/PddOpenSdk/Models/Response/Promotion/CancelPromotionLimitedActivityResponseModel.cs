using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Promotion
{
    public partial class CancelPromotionLimitedActivityResponseModel : PddResponseModel
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonProperty("result")]
        public bool? Result { get; set; }

    }

}
