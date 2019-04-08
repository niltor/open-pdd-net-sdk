using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class DeleteGoodsLogisticsSerTemplateResponseModel : PddResponseModel {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty ("goods_logistics_ser_template_delete_response")]
        public GoodsLogisticsSerTemplateDeleteResponseResponseModel GoodsLogisticsSerTemplateDeleteResponse { get; set; }
        public partial class GoodsLogisticsSerTemplateDeleteResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 是否成功
            /// </summary>
            [JsonProperty ("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}