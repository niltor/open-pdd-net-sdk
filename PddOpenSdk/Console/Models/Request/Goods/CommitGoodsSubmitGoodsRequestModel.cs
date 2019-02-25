using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Goods
{
public partial class CommitGoodsSubmitGoodsRequestModel : PddRequestModel
{
/// <summary>
/// 1213414
/// </summary>
[JsonProperty("goods_id")]
public long GoodsId {get;set;}
/// <summary>
/// 商品标题，例如，新疆特产 红满疆枣夹核桃500g
/// </summary>
[JsonProperty("goods_name")]
public string GoodsName {get;set;}
/// <summary>
/// 1-国内普通商品，2-进口，3-国外海淘，4-直邮 ,5-流量,6-话费,7,优惠券;8-QQ充值,9-加油卡 暂时支持1-普通商品的上架
/// </summary>
[JsonProperty("goods_type")]
public int GoodsType {get;set;}
/// <summary>
/// 商品描述， 字数限制：20-500，例如，新包装，保证产品的口感和新鲜度。单颗独立小包装，双重营养，1斤家庭分享装，更实惠新疆一级骏枣夹核桃仁。
/// </summary>
[JsonProperty("goods_desc")]
public string GoodsDesc {get;set;}
/// <summary>
/// 叶子类目ID
/// </summary>
[JsonProperty("cat_id")]
public long CatId {get;set;}
/// <summary>
/// 国家ID，0-中国，暂时只传0（普通商品）
/// </summary>
[JsonProperty("country_id")]
public int CountryId {get;set;}
/// <summary>
/// 保税仓，只在goods_type为直供商品时有效（现阶段暂不支持）
/// </summary>
[JsonProperty("warehouse")]
public string Warehouse {get;set;}
/// <summary>
/// 海关名称，只在goods_type为直供商品时有效（现阶段暂不支持）
/// </summary>
[JsonProperty("customs")]
public string Customs {get;set;}
/// <summary>
/// 是否需要上报海关，现阶段入参默认false，入参true会失败
/// </summary>
[JsonProperty("is_customs")]
public bool? IsCustoms {get;set;}
/// <summary>
/// 市场价格，单位为分
/// </summary>
[JsonProperty("market_price")]
public long MarketPrice {get;set;}
/// <summary>
/// 是否预售,true-预售商品，false-非预售商品
/// </summary>
[JsonProperty("is_pre_sale")]
public bool IsPreSale {get;set;}
/// <summary>
/// 预售时间，is_pre_sale为1时必传，UNIX时间戳
/// </summary>
[JsonProperty("pre_sale_time")]
public long? PreSaleTime {get;set;}
/// <summary>
/// 承诺发货时间（ 秒），48小时或24小时，is_pre_sale为1时不必传
/// </summary>
[JsonProperty("shipment_limit_second")]
public long ShipmentLimitSecond {get;set;}
/// <summary>
/// 物流运费模板ID，可使用pdd.logistics.template.get获取
/// </summary>
[JsonProperty("cost_template_id")]
public long CostTemplateId {get;set;}
/// <summary>
/// 团购人数
/// </summary>
[JsonProperty("customer_num")]
public long? CustomerNum {get;set;}
/// <summary>
/// 限购次数
/// </summary>
[JsonProperty("buy_limit")]
public long? BuyLimit {get;set;}
/// <summary>
/// 单次限量
/// </summary>
[JsonProperty("order_limit")]
public long? OrderLimit {get;set;}
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
/// 水果类目温馨提示，只在水果类目商品才生效， 字数限制：商品描述goods_desc+温馨提示总计不超过500字。
/// </summary>
[JsonProperty("warm_tips")]
public string WarmTips {get;set;}
/// <summary>
/// sku对象列表,实例：[{; 	"is_onsale": 1,; 	"limit_quantity": 999,; 	"price": "2200",; 	"weight": 1000,; 	"multi_price": "1900",; 	"thumb_url": "http://t06img.yangkeduo.com/images/2018-04-15/ced035033b5d40b589140af882621c03.jpg",; 	"out_sku_sn": "L",; 	"quantity": 100,; 	"spec_id_list": "[25]",; 	"oversea_sku": {; 		"measurement_code": "计量单位编码",; 		"taxation": "税费",; 		"specifications": "规格"; 	}; }]
/// </summary>
[JsonProperty("sku_list")]
public List<SkuListRequestModel> SkuList {get;set;}
/// <summary>
/// 商品goods外部编码
/// </summary>
[JsonProperty("out_goods_id")]
public string OutGoodsId {get;set;}
/// <summary>
/// 商品主图，请参考拼多多首页大图，如果商品参加部分活动则必填，否则无法参加活动; a. 尺寸750 x 352px; b. 大小100k以内; c. 图片格式仅支持JPG,PNG格式; d. 图片背景应以纯白为主, 商品图案居中显示; e. 图片不可以添加任何品牌相关文字或logo
/// </summary>
[JsonProperty("image_url")]
public string ImageUrl {get;set;}
/// <summary>
/// 商品轮播图，按次序上传，图片格式支持JPEG/JPG/PNG， 图片尺寸长宽比1：1且尺寸不低于480px，图片大小最高1MB
/// </summary>
[JsonProperty("carousel_gallery")]
public List<string> CarouselGallery {get;set;}
/// <summary>
/// 商品详情图：; a. 尺寸要求宽度处于480~1200px之间，高度0-1500px之间; b. 大小1M以内; c. 数量限制在20张之间; d. 图片格式仅支持JPG,PNG格式; e. 点击上传时，支持批量上传详情图
/// </summary>
[JsonProperty("detail_gallery")]
public List<string> DetailGallery {get;set;}
/// <summary>
/// 是否支持正品发票
/// </summary>
[JsonProperty("invoice_status")]
public int InvoiceStatus {get;set;}
/// <summary>
/// 草稿id
/// </summary>
[JsonProperty("goods_commit_id")]
public long GoodsCommitId {get;set;}
/// <summary>
/// 商品属性列表
/// </summary>
[JsonProperty("goods_properties")]
public List<GoodsPropertiesRequestModel> GoodsProperties {get;set;}
/// <summary>
/// 0：不支持全国联保；1：支持全国联保
/// </summary>
[JsonProperty("quan_guo_lian_bao")]
public int? QuanGuoLianBao {get;set;}
/// <summary>
/// 只换不修的天数，目前只支持0和365
/// </summary>
[JsonProperty("zhi_huan_bu_xiu")]
public int? ZhiHuanBuXiu {get;set;}
/// <summary>
/// oversea_type
/// </summary>
[JsonProperty("oversea_type")]
public int? OverseaType {get;set;}
/// <summary>
/// {; 	"consumption_tax_rate": 1,; 	"value_added_tax_rate": 9,; 	"hs_code": "2200",; 	"customs_broker": "sss",; 	"customs_declaration_method": 1,; 	"bonded_warehouse": "sss",; 	"bonded_warehouse_key": "pp"; }
/// </summary>
[JsonProperty("oversea_goods")]
public OverseaGoodsRequestModel OverseaGoods {get;set;}
/// <summary>
/// 短标题，示例:新包装，保证产品的口感和新鲜度。单颗独立小包装，双重营养，1斤家庭分享装，更实惠新疆一级骏枣夹核桃仁。
/// </summary>
[JsonProperty("tiny_name")]
public string TinyName {get;set;}
/// <summary>
/// 送货入户模版id
/// </summary>
[JsonProperty("song_huo_ru_hu")]
public string SongHuoRuHu {get;set;}
/// <summary>
/// 上门安装模版id
/// </summary>
[JsonProperty("shang_men_an_zhuang")]
public string ShangMenAnZhuang {get;set;}
/// <summary>
/// 送货入户并安装模版id
/// </summary>
[JsonProperty("song_huo_an_zhuang")]
public string SongHuoAnZhuang {get;set;}
/// <summary>
/// 买家自提模版id
/// </summary>
[JsonProperty("mai_jia_zi_ti")]
public string MaiJiaZiTi {get;set;}
public partial class SkuListRequestModel : PddRequestModel
{
/// <summary>
/// sku送装参数：长度
/// </summary>
[JsonProperty("length")]
public long? Length {get;set;}
/// <summary>
/// 商品规格列表，根据pdd.goods.spec.id.get生成的规格属性id，例如：颜色规格下商家新增白色和黑色，大小规格下商家新增L和XL，则由4种spec组合，入参一种组合即可，在skulist中需要有4个spec组合的sku
/// </summary>
[JsonProperty("spec_id_list")]
public string SpecIdList {get;set;}
/// <summary>
/// 重量，单位为g
/// </summary>
[JsonProperty("weight")]
public long Weight {get;set;}
/// <summary>
/// 商品sku库存初始数量，后续库存update只使用stocks.update接口进行调用
/// </summary>
[JsonProperty("quantity")]
public long Quantity {get;set;}
/// <summary>
/// 商品sku外部编码
/// </summary>
[JsonProperty("out_sku_sn")]
public string OutSkuSn {get;set;}
/// <summary>
/// sku预览图，预览图尺寸：等宽高，且高度不低于480px，现已支持1M大小，越清晰越好卖，SKU预览图格式：仅支持JPG,PNG格式
/// </summary>
[JsonProperty("thumb_url")]
public string ThumbUrl {get;set;}
/// <summary>
/// 商品团购价格
/// </summary>
[JsonProperty("multi_price")]
public long MultiPrice {get;set;}
/// <summary>
/// 商品单买价格
/// </summary>
[JsonProperty("price")]
public long Price {get;set;}
/// <summary>
/// sku购买限制，只入参999
/// </summary>
[JsonProperty("limit_quantity")]
public long LimitQuantity {get;set;}
/// <summary>
/// sku上架状态，0-已下架，1-上架中
/// </summary>
[JsonProperty("is_onsale")]
public int IsOnsale {get;set;}
/// <summary>
/// oversea_sku
/// </summary>
[JsonProperty("oversea_sku")]
public OverseaSkuRequestModel OverseaSku {get;set;}
public partial class OverseaSkuRequestModel : PddRequestModel
{
/// <summary>
/// 计量单位编码，从接口pdd.gooods.sku.measurement.list获取code
/// </summary>
[JsonProperty("measurement_code")]
public string MeasurementCode {get;set;}
/// <summary>
/// 税费
/// </summary>
[JsonProperty("taxation")]
public int Taxation {get;set;}
/// <summary>
/// 规格
/// </summary>
[JsonProperty("specifications")]
public string Specifications {get;set;}

}

}
public partial class GoodsPropertiesRequestModel : PddRequestModel
{
/// <summary>
/// 父属性id，非销售属性不用传
/// </summary>
[JsonProperty("parent_spec_id")]
public long? ParentSpecId {get;set;}
/// <summary>
/// 属性id，非销售属性不用传
/// </summary>
[JsonProperty("spec_id")]
public long? SpecId {get;set;}
/// <summary>
/// 备注，非销售属性不用传
/// </summary>
[JsonProperty("note")]
public string Note {get;set;}
/// <summary>
/// 图片url，非销售属性不用传
/// </summary>
[JsonProperty("img_url")]
public string ImgUrl {get;set;}
/// <summary>
/// 组id，非销售属性不用传
/// </summary>
[JsonProperty("group_id")]
public int? GroupId {get;set;}
/// <summary>
/// 模板属性id
/// </summary>
[JsonProperty("template_pid")]
public long? TemplatePid {get;set;}
/// <summary>
/// 属性值id
/// </summary>
[JsonProperty("vid")]
public long? Vid {get;set;}
/// <summary>
/// 属性值
/// </summary>
[JsonProperty("value")]
public string Value {get;set;}
/// <summary>
/// 属性单位
/// </summary>
[JsonProperty("value_unit")]
public string ValueUnit {get;set;}

}
public partial class OverseaGoodsRequestModel : PddRequestModel
{
/// <summary>
/// 消费税率
/// </summary>
[JsonProperty("consumption_tax_rate")]
public int? ConsumptionTaxRate {get;set;}
/// <summary>
/// 增值税率
/// </summary>
[JsonProperty("value_added_tax_rate")]
public int? ValueAddedTaxRate {get;set;}
/// <summary>
/// 海关编号
/// </summary>
[JsonProperty("hs_code")]
public string HsCode {get;set;}
/// <summary>
/// 清关服务商
/// </summary>
[JsonProperty("customs_broker")]
public string CustomsBroker {get;set;}
/// <summary>
/// 保税仓唯一标识
/// </summary>
[JsonProperty("bonded_warehouse_key")]
public string BondedWarehouseKey {get;set;}

}

}

}
