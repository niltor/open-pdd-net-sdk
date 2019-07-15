using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goodsedit
{
    public partial class GetGoodsCatTemplateRequestModel : PddRequestModel
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [JsonProperty("cat_id")]
        public long CatId { get; set; }

    }

}
