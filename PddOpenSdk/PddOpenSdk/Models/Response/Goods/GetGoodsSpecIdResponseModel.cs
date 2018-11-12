using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class GetGoodsSpecIdResponseModel : PddResponseModel
    {
        /// <summary>
        /// 生成规格响应对象
        /// </summary>
        [JsonProperty("goods_spec_id_get_response")]
        public GoodsSpecIdGetResponseResponseModel GoodsSpecIdGetResponse { get; set; }
        public partial class GoodsSpecIdGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 自定义规格所属的规格ID
            /// </summary>
            [JsonProperty("parent_spec_id")]
            public long? ParentSpecId { get; set; }
            /// <summary>
            /// 生成的自定义规格名称
            /// </summary>
            [JsonProperty("spec_name")]
            public string SpecName { get; set; }
            /// <summary>
            /// 生成的自定义规格ID
            /// </summary>
            [JsonProperty("spec_id")]
            public long? SpecId { get; set; }

        }

    }

}
