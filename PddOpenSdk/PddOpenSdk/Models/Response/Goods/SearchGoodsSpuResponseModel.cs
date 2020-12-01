using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class SearchGoodsSpuResponseModel : PddResponseModel
    {
        /// <summary>
        /// 标品搜索查询结果
        /// </summary>
        [JsonProperty("spu_search_response")]
        public SpuSearchResponseResponseModel SpuSearchResponse { get; set; }
        public partial class SpuSearchResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 标品列表
            /// </summary>
            [JsonProperty("spu_list")]
            public List<SpuListResponseModel> SpuList { get; set; }
            public partial class SpuListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 标品所在的类目ID。若非叶子类目，表示该标品可用于该类目下的任何叶子类目。
                /// </summary>
                [JsonProperty("cat_id")]
                public long? CatId { get; set; }
                /// <summary>
                /// 关键属性
                /// </summary>
                [JsonProperty("key_prop")]
                public List<KeyPropResponseModel> KeyProp { get; set; }
                /// <summary>
                /// 标品标题
                /// </summary>
                [JsonProperty("spu_name")]
                public string SpuName { get; set; }
                public partial class KeyPropResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 引用属性ID
                    /// </summary>
                    [JsonProperty("ref_pid")]
                    public long? RefPid { get; set; }
                    /// <summary>
                    /// 属性值单位
                    /// </summary>
                    [JsonProperty("value_unit")]
                    public string ValueUnit { get; set; }
                    /// <summary>
                    /// 属性值
                    /// </summary>
                    [JsonProperty("value")]
                    public string Value { get; set; }
                    /// <summary>
                    /// 属性值ID
                    /// </summary>
                    [JsonProperty("vid")]
                    public long? Vid { get; set; }

                }

            }

        }

    }

}
