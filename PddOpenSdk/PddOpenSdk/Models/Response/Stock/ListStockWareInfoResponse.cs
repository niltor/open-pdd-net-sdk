namespace PddOpenSdk.Models.Response.Stock;
public partial class ListStockWareInfoResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("stock_ware_info_list_response")]
    public StockWareInfoListResponseResponse StockWareInfoListResponse { get; set; }
    public partial class StockWareInfoListResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 货品信息列表
        /// </summary>
        [JsonPropertyName("ware_list")]
        public List<WareListResponse> WareList { get; set; }
        public partial class WareListResponse : PddResponseModel
        {

            /// <summary>
            /// 货品编码
            /// </summary>
            [JsonPropertyName("ware_sn")]
            public string WareSn { get; set; }

            /// <summary>
            /// 货品ID
            /// </summary>
            [JsonPropertyName("ware_id")]
            public long? WareId { get; set; }

            /// <summary>
            /// 是否删除
            /// </summary>
            [JsonPropertyName("is_deleted")]
            public bool? IsDeleted { get; set; }

        }

    }

}

