using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class UpdateGoodsSkuStockIncrementResponseModel : PddResponseModel
    {
        /// <summary>
        /// sku增量库存修改响应对象
        /// </summary>
        [JsonProperty("sku_stock_increment_update_response")]
        public object SkuStockIncrementUpdateResponse { get; set; }

        public partial class SkuStockIncrementUpdateResponseResponseModel : PddResponseModel
        {

        }

    }
}
