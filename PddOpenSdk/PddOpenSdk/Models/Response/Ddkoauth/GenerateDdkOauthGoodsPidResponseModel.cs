using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddkoauth
{
    public partial class GenerateDdkOauthGoodsPidResponseModel : PddResponseModel {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty ("p_id_generate_response")]
        public PIdGenerateResponseResponseModel PIdGenerateResponse { get; set; }
        public partial class PIdGenerateResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 多多进宝推广位对象列表
            /// </summary>
            [JsonProperty ("p_id_list")]
            public List<PIdListResponseModel> PIdList { get; set; }
            public partial class PIdListResponseModel : PddResponseModel {
                /// <summary>
                /// 推广位创建时间
                /// </summary>
                [JsonProperty ("create_time")]
                public int CreateTime { get; set; }
                /// <summary>
                /// 调用方推广位ID
                /// </summary>
                [JsonProperty ("p_id")]
                public int PId { get; set; }
                /// <summary>
                /// 推广位名称
                /// </summary>
                [JsonProperty ("pid_name")]
                public int PidName { get; set; }

            }

        }

    }

}