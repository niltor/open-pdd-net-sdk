using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class StatusAdApiUnitUpdateDataOperateRequestModel : PddRequestModel
    {
        /// <summary>
        /// 广告单元Id列表。一次不得超过20个。
        /// </summary>
        [JsonProperty("adIds")]
        public List<long> AdIds { get; set; }
        /// <summary>
        /// 数据操作状态。1表示开启，2表示暂停。
        /// </summary>
        [JsonProperty("dataOperateStatus")]
        public int DataOperateStatus { get; set; }

    }

}
