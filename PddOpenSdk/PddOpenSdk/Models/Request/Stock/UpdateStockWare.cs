namespace PddOpenSdk.Models.Request.Stock;
public partial class UpdateStockWare
{

    /// <summary>
    /// 货品id
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// 类型 0:单独货品。1:组合货品
    /// </summary>
    [JsonPropertyName("ware_type")]
    public int WareType { get; set; }

    /// <summary>
    /// 组合货品中子货品的关联关系, ware_type为1时必填；
    /// </summary>
    [JsonPropertyName("ware_infos")]
    public List<WareInfosModel> WareInfos { get; set; }

    /// <summary>
    /// 货品编码
    /// </summary>
    [JsonPropertyName("ware_sn")]
    public string WareSn { get; set; }

    /// <summary>
    /// 货品名称
    /// </summary>
    [JsonPropertyName("ware_name")]
    public string WareName { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    [JsonPropertyName("note")]
    public string Note { get; set; }

    /// <summary>
    /// 高低值服务
    /// </summary>
    [JsonPropertyName("service_quality")]
    public int? ServiceQuality { get; set; }

    /// <summary>
    /// 体积：立方毫米，只精确到100（即：最末两位为0）
    /// </summary>
    [JsonPropertyName("volume")]
    public int? Volume { get; set; }

    /// <summary>
    /// 长：毫米，精确到1
    /// </summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>
    /// 宽：毫米，精确到1
    /// </summary>
    [JsonPropertyName("width")]
    public int? Width { get; set; }

    /// <summary>
    /// 高：毫米，精确到1
    /// </summary>
    [JsonPropertyName("height")]
    public int? Height { get; set; }

    /// <summary>
    /// 重量：g，精确到10（即：末位为0）
    /// </summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }

    /// <summary>
    /// 毛重：g，精确到10（即：末位为0）
    /// </summary>
    [JsonPropertyName("gross_weight")]
    public int? GrossWeight { get; set; }

    /// <summary>
    /// 净重：g，精确到10（即：末位为0）
    /// </summary>
    [JsonPropertyName("net_weight")]
    public int? NetWeight { get; set; }

    /// <summary>
    /// 皮重：g，精确到10（即：末位为0）
    /// </summary>
    [JsonPropertyName("tare_weight")]
    public int? TareWeight { get; set; }

    /// <summary>
    /// 单价：分，精确到10（即：末位为0）
    /// </summary>
    [JsonPropertyName("price")]
    public int? Price { get; set; }

    /// <summary>
    /// 颜色
    /// </summary>
    [JsonPropertyName("color")]
    public string Color { get; set; }

    /// <summary>
    /// 包材
    /// </summary>
    [JsonPropertyName("packing")]
    public string Packing { get; set; }
    public partial class WareInfosModel
    {

        /// <summary>
        /// 子货品id
        /// </summary>
        [JsonPropertyName("ware_id")]
        public long WareId { get; set; }

        /// <summary>
        /// 子货品数量
        /// </summary>
        [JsonPropertyName("ware_quantity")]
        public int WareQuantity { get; set; }

    }

}

