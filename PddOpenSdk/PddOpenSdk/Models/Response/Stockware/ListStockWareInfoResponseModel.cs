using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Stockware
{
    public partial class ListStockWareInfoResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("stock_ware_info_list_response")]
        public StockWareInfoListResponseResponseModel StockWareInfoListResponse { get; set; }
        public partial class StockWareInfoListResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 货品信息列表
            /// </summary>
            [JsonProperty("ware_list")]
            public List<WareListResponseModel> WareList { get; set; }
            public partial class WareListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 货品编码
                /// </summary>
                [JsonProperty("ware_sn")]
                public string WareSn { get; set; }
                /// <summary>
                /// 货品ID
                /// </summary>
                [JsonProperty("ware_id")]
                public long? WareId { get; set; }
                /// <summary>
                /// 是否删除
                /// </summary>
                [JsonProperty("is_deleted")]
                public bool? IsDeleted { get; set; }

            }

        }

    }

}
