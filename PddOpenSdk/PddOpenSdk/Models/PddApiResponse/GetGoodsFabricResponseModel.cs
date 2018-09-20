using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class GetGoodsFabricResponseModel : PddResponseModel
    {
        /// <summary>
        /// 服饰面料对象列表
        /// </summary>
        [JsonProperty("goods_fabric_list")]
        public GoodsFabricListResponseModel GoodsFabricList { get; set; }

        public partial class GoodsFabricListResponseModel : PddResponseModel
        {
            /// <summary>
            /// 服饰面料对应的ID，用于入参
            /// </summary>
            [JsonProperty("code")]
            public int Code { get; set; }
            /// <summary>
            /// 对应ID下的服饰面料描述
            /// </summary>
            [JsonProperty("desc")]
            public string Desc { get; set; }

        }

    }
}
