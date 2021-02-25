using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class StatusAdApiUnitCreativeUpdateDataOperateRequestModel : PddRequestModel
    {
        /// <summary>
        /// 数据操作状态。1表示开启，2表示暂停。
        /// </summary>
        [JsonProperty("dataOperateStatus")]
        public int DataOperateStatus { get; set; }
        /// <summary>
        /// 创意单元Id列表
        /// </summary>
        [JsonProperty("unitCreativeIds")]
        public List<long> UnitCreativeIds { get; set; }

    }

}
