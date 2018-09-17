using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class GetGoodsOptRequestModel : PddRequestModel
    {
        /// <summary>
        /// 值=0时为顶点opt_id,通过树顶级节点获取opt树
        /// </summary>
        [JsonProperty("parent_opt_id")]
        public int ParentOptId { get; set; }

    }
}
