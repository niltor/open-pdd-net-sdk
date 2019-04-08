using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Stock
{
    public partial class DeleteStockWareRequestModel : PddRequestModel {
        /// <summary>
        /// 货品id
        /// </summary>
        [JsonProperty ("ware_id")]
        public long WareId { get; set; }

    }

}