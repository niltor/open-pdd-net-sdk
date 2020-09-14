using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class DeleteAdApiUnitCreativeRequestModel : PddRequestModel
    {
        /// <summary>
        /// 创意单元Id
        /// </summary>
        [JsonProperty("unitCreativeId")]
        public long UnitCreativeId { get; set; }

    }

}
