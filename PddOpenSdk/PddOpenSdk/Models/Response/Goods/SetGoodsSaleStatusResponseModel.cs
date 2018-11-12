using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class SetGoodsSaleStatusResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("goods_sale_status_set_response")]
        public GoodsSaleStatusSetResponseResponseModel GoodsSaleStatusSetResponse { get; set; }
        public partial class GoodsSaleStatusSetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 是否修改成功
            /// </summary>
            [JsonProperty("is_success")]
            public bool IsSuccess { get; set; }

        }

    }

}
