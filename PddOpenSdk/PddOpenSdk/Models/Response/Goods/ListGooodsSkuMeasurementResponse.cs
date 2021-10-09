namespace PddOpenSdk.Models.Response.Goods;
public partial class ListGooodsSkuMeasurementResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("gooods_sku_measurement_list_response")]
    public GooodsSkuMeasurementListResponseResponse GooodsSkuMeasurementListResponse { get; set; }
    public partial class GooodsSkuMeasurementListResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 列表
        /// </summary>
        [JsonPropertyName("measurement_list")]
        public List<MeasurementListResponse> MeasurementList { get; set; }
        public partial class MeasurementListResponse : PddResponseModel
        {

            /// <summary>
            /// 编码
            /// </summary>
            [JsonPropertyName("code")]
            public string Code { get; set; }

            /// <summary>
            /// 说明
            /// </summary>
            [JsonPropertyName("desc")]
            public string Desc { get; set; }

        }

    }

}

