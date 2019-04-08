using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Express
{
    public partial class GetExpressDepotInfoRequestModel : PddRequestModel
    {
        /// <summary>
        /// 仓库id
        /// </summary>
        [JsonProperty("depot_id")]
        public long DepotId { get; set; }

    }

}
