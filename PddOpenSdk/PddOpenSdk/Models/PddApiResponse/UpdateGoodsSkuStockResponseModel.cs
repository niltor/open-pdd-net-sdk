using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class UpdateGoodsSkuStockResponseModel : PddResponseModel
    {
        /// <summary>
        /// 全量库存更新响应对象
        /// </summary>
        [JsonProperty("sku_stock_update_response")]
        public SkuStockUpdateResponseResponseModel SkuStockUpdateResponse { get; set; }

        public partial class SkuStockUpdateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 全量更新是否成功，true-成功，false-失败
            /// </summary>
            [JsonProperty("is_success")]
            public bool IsSuccess { get; set; }

        }

    }
}
