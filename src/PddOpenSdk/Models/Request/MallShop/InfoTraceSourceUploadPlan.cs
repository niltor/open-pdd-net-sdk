namespace PddOpenSdk.Models.Request.MallShop;
public partial class InfoTraceSourceUploadPlan
{

    /// <summary>
    /// 到港日期
    /// </summary>
    [JsonPropertyName("arrive_time")]
    public string ArriveTime { get; set; }

    /// <summary>
    /// 提单号
    /// </summary>
    [JsonPropertyName("bill_no")]
    public string BillNo { get; set; }

    /// <summary>
    /// 报检日期
    /// </summary>
    [JsonPropertyName("ciq_date")]
    public string CiqDate { get; set; }

    /// <summary>
    /// 报检单号
    /// </summary>
    [JsonPropertyName("ciq_no")]
    public string CiqNo { get; set; }

    /// <summary>
    /// 境内收发货人
    /// </summary>
    [JsonPropertyName("dealer_org")]
    public string DealerOrg { get; set; }

    /// <summary>
    /// 申报单位
    /// </summary>
    [JsonPropertyName("declare_org")]
    public string DeclareOrg { get; set; }

    /// <summary>
    /// 启运地
    /// </summary>
    [JsonPropertyName("desp_port_name")]
    public string DespPortName { get; set; }

    /// <summary>
    /// 报关日期
    /// </summary>
    [JsonPropertyName("entry_date")]
    public string EntryDate { get; set; }

    /// <summary>
    /// 报关单号
    /// </summary>
    [JsonPropertyName("entry_no")]
    public string EntryNo { get; set; }

    /// <summary>
    /// 溯源码粘贴计划(商品维度)
    /// </summary>
    [JsonPropertyName("goods")]
    public List<GoodsModel> Goods { get; set; }

    /// <summary>
    /// 清单申报日期
    /// </summary>
    [JsonPropertyName("list_date")]
    public string ListDate { get; set; }

    /// <summary>
    /// 核注清单编号
    /// </summary>
    [JsonPropertyName("list_no")]
    public string ListNo { get; set; }

    /// <summary>
    /// 装货港
    /// </summary>
    [JsonPropertyName("load_port")]
    public string LoadPort { get; set; }

    /// <summary>
    /// 粘贴计划所属店铺ID
    /// </summary>
    [JsonPropertyName("mall_id")]
    public long MallId { get; set; }

    /// <summary>
    /// 粘贴计划所属店铺名
    /// </summary>
    [JsonPropertyName("mall_name")]
    public string MallName { get; set; }

    /// <summary>
    /// 粘贴计划单激活时间
    /// </summary>
    [JsonPropertyName("plan_active_time")]
    public string PlanActiveTime { get; set; }

    /// <summary>
    /// 粘贴计划单创建时间
    /// </summary>
    [JsonPropertyName("plan_created_time")]
    public string PlanCreatedTime { get; set; }

    /// <summary>
    /// 粘贴计划单编号
    /// </summary>
    [JsonPropertyName("plan_no")]
    public string PlanNo { get; set; }

    /// <summary>
    /// 进口口岸
    /// </summary>
    [JsonPropertyName("port")]
    public string Port { get; set; }

    /// <summary>
    /// 运输方式
    /// </summary>
    [JsonPropertyName("transport_mode")]
    public string TransportMode { get; set; }

    /// <summary>
    /// 粘贴计划单所属保税仓名称
    /// </summary>
    [JsonPropertyName("warehouse_name")]
    public string WarehouseName { get; set; }
    public partial class GoodsModel
    {

        /// <summary>
        /// 防伪溯源码粘贴数量
        /// </summary>
        [JsonPropertyName("code_amount")]
        public long CodeAmount { get; set; }

        /// <summary>
        /// 防伪溯源码结束顺序号
        /// </summary>
        [JsonPropertyName("end_serial_no")]
        public string EndSerialNo { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonPropertyName("goods_id")]
        public long GoodsId { get; set; }

        /// <summary>
        /// 商品备案图片
        /// </summary>
        [JsonPropertyName("goods_image_url")]
        public string GoodsImageUrl { get; set; }

        /// <summary>
        /// 商品备案名称
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 原产国(地)
        /// </summary>
        [JsonPropertyName("goods_origin")]
        public string GoodsOrigin { get; set; }

        /// <summary>
        /// 商品备案规格型号
        /// </summary>
        [JsonPropertyName("goods_property")]
        public string GoodsProperty { get; set; }

        /// <summary>
        /// 商品规格
        /// </summary>
        [JsonPropertyName("goods_sku_no")]
        public string GoodsSkuNo { get; set; }

        /// <summary>
        /// Hs编码
        /// </summary>
        [JsonPropertyName("hs_code")]
        public string HsCode { get; set; }

        /// <summary>
        /// Hs名称
        /// </summary>
        [JsonPropertyName("hs_name")]
        public string HsName { get; set; }

        /// <summary>
        /// 防伪溯源码起始顺序号
        /// </summary>
        [JsonPropertyName("start_serial_no")]
        public string StartSerialNo { get; set; }

    }

}

