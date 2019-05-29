using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
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
