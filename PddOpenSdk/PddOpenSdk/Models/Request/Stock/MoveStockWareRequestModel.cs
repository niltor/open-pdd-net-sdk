using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Stock
{
    public partial class MoveStockWareRequestModel : PddRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("stock_move_order_action_dto")]
        public StockMoveOrderActionDtoRequestModel StockMoveOrderActionDto { get; set; }
        /// <summary>
        /// List<JsonObject>的json string, 一次传入StockMoveRecordActionDTO list size不超过30个
        /// </summary>
        [JsonProperty("stock_move_record_action_dto_list")]
        public StockMoveRecordActionDtoListRequestModel StockMoveRecordActionDtoList { get; set; }
        public partial class StockMoveOrderActionDtoRequestModel : PddRequestModel
        {
            /// <summary>
            /// 调整方向。1, "入库"；2, "出库"；3, "库存同步"
            /// </summary>
            [JsonProperty("move_direction")]
            public object MoveDirection { get; set; }
            /// <summary>
            /// 调整单备注
            /// </summary>
            [JsonProperty("order_note")]
            public string OrderNote { get; set; }
            /// <summary>
            /// 业务类型。1, "采购"；2, "调拨"；3, "退货"；4, "盘点"；5, "发货"；6, "库存同步"
            /// </summary>
            [JsonProperty("business_type")]
            public object BusinessType { get; set; }
            /// <summary>
            /// 仓库编码
            /// </summary>
            [JsonProperty("warehouse_sn")]
            public string WarehouseSn { get; set; }
            /// <summary>
            /// 调整时间
            /// </summary>
            [JsonProperty("move_time")]
            public object MoveTime { get; set; }
            /// <summary>
            /// 调整单号
            /// </summary>
            [JsonProperty("move_order_sn")]
            public string MoveOrderSn { get; set; }

        }
        public partial class StockMoveRecordActionDtoListRequestModel : PddRequestModel
        {
            /// <summary>
            /// 备注
            /// </summary>
            [JsonProperty("note")]
            public string Note { get; set; }
            /// <summary>
            /// 调整数量
            /// </summary>
            [JsonProperty("move_num")]
            public object MoveNum { get; set; }
            /// <summary>
            /// 货品sn
            /// </summary>
            [JsonProperty("ware_sn")]
            public string WareSn { get; set; }

        }

    }

}
