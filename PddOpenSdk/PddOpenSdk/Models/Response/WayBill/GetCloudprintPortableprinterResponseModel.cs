using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.WayBill
{
    public partial class GetCloudprintPortableprinterResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pdd_cloudprint_portableprinter_get_response")]
        public PddCloudprintPortableprinterGetResponseResponseModel PddCloudprintPortableprinterGetResponse { get; set; }
        public partial class PddCloudprintPortableprinterGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("portableprinter_list")]
            public List<PortableprinterListResponseModel> PortableprinterList { get; set; }
            public partial class PortableprinterListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 蓝牙打印机品牌
                /// </summary>
                [JsonProperty("brand")]
                public string Brand { get; set; }
                /// <summary>
                /// 蓝牙打印机型号
                /// </summary>
                [JsonProperty("portableprinter_name")]
                public string PortableprinterName { get; set; }
                /// <summary>
                /// 蓝牙打印机协议，如CPCL, TSPL
                /// </summary>
                [JsonProperty("protocol_name")]
                public string ProtocolName { get; set; }
                /// <summary>
                /// 描述备注
                /// </summary>
                [JsonProperty("remark")]
                public string Remark { get; set; }

            }

        }

    }

}
