using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public partial class GetDdkGoodsBasicInfoResponseModel : PddResponseModel {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty ("goods_basic_detail_response")]
        public GoodsBasicDetailResponseResponseModel GoodsBasicDetailResponse { get; set; }
        public partial class GoodsBasicDetailResponseResponseModel : PddResponseModel {
            /// <summary>
            /// list
            /// </summary>
            [JsonProperty ("goods_list")]
            public List<GoodsListResponseModel> GoodsList { get; set; }
            public partial class GoodsListResponseModel : PddResponseModel {
                /// <summary>
                /// 商品id
                /// </summary>
                [JsonProperty ("goods_id")]
                public long? GoodsId { get; set; }
                /// <summary>
                /// 最小单买价格，单位分
                /// </summary>
                [JsonProperty ("min_normal_price")]
                public long? MinNormalPrice { get; set; }
                /// <summary>
                /// 最小成团价格，单位分
                /// </summary>
                [JsonProperty ("min_group_price")]
                public long? MinGroupPrice { get; set; }
                /// <summary>
                /// 商品缩略图
                /// </summary>
                [JsonProperty ("goods_pic")]
                public string GoodsPic { get; set; }
                /// <summary>
                /// 商品标题
                /// </summary>
                [JsonProperty ("goods_name")]
                public string GoodsName { get; set; }

            }

        }

    }

}