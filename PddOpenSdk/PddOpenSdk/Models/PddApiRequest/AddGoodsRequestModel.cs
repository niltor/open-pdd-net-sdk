using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class AddGoodsRequestModel : PddRequestModel
    {
        /// <summary>
/// 该值为：pdd.goods.add
/// </summary>
[JsonProperty("type")]
public object Type {get;set;}
/// <summary>
/// 商品标题，例如，新疆特产 红满疆枣夹核桃500g
/// </summary>
[JsonProperty("goods_name")]
public object GoodsName {get;set;}
/// <summary>
/// 1-国内普通商品，2-进口，3-直供（保税），4-直邮 ,5-流量 ,6-话费 ,7-优惠券 ,8-QQ充值 ,9-加油卡
/// </summary>
[JsonProperty("goods_type")]
public int GoodsType {get;set;}
/// <summary>
/// 商品描述， 字数限制：20-500，例如，新包装，保证产品的口感和新鲜度。单颗独立小包装，双重营养，1斤家庭分享装，更实惠新疆一级骏枣夹核桃仁。
/// </summary>
[JsonProperty("goods_desc")]
public object GoodsDesc {get;set;}
/// <summary>
/// 叶子类目ID
/// </summary>
[JsonProperty("cat_id")]
public int CatId {get;set;}
/// <summary>
/// 商品短标题（仅在部分活动中生效），字数限制为4-20字
/// </summary>
[JsonProperty("tiny_name")]
public object TinyName {get;set;}
/// <summary>
/// 国家ID，country_id可以通过pdd.goods.country.get获取，仅在goods_type为2、3时（海淘商品）入参生效，其余goods_type传0
/// </summary>
[JsonProperty("country_id")]
public int CountryId {get;set;}
/// <summary>
/// 保税仓，只在goods_type=3（直供商品）时入参，入参枚举值为：宁波保税仓、杭州保税仓、广州保税仓、深圳保税仓、重庆保税仓、郑州保税仓、福建保税仓、天津保税仓、上海保税仓、银川保税仓、成都保税仓
/// </summary>
[JsonProperty("warehouse")]
public object Warehouse {get;set;}
/// <summary>
/// 海关名称，只在goods_type=3（直供商品）时入参且is_customs=true，入参枚举值为：广州、杭州、宁波、郑州、郑州(保税物流中心)、重庆、西安、上海、郑州(综保区)、深圳、福建、天津
/// </summary>
[JsonProperty("customs")]
public object Customs {get;set;}
/// <summary>
/// 是否需要上报海关，false-无需上报海关，true-需上报海关
/// </summary>
[JsonProperty("is_customs")]
public bool? IsCustoms {get;set;}
/// <summary>
/// 市场价格，单位为分
/// </summary>
[JsonProperty("market_price")]
public int MarketPrice {get;set;}
/// <summary>
/// 是否预售,true-预售商品，false-非预售商品
/// </summary>
[JsonProperty("is_pre_sale")]
public bool IsPreSale {get;set;}
/// <summary>
/// 预售时间，is_pre_sale为1时必传，UNIX时间戳
/// </summary>
[JsonProperty("pre_sale_time")]
public object PreSaleTime {get;set;}
/// <summary>
/// 承诺发货时间（ 秒），普通、进口商品可选48小时或24小时；直邮、直供商品只能入参120小时；is_pre_sale为1时不必传
/// </summary>
[JsonProperty("shipment_limit_second")]
public object ShipmentLimitSecond {get;set;}
/// <summary>
/// 物流运费模板ID，可使用pdd.logistics.template.get获取
/// </summary>
[JsonProperty("cost_template_id")]
public int CostTemplateId {get;set;}
/// <summary>
/// 团购人数
/// </summary>
[JsonProperty("customer_num")]
public int? CustomerNum {get;set;}
/// <summary>
/// 单次限量
/// </summary>
[JsonProperty("buy_limit")]
public int? BuyLimit {get;set;}
/// <summary>
/// 限购次数
/// </summary>
[JsonProperty("order_limit")]
public int? OrderLimit {get;set;}
/// <summary>
/// 是否7天无理由退换货，true-支持，false-不支持
/// </summary>
[JsonProperty("is_refundable")]
public bool IsRefundable {get;set;}
/// <summary>
/// 是否二手商品，true -二手商品 ，false-全新商品
/// </summary>
[JsonProperty("second_hand")]
public bool SecondHand {get;set;}
/// <summary>
/// 是否支持假一赔十，false-不支持，true-支持
/// </summary>
[JsonProperty("is_folt")]
public bool IsFolt {get;set;}
/// <summary>
/// 服饰面料，fabirc枚举如下：
/// </summary>
[JsonProperty("fabric")]
public int? Fabric {get;set;}
/// <summary>
/// 成分含量
/// </summary>
[JsonProperty("fabric_content")]
public int? FabricContent {get;set;}
/// <summary>
/// 水果类目温馨提示，只在水果类目商品才生效， 字数限制：商品描述goods_desc+温馨提示总计不超过500字。
/// </summary>
[JsonProperty("warm_tips")]
public object WarmTips {get;set;}
/// <summary>
/// 食品保质期，cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079; )必填
/// </summary>
[JsonProperty("shelf_life")]
public int? ShelfLife {get;set;}
/// <summary>
/// 生产日期起始时间， UNIX时间戳; cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079; )必填
/// </summary>
[JsonProperty("start_production_date")]
public object StartProductionDate {get;set;}
/// <summary>
/// 生产日期结束时间， UNIX时间戳; cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079; )必填
/// </summary>
[JsonProperty("end_production_date")]
public object EndProductionDate {get;set;}
/// <summary>
/// 产品标准号， ; cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079; )必填
/// </summary>
[JsonProperty("production_standard_number")]
public object ProductionStandardNumber {get;set;}
/// <summary>
/// sku对象列表
/// </summary>
[JsonProperty("sku_list")]
public SkuList SkuList {get;set;}
/// <summary>
/// 商品goods外部编码，同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）。
/// </summary>
[JsonProperty("out_goods_id")]
public object OutGoodsId {get;set;}
/// <summary>
/// 高清缩略图，上传轮播图首图，尺寸400*400，图片格式仅支持JPG,PNG格式
/// </summary>
[JsonProperty("hd_thumb_url")]
public object HdThumbUrl {get;set;}
/// <summary>
/// 普通缩略图，上传轮播图首图，尺寸200*200，图片格式仅支持JPG,PNG格式
/// </summary>
[JsonProperty("thumb_url")]
public object ThumbUrl {get;set;}
/// <summary>
/// 商品主图，请参考拼多多首页大图，如果商品参加部分活动则必填，否则无法参加活动; a. 尺寸750 x 352px; b. 大小100k以内; c. 图片格式仅支持JPG,PNG格式; d. 图片背景应以纯白为主, 商品图案居中显示; e. 图片不可以添加任何品牌相关文字或logo
/// </summary>
[JsonProperty("image_url")]
public object ImageUrl {get;set;}
/// <summary>
/// 商品轮播图，按次序上传，图片格式支持JPEG/JPG/PNG， 图片尺寸长宽比1：1且尺寸不低于480px，图片大小最高1MB
/// </summary>
[JsonProperty("carousel_gallery")]
public CarouselGallery CarouselGallery {get;set;}
/// <summary>
/// 商品详情图：; a. 尺寸要求宽度处于480~1200px之间，高度0-1500px之间; b. 大小1M以内; c. 数量限制在20张之间; d. 图片格式仅支持JPG,PNG格式; e. 点击上传时，支持批量上传详情图
/// </summary>
[JsonProperty("detail_gallery")]
public DetailGallery DetailGallery {get;set;}
/// <summary>
/// 产品标准号 ，例如23453
/// </summary>
[JsonProperty("production_license")]
public object ProductionLicense {get;set;}
/// <summary>
/// 仅在cat_id=983（卷筒纸）类目下入参，每包或者卷的净含量，计量单位是g，范围是1~999的整数
/// </summary>
[JsonProperty("paper_net_weight")]
public int? PaperNetWeight {get;set;}
/// <summary>
/// 仅在cat_id=983（卷筒纸）类目下入参，每段/节纸品的长度，单位是mm，范围是1~999的整数
/// </summary>
[JsonProperty("paper_length")]
public int? PaperLength {get;set;}
/// <summary>
/// 仅在cat_id=983（卷筒纸）类目下入参，每段/节的宽度，单位是mm，范围是1~999的整数
/// </summary>
[JsonProperty("paper_width")]
public int? PaperWidth {get;set;}
/// <summary>
/// 仅在cat_id=983（卷筒纸）类目下入参，纸张的层数，单位是层，范围是1~9的整数
/// </summary>
[JsonProperty("paper_plies_num")]
public int? PaperPliesNum {get;set;}
/// <summary>
/// 是否支持开票（测试中）
/// </summary>
[JsonProperty("invoice_status")]
public int? InvoiceStatus {get;set;}
/// <summary>
/// 商品属性列表
/// </summary>
[JsonProperty("goods_properties")]
public object GoodsProperties {get;set;}
/// <summary>
/// 商品规格列表，根据pdd.goods.spec.id.get生成的规格属性id，例如：颜色规格下商家新增白色和黑色，大小规格下商家新增L和XL，则由4种spec组合，入参一种组合即可，在skulist中需要有4个spec组合的sku，示例：[20,5]
/// </summary>
[JsonProperty("spec_id_list")]
public SpecIdList SpecIdList {get;set;}
/// <summary>
/// 重量，单位为g
/// </summary>
[JsonProperty("weight")]
public int Weight {get;set;}
/// <summary>
/// 商品sku库存初始数量，后续库存update只使用stocks.update接口进行调用
/// </summary>
[JsonProperty("quantity")]
public int Quantity {get;set;}
/// <summary>
/// 商品sku外部编码，同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。
/// </summary>
[JsonProperty("out_sku_sn")]
public object OutSkuSn {get;set;}
/// <summary>
/// sku预览图，预览图尺寸：等宽高，且高度不低于480px，现已支持1M大小，越清晰越好卖，SKU预览图格式：仅支持JPG,PNG格式
/// </summary>
[JsonProperty("thumb_url")]
public object ThumbUrl {get;set;}
/// <summary>
/// 商品团购价格
/// </summary>
[JsonProperty("multi_price")]
public int MultiPrice {get;set;}
/// <summary>
/// 商品单买价格
/// </summary>
[JsonProperty("price")]
public int Price {get;set;}
/// <summary>
/// sku购买限制，只入参999
/// </summary>
[JsonProperty("limit_quantity")]
public int LimitQuantity {get;set;}
/// <summary>
/// sku上架状态，0-已下架，1-上架中
/// </summary>
[JsonProperty("is_onsale")]
public int IsOnsale {get;set;}
/// <summary>
/// 模板属性id
/// </summary>
[JsonProperty("template_pid")]
public int? TemplatePid {get;set;}
/// <summary>
/// 模板模块id
/// </summary>
[JsonProperty("template_module_id")]
public int? TemplateModuleId {get;set;}
/// <summary>
/// 属性id
/// </summary>
[JsonProperty("pid")]
public int? Pid {get;set;}
/// <summary>
/// 属性值id
/// </summary>
[JsonProperty("vid")]
public int? Vid {get;set;}
/// <summary>
/// 属性值
/// </summary>
[JsonProperty("value")]
public object Value {get;set;}
/// <summary>
/// 属性单位
/// </summary>
[JsonProperty("value_unit")]
public object ValueUnit {get;set;}

    public partial class SkuListRequestModel : PddRequestModel
    {
        /// <summary>
/// 商品规格列表，根据pdd.goods.spec.id.get生成的规格属性id，例如：颜色规格下商家新增白色和黑色，大小规格下商家新增L和XL，则由4种spec组合，入参一种组合即可，在skulist中需要有4个spec组合的sku，示例：[20,5]
/// </summary>
[JsonProperty("spec_id_list")]
public SpecIdList SpecIdList {get;set;}
/// <summary>
/// 重量，单位为g
/// </summary>
[JsonProperty("weight")]
public int Weight {get;set;}
/// <summary>
/// 商品sku库存初始数量，后续库存update只使用stocks.update接口进行调用
/// </summary>
[JsonProperty("quantity")]
public int Quantity {get;set;}
/// <summary>
/// 商品sku外部编码，同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。
/// </summary>
[JsonProperty("out_sku_sn")]
public object OutSkuSn {get;set;}
/// <summary>
/// sku预览图，预览图尺寸：等宽高，且高度不低于480px，现已支持1M大小，越清晰越好卖，SKU预览图格式：仅支持JPG,PNG格式
/// </summary>
[JsonProperty("thumb_url")]
public object ThumbUrl {get;set;}
/// <summary>
/// 商品团购价格
/// </summary>
[JsonProperty("multi_price")]
public int MultiPrice {get;set;}
/// <summary>
/// 商品单买价格
/// </summary>
[JsonProperty("price")]
public int Price {get;set;}
/// <summary>
/// sku购买限制，只入参999
/// </summary>
[JsonProperty("limit_quantity")]
public int LimitQuantity {get;set;}
/// <summary>
/// sku上架状态，0-已下架，1-上架中
/// </summary>
[JsonProperty("is_onsale")]
public int IsOnsale {get;set;}

}

    public partial class GoodsPropertiesRequestModel : PddRequestModel
    {
        /// <summary>
/// 模板属性id
/// </summary>
[JsonProperty("template_pid")]
public int? TemplatePid {get;set;}
/// <summary>
/// 模板模块id
/// </summary>
[JsonProperty("template_module_id")]
public int? TemplateModuleId {get;set;}
/// <summary>
/// 属性id
/// </summary>
[JsonProperty("pid")]
public int? Pid {get;set;}
/// <summary>
/// 属性值id
/// </summary>
[JsonProperty("vid")]
public int? Vid {get;set;}
/// <summary>
/// 属性值
/// </summary>
[JsonProperty("value")]
public object Value {get;set;}
/// <summary>
/// 属性单位
/// </summary>
[JsonProperty("value_unit")]
public object ValueUnit {get;set;}

}

}
}
