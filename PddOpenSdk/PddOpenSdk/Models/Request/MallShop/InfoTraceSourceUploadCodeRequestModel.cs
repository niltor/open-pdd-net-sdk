using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.MallShop
{
    public partial class InfoTraceSourceUploadCodeRequestModel : PddRequestModel
    {
        /// <summary>
        /// 溯源码列表
        /// </summary>
        [JsonProperty("serial_num_list")]
        public List<SerialNumListRequestModel> SerialNumList { get; set; }
        public partial class SerialNumListRequestModel : PddRequestModel
        {
            /// <summary>
            /// 溯源码（处理后）
            /// </summary>
            [JsonProperty("encoded_serial_num")]
            public string EncodedSerialNum { get; set; }
            /// <summary>
            /// 溯源码
            /// </summary>
            [JsonProperty("serial_num")]
            public string SerialNum { get; set; }

        }

    }

}
