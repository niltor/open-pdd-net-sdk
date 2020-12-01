using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Stock
{
    public partial class QueryStockWareWarehouseResponseModel : PddResponseModel
    {
        /// <summary>
        /// 查询结果
        /// </summary>
        [JsonProperty("result")]
        public ResultResponseModel Result { get; set; }
        public partial class ResultResponseModel : PddResponseModel
        {
            /// <summary>
            /// 总数
            /// </summary>
            [JsonProperty("total")]
            public long? Total { get; set; }
            /// <summary>
            /// 查询结果
            /// </summary>
            [JsonProperty("ware_sn_warehouse_info")]
            public Dictionary<string, object> WareSnWarehouseInfo { get; set; }
            public partial class WareSnWarehouseInfoResponseModel : PddResponseModel
            {
                /// <summary>
                /// 货品编码
                /// </summary>
                [JsonProperty("$key")]
                public string Key { get; set; }
                /// <summary>
                /// 库存信息列表
                /// </summary>
                [JsonProperty("$value")]
                public List<ValueResponseModel> Value { get; set; }
                public partial class ValueResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 库存数量
                    /// </summary>
                    [JsonProperty("quantity")]
                    public long? Quantity { get; set; }
                    /// <summary>
                    /// 仓库名称
                    /// </summary>
                    [JsonProperty("warehouse_name")]
                    public string WarehouseName { get; set; }
                    /// <summary>
                    /// 仓库编码
                    /// </summary>
                    [JsonProperty("warehouse_sn")]
                    public string WarehouseSn { get; set; }

                }

            }

        }

    }

}
