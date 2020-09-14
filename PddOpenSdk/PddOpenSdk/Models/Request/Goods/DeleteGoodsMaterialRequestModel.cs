using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class DeleteGoodsMaterialRequestModel : PddRequestModel
    {
        /// <summary>
        /// 素材id
        /// </summary>
        [JsonProperty("material_id")]
        public long MaterialId { get; set; }

    }

}
