using App.Models.PddApiResult;
using System.Threading.Tasks;
namespace App.Services.PddApiRequest
{
    public class GoodsApiRequest : PddRequest {
        /// <summary>
/// 商品列表接口
/// </summary>
/// <param name="Type">该值为：pdd.goods.list.get</param>
/// <param name="OuterId">商品外部编码（sku），同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。outer_id,is_onsale,goods_name三选一，优先级is_onsale>outer_id>goods_name</param>
/// <param name="IsOnsale">上下架状态，0-下架，1-上架,outer_id,is_onsale,goods_name三选一，优先级is_onsale>outer_id>goods_name</param>
/// <param name="GoodsName">商品名称模糊查询,outer_id,is_onsale,goods_name三选一，优先级is_onsale>outer_id>goods_name</param>
/// <param name="PageSize">返回数量，默认 100，最大100。</param>
/// <param name="Page">返回页码 默认 1，页码从 1 开始PS：当前采用分页返回，数量和页数会一起传，如果不传，则采用 默认值</param>
public async Task<GetGoodsListApiResult> GetGoodsListAsync(string Type,string OuterId,number IsOnsale,string GoodsName,number PageSize,number Page)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
dic.Add("outer_id",Outer Id);
dic.Add("is_onsale",Is Onsale);
dic.Add("goods_name",Goods Name);
dic.Add("page_size",Page Size);
dic.Add("page",Page);
    
    var result = Post<GetGoodsListApiResult>(pdd.goods.list.get,);
    return JsonConvert.DeserializeObject<GetGoodsListApiResult>(result);
}/// <summary>
/// 商品详情接口
/// </summary>
/// <param name="Type">该值为：pdd.goods.information.get</param>
/// <param name="GoodsId">商品编码</param>
public async Task<GetGoodsInformationApiResult> GetGoodsInformationAsync(string Type,string GoodsId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
dic.Add("goods_id",Goods Id);
    
    var result = Post<GetGoodsInformationApiResult>(pdd.goods.information.get,);
    return JsonConvert.DeserializeObject<GetGoodsInformationApiResult>(result);
}/// <summary>
/// 商品全量修改接口
/// </summary>
/// <param name="Type">该值为：pdd.goods.sku.stock.update</param>
/// <param name="Quantity">修改后的库存值：如 56</param>
/// <param name="SkuId">879512</param>
/// <param name="OuterId">外部编码如：outer_11，ps: sku_id 和 outer_id 两者必须填一个，同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。</param>
public async Task<UpdateGoodsSkuStockApiResult> UpdateGoodsSkuStockAsync(string Type,int Quantity,string SkuId,string OuterId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
dic.Add("quantity",Quantity);
dic.Add("sku_id",Sku Id);
dic.Add("outer_id",Outer Id);
    
    var result = Post<UpdateGoodsSkuStockApiResult>(pdd.goods.sku.stock.update,);
    return JsonConvert.DeserializeObject<UpdateGoodsSkuStockApiResult>(result);
}/// <summary>
/// 商品增量修改接口
/// </summary>
/// <param name="Type">该值为：pdd.goods.sku.stock.increment.update</param>
/// <param name="SkuId">商品sku编码</param>
/// <param name="OuterId">外部编码 outer_11，ps: sku_id 和 outer_id 两者必须填一个，同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。</param>
/// <param name="IncrementQuantity">增量库存值，222</param>
public async Task<UpdateGoodsSkuStockIncrementApiResult> UpdateGoodsSkuStockIncrementAsync(string Type,string SkuId,string OuterId,int IncrementQuantity)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
dic.Add("sku_id",Sku Id);
dic.Add("outer _id",Outer  Id);
dic.Add("increment_quantity",Increment Quantity);
    
    var result = Post<UpdateGoodsSkuStockIncrementApiResult>(pdd.goods.sku.stock.increment.update,);
    return JsonConvert.DeserializeObject<UpdateGoodsSkuStockIncrementApiResult>(result);
}/// <summary>
/// 商品标准类目接口
/// </summary>
/// <param name="Type">该值为：pdd.goods.cats.get</param>
/// <param name="ParentCatId">值=0时为顶点cat_id,通过树顶级节点获取cat树</param>
public async Task<GetGoodsCatsApiResult> GetGoodsCatsAsync(string Type,number ParentCatId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
dic.Add("parent_cat_id",Parent Cat Id);
    
    var result = Post<GetGoodsCatsApiResult>(pdd.goods.cats.get,);
    return JsonConvert.DeserializeObject<GetGoodsCatsApiResult>(result);
}/// <summary>
/// 商品运费模版接口
/// </summary>
/// <param name="Type">该值为：pdd.goods.logistics.template.get</param>
/// <param name="Page">默认返回运费模板的页数为1，最高为100页，注意：page与page_size必须传一个</param>
/// <param name="PageSize">默认返回20条模板数据，最多100条数据</param>
public async Task<GetGoodsLogisticsTemplateApiResult> GetGoodsLogisticsTemplateAsync(string Type,number Page,number PageSize)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
dic.Add("page",Page);
dic.Add("page_size",Page Size);
    
    var result = Post<GetGoodsLogisticsTemplateApiResult>(pdd.goods.logistics.template.get,);
    return JsonConvert.DeserializeObject<GetGoodsLogisticsTemplateApiResult>(result);
}/// <summary>
/// 商品图片上传接口
/// </summary>
/// <param name="Type">该值为：pdd.goods.image.upload</param>
/// <param name="Image">支持格式有：jpg/jpeg、png等图片格式，注意入参图片必须转码为base64编码</param>
public async Task<UploadGoodsImageApiResult> UploadGoodsImageAsync(string Type,string Image)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
dic.Add("image",Image);
    
    var result = Post<UploadGoodsImageApiResult>(pdd.goods.image.upload,);
    return JsonConvert.DeserializeObject<UploadGoodsImageApiResult>(result);
}/// <summary>
/// 商品国家接口
/// </summary>
/// <param name="Type">该值为：pdd.goods.country.get</param>
public async Task<GetGoodsCountryApiResult> GetGoodsCountryAsync(string Type)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
    
    var result = Post<GetGoodsCountryApiResult>(pdd.goods.country.get,);
    return JsonConvert.DeserializeObject<GetGoodsCountryApiResult>(result);
}/// <summary>
/// 生成商家自定义的规格
/// </summary>
/// <param name="Type">该值为：pdd.goods.spec.id.get，配合pdd.goods.spec.get接口获取对应要发布的商品所属叶子类目所需的规格id，通过此接口生成对应的规格名称，例如叶子类目下某规格id为0，对应规格名称为颜色，通过此接口可以新建颜色规格下颜色、白色等。</param>
/// <param name="ParentSpecId">拼多多标准规格ID，可以通过pdd.goods.spec.get接口获取</param>
/// <param name="SpecName">商家编辑的规格值，如颜色规格下设置白色属性</param>
public async Task<GetGoodsSpecIdApiResult> GetGoodsSpecIdAsync(string Type,number ParentSpecId,string SpecName)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
dic.Add("parent_spec_id",Parent Spec Id);
dic.Add("spec_name",Spec Name);
    
    var result = Post<GetGoodsSpecIdApiResult>(pdd.goods.spec.id.get,);
    return JsonConvert.DeserializeObject<GetGoodsSpecIdApiResult>(result);
}/// <summary>
/// 商品属性类目接口
/// </summary>
/// <param name="Type">该值为：pdd.goods.spec.get</param>
/// <param name="CatId">叶子类目ID，必须入参level=3时的cat_id,否则无法返回正确的参数</param>
public async Task<GetGoodsSpecApiResult> GetGoodsSpecAsync(string Type,string CatId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
dic.Add("cat_id",Cat Id);
    
    var result = Post<GetGoodsSpecApiResult>(pdd.goods.spec.get,);
    return JsonConvert.DeserializeObject<GetGoodsSpecApiResult>(result);
}/// <summary>
/// 获取当前授权商家可发布的商品类目信息
/// </summary>
/// <param name="Type">该值为：pdd.goods.authorization.cats</param>
/// <param name="ParentCatId">默认值=0，值=0时为顶点cat_id,通过树顶级节点获取一级类目</param>
public async Task<CatsGoodsAuthorizationApiResult> CatsGoodsAuthorizationAsync(string Type,number ParentCatId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
dic.Add("parent_cat_id",Parent Cat Id);
    
    var result = Post<CatsGoodsAuthorizationApiResult>(pdd.goods.authorization.cats,);
    return JsonConvert.DeserializeObject<CatsGoodsAuthorizationApiResult>(result);
}/// <summary>
/// 获取服饰成分含量信息
/// </summary>
/// <param name="Type">该值为：pdd.goods.fabric.content.get</param>
public async Task<GetGoodsFabricContentApiResult> GetGoodsFabricContentAsync(string Type)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
    
    var result = Post<GetGoodsFabricContentApiResult>(pdd.goods.fabric.content.get,);
    return JsonConvert.DeserializeObject<GetGoodsFabricContentApiResult>(result);
}/// <summary>
/// 获取服饰面料信息
/// </summary>
/// <param name="Type">该值为：pdd.goods.fabric.get</param>
public async Task<GetGoodsFabricApiResult> GetGoodsFabricAsync(string Type)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
    
    var result = Post<GetGoodsFabricApiResult>(pdd.goods.fabric.get,);
    return JsonConvert.DeserializeObject<GetGoodsFabricApiResult>(result);
}/// <summary>
/// 商品新增接口
/// </summary>
/// <param name="Type">该值为：pdd.goods.add</param>
/// <param name="GoodsName">商品标题，例如，新疆特产 红满疆枣夹核桃500g</param>
/// <param name="GoodsType">1-国内普通商品，2-进口，3-直供（保税），4-直邮 ,5-流量 ,6-话费 ,7-优惠券 ,8-QQ充值 ,9-加油卡</param>
/// <param name="GoodsDesc">商品描述， 字数限制：20-500，例如，新包装，保证产品的口感和新鲜度。单颗独立小包装，双重营养，1斤家庭分享装，更实惠新疆一级骏枣夹核桃仁。</param>
/// <param name="CatId">叶子类目ID</param>
/// <param name="CountryId">国家ID，country_id可以通过pdd.goods.country.get获取，仅在goods_type为2、3时（海淘商品）入参生效，其余goods_type传0</param>
/// <param name="MarketPrice">市场价格，单位为分</param>
/// <param name="IsPreSale">是否预售,true-预售商品，false-非预售商品</param>
/// <param name="ShipmentLimitSecond">承诺发货时间（ 秒），普通、进口商品可选48小时或24小时；直邮、直供商品只能入参120小时；is_pre_sale为1时不必传</param>
/// <param name="CostTemplateId">物流运费模板ID，可使用pdd.logistics.template.get获取</param>
/// <param name="IsRefundable">是否7天无理由退换货，true-支持，false-不支持</param>
/// <param name="SecondHand">是否二手商品，true -二手商品 ，false-全新商品</param>
/// <param name="IsFolt">是否支持假一赔十，false-不支持，true-支持</param>
/// <param name="SkuList">sku对象列表</param>
/// <param name="HdThumbUrl">高清缩略图，上传轮播图首图，尺寸400*400，图片格式仅支持JPG,PNG格式</param>
/// <param name="ThumbUrl">普通缩略图，上传轮播图首图，尺寸200*200，图片格式仅支持JPG,PNG格式</param>
/// <param name="CarouselGallery">商品轮播图，按次序上传，图片格式支持JPEG/JPG/PNG， 图片尺寸长宽比1：1且尺寸不低于480px，图片大小最高1MB</param>
/// <param name="DetailGallery">商品详情图：
a. 尺寸要求宽度处于480~1200px之间，高度0-1500px之间
b. 大小1M以内
c. 数量限制在20张之间
d. 图片格式仅支持JPG,PNG格式
e. 点击上传时，支持批量上传详情图</param>
/// <param name="SpecIdList">商品规格列表，根据pdd.goods.spec.id.get生成的规格属性id，例如：颜色规格下商家新增白色和黑色，大小规格下商家新增L和XL，则由4种spec组合，入参一种组合即可，在skulist中需要有4个spec组合的sku，示例：[20,5]</param>
/// <param name="Weight">重量，单位为g</param>
/// <param name="Quantity">商品sku库存初始数量，后续库存update只使用stocks.update接口进行调用</param>
/// <param name="ThumbUrl">sku预览图，预览图尺寸：等宽高，且高度不低于480px，现已支持1M大小，越清晰越好卖，SKU预览图格式：仅支持JPG,PNG格式</param>
/// <param name="MultiPrice">商品团购价格</param>
/// <param name="Price">商品单买价格</param>
/// <param name="LimitQuantity">sku购买限制，只入参999</param>
/// <param name="IsOnsale">sku上架状态，0-已下架，1-上架中</param>
/// <param name="TinyName">商品短标题（仅在部分活动中生效），字数限制为4-20字</param>
/// <param name="Warehouse">保税仓，只在goods_type=3（直供商品）时入参，入参枚举值为：宁波保税仓、杭州保税仓、广州保税仓、深圳保税仓、重庆保税仓、郑州保税仓、福建保税仓、天津保税仓、上海保税仓、银川保税仓、成都保税仓</param>
/// <param name="Customs">海关名称，只在goods_type=3（直供商品）时入参且is_customs=true，入参枚举值为：广州、杭州、宁波、郑州、郑州(保税物流中心)、重庆、西安、上海、郑州(综保区)、深圳、福建、天津</param>
/// <param name="IsCustoms">是否需要上报海关，false-无需上报海关，true-需上报海关</param>
/// <param name="PreSaleTime">预售时间，is_pre_sale为1时必传，UNIX时间戳</param>
/// <param name="CustomerNum">团购人数</param>
/// <param name="BuyLimit">单次限量</param>
/// <param name="OrderLimit">限购次数</param>
/// <param name="Fabric">服饰面料，fabirc枚举如下：</param>
/// <param name="FabricContent">成分含量</param>
/// <param name="WarmTips">水果类目温馨提示，只在水果类目商品才生效， 字数限制：商品描述goods_desc+温馨提示总计不超过500字。</param>
/// <param name="ShelfLife">食品保质期，cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079
)必填</param>
/// <param name="StartProductionDate">生产日期起始时间， UNIX时间戳
cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079
)必填</param>
/// <param name="EndProductionDate">生产日期结束时间， UNIX时间戳
cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079
)必填</param>
/// <param name="ProductionStandardNumber">产品标准号， 
cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079
)必填</param>
/// <param name="OutGoodsId">商品goods外部编码，同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）。</param>
/// <param name="ImageUrl">商品主图，请参考拼多多首页大图，如果商品参加部分活动则必填，否则无法参加活动
a. 尺寸750 x 352px
b. 大小100k以内
c. 图片格式仅支持JPG,PNG格式
d. 图片背景应以纯白为主, 商品图案居中显示
e. 图片不可以添加任何品牌相关文字或logo</param>
/// <param name="ProductionLicense">产品标准号 ，例如23453</param>
/// <param name="PaperNetWeight">仅在cat_id=983（卷筒纸）类目下入参，每包或者卷的净含量，计量单位是g，范围是1~999的整数</param>
/// <param name="PaperLength">仅在cat_id=983（卷筒纸）类目下入参，每段/节纸品的长度，单位是mm，范围是1~999的整数</param>
/// <param name="PaperWidth">仅在cat_id=983（卷筒纸）类目下入参，每段/节的宽度，单位是mm，范围是1~999的整数</param>
/// <param name="PaperPliesNum">仅在cat_id=983（卷筒纸）类目下入参，纸张的层数，单位是层，范围是1~9的整数</param>
/// <param name="InvoiceStatus">是否支持开票（测试中）</param>
/// <param name="GoodsProperties">商品属性列表</param>
/// <param name="OutSkuSn">商品sku外部编码，同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。</param>
/// <param name="TemplatePid">模板属性id</param>
/// <param name="TemplateModuleId">模板模块id</param>
/// <param name="Pid">属性id</param>
/// <param name="Vid">属性值id</param>
/// <param name="Value">属性值</param>
/// <param name="ValueUnit">属性单位</param>
public async Task<AddGoodsApiResult> AddGoodsAsync(string Type,string GoodsName,number GoodsType,string GoodsDesc,number CatId,number CountryId,number MarketPrice,boolean IsPreSale,string ShipmentLimitSecond,number CostTemplateId,boolean IsRefundable,boolean SecondHand,boolean IsFolt,jsonstring SkuList,string HdThumbUrl,string ThumbUrl,jsonstring CarouselGallery,jsonstring DetailGallery,jsonstring SpecIdList,number Weight,number Quantity,string ThumbUrl,number MultiPrice,number Price,number LimitQuantity,number IsOnsale,string TinyName,string Warehouse,string Customs,boolean IsCustoms,string PreSaleTime,number CustomerNum,number BuyLimit,number OrderLimit,number Fabric,number FabricContent,string WarmTips,number ShelfLife,string StartProductionDate,string EndProductionDate,string ProductionStandardNumber,string OutGoodsId,string ImageUrl,string ProductionLicense,number PaperNetWeight,number PaperLength,number PaperWidth,number PaperPliesNum,number InvoiceStatus,string GoodsProperties,string OutSkuSn,number TemplatePid,number TemplateModuleId,number Pid,number Vid,string Value,string ValueUnit)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
dic.Add("goods_name",Goods Name);
dic.Add("goods_type",Goods Type);
dic.Add("goods_desc",Goods Desc);
dic.Add("cat_id",Cat Id);
dic.Add("country_id",Country Id);
dic.Add("market_price",Market Price);
dic.Add("is_pre_sale",Is Pre Sale);
dic.Add("shipment_limit_second",Shipment Limit Second);
dic.Add("cost_template_id",Cost Template Id);
dic.Add("is_refundable",Is Refundable);
dic.Add("second_hand",Second Hand);
dic.Add("is_folt",Is Folt);
dic.Add("sku_list",Sku List);
dic.Add("hd_thumb_url",Hd Thumb Url);
dic.Add("thumb_url",Thumb Url);
dic.Add("carousel_gallery",Carousel Gallery);
dic.Add("detail_gallery",Detail Gallery);
dic.Add("spec_id_list",Spec Id List);
dic.Add("weight",Weight);
dic.Add("quantity",Quantity);
dic.Add("thumb_url",Thumb Url);
dic.Add("multi_price",Multi Price);
dic.Add("price",Price);
dic.Add("limit_quantity",Limit Quantity);
dic.Add("is_onsale",Is Onsale);
dic.Add("tiny_name",Tiny Name);
dic.Add("warehouse",Warehouse);
dic.Add("customs",Customs);
dic.Add("is_customs",Is Customs);
dic.Add("pre_sale_time",Pre Sale Time);
dic.Add("customer_num",Customer Num);
dic.Add("buy_limit",Buy Limit);
dic.Add("order_limit",Order Limit);
dic.Add("fabric",Fabric);
dic.Add("fabric_content",Fabric Content);
dic.Add("warm_tips",Warm Tips);
dic.Add("shelf_life",Shelf Life);
dic.Add("start_production_date",Start Production Date);
dic.Add("end_production_date",End Production Date);
dic.Add("production_standard_number",Production Standard Number);
dic.Add("out_goods_id",Out Goods Id);
dic.Add("image_url",Image Url);
dic.Add("production_license",Production License);
dic.Add("paper_net_weight",Paper Net Weight);
dic.Add("paper_length",Paper Length);
dic.Add("paper_width",Paper Width);
dic.Add("paper_plies_num",Paper Plies Num);
dic.Add("invoice_status",Invoice Status);
dic.Add("goods_properties",Goods Properties);
dic.Add("out_sku_sn",Out Sku Sn);
dic.Add("template_pid",Template Pid);
dic.Add("template_module_id",Template Module Id);
dic.Add("pid",Pid);
dic.Add("vid",Vid);
dic.Add("value",Value);
dic.Add("value_unit",Value Unit);
    
    var result = Post<AddGoodsApiResult>(pdd.goods.add,);
    return JsonConvert.DeserializeObject<AddGoodsApiResult>(result);
}/// <summary>
/// 商品编辑
/// </summary>
/// <param name="GoodsId">1213414</param>
/// <param name="GoodsName">商品标题，例如，新疆特产 红满疆枣夹核桃500g</param>
/// <param name="GoodsType">1-国内普通商品，2-进口，3-国外海淘，4-直邮 ,5-流量,6-话费,7,优惠券;8-QQ充值,9-加油卡 暂时支持1-普通商品的上架</param>
/// <param name="GoodsDesc">商品描述， 字数限制：20-500，例如，新包装，保证产品的口感和新鲜度。单颗独立小包装，双重营养，1斤家庭分享装，更实惠新疆一级骏枣夹核桃仁。</param>
/// <param name="CatId">叶子类目ID</param>
/// <param name="CountryId">国家ID，0-中国，暂时只传0（普通商品）</param>
/// <param name="MarketPrice">市场价格，单位为分</param>
/// <param name="IsPreSale">是否预售,true-预售商品，false-非预售商品</param>
/// <param name="ShipmentLimitSecond">承诺发货时间（ 秒），48小时或24小时，is_pre_sale为1时不必传</param>
/// <param name="CostTemplateId">物流运费模板ID，可使用pdd.logistics.template.get获取</param>
/// <param name="IsRefundable">是否7天无理由退换货，true-支持，false-不支持</param>
/// <param name="SecondHand">是否二手商品，true -二手商品 ，false-全新商品</param>
/// <param name="IsFolt">是否支持假一赔十，false-不支持，true-支持</param>
/// <param name="SkuList">sku对象列表</param>
/// <param name="HdThumbUrl">高清缩略图，上传轮播图首图，尺寸400*400，图片格式仅支持JPG,PNG格式</param>
/// <param name="ThumbUrl">普通缩略图，上传轮播图首图，尺寸200*200，图片格式仅支持JPG,PNG格式</param>
/// <param name="CarouselGallery">商品轮播图，按次序上传，图片格式支持JPEG/JPG/PNG， 图片尺寸长宽比1：1且尺寸不低于480px，图片大小最高1MB</param>
/// <param name="DetailGallery">商品详情图：
a. 尺寸要求宽度处于480~1200px之间，高度0-1500px之间
b. 大小1M以内
c. 数量限制在20张之间
d. 图片格式仅支持JPG,PNG格式
e. 点击上传时，支持批量上传详情图</param>
/// <param name="SkuId">sku编码，如果传值，则在原sku基础上进行编辑，如果传空，则新增sku。</param>
/// <param name="SpecIdList">商品规格列表，根据pdd.goods.spec.id.get生成的规格属性id，例如：颜色规格下商家新增白色和黑色，大小规格下商家新增L和XL，则由4种spec组合，入参一种组合即可，在skulist中需要有4个spec组合的sku</param>
/// <param name="Weight">重量，单位为g</param>
/// <param name="Quantity">商品sku库存增减数量，可入参值为正负0整数。后续库存update建议只使用stocks.update接口进行调用</param>
/// <param name="ThumbUrl">sku预览图，预览图尺寸：等宽高，且高度不低于480px，现已支持1M大小，越清晰越好卖，SKU预览图格式：仅支持JPG,PNG格式</param>
/// <param name="MultiPrice">商品团购价格</param>
/// <param name="Price">商品单买价格</param>
/// <param name="LimitQuantity">sku购买限制，只入参999</param>
/// <param name="IsOnsale">sku上架状态，0-已下架，1-上架中</param>
/// <param name="TinyName">商品短标题（仅在部分活动中生效），字数限制为4-20字</param>
/// <param name="Warehouse">保税仓，只在goods_type为直供商品时有效（现阶段暂不支持）</param>
/// <param name="Customs">海关名称，只在goods_type为直供商品时有效（现阶段暂不支持）</param>
/// <param name="IsCustoms">是否需要上报海关，现阶段入参默认false，入参true会失败</param>
/// <param name="PreSaleTime">预售时间，is_pre_sale为1时必传，UNIX时间戳</param>
/// <param name="CustomerNum">团购人数</param>
/// <param name="BuyLimit">单次限量</param>
/// <param name="OrderLimit">限购次数</param>
/// <param name="Fabric">服饰面料，fabirc枚举如下：</param>
/// <param name="FabricContent">成分含量</param>
/// <param name="WarmTips">水果类目温馨提示，只在水果类目商品才生效， 字数限制：商品描述goods_desc+温馨提示总计不超过500字。</param>
/// <param name="ShelfLife">食品保质期，cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079
)必填</param>
/// <param name="StartProductionDate">生产日期起始时间， 
cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079
)必填</param>
/// <param name="EndProductionDate">生产许可证编号， 
cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079
)必填</param>
/// <param name="ProductionStandardNumber">产品标准号， 
cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079
)必填</param>
/// <param name="OutGoodsId">商品goods外部编码，同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）。</param>
/// <param name="ImageUrl">商品主图，请参考拼多多首页大图，如果商品参加部分活动则必填，否则无法参加活动
a. 尺寸750 x 352px
b. 大小100k以内
c. 图片格式仅支持JPG,PNG格式
d. 图片背景应以纯白为主, 商品图案居中显示
e. 图片不可以添加任何品牌相关文字或logo</param>
/// <param name="InvoiceStatus">是否支持开票（测试中）</param>
/// <param name="GoodsProperties">商品属性列表</param>
/// <param name="OutSkuSn">商品sku外部编码，同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。</param>
/// <param name="TemplatePid">模板属性id</param>
/// <param name="TemplateModuleId">模板模块id</param>
/// <param name="Pid">属性id</param>
/// <param name="Vid">属性值id</param>
/// <param name="Value">属性值</param>
/// <param name="ValueUnit">属性单位</param>
public async Task<UpdateGoodsInformationApiResult> UpdateGoodsInformationAsync(number GoodsId,string GoodsName,number GoodsType,string GoodsDesc,number CatId,number CountryId,number MarketPrice,boolean IsPreSale,string ShipmentLimitSecond,number CostTemplateId,boolean IsRefundable,boolean SecondHand,boolean IsFolt,jsonstring SkuList,string HdThumbUrl,string ThumbUrl,jsonstring CarouselGallery,jsonstring DetailGallery,number SkuId,jsonstring SpecIdList,number Weight,number Quantity,string ThumbUrl,number MultiPrice,number Price,number LimitQuantity,number IsOnsale,string TinyName,string Warehouse,string Customs,boolean IsCustoms,string PreSaleTime,number CustomerNum,number BuyLimit,number OrderLimit,number Fabric,number FabricContent,string WarmTips,number ShelfLife,string StartProductionDate,string EndProductionDate,string ProductionStandardNumber,number OutGoodsId,string ImageUrl,number InvoiceStatus,string GoodsProperties,number OutSkuSn,number TemplatePid,number TemplateModuleId,number Pid,number Vid,string Value,string ValueUnit)
{
    var dic = new Dictionary<string, string>();
    dic.Add("goods_id",Goods Id);
dic.Add("goods_name",Goods Name);
dic.Add("goods_type",Goods Type);
dic.Add("goods_desc",Goods Desc);
dic.Add("cat_id",Cat Id);
dic.Add("country_id",Country Id);
dic.Add("market_price",Market Price);
dic.Add("is_pre_sale",Is Pre Sale);
dic.Add("shipment_limit_second",Shipment Limit Second);
dic.Add("cost_template_id",Cost Template Id);
dic.Add("is_refundable",Is Refundable);
dic.Add("second_hand",Second Hand);
dic.Add("is_folt",Is Folt);
dic.Add("sku_list",Sku List);
dic.Add("hd_thumb_url",Hd Thumb Url);
dic.Add("thumb_url",Thumb Url);
dic.Add("carousel_gallery",Carousel Gallery);
dic.Add("detail_gallery",Detail Gallery);
dic.Add("sku_id",Sku Id);
dic.Add("spec_id_list",Spec Id List);
dic.Add("weight",Weight);
dic.Add("quantity",Quantity);
dic.Add("thumb_url",Thumb Url);
dic.Add("multi_price",Multi Price);
dic.Add("price",Price);
dic.Add("limit_quantity",Limit Quantity);
dic.Add("is_onsale",Is Onsale);
dic.Add("tiny_name",Tiny Name);
dic.Add("warehouse",Warehouse);
dic.Add("customs",Customs);
dic.Add("is_customs",Is Customs);
dic.Add("pre_sale_time",Pre Sale Time);
dic.Add("customer_num",Customer Num);
dic.Add("buy_limit",Buy Limit);
dic.Add("order_limit",Order Limit);
dic.Add("fabric",Fabric);
dic.Add("fabric_content",Fabric Content);
dic.Add("warm_tips",Warm Tips);
dic.Add("shelf_life",Shelf Life);
dic.Add("start_production_date",Start Production Date);
dic.Add("end_production_date",End Production Date);
dic.Add("production_standard_number",Production Standard Number);
dic.Add("out_goods_id",Out Goods Id);
dic.Add("image_url",Image Url);
dic.Add("invoice_status",Invoice Status);
dic.Add("goods_properties",Goods Properties);
dic.Add("out_sku_sn",Out Sku Sn);
dic.Add("template_pid",Template Pid);
dic.Add("template_module_id",Template Module Id);
dic.Add("pid",Pid);
dic.Add("vid",Vid);
dic.Add("value",Value);
dic.Add("value_unit",Value Unit);
    
    var result = Post<UpdateGoodsInformationApiResult>(pdd.goods.information.update,);
    return JsonConvert.DeserializeObject<UpdateGoodsInformationApiResult>(result);
}/// <summary>
/// 商品明细
/// </summary>
/// <param name="GoodsId">1213414</param>
public async Task<GetGoodsDetailApiResult> GetGoodsDetailAsync(number GoodsId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("goods_id",Goods Id);
    
    var result = Post<GetGoodsDetailApiResult>(pdd.goods.detail.get,);
    return JsonConvert.DeserializeObject<GetGoodsDetailApiResult>(result);
}/// <summary>
/// 商品上架状态设置
/// </summary>
/// <param name="GoodsId">拼多多商品id</param>
/// <param name="IsOnsale">上下架状态：1:上架 0:下架</param>
public async Task<SetGoodsSaleStatusApiResult> SetGoodsSaleStatusAsync(number GoodsId,number IsOnsale)
{
    var dic = new Dictionary<string, string>();
    dic.Add("goods_id",Goods Id);
dic.Add("is_onsale",Is Onsale);
    
    var result = Post<SetGoodsSaleStatusApiResult>(pdd.goods.sale.status.set,);
    return JsonConvert.DeserializeObject<SetGoodsSaleStatusApiResult>(result);
}/// <summary>
/// 查询商品标签列表
/// </summary>
/// <param name="ParentOptId">值=0时为顶点opt_id,通过树顶级节点获取opt树</param>
public async Task<GetGoodsOptApiResult> GetGoodsOptAsync(number ParentOptId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("parent_opt_id",Parent Opt Id);
    
    var result = Post<GetGoodsOptApiResult>(pdd.goods.opt.get,);
    return JsonConvert.DeserializeObject<GetGoodsOptApiResult>(result);
}/// <summary>
/// 创建商品物流模版
/// </summary>
/// <param name="CostTemplateList">非包邮模版列表</param>
/// <param name="FreeProvinceList">包邮地区</param>
/// <param name="CostType">计费方式，0-按件计费，1-按重量计费</param>
/// <param name="FreeDeliverHouse">是否送货入户</param>
/// <param name="TemplateName">运费模板名称</param>
/// <param name="FirstStandard">首件</param>
/// <param name="FirstCost">首件或首重价格，单位为分</param>
/// <param name="AddStandard">续重或续件</param>
/// <param name="AddCost">续件或续重价格，单位为分</param>
/// <param name="IsHaveFreeMinCount">对不包邮地区，true-若要包邮须满足件数包邮，false-不开启满足件数包邮</param>
/// <param name="HaveFreeMinCount">对不包邮地区，满足指定件数包邮，该值为商家设置的指定件数，若为-1则商家没有开启满足件数包邮</param>
/// <param name="IsHaveFreeMinAmount">对不包邮地区，true-若要包邮须满足指定价格则可以包邮，false-不开启满足指定价格包邮</param>
/// <param name="HaveFreeMinAmount">对不包邮地区，满足指定价格包邮，该值为商家设置的指定订单金额，若为-1则商家没有开启满足指定价格包邮，注意，单位为分</param>
/// <param name="CostProvinceList">省份列表</param>
/// <param name="ProvinceId">省份ID</param>
/// <param name="ProvinceId">省份ID</param>
/// <param name="CityId">城市ID</param>
/// <param name="TownId">城区ID</param>
/// <param name="ProvinceId">省份ID</param>
/// <param name="FreeDeliverHouseAreaList">送货入户区域</param>
public async Task<CreateGoodsLogisticsTemplateApiResult> CreateGoodsLogisticsTemplateAsync(string CostTemplateList,string FreeProvinceList,number CostType,boolean FreeDeliverHouse,string TemplateName,number FirstStandard,number FirstCost,number AddStandard,number AddCost,boolean IsHaveFreeMinCount,number HaveFreeMinCount,boolean IsHaveFreeMinAmount,number HaveFreeMinAmount,string CostProvinceList,number ProvinceId,number ProvinceId,number CityId,number TownId,number ProvinceId,string FreeDeliverHouseAreaList)
{
    var dic = new Dictionary<string, string>();
    dic.Add("cost_template_list",Cost Template List);
dic.Add("free_province_list",Free Province List);
dic.Add("cost_type",Cost Type);
dic.Add("free_deliver_house",Free Deliver House);
dic.Add("template_name",Template Name);
dic.Add("first_standard",First Standard);
dic.Add("first_cost",First Cost);
dic.Add("add_standard",Add Standard);
dic.Add("add_cost",Add Cost);
dic.Add("is_have_free_min_count",Is Have Free Min Count);
dic.Add("have_free_min_count",Have Free Min Count);
dic.Add("is_have_free_min_amount",Is Have Free Min Amount);
dic.Add("have_free_min_amount",Have Free Min Amount);
dic.Add("cost_province_list",Cost Province List);
dic.Add("province_id",Province Id);
dic.Add("province_id",Province Id);
dic.Add("city_id",City Id);
dic.Add("town_id",Town Id);
dic.Add("province_id",Province Id);
dic.Add("free_deliver_house_area_list",Free Deliver House Area List);
    
    var result = Post<CreateGoodsLogisticsTemplateApiResult>(pdd.goods.logistics.template.create,);
    return JsonConvert.DeserializeObject<CreateGoodsLogisticsTemplateApiResult>(result);
}/// <summary>
/// 获取商品提交的商品详情
/// </summary>
/// <param name="GoodsCommitId">提交申请的序列id</param>
public async Task<GetGoodsCommitDetailApiResult> GetGoodsCommitDetailAsync(number GoodsCommitId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("goods_commit_id",Goods Commit Id);
    
    var result = Post<GetGoodsCommitDetailApiResult>(pdd.goods.commit.detail.get,);
    return JsonConvert.DeserializeObject<GetGoodsCommitDetailApiResult>(result);
}/// <summary>
/// 商品关联信息设置接口
/// </summary>
/// <param name="GoodsId">拼多多商品id</param>
/// <param name="OutGoodsId">外部平台商品id</param>
/// <param name="OutLowGoodsPrice">外部平台商品最低价，单位：分</param>
/// <param name="OutHighGoodsPrice">外部平台商品最高价，单位：分</param>
/// <param name="SourceType">外部平台枚举值， 淘宝/天猫 0，京东1，1688 2，唯品会3，苏宁4，亚马逊,5，网易6，其他7</param>
/// <param name="Postage">邮费</param>
/// <param name="OutDetailUrl">外部平台商品url</param>
public async Task<SetGoodsRelationApiResult> SetGoodsRelationAsync(number GoodsId,number OutGoodsId,number OutLowGoodsPrice,number OutHighGoodsPrice,number SourceType,number Postage,string OutDetailUrl)
{
    var dic = new Dictionary<string, string>();
    dic.Add("goods_id",Goods Id);
dic.Add("out_goods_id",Out Goods Id);
dic.Add("out_low_goods_price",Out Low Goods Price);
dic.Add("out_high_goods_price",Out High Goods Price);
dic.Add("source_type",Source Type);
dic.Add("postage",Postage);
dic.Add("out_detail_url",Out Detail Url);
    
    var result = Post<SetGoodsRelationApiResult>(pdd.goods.relation.set,);
    return JsonConvert.DeserializeObject<SetGoodsRelationApiResult>(result);
}/// <summary>
/// 新增或编辑草稿接口
/// </summary>
/// <param name="CatId">叶子类目ID</param>
/// <param name="SpecIdList">商品规格列表，根据pdd.goods.spec.id.get生成的规格属性id，例如：颜色规格下商家新增白色和黑色，大小规格下商家新增L和XL，则由4种spec组合，入参一种组合即可，在skulist中需要有4个spec组合的sku</param>
/// <param name="Weight">重量，单位为g</param>
/// <param name="Quantity">商品sku库存初始数量，后续库存update只使用stocks.update接口进行调用</param>
/// <param name="ThumbUrl">sku预览图，预览图尺寸：等宽高，且高度不低于480px，现已支持1M大小，越清晰越好卖，SKU预览图格式：仅支持JPG,PNG格式</param>
/// <param name="MultiPrice">商品团购价格</param>
/// <param name="Price">商品单买价格</param>
/// <param name="LimitQuantity">sku购买限制，只入参999</param>
/// <param name="IsOnsale">sku上架状态，0-已下架，1-上架中</param>
/// <param name="GoodsName">商品标题，例如，新疆特产 红满疆枣夹核桃500g</param>
/// <param name="GoodsType">1-国内普通商品，2-进口，3-国外海淘，4-直邮 ,5-流量,6-话费,7,优惠券;8-QQ充值,9-加油卡 暂时支持1-普通商品的上架</param>
/// <param name="GoodsDesc">商品描述， 字数限制：20-500，例如，新包装，保证产品的口感和新鲜度。单颗独立小包装，双重营养，1斤家庭分享装，更实惠新疆一级骏枣夹核桃仁。</param>
/// <param name="TinyName">商品短标题（仅在部分活动中生效），字数限制为4-20字</param>
/// <param name="CountryId">国家ID，0-中国，暂时只传0（普通商品）</param>
/// <param name="Warehouse">保税仓，只在goods_type为直供商品时有效（现阶段暂不支持）</param>
/// <param name="Customs">海关名称，只在goods_type为直供商品时有效（现阶段暂不支持）</param>
/// <param name="IsCustoms">是否需要上报海关，现阶段入参默认false，入参true会失败</param>
/// <param name="MarketPrice">市场价格，单位为分</param>
/// <param name="IsPreSale">是否预售,true-预售商品，false-非预售商品</param>
/// <param name="PreSaleTime">预售时间，is_pre_sale为1时必传，UNIX时间戳</param>
/// <param name="ShipmentLimitSecond">承诺发货时间（ 秒），48小时或24小时，is_pre_sale为1时不必传</param>
/// <param name="CostTemplateId">物流运费模板ID，可使用pdd.logistics.template.get获取</param>
/// <param name="CustomerNum">团购人数</param>
/// <param name="BuyLimit">单次限量</param>
/// <param name="OrderLimit">限购次数</param>
/// <param name="IsRefundable">是否7天无理由退换货，true-支持，false-不支持</param>
/// <param name="SecondHand">是否二手商品，true -二手商品 ，false-全新商品</param>
/// <param name="IsFolt">是否支持假一赔十，false-不支持，true-支持</param>
/// <param name="Fabric">服饰面料，fabirc枚举如下：</param>
/// <param name="FabricContent">成分含量</param>
/// <param name="WarmTips">水果类目温馨提示，只在水果类目商品才生效， 字数限制：商品描述goods_desc+温馨提示总计不超过500字。</param>
/// <param name="ShelfLife">食品保质期，cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079
)必填</param>
/// <param name="StartProductionDate">生产日期起始时间， 
cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079
)必填</param>
/// <param name="EndProductionDate">生产许可证编号， 
cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079
)必填</param>
/// <param name="ProductionStandardNumber">产品标准号， 
cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079
)必填</param>
/// <param name="SkuList">sku对象列表</param>
/// <param name="OutGoodsId">商品goods外部编码</param>
/// <param name="HdThumbUrl">高清缩略图，上传轮播图首图，尺寸400*400，图片格式仅支持JPG,PNG格式</param>
/// <param name="ThumbUrl">普通缩略图，上传轮播图首图，尺寸200*200，图片格式仅支持JPG,PNG格式</param>
/// <param name="ImageUrl">商品主图，请参考拼多多首页大图，如果商品参加部分活动则必填，否则无法参加活动
a. 尺寸750 x 352px
b. 大小100k以内
c. 图片格式仅支持JPG,PNG格式
d. 图片背景应以纯白为主, 商品图案居中显示
e. 图片不可以添加任何品牌相关文字或logo</param>
/// <param name="CarouselGallery">商品轮播图，按次序上传，图片格式支持JPEG/JPG/PNG， 图片尺寸长宽比1：1且尺寸不低于480px，图片大小最高1MB</param>
/// <param name="DetailGallery">商品详情图：
a. 尺寸要求宽度处于480~1200px之间，高度0-1500px之间
b. 大小1M以内
c. 数量限制在20张之间
d. 图片格式仅支持JPG,PNG格式
e. 点击上传时，支持批量上传详情图</param>
/// <param name="InvoiceStatus">invoice_status</param>
/// <param name="GoodsProperties">商品属性列表</param>
/// <param name="OutSkuSn">商品sku外部编码</param>
public async Task<CommitGoodsEditGoodsApiResult> CommitGoodsEditGoodsAsync(number CatId,jsonstring SpecIdList,number Weight,number Quantity,string ThumbUrl,number MultiPrice,number Price,number LimitQuantity,number IsOnsale,string GoodsName,number GoodsType,string GoodsDesc,string TinyName,number CountryId,string Warehouse,string Customs,boolean IsCustoms,number MarketPrice,boolean IsPreSale,string PreSaleTime,string ShipmentLimitSecond,number CostTemplateId,number CustomerNum,number BuyLimit,number OrderLimit,boolean IsRefundable,boolean SecondHand,boolean IsFolt,number Fabric,number FabricContent,string WarmTips,number ShelfLife,string StartProductionDate,string EndProductionDate,string ProductionStandardNumber,jsonstring SkuList,number OutGoodsId,string HdThumbUrl,string ThumbUrl,string ImageUrl,jsonstring CarouselGallery,jsonstring DetailGallery,number InvoiceStatus,string GoodsProperties,number OutSkuSn)
{
    var dic = new Dictionary<string, string>();
    dic.Add("cat_id",Cat Id);
dic.Add("spec_id_list",Spec Id List);
dic.Add("weight",Weight);
dic.Add("quantity",Quantity);
dic.Add("thumb_url",Thumb Url);
dic.Add("multi_price",Multi Price);
dic.Add("price",Price);
dic.Add("limit_quantity",Limit Quantity);
dic.Add("is_onsale",Is Onsale);
dic.Add("goods_name",Goods Name);
dic.Add("goods_type",Goods Type);
dic.Add("goods_desc",Goods Desc);
dic.Add("tiny_name",Tiny Name);
dic.Add("country_id",Country Id);
dic.Add("warehouse",Warehouse);
dic.Add("customs",Customs);
dic.Add("is_customs",Is Customs);
dic.Add("market_price",Market Price);
dic.Add("is_pre_sale",Is Pre Sale);
dic.Add("pre_sale_time",Pre Sale Time);
dic.Add("shipment_limit_second",Shipment Limit Second);
dic.Add("cost_template_id",Cost Template Id);
dic.Add("customer_num",Customer Num);
dic.Add("buy_limit",Buy Limit);
dic.Add("order_limit",Order Limit);
dic.Add("is_refundable",Is Refundable);
dic.Add("second_hand",Second Hand);
dic.Add("is_folt",Is Folt);
dic.Add("fabric",Fabric);
dic.Add("fabric_content",Fabric Content);
dic.Add("warm_tips",Warm Tips);
dic.Add("shelf_life",Shelf Life);
dic.Add("start_production_date",Start Production Date);
dic.Add("end_production_date",End Production Date);
dic.Add("production_standard_number",Production Standard Number);
dic.Add("sku_list",Sku List);
dic.Add("out_goods_id",Out Goods Id);
dic.Add("hd_thumb_url",Hd Thumb Url);
dic.Add("thumb_url",Thumb Url);
dic.Add("image_url",Image Url);
dic.Add("carousel_gallery",Carousel Gallery);
dic.Add("detail_gallery",Detail Gallery);
dic.Add("invoice_status",Invoice Status);
dic.Add("goods_properties",Goods Properties);
dic.Add("out_sku_sn",Out Sku Sn);
    
    var result = Post<CommitGoodsEditGoodsApiResult>(pdd.goods.edit.goods.commit,);
    return JsonConvert.DeserializeObject<CommitGoodsEditGoodsApiResult>(result);
}/// <summary>
/// 编辑并提交草稿接口
/// </summary>
/// <param name="GoodsId">1213414</param>
/// <param name="GoodsName">商品标题，例如，新疆特产 红满疆枣夹核桃500g</param>
/// <param name="GoodsType">1-国内普通商品，2-进口，3-国外海淘，4-直邮 ,5-流量,6-话费,7,优惠券;8-QQ充值,9-加油卡 暂时支持1-普通商品的上架</param>
/// <param name="GoodsDesc">商品描述， 字数限制：20-500，例如，新包装，保证产品的口感和新鲜度。单颗独立小包装，双重营养，1斤家庭分享装，更实惠新疆一级骏枣夹核桃仁。</param>
/// <param name="CatId">叶子类目ID</param>
/// <param name="CountryId">国家ID，0-中国，暂时只传0（普通商品）</param>
/// <param name="MarketPrice">市场价格，单位为分</param>
/// <param name="IsPreSale">是否预售,true-预售商品，false-非预售商品</param>
/// <param name="ShipmentLimitSecond">承诺发货时间（ 秒），48小时或24小时，is_pre_sale为1时不必传</param>
/// <param name="CostTemplateId">物流运费模板ID，可使用pdd.logistics.template.get获取</param>
/// <param name="IsRefundable">是否7天无理由退换货，true-支持，false-不支持</param>
/// <param name="SecondHand">是否二手商品，true -二手商品 ，false-全新商品</param>
/// <param name="IsFolt">是否支持假一赔十，false-不支持，true-支持</param>
/// <param name="SkuList">sku对象列表</param>
/// <param name="HdThumbUrl">高清缩略图，上传轮播图首图，尺寸400*400，图片格式仅支持JPG,PNG格式</param>
/// <param name="ThumbUrl">普通缩略图，上传轮播图首图，尺寸200*200，图片格式仅支持JPG,PNG格式</param>
/// <param name="CarouselGallery">商品轮播图，按次序上传，图片格式支持JPEG/JPG/PNG， 图片尺寸长宽比1：1且尺寸不低于480px，图片大小最高1MB</param>
/// <param name="DetailGallery">商品详情图：
a. 尺寸要求宽度处于480~1200px之间，高度0-1500px之间
b. 大小1M以内
c. 数量限制在20张之间
d. 图片格式仅支持JPG,PNG格式
e. 点击上传时，支持批量上传详情图</param>
/// <param name="InvoiceStatus">invoice_status</param>
/// <param name="GoodsCommitId">草稿id</param>
/// <param name="SpecIdList">商品规格列表，根据pdd.goods.spec.id.get生成的规格属性id，例如：颜色规格下商家新增白色和黑色，大小规格下商家新增L和XL，则由4种spec组合，入参一种组合即可，在skulist中需要有4个spec组合的sku</param>
/// <param name="Weight">重量，单位为g</param>
/// <param name="Quantity">商品sku库存初始数量，后续库存update只使用stocks.update接口进行调用</param>
/// <param name="ThumbUrl">sku预览图，预览图尺寸：等宽高，且高度不低于480px，现已支持1M大小，越清晰越好卖，SKU预览图格式：仅支持JPG,PNG格式</param>
/// <param name="MultiPrice">商品团购价格</param>
/// <param name="Price">商品单买价格</param>
/// <param name="LimitQuantity">sku购买限制，只入参999</param>
/// <param name="IsOnsale">sku上架状态，0-已下架，1-上架中</param>
/// <param name="TinyName">商品短标题（仅在部分活动中生效），字数限制为4-20字</param>
/// <param name="Warehouse">保税仓，只在goods_type为直供商品时有效（现阶段暂不支持）</param>
/// <param name="Customs">海关名称，只在goods_type为直供商品时有效（现阶段暂不支持）</param>
/// <param name="IsCustoms">是否需要上报海关，现阶段入参默认false，入参true会失败</param>
/// <param name="PreSaleTime">预售时间，is_pre_sale为1时必传，UNIX时间戳</param>
/// <param name="CustomerNum">团购人数</param>
/// <param name="BuyLimit">单次限量</param>
/// <param name="OrderLimit">限购次数</param>
/// <param name="Fabric">服饰面料，fabirc枚举如下：</param>
/// <param name="FabricContent">成分含量</param>
/// <param name="WarmTips">水果类目温馨提示，只在水果类目商品才生效， 字数限制：商品描述goods_desc+温馨提示总计不超过500字。</param>
/// <param name="ShelfLife">食品保质期，cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079
)必填</param>
/// <param name="StartProductionDate">生产日期起始时间， 
cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079
)必填</param>
/// <param name="EndProductionDate">生产许可证编号， 
cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079
)必填</param>
/// <param name="ProductionStandardNumber">产品标准号， 
cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079
)必填</param>
/// <param name="OutGoodsId">商品goods外部编码</param>
/// <param name="ImageUrl">商品主图，请参考拼多多首页大图，如果商品参加部分活动则必填，否则无法参加活动
a. 尺寸750 x 352px
b. 大小100k以内
c. 图片格式仅支持JPG,PNG格式
d. 图片背景应以纯白为主, 商品图案居中显示
e. 图片不可以添加任何品牌相关文字或logo</param>
/// <param name="GoodsProperties">商品属性列表</param>
/// <param name="OutSkuSn">商品sku外部编码</param>
/// <param name="TemplatePid">模板属性id</param>
/// <param name="TemplateModuleId">模板模块id</param>
/// <param name="Pid">属性id</param>
/// <param name="Vid">属性值id</param>
/// <param name="Value">属性值</param>
/// <param name="ValueUnit">属性单位</param>
public async Task<CommitGoodsSubmitGoodsApiResult> CommitGoodsSubmitGoodsAsync(number GoodsId,string GoodsName,number GoodsType,string GoodsDesc,number CatId,number CountryId,number MarketPrice,boolean IsPreSale,string ShipmentLimitSecond,number CostTemplateId,boolean IsRefundable,boolean SecondHand,boolean IsFolt,jsonstring SkuList,string HdThumbUrl,string ThumbUrl,jsonstring CarouselGallery,jsonstring DetailGallery,number InvoiceStatus,number GoodsCommitId,jsonstring SpecIdList,number Weight,number Quantity,string ThumbUrl,number MultiPrice,number Price,number LimitQuantity,number IsOnsale,string TinyName,string Warehouse,string Customs,boolean IsCustoms,string PreSaleTime,number CustomerNum,number BuyLimit,number OrderLimit,number Fabric,number FabricContent,string WarmTips,number ShelfLife,string StartProductionDate,string EndProductionDate,string ProductionStandardNumber,number OutGoodsId,string ImageUrl,string GoodsProperties,number OutSkuSn,number TemplatePid,number TemplateModuleId,number Pid,number Vid,string Value,string ValueUnit)
{
    var dic = new Dictionary<string, string>();
    dic.Add("goods_id",Goods Id);
dic.Add("goods_name",Goods Name);
dic.Add("goods_type",Goods Type);
dic.Add("goods_desc",Goods Desc);
dic.Add("cat_id",Cat Id);
dic.Add("country_id",Country Id);
dic.Add("market_price",Market Price);
dic.Add("is_pre_sale",Is Pre Sale);
dic.Add("shipment_limit_second",Shipment Limit Second);
dic.Add("cost_template_id",Cost Template Id);
dic.Add("is_refundable",Is Refundable);
dic.Add("second_hand",Second Hand);
dic.Add("is_folt",Is Folt);
dic.Add("sku_list",Sku List);
dic.Add("hd_thumb_url",Hd Thumb Url);
dic.Add("thumb_url",Thumb Url);
dic.Add("carousel_gallery",Carousel Gallery);
dic.Add("detail_gallery",Detail Gallery);
dic.Add("invoice_status",Invoice Status);
dic.Add("goods_commit_id",Goods Commit Id);
dic.Add("spec_id_list",Spec Id List);
dic.Add("weight",Weight);
dic.Add("quantity",Quantity);
dic.Add("thumb_url",Thumb Url);
dic.Add("multi_price",Multi Price);
dic.Add("price",Price);
dic.Add("limit_quantity",Limit Quantity);
dic.Add("is_onsale",Is Onsale);
dic.Add("tiny_name",Tiny Name);
dic.Add("warehouse",Warehouse);
dic.Add("customs",Customs);
dic.Add("is_customs",Is Customs);
dic.Add("pre_sale_time",Pre Sale Time);
dic.Add("customer_num",Customer Num);
dic.Add("buy_limit",Buy Limit);
dic.Add("order_limit",Order Limit);
dic.Add("fabric",Fabric);
dic.Add("fabric_content",Fabric Content);
dic.Add("warm_tips",Warm Tips);
dic.Add("shelf_life",Shelf Life);
dic.Add("start_production_date",Start Production Date);
dic.Add("end_production_date",End Production Date);
dic.Add("production_standard_number",Production Standard Number);
dic.Add("out_goods_id",Out Goods Id);
dic.Add("image_url",Image Url);
dic.Add("goods_properties",Goods Properties);
dic.Add("out_sku_sn",Out Sku Sn);
dic.Add("template_pid",Template Pid);
dic.Add("template_module_id",Template Module Id);
dic.Add("pid",Pid);
dic.Add("vid",Vid);
dic.Add("value",Value);
dic.Add("value_unit",Value Unit);
    
    var result = Post<CommitGoodsSubmitGoodsApiResult>(pdd.goods.submit.goods.commit,);
    return JsonConvert.DeserializeObject<CommitGoodsSubmitGoodsApiResult>(result);
}/// <summary>
/// 查询模板接口
/// </summary>
/// <param name="CatId">类目id</param>
public async Task<GetGoodsMallTemplateApiResult> GetGoodsMallTemplateAsync(number CatId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("cat_id",Cat Id);
    
    var result = Post<GetGoodsMallTemplateApiResult>(pdd.goods.mall.template.get,);
    return JsonConvert.DeserializeObject<GetGoodsMallTemplateApiResult>(result);
}/// <summary>
/// 搜索属性值接口
/// </summary>
/// <param name="TemplatePid">模板属性id</param>
/// <param name="ParentVid">父属性值id</param>
/// <param name="Value">属性值</param>
public async Task<SearchGoodsTemplateValueApiResult> SearchGoodsTemplateValueAsync(number TemplatePid,number ParentVid,string Value)
{
    var dic = new Dictionary<string, string>();
    dic.Add("template_pid",Template Pid);
dic.Add("parent_vid",Parent Vid);
dic.Add("value",Value);
    
    var result = Post<SearchGoodsTemplateValueApiResult>(pdd.goods.template.value.search,);
    return JsonConvert.DeserializeObject<SearchGoodsTemplateValueApiResult>(result);
}/// <summary>
/// 查询子属性接口
/// </summary>
/// <param name="TemplatePid">templatePid</param>
/// <param name="Vid">vid</param>
public async Task<GetGoodsTemplateSubPropertyApiResult> GetGoodsTemplateSubPropertyAsync(number TemplatePid,number Vid)
{
    var dic = new Dictionary<string, string>();
    dic.Add("template_pid",Template Pid);
dic.Add("vid",Vid);
    
    var result = Post<GetGoodsTemplateSubPropertyApiResult>(pdd.goods.template.sub.property.get,);
    return JsonConvert.DeserializeObject<GetGoodsTemplateSubPropertyApiResult>(result);
}/// <summary>
/// 修改商品sku价格
/// </summary>
/// <param name="GoodsId">商品id</param>
/// <param name="SkuPriceList">待修改的sku价格</param>
/// <param name="SinglePrice">单独购买价格（单位分）</param>
/// <param name="GroupPrice">拼团购买价格（单位分）</param>
/// <param name="SkuId">sku标识</param>
public async Task<UpdateGoodsSkuPriceApiResult> UpdateGoodsSkuPriceAsync(string GoodsId,jsonstring SkuPriceList,number SinglePrice,number GroupPrice,number SkuId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("goods_id",Goods Id);
dic.Add("sku_price_list",Sku Price List);
dic.Add("single_price",Single Price);
dic.Add("group_price",Group Price);
dic.Add("sku_id",Sku Id);
    
    var result = Post<UpdateGoodsSkuPriceApiResult>(pdd.goods.sku.price.update,);
    return JsonConvert.DeserializeObject<UpdateGoodsSkuPriceApiResult>(result);
}/// <summary>
/// 第三方平台商详字段转化到拼多多草稿箱
/// </summary>
/// <param name="NumIid">第三方平台商品的商品ID</param>
/// <param name="Title">第三方平台商品的商品标题，例如“马克杯”</param>
/// <param name="Cid">第三方平台商品所属的叶子类目id，例如“162653”</param>
/// <param name="Desc">第三方平台商品描述，例如“马克杯，高16.cm，白色，http://testimg.yangkeduo.com/pdd_oms/2018-07-13/06b79325f5235b9d420201414ca57488.jpeg"</param>
/// <param name="PicUrl">第三方平台商品主图片地址，例如“http://testimg.yangkeduo.com/pdd_oms/2018-07-13/06b79325f5235b9d420201414ca57488.jpeg"</param>
/// <param name="StuffStatus">第三方平台商品新旧程度，全新new，闲置unused，二手second</param>
/// <param name="CostTemplateId">拼多多的物流运费模板ID，可使用pdd.logistics.template.get获取</param>
/// <param name="ItemImgsUrl">第三方平台商品轮播图地址（包括主图)，最多传5张，例如：
“http://testimg.yangkeduo.com/pdd_oms/2018-07-13/06b79325f5235b9d420201414ca57488.jpeg”</param>
/// <param name="Skus">第三方

平台商品的sku内容，包括：sku的销售属性组合字符串properties_name（必填，当您上传的商品是单品时可以不传），sku对应的商品数量quantity（必填），sku应的商品价格price（必填），sku的商家外部outer_id（选填），例如：[{"outer_id":"1","price":51, "properties_name":"1627207:28332:颜色:浅灰色","quantity":11}]</param>
/// <param name="OuterId">第三方平台商品的商家外部编码，可与商家外部系统对应，例如“34143554352“</param>
public async Task<FieldExchangeThirdApiResult> FieldExchangeThirdAsync(long NumIid,string Title,string Cid,string Desc,string PicUrl,string StuffStatus,long CostTemplateId,string ItemImgsUrl,json string Skus,string OuterId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("num_iid",Num Iid);
dic.Add("title",Title);
dic.Add("cid",Cid);
dic.Add("desc",Desc);
dic.Add("pic_url",Pic Url);
dic.Add("stuff_status",Stuff Status);
dic.Add("cost_template_id",Cost Template Id);
dic.Add("item_imgs_url",Item Imgs Url);
dic.Add("skus",Skus);
dic.Add("outer_id",Outer Id);
    
    var result = Post<FieldExchangeThirdApiResult>(pdd.exchange.third.field,);
    return JsonConvert.DeserializeObject<FieldExchangeThirdApiResult>(result);
}/// <summary>
/// 查询商品推广API
/// </summary>
/// <param name="GoodsId">商品id</param>
public async Task<QueryGoodsCpsUnitApiResult> QueryGoodsCpsUnitAsync(string GoodsId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("goods_id",Goods Id);
    
    var result = Post<QueryGoodsCpsUnitApiResult>(pdd.goods.cps.unit.query,);
    return JsonConvert.DeserializeObject<QueryGoodsCpsUnitApiResult>(result);
}/// <summary>
/// 设置全店推广API
/// </summary>
/// <param name="Rate">佣金比（千分比）</param>
public async Task<CreateGoodsCpsMallUnitApiResult> CreateGoodsCpsMallUnitAsync(number Rate)
{
    var dic = new Dictionary<string, string>();
    dic.Add("rate",Rate);
    
    var result = Post<CreateGoodsCpsMallUnitApiResult>(pdd.goods.cps.mall.unit.create,);
    return JsonConvert.DeserializeObject<CreateGoodsCpsMallUnitApiResult>(result);
}/// <summary>
/// 设置单品推广API
/// </summary>
/// <param name="Units">批量设置商品字符串，按照此格式来填写，具体参数见下。注意：创建优惠券时，必须优惠券几个参数都填，否则商品能创建成功,但是默认没有优惠券：[{"goods_id":10000,"rate":2,"coupon_id":123456,"coupon_start_time":1572345,"coupon_end_time":1576482,"discount":300,"init_quantity":600,"remain_quantity":560},{...}........]</param>
/// <param name="GoodsId">商品id</param>
/// <param name="Rate">佣金比例（千分比）</param>
/// <param name="CouponId">优惠券id</param>
/// <param name="CouponStartTime">优惠券开始时间（unix时间戳）</param>
/// <param name="CouponEndTime">优惠券结束时间（unix时间戳）</param>
/// <param name="Discount">优惠券面额（单位为分）</param>
/// <param name="InitQuantity">设置的优惠券张数</param>
/// <param name="RemainQuantity">剩余的优惠券张数</param>
public async Task<CreateGoodsCpsUnitApiResult> CreateGoodsCpsUnitAsync(string Units,number GoodsId,number Rate,number CouponId,string CouponStartTime,string CouponEndTime,number Discount,number InitQuantity,number RemainQuantity)
{
    var dic = new Dictionary<string, string>();
    dic.Add("units",Units);
dic.Add("goods_id",Goods Id);
dic.Add("rate",Rate);
dic.Add("coupon_id",Coupon Id);
dic.Add("coupon_start_time",Coupon Start Time);
dic.Add("coupon_end_time",Coupon End Time);
dic.Add("discount",Discount);
dic.Add("init_quantity",Init Quantity);
dic.Add("remain_quantity",Remain Quantity);
    
    var result = Post<CreateGoodsCpsUnitApiResult>(pdd.goods.cps.unit.create,);
    return JsonConvert.DeserializeObject<CreateGoodsCpsUnitApiResult>(result);
}/// <summary>
/// 修改商品推广API
/// </summary>
/// <param name="GoodsId">商品id</param>
/// <param name="Rate">佣金比例（千分比）</param>
/// <param name="CouponId">优惠券id</param>
/// <param name="CouponStartTime">优惠券开始时间（unix时间戳）</param>
/// <param name="CouponEndTime">优惠券结束时间（unix时间戳）</param>
/// <param name="Discount">优惠券面额（单位为分）</param>
/// <param name="InitQuantity">设置的优惠券张数</param>
/// <param name="RemainQuantity">优惠券剩余数量</param>
public async Task<ChangeGoodsCpsUnitApiResult> ChangeGoodsCpsUnitAsync(number GoodsId,number Rate,number CouponId,string CouponStartTime,string CouponEndTime,number Discount,number InitQuantity,number RemainQuantity)
{
    var dic = new Dictionary<string, string>();
    dic.Add("goods_id",Goods Id);
dic.Add("rate",Rate);
dic.Add("coupon_id",Coupon Id);
dic.Add("coupon_start_time",Coupon Start Time);
dic.Add("coupon_end_time",Coupon End Time);
dic.Add("discount",Discount);
dic.Add("init_quantity",Init Quantity);
dic.Add("remain_quantity",Remain Quantity);
    
    var result = Post<ChangeGoodsCpsUnitApiResult>(pdd.goods.cps.unit.change,);
    return JsonConvert.DeserializeObject<ChangeGoodsCpsUnitApiResult>(result);
}/// <summary>
/// 查询商品销量验证结果
/// </summary>
/// <param name="SerialNumber">申请标号</param>
public async Task<GetGoodsSoldCountAuditApiResult> GetGoodsSoldCountAuditAsync(string SerialNumber)
{
    var dic = new Dictionary<string, string>();
    dic.Add("serial_number",Serial Number);
    
    var result = Post<GetGoodsSoldCountAuditApiResult>(pdd.goods.sold.count.audit.get,);
    return JsonConvert.DeserializeObject<GetGoodsSoldCountAuditApiResult>(result);
}/// <summary>
/// 同步店铺销量
/// </summary>
/// <param name="PddGoodsId">拼多多商品id</param>
/// <param name="OutGoodsId">第三方商品id</param>
/// <param name="OutSoldCountMonth">第三方月销量</param>
/// <param name="OutSoldCountTotal">第三方总销量</param>
/// <param name="OutMallName">第三方店铺名称</param>
/// <param name="OutSourceType">商品来源平台，0，1，2，3，4，5，6，7</param>
public async Task<SetGoodsSoldCountApiResult> SetGoodsSoldCountAsync(string PddGoodsId,string OutGoodsId,string OutSoldCountMonth,string OutSoldCountTotal,string OutMallName,string OutSourceType)
{
    var dic = new Dictionary<string, string>();
    dic.Add("pdd_goods_id",Pdd Goods Id);
dic.Add("out_goods_id",Out Goods Id);
dic.Add("out_sold_count_month",Out Sold Count Month);
dic.Add("out_sold_count_total",Out Sold Count Total);
dic.Add("out_mall_name",Out Mall Name);
dic.Add("out_source_type",Out Source Type);
    
    var result = Post<SetGoodsSoldCountApiResult>(pdd.goods.sold.count.set,);
    return JsonConvert.DeserializeObject<SetGoodsSoldCountApiResult>(result);
}/// <summary>
/// 商品映射查询接口
/// </summary>
/// <param name="PddGoodsId">拼多多商品id</param>
public async Task<RelationGoodsGetApiResult> RelationGoodsGetAsync(json list PddGoodsId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("pdd_goods_id",Pdd Goods Id);
    
    var result = Post<RelationGoodsGetApiResult>(pdd.goods.get.relation,);
    return JsonConvert.DeserializeObject<RelationGoodsGetApiResult>(result);
}/// <summary>
/// 按id获取商品运费模版接口
/// </summary>
/// <param name="CostTemplateId">运费模板id</param>
public async Task<TemplateOneExpressCostApiResult> TemplateOneExpressCostAsync(integer CostTemplateId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("cost_template_id",Cost Template Id);
    
    var result = Post<TemplateOneExpressCostApiResult>(pdd.one.express.cost.template,);
    return JsonConvert.DeserializeObject<TemplateOneExpressCostApiResult>(result);
}
    }
}
