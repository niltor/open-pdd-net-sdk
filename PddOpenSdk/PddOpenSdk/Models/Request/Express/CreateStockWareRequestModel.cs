using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Express
{
    public partial class CreateStockWareRequestModel : PddRequestModel
    {
        /// <summary>
        /// 类型 0:单独货品。1:组合货品
        /// </summary>
        [JsonProperty("ware_type")]
        public int WareType { get; set; }
        /// <summary>
        /// 组合货品中子货品的关联关系, ware_type为1时必填；
        /// </summary>
        [JsonProperty("ware_infos")]
        public List<WareInfosRequestModel> WareInfos { get; set; }
        /// <summary>
        /// 货品编码
        /// </summary>
        [JsonProperty("ware_sn")]
        public string WareSn { get; set; }
        /// <summary>
        /// 货品名称
        /// </summary>
        [JsonProperty("ware_name")]
        public string WareName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }
        /// <summary>
        /// 高低值服务
        /// </summary>
        [JsonProperty("service_quality")]
        public int? ServiceQuality { get; set; }
        /// <summary>
        /// 体积：立方毫米，只精确到100（即：最末两位为0）
        /// </summary>
        [JsonProperty("volume")]
        public int? Volume { get; set; }
        /// <summary>
        /// 长：毫米，精确到1
        /// </summary>
        [JsonProperty("length")]
        public int? Length { get; set; }
        /// <summary>
        /// 宽：毫米，精确到1
        /// </summary>
        [JsonProperty("width")]
        public int? Width { get; set; }
        /// <summary>
        /// 高：毫米，精确到1
        /// </summary>
        [JsonProperty("height")]
        public int? Height { get; set; }
        /// <summary>
        /// 重量：g，精确到10（即：末位为0）
        /// </summary>
        [JsonProperty("weight")]
        public int Weight { get; set; }
        /// <summary>
        /// 毛重：g，精确到10（即：末位为0）
        /// </summary>
        [JsonProperty("gross_weight")]
        public int? GrossWeight { get; set; }
        /// <summary>
        /// 净重：g，精确到10（即：末位为0）
        /// </summary>
        [JsonProperty("net_weight")]
        public int? NetWeight { get; set; }
        /// <summary>
        /// 皮重：g，精确到10（即：末位为0）
        /// </summary>
        [JsonProperty("tare_weight")]
        public int? TareWeight { get; set; }
        /// <summary>
        /// 单价：分，精确到10（即：末位为0）
        /// </summary>
        [JsonProperty("price")]
        public int? Price { get; set; }
        /// <summary>
        /// 颜色
        /// </summary>
        [JsonProperty("color")]
        public string Color { get; set; }
        /// <summary>
        /// 包材
        /// </summary>
        [JsonProperty("packing")]
        public string Packing { get; set; }
        public partial class WareInfosRequestModel : PddRequestModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("ware_quantity")]
            public int WareQuantity { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("ware_id")]
            public long WareId { get; set; }

        }

    }

}
