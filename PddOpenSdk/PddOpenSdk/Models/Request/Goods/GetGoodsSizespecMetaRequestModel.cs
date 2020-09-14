using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class GetGoodsSizespecMetaRequestModel : PddRequestModel
    {
        /// <summary>
        /// 尺码分类id
        /// </summary>
        [JsonProperty("class_id")]
        public int ClassId { get; set; }

    }

}
