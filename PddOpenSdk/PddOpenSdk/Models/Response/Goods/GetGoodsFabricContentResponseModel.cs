using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class GetGoodsFabricContentResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_fabric_content_get_response")]
        public GoodsFabricContentGetResponseResponseModel GoodsFabricContentGetResponse { get; set; }
        public partial class GoodsFabricContentGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 服饰成分含量对象列表
            /// </summary>
            [JsonProperty("goods_fabric_content_list")]
            public List<GoodsFabricContentListResponseModel> GoodsFabricContentList { get; set; }
            public partial class GoodsFabricContentListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 服饰成分含量 对应的ID，用于入参
                /// </summary>
                [JsonProperty("code")]
                public long? Code { get; set; }
                /// <summary>
                /// 对应ID下的服饰成分含量描述
                /// </summary>
                [JsonProperty("desc")]
                public string Desc { get; set; }

            }

        }

    }

}
