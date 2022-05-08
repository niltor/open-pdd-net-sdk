namespace PddOpenSdk.Models.Request.Stock;
public partial class MoveStockWare
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("stock_move_order_action_dto")]
    public StockMoveOrderActionDtoModel StockMoveOrderActionDto { get; set; }

    /// <summary>
    /// List<JsonObject>的json string, 一次传入StockMoveRecordActionDTO list size不超过30个
    /// </summary>
    [JsonPropertyName("stock_move_record_action_dto_list")]
    public List<StockMoveRecordActionDtoListModel> StockMoveRecordActionDtoList { get; set; }
    public partial class StockMoveOrderActionDtoModel
    {

        /// <summary>
        /// 调整方向。1, "入库"；2, "出库"；3, "库存同步"
        /// </summary>
        [JsonPropertyName("move_direction")]
        public int MoveDirection { get; set; }

        /// <summary>
        /// 调整单备注
        /// </summary>
        [JsonPropertyName("order_note")]
        public string OrderNote { get; set; }

        /// <summary>
        /// 业务类型。1, "采购"；2, "调拨"；3, "退货"；4, "盘点"；5, "发货"；6, "库存同步"
        /// </summary>
        [JsonPropertyName("business_type")]
        public int BusinessType { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonPropertyName("warehouse_sn")]
        public string WarehouseSn { get; set; }

        /// <summary>
        /// 调整时间
        /// </summary>
        [JsonPropertyName("move_time")]
        public long MoveTime { get; set; }

        /// <summary>
        /// 调整单号
        /// </summary>
        [JsonPropertyName("move_order_sn")]
        public string MoveOrderSn { get; set; }

    }
    public partial class StockMoveRecordActionDtoListModel
    {

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("note")]
        public string Note { get; set; }

        /// <summary>
        /// 调整数量
        /// </summary>
        [JsonPropertyName("move_num")]
        public long MoveNum { get; set; }

        /// <summary>
        /// 货品sn
        /// </summary>
        [JsonPropertyName("ware_sn")]
        public string WareSn { get; set; }

    }

}

