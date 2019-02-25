using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class GenerateDdkPhraseRequestModel : PddRequestModel
    {
        /// <summary>
        /// 推广位ID
        /// </summary>
        [JsonProperty("p_id")]
        public string PId { get; set; }
        /// <summary>
        /// 商品ID，仅支持单个查询, json 字符串 例子：[1112]
        /// </summary>
        [JsonProperty("goods_id_list")]
        public List<long> GoodsIdList { get; set; }
        /// <summary>
        /// 是否多人团
        /// </summary>
        [JsonProperty("multi_group")]
        public bool? MultiGroup { get; set; }
        /// <summary>
        /// 自定义参数
        /// </summary>
        [JsonProperty("custom_parameters")]
        public string CustomParameters { get; set; }
        /// <summary>
        /// 招商多多客ID
        /// </summary>
        [JsonProperty("zs_duo_id")]
        public long? ZsDuoId { get; set; }
        /// <summary>
        /// 1-大图弹框 2-对话弹框
        /// </summary>
        [JsonProperty("style")]
        public int? Style { get; set; }

    }

}
