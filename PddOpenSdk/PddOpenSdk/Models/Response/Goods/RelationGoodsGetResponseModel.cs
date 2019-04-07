using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class RelationGoodsGetResponseModel : PddResponseModel {
        /// <summary>
        /// 映射关系查询返回对象列表
        /// </summary>
        [JsonProperty ("query_goods_relation_response")]
        public List<QueryGoodsRelationResponseResponseModel> QueryGoodsRelationResponse { get; set; }
        public partial class QueryGoodsRelationResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 拼多多商品id
            /// </summary>
            [JsonProperty ("pdd_goods_id")]
            public long? PddGoodsId { get; set; }
            /// <summary>
            /// 外部平台枚举值， 淘宝/天猫 0，京东1，1688 2，唯品会3，苏宁4，亚马逊,5，网易6，其他7
            /// </summary>
            [JsonProperty ("out_goods_platform")]
            public int OutGoodsPlatform { get; set; }
            /// <summary>
            /// 外部平台商品id
            /// </summary>
            [JsonProperty ("out_goods_id")]
            public string OutGoodsId { get; set; }

        }

    }

}