using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class GetGoodsSpecRequestModel : PddRequestModel {
        /// <summary>
        /// 叶子类目ID，必须入参level=3时的cat_id,否则无法返回正确的参数
        /// </summary>
        [JsonProperty ("cat_id")]
        public long CatId { get; set; }

    }

}