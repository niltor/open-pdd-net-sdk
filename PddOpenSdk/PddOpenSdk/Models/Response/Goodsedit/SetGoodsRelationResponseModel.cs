using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goodsedit
{
    public partial class SetGoodsRelationResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_relation_set_response")]
        public GoodsRelationSetResponseResponseModel GoodsRelationSetResponse { get; set; }
        public partial class GoodsRelationSetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 是否成功
            /// </summary>
            [JsonProperty("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}
