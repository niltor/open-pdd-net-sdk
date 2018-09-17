using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class UpdateGoodsSkuStockResponseModel : PddResponseModel
    {
        /// <summary>
        /// 全量库存更新响应对象
        /// </summary>
        [JsonProperty("sku_stock_update_response")]
        public object SkuStockUpdateResponse { get; set; }

        public partial class SkuStockUpdateResponseResponseModel : PddResponseModel
        {

        }

    }
}
