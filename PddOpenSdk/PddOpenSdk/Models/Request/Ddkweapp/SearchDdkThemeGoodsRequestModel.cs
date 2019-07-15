using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddkweapp
{
    public partial class SearchDdkThemeGoodsRequestModel : PddRequestModel
    {
        /// <summary>
        /// 主题ID
        /// </summary>
        [JsonProperty("theme_id")]
        public long ThemeId { get; set; }

    }

}
