using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Virtual
{
    public partial class QueryVirtualGameServerResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("game_server_query_response")]
        public GameServerQueryResponseResponseModel GameServerQueryResponse { get; set; }
        public partial class GameServerQueryResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 区服信息
            /// </summary>
            [JsonProperty("item_list")]
            public List<ItemListResponseModel> ItemList { get; set; }
            /// <summary>
            /// 游戏CODE
            /// </summary>
            [JsonProperty("goods_config_code")]
            public string GoodsConfigCode { get; set; }
            /// <summary>
            /// 游戏配置名称
            /// </summary>
            [JsonProperty("goods_config_name")]
            public string GoodsConfigName { get; set; }
            /// <summary>
            /// 游戏ID
            /// </summary>
            [JsonProperty("goods_config_id")]
            public long? GoodsConfigId { get; set; }
            public partial class ItemListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 下级区服信息
                /// </summary>
                [JsonProperty("children")]
                public List<ChildrenResponseModel> Children { get; set; }
                /// <summary>
                /// 区服ID
                /// </summary>
                [JsonProperty("id")]
                public long? Id { get; set; }
                /// <summary>
                /// 名称
                /// </summary>
                [JsonProperty("name")]
                public string Name { get; set; }
                /// <summary>
                /// 类型 1-区 2-服
                /// </summary>
                [JsonProperty("type")]
                public int? Type { get; set; }
                public partial class ChildrenResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 区服ID
                    /// </summary>
                    [JsonProperty("id")]
                    public long? Id { get; set; }
                    /// <summary>
                    /// 名称
                    /// </summary>
                    [JsonProperty("name")]
                    public string Name { get; set; }
                    /// <summary>
                    /// 类型 1-区 2-服
                    /// </summary>
                    [JsonProperty("type")]
                    public int? Type { get; set; }

                }

            }

        }

    }

}
