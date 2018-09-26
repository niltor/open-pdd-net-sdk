using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddkoauth
{
    public class PIdList
    {

        /// <summary>
        /// Examples: "81_1812886", "81_1812888", "81_1812889", "81_1812890", "81_1812891"
        /// </summary>
        [JsonProperty("p_id")]
        public string PId { get; set; }

        /// <summary>
        /// Examples: 1517724155, 1517916590, 1517916634, 1517917263, 1517917855
        /// </summary>
        [JsonProperty("create_time")]
        public int CreateTime { get; set; }
    }

    public class PIdQueryResponse
    {

        /// <summary>
        /// Examples: [{"p_id":"81_1812886","create_time":1517724155},{"p_id":"81_1812888","create_time":1517916590},{"p_id":"81_1812889","create_time":1517916590},{"p_id":"81_1812890","create_time":1517916634},{"p_id":"81_1812891","create_time":1517916634},{"p_id":"81_1812892","create_time":1517917263},{"p_id":"81_1812893","create_time":1517917263},{"p_id":"81_1812894","create_time":1517917855},{"p_id":"81_1812895","create_time":1517917855},{"p_id":"81_1812896","create_time":1517917862}]
        /// </summary>
        [JsonProperty("p_id_list")]
        public IList<PIdList> PIdList { get; set; }

        /// <summary>
        /// Examples: 17
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class QueryDdkOauthGoodsPidResponseModel
    {

        /// <summary>
        /// Examples: {"p_id_list":[{"p_id":"81_1812886","create_time":1517724155},{"p_id":"81_1812888","create_time":1517916590},{"p_id":"81_1812889","create_time":1517916590},{"p_id":"81_1812890","create_time":1517916634},{"p_id":"81_1812891","create_time":1517916634},{"p_id":"81_1812892","create_time":1517917263},{"p_id":"81_1812893","create_time":1517917263},{"p_id":"81_1812894","create_time":1517917855},{"p_id":"81_1812895","create_time":1517917855},{"p_id":"81_1812896","create_time":1517917862}],"total_count":17}
        /// </summary>
        [JsonProperty("p_id_query_response")]
        public PIdQueryResponse PIdQueryResponse { get; set; }
    }


}
