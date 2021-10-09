namespace PddOpenSdk.Models.Response.WayBill;
public partial class GetCloudprintPortableprinterResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("pdd_cloudprint_portableprinter_get_response")]
    public PddCloudprintPortableprinterGetResponseResponse PddCloudprintPortableprinterGetResponse { get; set; }
    public partial class PddCloudprintPortableprinterGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("portableprinter_list")]
        public List<PortableprinterListResponse> PortableprinterList { get; set; }
        public partial class PortableprinterListResponse : PddResponseModel
        {

            /// <summary>
            /// 蓝牙打印机品牌
            /// </summary>
            [JsonPropertyName("brand")]
            public string Brand { get; set; }

            /// <summary>
            /// 蓝牙打印机型号
            /// </summary>
            [JsonPropertyName("portableprinter_name")]
            public string PortableprinterName { get; set; }

            /// <summary>
            /// 蓝牙打印机协议，如CPCL, TSPL
            /// </summary>
            [JsonPropertyName("protocol_name")]
            public string ProtocolName { get; set; }

            /// <summary>
            /// 描述备注
            /// </summary>
            [JsonPropertyName("remark")]
            public string Remark { get; set; }

        }

    }

}

