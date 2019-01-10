using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ddkall
{
    public partial class GenerateDdkOauthGoodsPidResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("p_id_generate_response")]
        public PIdGenerateResponseResponseModel PIdGenerateResponse { get; set; }
        public partial class PIdGenerateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 多多进宝推广位对象列表
            /// </summary>
            [JsonProperty("p_id_list")]
            public List<PIdListResponseModel> PIdList { get; set; }
            public partial class PIdListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 推广位名称
                /// </summary>
                [JsonProperty("p_id_name")]
                public string PIdName { get; set; }
                /// <summary>
                /// 调用方推广位ID
                /// </summary>
                [JsonProperty("p_id")]
                public string PId { get; set; }

            }

        }

    }

}
