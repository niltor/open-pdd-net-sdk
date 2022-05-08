namespace PddOpenSdk.Models.Response.Stock;
public partial class QueryStockWareWarehouseResponse : PddResponseModel
{

    /// <summary>
    /// 查询结果
    /// </summary>
    [JsonPropertyName("result")]
    public ResultResponse Result { get; set; }
    public partial class ResultResponse : PddResponseModel
    {

        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("total")]
        public long? Total { get; set; }

        /// <summary>
        /// 查询结果
        /// </summary>
        [JsonPropertyName("ware_sn_warehouse_info")]
        public Dictionary<string, object> WareSnWarehouseInfo { get; set; }
        public partial class WareSnWarehouseInfoResponse : PddResponseModel
        {

            /// <summary>
            /// 货品编码
            /// </summary>
            [JsonPropertyName("$key")]
            public string Key { get; set; }

            /// <summary>
            /// 库存信息列表
            /// </summary>
            [JsonPropertyName("$value")]
            public List<ValueResponse> Value { get; set; }
            public partial class ValueResponse : PddResponseModel
            {

                /// <summary>
                /// 库存数量
                /// </summary>
                [JsonPropertyName("quantity")]
                public long? Quantity { get; set; }

                /// <summary>
                /// 仓库名称
                /// </summary>
                [JsonPropertyName("warehouse_name")]
                public string WarehouseName { get; set; }

                /// <summary>
                /// 仓库编码
                /// </summary>
                [JsonPropertyName("warehouse_sn")]
                public string WarehouseSn { get; set; }

            }

        }

    }

}

