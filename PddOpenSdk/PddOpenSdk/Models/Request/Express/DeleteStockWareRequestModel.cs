using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Express
{
    public partial class DeleteStockWareRequestModel : PddRequestModel
    {
        /// <summary>
        /// 货品id
        /// </summary>
        [JsonProperty("ware_id")]
        public long WareId { get; set; }

    }

}
