using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class CatsGoodsAuthorizationResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_auth_cats_get_response")]
        public GoodsAuthCatsGetResponseResponseModel GoodsAuthCatsGetResponse { get; set; }
        public partial class GoodsAuthCatsGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 类目对象列表
            /// </summary>
            [JsonProperty("goods_cats_list")]
            public List<GoodsCatsListResponseModel> GoodsCatsList { get; set; }
            public partial class GoodsCatsListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 类目ID，一级类目ID
                /// </summary>
                [JsonProperty("cat_id")]
                public long? CatId { get; set; }
                /// <summary>
                /// 对应ID下的类目名称
                /// </summary>
                [JsonProperty("cat_name")]
                public string CatName { get; set; }
                /// <summary>
                /// 是否为叶子类目
                /// </summary>
                [JsonProperty("leaf")]
                public bool? Leaf { get; set; }

            }

        }

    }

}
