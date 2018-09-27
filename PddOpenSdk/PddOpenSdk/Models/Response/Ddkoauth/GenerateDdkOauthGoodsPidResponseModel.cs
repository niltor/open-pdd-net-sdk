using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddkoauth
{
    public class GeneratePIdList
    {

        /// <summary>
        /// Examples: "1000098_14222229", "1000098_14222230"
        /// </summary>
        [JsonProperty("p_id")]
        public string PId { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("p_id_name")]
        public object PIdName { get; set; }
    }

    public class PIdGenerateResponse
    {

        /// <summary>
        /// Examples: [{"p_id":"1000098_14222229","p_id_name":null},{"p_id":"1000098_14222230","p_id_name":null}]
        /// </summary>
        [JsonProperty("p_id_list")]
        public IList<GeneratePIdList> PIdList { get; set; }
    }

    public class GenerateDdkOauthGoodsPidResponseModel
    {

        /// <summary>
        /// Examples: {"p_id_list":[{"p_id":"1000098_14222229","p_id_name":null},{"p_id":"1000098_14222230","p_id_name":null}]}
        /// </summary>
        [JsonProperty("p_id_generate_response")]
        public PIdGenerateResponse PIdGenerateResponse { get; set; }
    }


}
