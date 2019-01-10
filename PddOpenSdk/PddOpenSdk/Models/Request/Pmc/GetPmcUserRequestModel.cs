using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Pmc
{
    public partial class GetPmcUserRequestModel : PddRequestModel
    {
        /// <summary>
        /// 用户唯一id
        /// </summary>
        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

    }

}
