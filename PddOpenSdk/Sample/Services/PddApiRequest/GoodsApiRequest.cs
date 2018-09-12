using PddOpenSdk.Models.PddApiResult;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Services.PddApiRequest
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
public async Task<GetGoodsListApiResult> GetGoodsListAsync(string Type,string OuterId,int IsOnsale,string GoodsName,int PageSize,int Page)
{
    var dic = new Dictionary<string, object>();
    dic.Add("type",Type);
dic.Add("outer_id",OuterId);
dic.Add("is_onsale",IsOnsale);
dic.Add("goods_name",GoodsName);
dic.Add("page_size",PageSize);
dic.Add("page",Page);
    
    var result = await PostAsync<GetGoodsListApiResult>("pdd.goods.list.get",dic);
    return result;
}/// <summary>
/// 商品详情接口
/// </summary>
/// <param name="Type">该值为：pdd.goods.information.get</param>
/// <param name="GoodsId">商品编码</param>
public async Task<GetGoodsInformationApiResult> GetGoodsInformationAsync(string Type,string GoodsId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("type",Type);
dic.Add("goods_id",GoodsId);
    
    var result = await PostAsync<GetGoodsInformationApiResult>("pdd.goods.information.get",dic);
    return result;
}/// <summary>
/// 商品全量修改接口
/// </summary>
/// <param name="Type">该值为：pdd.goods.sku.stock.update</param>
/// <param name="Quantity">修改后的库存值：如 56</param>
/// <param name="SkuId">879512</param>
/// <param name="OuterId">外部编码如：outer_11，ps: sku_id 和 outer_id 两者必须填一个，同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。</param>
public async Task<UpdateGoodsSkuStockApiResult> UpdateGoodsSkuStockAsync(string Type,int Quantity,string SkuId,string OuterId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("type",Type);
dic.Add("quantity",Quantity);
dic.Add("sku_id",SkuId);
dic.Add("outer_id",OuterId);
    
    var result = await PostAsync<UpdateGoodsSkuStockApiResult>("pdd.goods.sku.stock.update",dic);
    return result;
}/// <summary>
/// 商品增量修改接口
/// </summary>
/// <param name="Type">该值为：pdd.goods.sku.stock.increment.update</param>
/// <param name="SkuId">商品sku编码</param>
/// <param name="OuterId">外部编码 outer_11，ps: sku_id 和 outer_id 两者必须填一个，同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。</param>
/// <param name="IncrementQuantity">增量库存值，222</param>
public async Task<UpdateGoodsSkuStockIncrementApiResult> UpdateGoodsSkuStockIncrementAsync(string Type,string SkuId,string OuterId,int IncrementQuantity)
{
    var dic = new Dictionary<string, object>();
    dic.Add("type",Type);
dic.Add("sku_id",SkuId);
dic.Add("outer _id",OuterId);
dic.Add("increment_quantity",IncrementQuantity);
    
    var result = await PostAsync<UpdateGoodsSkuStockIncrementApiResult>("pdd.goods.sku.stock.increment.update",dic);
    return result;
}/// <summary>
/// 商品标准类目接口
/// </summary>
/// <param name="Type">该值为：pdd.goods.cats.get</param>
/// <param name="ParentCatId">值=0时为顶点cat_id,通过树顶级节点获取cat树</param>
public async Task<GetGoodsCatsApiResult> GetGoodsCatsAsync(string Type,int ParentCatId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("type",Type);
dic.Add("parent_cat_id",ParentCatId);
    
    var result = await PostAsync<GetGoodsCatsApiResult>("pdd.goods.cats.get",dic);
    return result;
}/// <summary>
/// 商品运费模版接口
/// </summary>
/// <param name="Type">该值为：pdd.goods.logistics.template.get</param>
/// <param name="Page">默认返回运费模板的页数为1，最高为100页，注意：page与page_size必须传一个</param>
/// <param name="PageSize">默认返回20条模板数据，最多100条数据</param>
public async Task<GetGoodsLogisticsTemplateApiResult> GetGoodsLogisticsTemplateAsync(string Type,int Page,int PageSize)
{
    var dic = new Dictionary<string, object>();
    dic.Add("type",Type);
dic.Add("page",Page);
dic.Add("page_size",PageSize);
    
    var result = await PostAsync<GetGoodsLogisticsTemplateApiResult>("pdd.goods.logistics.template.get",dic);
    return result;
}/// <summary>
/// 商品图片上传接口
/// </summary>
/// <param name="Type">该值为：pdd.goods.image.upload</param>
/// <param name="Image">支持格式有：jpg/jpeg、png等图片格式，注意入参图片必须转码为base64编码</param>
public async Task<UploadGoodsImageApiResult> UploadGoodsImageAsync(string Type,string Image)
{
    var dic = new Dictionary<string, object>();
    dic.Add("type",Type);
dic.Add("image",Image);
    
    var result = await PostAsync<UploadGoodsImageApiResult>("pdd.goods.image.upload",dic);
    return result;
}/// <summary>
/// 商品国家接口
/// </summary>
/// <param name="Type">该值为：pdd.goods.country.get</param>
public async Task<GetGoodsCountryApiResult> GetGoodsCountryAsync(string Type)
{
    var dic = new Dictionary<string, object>();
    dic.Add("type",Type);
    
    var result = await PostAsync<GetGoodsCountryApiResult>("pdd.goods.country.get",dic);
    return result;
}/// <summary>
/// 生成商家自定义的规格
/// </summary>
/// <param name="Type">该值为：pdd.goods.spec.id.get，配合pdd.goods.spec.get接口获取对应要发布的商品所属叶子类目所需的规格id，通过此接口生成对应的规格名称，例如叶子类目下某规格id为0，对应规格名称为颜色，通过此接口可以新建颜色规格下颜色、白色等。</param>
/// <param name="ParentSpecId">拼多多标准规格ID，可以通过pdd.goods.spec.get接口获取</param>
/// <param name="SpecName">商家编辑的规格值，如颜色规格下设置白色属性</param>
public async Task<GetGoodsSpecIdApiResult> GetGoodsSpecIdAsync(string Type,int ParentSpecId,string SpecName)
{
    var dic = new Dictionary<string, object>();
    dic.Add("type",Type);
dic.Add("parent_spec_id",ParentSpecId);
dic.Add("spec_name",SpecName);
    
    var result = await PostAsync<GetGoodsSpecIdApiResult>("pdd.goods.spec.id.get",dic);
    return result;
}/// <summary>
/// 商品属性类目接口
/// </summary>
/// <param name="Type">该值为：pdd.goods.spec.get</param>
/// <param name="CatId">叶子类目ID，必须入参level=3时的cat_id,否则无法返回正确的参数</param>
public async Task<GetGoodsSpecApiResult> GetGoodsSpecAsync(string Type,string CatId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("type",Type);
dic.Add("cat_id",CatId);
    
    var result = await PostAsync<GetGoodsSpecApiResult>("pdd.goods.spec.get",dic);
    return result;
}/// <summary>
/// 获取当前授权商家可发布的商品类目信息
/// </summary>
/// <param name="Type">该值为：pdd.goods.authorization.cats</param>
/// <param name="ParentCatId">默认值=0，值=0时为顶点cat_id,通过树顶级节点获取一级类目</param>
public async Task<CatsGoodsAuthorizationApiResult> CatsGoodsAuthorizationAsync(string Type,int ParentCatId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("type",Type);
dic.Add("parent_cat_id",ParentCatId);
    
    var result = await PostAsync<CatsGoodsAuthorizationApiResult>("pdd.goods.authorization.cats",dic);
    return result;
}/// <summary>
/// 获取服饰成分含量信息
/// </summary>
/// <param name="Type">该值为：pdd.goods.fabric.content.get</param>
public async Task<GetGoodsFabricContentApiResult> GetGoodsFabricContentAsync(string Type)
{
    var dic = new Dictionary<string, object>();
    dic.Add("type",Type);
    
    var result = await PostAsync<GetGoodsFabricContentApiResult>("pdd.goods.fabric.content.get",dic);
    return result;
}/// <summary>
/// 获取服饰面料信息
/// </summary>
/// <param name="Type">该值为：pdd.goods.fabric.get</param>
public async Task<GetGoodsFabricApiResult> GetGoodsFabricAsync(string Type)
{
    var dic = new Dictionary<string, object>();
    dic.Add("type",Type);
    
    var result = await PostAsync<GetGoodsFabricApiResult>("pdd.goods.fabric.get",dic);
    return result;
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
/// <param name="DetailGallery">商品详情图：; a. 尺寸要求宽度处于480~1200px之间，高度0-1500px之间; b. 大小1M以内; c. 数量限制在20张之间; d. 图片格式仅支持JPG,PNG格式; e. 点击上传时，支持批量上传详情图</param>
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
/// <param name="ShelfLife">食品保质期，cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079; )必填</param>
/// <param name="StartProductionDate">生产日期起始时间， UNIX时间戳; cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079; )必填</param>
/// <param name="EndProductionDate">生产日期结束时间， UNIX时间戳; cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079; )必填</param>
/// <param name="ProductionStandardNumber">产品标准号， ; cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079; )必填</param>
/// <param name="OutGoodsId">商品goods外部编码，同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）。</param>
/// <param name="ImageUrl">商品主图，请参考拼多多首页大图，如果商品参加部分活动则必填，否则无法参加活动; a. 尺寸750 x 352px; b. 大小100k以内; c. 图片格式仅支持JPG,PNG格式; d. 图片背景应以纯白为主, 商品图案居中显示; e. 图片不可以添加任何品牌相关文字或logo</param>
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
public async Task<AddGoodsApiResult> AddGoodsAsync(string Type,string GoodsName,int GoodsType,string GoodsDesc,int CatId,int CountryId,int MarketPrice,bool IsPreSale,string ShipmentLimitSecond,int CostTemplateId,bool IsRefundable,bool SecondHand,bool IsFolt,jsonstring SkuList,string HdThumbUrl,string ThumbUrl,jsonstring CarouselGallery,jsonstring DetailGallery,jsonstring SpecIdList,int Weight,int Quantity,string ThumbUrl,int MultiPrice,int Price,int LimitQuantity,int IsOnsale,string TinyName,string Warehouse,string Customs,bool IsCustoms,string PreSaleTime,int CustomerNum,int BuyLimit,int OrderLimit,int Fabric,int FabricContent,string WarmTips,int ShelfLife,string StartProductionDate,string EndProductionDate,string ProductionStandardNumber,string OutGoodsId,string ImageUrl,string ProductionLicense,int PaperNetWeight,int PaperLength,int PaperWidth,int PaperPliesNum,int InvoiceStatus,string GoodsProperties,string OutSkuSn,int TemplatePid,int TemplateModuleId,int Pid,int Vid,string Value,string ValueUnit)
{
    var dic = new Dictionary<string, object>();
    dic.Add("type",Type);
dic.Add("goods_name",GoodsName);
dic.Add("goods_type",GoodsType);
dic.Add("goods_desc",GoodsDesc);
dic.Add("cat_id",CatId);
dic.Add("country_id",CountryId);
dic.Add("market_price",MarketPrice);
dic.Add("is_pre_sale",IsPreSale);
dic.Add("shipment_limit_second",ShipmentLimitSecond);
dic.Add("cost_template_id",CostTemplateId);
dic.Add("is_refundable",IsRefundable);
dic.Add("second_hand",SecondHand);
dic.Add("is_folt",IsFolt);
dic.Add("sku_list",SkuList);
dic.Add("hd_thumb_url",HdThumbUrl);
dic.Add("thumb_url",ThumbUrl);
dic.Add("carousel_gallery",CarouselGallery);
dic.Add("detail_gallery",DetailGallery);
dic.Add("spec_id_list",SpecIdList);
dic.Add("weight",Weight);
dic.Add("quantity",Quantity);
dic.Add("thumb_url",ThumbUrl);
dic.Add("multi_price",MultiPrice);
dic.Add("price",Price);
dic.Add("limit_quantity",LimitQuantity);
dic.Add("is_onsale",IsOnsale);
dic.Add("tiny_name",TinyName);
dic.Add("warehouse",Warehouse);
dic.Add("customs",Customs);
dic.Add("is_customs",IsCustoms);
dic.Add("pre_sale_time",PreSaleTime);
dic.Add("customer_num",CustomerNum);
dic.Add("buy_limit",BuyLimit);
dic.Add("order_limit",OrderLimit);
dic.Add("fabric",Fabric);
dic.Add("fabric_content",FabricContent);
dic.Add("warm_tips",WarmTips);
dic.Add("shelf_life",ShelfLife);
dic.Add("start_production_date",StartProductionDate);
dic.Add("end_production_date",EndProductionDate);
dic.Add("production_standard_number",ProductionStandardNumber);
dic.Add("out_goods_id",OutGoodsId);
dic.Add("image_url",ImageUrl);
dic.Add("production_license",ProductionLicense);
dic.Add("paper_net_weight",PaperNetWeight);
dic.Add("paper_length",PaperLength);
dic.Add("paper_width",PaperWidth);
dic.Add("paper_plies_num",PaperPliesNum);
dic.Add("invoice_status",InvoiceStatus);
dic.Add("goods_properties",GoodsProperties);
dic.Add("out_sku_sn",OutSkuSn);
dic.Add("template_pid",TemplatePid);
dic.Add("template_module_id",TemplateModuleId);
dic.Add("pid",Pid);
dic.Add("vid",Vid);
dic.Add("value",Value);
dic.Add("value_unit",ValueUnit);
    
    var result = await PostAsync<AddGoodsApiResult>("pdd.goods.add",dic);
    return result;
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
/// <param name="DetailGallery">商品详情图：; a. 尺寸要求宽度处于480~1200px之间，高度0-1500px之间; b. 大小1M以内; c. 数量限制在20张之间; d. 图片格式仅支持JPG,PNG格式; e. 点击上传时，支持批量上传详情图</param>
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
/// <param name="ShelfLife">食品保质期，cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079; )必填</param>
/// <param name="StartProductionDate">生产日期起始时间， ; cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079; )必填</param>
/// <param name="EndProductionDate">生产许可证编号， ; cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079; )必填</param>
/// <param name="ProductionStandardNumber">产品标准号， ; cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079; )必填</param>
/// <param name="OutGoodsId">商品goods外部编码，同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）。</param>
/// <param name="ImageUrl">商品主图，请参考拼多多首页大图，如果商品参加部分活动则必填，否则无法参加活动; a. 尺寸750 x 352px; b. 大小100k以内; c. 图片格式仅支持JPG,PNG格式; d. 图片背景应以纯白为主, 商品图案居中显示; e. 图片不可以添加任何品牌相关文字或logo</param>
/// <param name="InvoiceStatus">是否支持开票（测试中）</param>
/// <param name="GoodsProperties">商品属性列表</param>
/// <param name="OutSkuSn">商品sku外部编码，同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。</param>
/// <param name="TemplatePid">模板属性id</param>
/// <param name="TemplateModuleId">模板模块id</param>
/// <param name="Pid">属性id</param>
/// <param name="Vid">属性值id</param>
/// <param name="Value">属性值</param>
/// <param name="ValueUnit">属性单位</param>
public async Task<UpdateGoodsInformationApiResult> UpdateGoodsInformationAsync(int GoodsId,string GoodsName,int GoodsType,string GoodsDesc,int CatId,int CountryId,int MarketPrice,bool IsPreSale,string ShipmentLimitSecond,int CostTemplateId,bool IsRefundable,bool SecondHand,bool IsFolt,jsonstring SkuList,string HdThumbUrl,string ThumbUrl,jsonstring CarouselGallery,jsonstring DetailGallery,int SkuId,jsonstring SpecIdList,int Weight,int Quantity,string ThumbUrl,int MultiPrice,int Price,int LimitQuantity,int IsOnsale,string TinyName,string Warehouse,string Customs,bool IsCustoms,string PreSaleTime,int CustomerNum,int BuyLimit,int OrderLimit,int Fabric,int FabricContent,string WarmTips,int ShelfLife,string StartProductionDate,string EndProductionDate,string ProductionStandardNumber,int OutGoodsId,string ImageUrl,int InvoiceStatus,string GoodsProperties,int OutSkuSn,int TemplatePid,int TemplateModuleId,int Pid,int Vid,string Value,string ValueUnit)
{
    var dic = new Dictionary<string, object>();
    dic.Add("goods_id",GoodsId);
dic.Add("goods_name",GoodsName);
dic.Add("goods_type",GoodsType);
dic.Add("goods_desc",GoodsDesc);
dic.Add("cat_id",CatId);
dic.Add("country_id",CountryId);
dic.Add("market_price",MarketPrice);
dic.Add("is_pre_sale",IsPreSale);
dic.Add("shipment_limit_second",ShipmentLimitSecond);
dic.Add("cost_template_id",CostTemplateId);
dic.Add("is_refundable",IsRefundable);
dic.Add("second_hand",SecondHand);
dic.Add("is_folt",IsFolt);
dic.Add("sku_list",SkuList);
dic.Add("hd_thumb_url",HdThumbUrl);
dic.Add("thumb_url",ThumbUrl);
dic.Add("carousel_gallery",CarouselGallery);
dic.Add("detail_gallery",DetailGallery);
dic.Add("sku_id",SkuId);
dic.Add("spec_id_list",SpecIdList);
dic.Add("weight",Weight);
dic.Add("quantity",Quantity);
dic.Add("thumb_url",ThumbUrl);
dic.Add("multi_price",MultiPrice);
dic.Add("price",Price);
dic.Add("limit_quantity",LimitQuantity);
dic.Add("is_onsale",IsOnsale);
dic.Add("tiny_name",TinyName);
dic.Add("warehouse",Warehouse);
dic.Add("customs",Customs);
dic.Add("is_customs",IsCustoms);
dic.Add("pre_sale_time",PreSaleTime);
dic.Add("customer_num",CustomerNum);
dic.Add("buy_limit",BuyLimit);
dic.Add("order_limit",OrderLimit);
dic.Add("fabric",Fabric);
dic.Add("fabric_content",FabricContent);
dic.Add("warm_tips",WarmTips);
dic.Add("shelf_life",ShelfLife);
dic.Add("start_production_date",StartProductionDate);
dic.Add("end_production_date",EndProductionDate);
dic.Add("production_standard_number",ProductionStandardNumber);
dic.Add("out_goods_id",OutGoodsId);
dic.Add("image_url",ImageUrl);
dic.Add("invoice_status",InvoiceStatus);
dic.Add("goods_properties",GoodsProperties);
dic.Add("out_sku_sn",OutSkuSn);
dic.Add("template_pid",TemplatePid);
dic.Add("template_module_id",TemplateModuleId);
dic.Add("pid",Pid);
dic.Add("vid",Vid);
dic.Add("value",Value);
dic.Add("value_unit",ValueUnit);
    
    var result = await PostAsync<UpdateGoodsInformationApiResult>("pdd.goods.information.update",dic);
    return result;
}/// <summary>
/// 商品明细
/// </summary>
/// <param name="GoodsId">1213414</param>
public async Task<GetGoodsDetailApiResult> GetGoodsDetailAsync(int GoodsId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("goods_id",GoodsId);
    
    var result = await PostAsync<GetGoodsDetailApiResult>("pdd.goods.detail.get",dic);
    return result;
}/// <summary>
/// 商品上架状态设置
/// </summary>
/// <param name="GoodsId">拼多多商品id</param>
/// <param name="IsOnsale">上下架状态：1:上架 0:下架</param>
public async Task<SetGoodsSaleStatusApiResult> SetGoodsSaleStatusAsync(int GoodsId,int IsOnsale)
{
    var dic = new Dictionary<string, object>();
    dic.Add("goods_id",GoodsId);
dic.Add("is_onsale",IsOnsale);
    
    var result = await PostAsync<SetGoodsSaleStatusApiResult>("pdd.goods.sale.status.set",dic);
    return result;
}/// <summary>
/// 查询商品标签列表
/// </summary>
/// <param name="ParentOptId">值=0时为顶点opt_id,通过树顶级节点获取opt树</param>
public async Task<GetGoodsOptApiResult> GetGoodsOptAsync(int ParentOptId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("parent_opt_id",ParentOptId);
    
    var result = await PostAsync<GetGoodsOptApiResult>("pdd.goods.opt.get",dic);
    return result;
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
public async Task<CreateGoodsLogisticsTemplateApiResult> CreateGoodsLogisticsTemplateAsync(string CostTemplateList,string FreeProvinceList,int CostType,bool FreeDeliverHouse,string TemplateName,int FirstStandard,int FirstCost,int AddStandard,int AddCost,bool IsHaveFreeMinCount,int HaveFreeMinCount,bool IsHaveFreeMinAmount,int HaveFreeMinAmount,string CostProvinceList,int ProvinceId,int ProvinceId,int CityId,int TownId,int ProvinceId,string FreeDeliverHouseAreaList)
{
    var dic = new Dictionary<string, object>();
    dic.Add("cost_template_list",CostTemplateList);
dic.Add("free_province_list",FreeProvinceList);
dic.Add("cost_type",CostType);
dic.Add("free_deliver_house",FreeDeliverHouse);
dic.Add("template_name",TemplateName);
dic.Add("first_standard",FirstStandard);
dic.Add("first_cost",FirstCost);
dic.Add("add_standard",AddStandard);
dic.Add("add_cost",AddCost);
dic.Add("is_have_free_min_count",IsHaveFreeMinCount);
dic.Add("have_free_min_count",HaveFreeMinCount);
dic.Add("is_have_free_min_amount",IsHaveFreeMinAmount);
dic.Add("have_free_min_amount",HaveFreeMinAmount);
dic.Add("cost_province_list",CostProvinceList);
dic.Add("province_id",ProvinceId);
dic.Add("province_id",ProvinceId);
dic.Add("city_id",CityId);
dic.Add("town_id",TownId);
dic.Add("province_id",ProvinceId);
dic.Add("free_deliver_house_area_list",FreeDeliverHouseAreaList);
    
    var result = await PostAsync<CreateGoodsLogisticsTemplateApiResult>("pdd.goods.logistics.template.create",dic);
    return result;
}/// <summary>
/// 获取商品提交的商品详情
/// </summary>
/// <param name="GoodsCommitId">提交申请的序列id</param>
public async Task<GetGoodsCommitDetailApiResult> GetGoodsCommitDetailAsync(int GoodsCommitId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("goods_commit_id",GoodsCommitId);
    
    var result = await PostAsync<GetGoodsCommitDetailApiResult>("pdd.goods.commit.detail.get",dic);
    return result;
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
public async Task<SetGoodsRelationApiResult> SetGoodsRelationAsync(int GoodsId,int OutGoodsId,int OutLowGoodsPrice,int OutHighGoodsPrice,int SourceType,int Postage,string OutDetailUrl)
{
    var dic = new Dictionary<string, object>();
    dic.Add("goods_id",GoodsId);
dic.Add("out_goods_id",OutGoodsId);
dic.Add("out_low_goods_price",OutLowGoodsPrice);
dic.Add("out_high_goods_price",OutHighGoodsPrice);
dic.Add("source_type",SourceType);
dic.Add("postage",Postage);
dic.Add("out_detail_url",OutDetailUrl);
    
    var result = await PostAsync<SetGoodsRelationApiResult>("pdd.goods.relation.set",dic);
    return result;
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
/// <param name="ShelfLife">食品保质期，cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079; )必填</param>
/// <param name="StartProductionDate">生产日期起始时间， ; cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079; )必填</param>
/// <param name="EndProductionDate">生产许可证编号， ; cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079; )必填</param>
/// <param name="ProductionStandardNumber">产品标准号， ; cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079; )必填</param>
/// <param name="SkuList">sku对象列表</param>
/// <param name="OutGoodsId">商品goods外部编码</param>
/// <param name="HdThumbUrl">高清缩略图，上传轮播图首图，尺寸400*400，图片格式仅支持JPG,PNG格式</param>
/// <param name="ThumbUrl">普通缩略图，上传轮播图首图，尺寸200*200，图片格式仅支持JPG,PNG格式</param>
/// <param name="ImageUrl">商品主图，请参考拼多多首页大图，如果商品参加部分活动则必填，否则无法参加活动; a. 尺寸750 x 352px; b. 大小100k以内; c. 图片格式仅支持JPG,PNG格式; d. 图片背景应以纯白为主, 商品图案居中显示; e. 图片不可以添加任何品牌相关文字或logo</param>
/// <param name="CarouselGallery">商品轮播图，按次序上传，图片格式支持JPEG/JPG/PNG， 图片尺寸长宽比1：1且尺寸不低于480px，图片大小最高1MB</param>
/// <param name="DetailGallery">商品详情图：; a. 尺寸要求宽度处于480~1200px之间，高度0-1500px之间; b. 大小1M以内; c. 数量限制在20张之间; d. 图片格式仅支持JPG,PNG格式; e. 点击上传时，支持批量上传详情图</param>
/// <param name="InvoiceStatus">invoice_status</param>
/// <param name="GoodsProperties">商品属性列表</param>
/// <param name="OutSkuSn">商品sku外部编码</param>
public async Task<CommitGoodsEditGoodsApiResult> CommitGoodsEditGoodsAsync(int CatId,jsonstring SpecIdList,int Weight,int Quantity,string ThumbUrl,int MultiPrice,int Price,int LimitQuantity,int IsOnsale,string GoodsName,int GoodsType,string GoodsDesc,string TinyName,int CountryId,string Warehouse,string Customs,bool IsCustoms,int MarketPrice,bool IsPreSale,string PreSaleTime,string ShipmentLimitSecond,int CostTemplateId,int CustomerNum,int BuyLimit,int OrderLimit,bool IsRefundable,bool SecondHand,bool IsFolt,int Fabric,int FabricContent,string WarmTips,int ShelfLife,string StartProductionDate,string EndProductionDate,string ProductionStandardNumber,jsonstring SkuList,int OutGoodsId,string HdThumbUrl,string ThumbUrl,string ImageUrl,jsonstring CarouselGallery,jsonstring DetailGallery,int InvoiceStatus,string GoodsProperties,int OutSkuSn)
{
    var dic = new Dictionary<string, object>();
    dic.Add("cat_id",CatId);
dic.Add("spec_id_list",SpecIdList);
dic.Add("weight",Weight);
dic.Add("quantity",Quantity);
dic.Add("thumb_url",ThumbUrl);
dic.Add("multi_price",MultiPrice);
dic.Add("price",Price);
dic.Add("limit_quantity",LimitQuantity);
dic.Add("is_onsale",IsOnsale);
dic.Add("goods_name",GoodsName);
dic.Add("goods_type",GoodsType);
dic.Add("goods_desc",GoodsDesc);
dic.Add("tiny_name",TinyName);
dic.Add("country_id",CountryId);
dic.Add("warehouse",Warehouse);
dic.Add("customs",Customs);
dic.Add("is_customs",IsCustoms);
dic.Add("market_price",MarketPrice);
dic.Add("is_pre_sale",IsPreSale);
dic.Add("pre_sale_time",PreSaleTime);
dic.Add("shipment_limit_second",ShipmentLimitSecond);
dic.Add("cost_template_id",CostTemplateId);
dic.Add("customer_num",CustomerNum);
dic.Add("buy_limit",BuyLimit);
dic.Add("order_limit",OrderLimit);
dic.Add("is_refundable",IsRefundable);
dic.Add("second_hand",SecondHand);
dic.Add("is_folt",IsFolt);
dic.Add("fabric",Fabric);
dic.Add("fabric_content",FabricContent);
dic.Add("warm_tips",WarmTips);
dic.Add("shelf_life",ShelfLife);
dic.Add("start_production_date",StartProductionDate);
dic.Add("end_production_date",EndProductionDate);
dic.Add("production_standard_number",ProductionStandardNumber);
dic.Add("sku_list",SkuList);
dic.Add("out_goods_id",OutGoodsId);
dic.Add("hd_thumb_url",HdThumbUrl);
dic.Add("thumb_url",ThumbUrl);
dic.Add("image_url",ImageUrl);
dic.Add("carousel_gallery",CarouselGallery);
dic.Add("detail_gallery",DetailGallery);
dic.Add("invoice_status",InvoiceStatus);
dic.Add("goods_properties",GoodsProperties);
dic.Add("out_sku_sn",OutSkuSn);
    
    var result = await PostAsync<CommitGoodsEditGoodsApiResult>("pdd.goods.edit.goods.commit",dic);
    return result;
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
/// <param name="DetailGallery">商品详情图：; a. 尺寸要求宽度处于480~1200px之间，高度0-1500px之间; b. 大小1M以内; c. 数量限制在20张之间; d. 图片格式仅支持JPG,PNG格式; e. 点击上传时，支持批量上传详情图</param>
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
/// <param name="ShelfLife">食品保质期，cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079; )必填</param>
/// <param name="StartProductionDate">生产日期起始时间， ; cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079; )必填</param>
/// <param name="EndProductionDate">生产许可证编号， ; cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079; )必填</param>
/// <param name="ProductionStandardNumber">产品标准号， ; cat_id in (63,64,65,92,95,99,101,3853,3862,3867,3872,3876,3900,898,897,3993,1079; )必填</param>
/// <param name="OutGoodsId">商品goods外部编码</param>
/// <param name="ImageUrl">商品主图，请参考拼多多首页大图，如果商品参加部分活动则必填，否则无法参加活动; a. 尺寸750 x 352px; b. 大小100k以内; c. 图片格式仅支持JPG,PNG格式; d. 图片背景应以纯白为主, 商品图案居中显示; e. 图片不可以添加任何品牌相关文字或logo</param>
/// <param name="GoodsProperties">商品属性列表</param>
/// <param name="OutSkuSn">商品sku外部编码</param>
/// <param name="TemplatePid">模板属性id</param>
/// <param name="TemplateModuleId">模板模块id</param>
/// <param name="Pid">属性id</param>
/// <param name="Vid">属性值id</param>
/// <param name="Value">属性值</param>
/// <param name="ValueUnit">属性单位</param>
public async Task<CommitGoodsSubmitGoodsApiResult> CommitGoodsSubmitGoodsAsync(int GoodsId,string GoodsName,int GoodsType,string GoodsDesc,int CatId,int CountryId,int MarketPrice,bool IsPreSale,string ShipmentLimitSecond,int CostTemplateId,bool IsRefundable,bool SecondHand,bool IsFolt,jsonstring SkuList,string HdThumbUrl,string ThumbUrl,jsonstring CarouselGallery,jsonstring DetailGallery,int InvoiceStatus,int GoodsCommitId,jsonstring SpecIdList,int Weight,int Quantity,string ThumbUrl,int MultiPrice,int Price,int LimitQuantity,int IsOnsale,string TinyName,string Warehouse,string Customs,bool IsCustoms,string PreSaleTime,int CustomerNum,int BuyLimit,int OrderLimit,int Fabric,int FabricContent,string WarmTips,int ShelfLife,string StartProductionDate,string EndProductionDate,string ProductionStandardNumber,int OutGoodsId,string ImageUrl,string GoodsProperties,int OutSkuSn,int TemplatePid,int TemplateModuleId,int Pid,int Vid,string Value,string ValueUnit)
{
    var dic = new Dictionary<string, object>();
    dic.Add("goods_id",GoodsId);
dic.Add("goods_name",GoodsName);
dic.Add("goods_type",GoodsType);
dic.Add("goods_desc",GoodsDesc);
dic.Add("cat_id",CatId);
dic.Add("country_id",CountryId);
dic.Add("market_price",MarketPrice);
dic.Add("is_pre_sale",IsPreSale);
dic.Add("shipment_limit_second",ShipmentLimitSecond);
dic.Add("cost_template_id",CostTemplateId);
dic.Add("is_refundable",IsRefundable);
dic.Add("second_hand",SecondHand);
dic.Add("is_folt",IsFolt);
dic.Add("sku_list",SkuList);
dic.Add("hd_thumb_url",HdThumbUrl);
dic.Add("thumb_url",ThumbUrl);
dic.Add("carousel_gallery",CarouselGallery);
dic.Add("detail_gallery",DetailGallery);
dic.Add("invoice_status",InvoiceStatus);
dic.Add("goods_commit_id",GoodsCommitId);
dic.Add("spec_id_list",SpecIdList);
dic.Add("weight",Weight);
dic.Add("quantity",Quantity);
dic.Add("thumb_url",ThumbUrl);
dic.Add("multi_price",MultiPrice);
dic.Add("price",Price);
dic.Add("limit_quantity",LimitQuantity);
dic.Add("is_onsale",IsOnsale);
dic.Add("tiny_name",TinyName);
dic.Add("warehouse",Warehouse);
dic.Add("customs",Customs);
dic.Add("is_customs",IsCustoms);
dic.Add("pre_sale_time",PreSaleTime);
dic.Add("customer_num",CustomerNum);
dic.Add("buy_limit",BuyLimit);
dic.Add("order_limit",OrderLimit);
dic.Add("fabric",Fabric);
dic.Add("fabric_content",FabricContent);
dic.Add("warm_tips",WarmTips);
dic.Add("shelf_life",ShelfLife);
dic.Add("start_production_date",StartProductionDate);
dic.Add("end_production_date",EndProductionDate);
dic.Add("production_standard_number",ProductionStandardNumber);
dic.Add("out_goods_id",OutGoodsId);
dic.Add("image_url",ImageUrl);
dic.Add("goods_properties",GoodsProperties);
dic.Add("out_sku_sn",OutSkuSn);
dic.Add("template_pid",TemplatePid);
dic.Add("template_module_id",TemplateModuleId);
dic.Add("pid",Pid);
dic.Add("vid",Vid);
dic.Add("value",Value);
dic.Add("value_unit",ValueUnit);
    
    var result = await PostAsync<CommitGoodsSubmitGoodsApiResult>("pdd.goods.submit.goods.commit",dic);
    return result;
}/// <summary>
/// 查询模板接口
/// </summary>
/// <param name="CatId">类目id</param>
public async Task<GetGoodsMallTemplateApiResult> GetGoodsMallTemplateAsync(int CatId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("cat_id",CatId);
    
    var result = await PostAsync<GetGoodsMallTemplateApiResult>("pdd.goods.mall.template.get",dic);
    return result;
}/// <summary>
/// 搜索属性值接口
/// </summary>
/// <param name="TemplatePid">模板属性id</param>
/// <param name="ParentVid">父属性值id</param>
/// <param name="Value">属性值</param>
public async Task<SearchGoodsTemplateValueApiResult> SearchGoodsTemplateValueAsync(int TemplatePid,int ParentVid,string Value)
{
    var dic = new Dictionary<string, object>();
    dic.Add("template_pid",TemplatePid);
dic.Add("parent_vid",ParentVid);
dic.Add("value",Value);
    
    var result = await PostAsync<SearchGoodsTemplateValueApiResult>("pdd.goods.template.value.search",dic);
    return result;
}/// <summary>
/// 查询子属性接口
/// </summary>
/// <param name="TemplatePid">templatePid</param>
/// <param name="Vid">vid</param>
public async Task<GetGoodsTemplateSubPropertyApiResult> GetGoodsTemplateSubPropertyAsync(int TemplatePid,int Vid)
{
    var dic = new Dictionary<string, object>();
    dic.Add("template_pid",TemplatePid);
dic.Add("vid",Vid);
    
    var result = await PostAsync<GetGoodsTemplateSubPropertyApiResult>("pdd.goods.template.sub.property.get",dic);
    return result;
}/// <summary>
/// 修改商品sku价格
/// </summary>
/// <param name="GoodsId">商品id</param>
/// <param name="SkuPriceList">待修改的sku价格</param>
/// <param name="SinglePrice">单独购买价格（单位分）</param>
/// <param name="GroupPrice">拼团购买价格（单位分）</param>
/// <param name="SkuId">sku标识</param>
public async Task<UpdateGoodsSkuPriceApiResult> UpdateGoodsSkuPriceAsync(string GoodsId,jsonstring SkuPriceList,int SinglePrice,int GroupPrice,int SkuId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("goods_id",GoodsId);
dic.Add("sku_price_list",SkuPriceList);
dic.Add("single_price",SinglePrice);
dic.Add("group_price",GroupPrice);
dic.Add("sku_id",SkuId);
    
    var result = await PostAsync<UpdateGoodsSkuPriceApiResult>("pdd.goods.sku.price.update",dic);
    return result;
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
/// <param name="ItemImgsUrl">第三方平台商品轮播图地址（包括主图)，最多传5张，例如：; “http://testimg.yangkeduo.com/pdd_oms/2018-07-13/06b79325f5235b9d420201414ca57488.jpeg”</param>
/// <param name="Skus">第三方; ; 平台商品的sku内容，包括：sku的销售属性组合字符串properties_name（必填，当您上传的商品是单品时可以不传），sku对应的商品数量quantity（必填），sku应的商品价格price（必填），sku的商家外部outer_id（选填），例如：[{"outer_id":"1","price":51, "properties_name":"1627207:28332:颜色:浅灰色","quantity":11}]</param>
/// <param name="OuterId">第三方平台商品的商家外部编码，可与商家外部系统对应，例如“34143554352“</param>
public async Task<FieldExchangeThirdApiResult> FieldExchangeThirdAsync(long NumIid,string Title,string Cid,string Desc,string PicUrl,string StuffStatus,long CostTemplateId,string ItemImgsUrl,json string Skus,string OuterId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("num_iid",NumIid);
dic.Add("title",Title);
dic.Add("cid",Cid);
dic.Add("desc",Desc);
dic.Add("pic_url",PicUrl);
dic.Add("stuff_status",StuffStatus);
dic.Add("cost_template_id",CostTemplateId);
dic.Add("item_imgs_url",ItemImgsUrl);
dic.Add("skus",Skus);
dic.Add("outer_id",OuterId);
    
    var result = await PostAsync<FieldExchangeThirdApiResult>("pdd.exchange.third.field",dic);
    return result;
}/// <summary>
/// 查询商品推广API
/// </summary>
/// <param name="GoodsId">商品id</param>
public async Task<QueryGoodsCpsUnitApiResult> QueryGoodsCpsUnitAsync(string GoodsId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("goods_id",GoodsId);
    
    var result = await PostAsync<QueryGoodsCpsUnitApiResult>("pdd.goods.cps.unit.query",dic);
    return result;
}/// <summary>
/// 设置全店推广API
/// </summary>
/// <param name="Rate">佣金比（千分比）</param>
public async Task<CreateGoodsCpsMallUnitApiResult> CreateGoodsCpsMallUnitAsync(int Rate)
{
    var dic = new Dictionary<string, object>();
    dic.Add("rate",Rate);
    
    var result = await PostAsync<CreateGoodsCpsMallUnitApiResult>("pdd.goods.cps.mall.unit.create",dic);
    return result;
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
public async Task<CreateGoodsCpsUnitApiResult> CreateGoodsCpsUnitAsync(string Units,int GoodsId,int Rate,int CouponId,string CouponStartTime,string CouponEndTime,int Discount,int InitQuantity,int RemainQuantity)
{
    var dic = new Dictionary<string, object>();
    dic.Add("units",Units);
dic.Add("goods_id",GoodsId);
dic.Add("rate",Rate);
dic.Add("coupon_id",CouponId);
dic.Add("coupon_start_time",CouponStartTime);
dic.Add("coupon_end_time",CouponEndTime);
dic.Add("discount",Discount);
dic.Add("init_quantity",InitQuantity);
dic.Add("remain_quantity",RemainQuantity);
    
    var result = await PostAsync<CreateGoodsCpsUnitApiResult>("pdd.goods.cps.unit.create",dic);
    return result;
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
public async Task<ChangeGoodsCpsUnitApiResult> ChangeGoodsCpsUnitAsync(int GoodsId,int Rate,int CouponId,string CouponStartTime,string CouponEndTime,int Discount,int InitQuantity,int RemainQuantity)
{
    var dic = new Dictionary<string, object>();
    dic.Add("goods_id",GoodsId);
dic.Add("rate",Rate);
dic.Add("coupon_id",CouponId);
dic.Add("coupon_start_time",CouponStartTime);
dic.Add("coupon_end_time",CouponEndTime);
dic.Add("discount",Discount);
dic.Add("init_quantity",InitQuantity);
dic.Add("remain_quantity",RemainQuantity);
    
    var result = await PostAsync<ChangeGoodsCpsUnitApiResult>("pdd.goods.cps.unit.change",dic);
    return result;
}/// <summary>
/// 商品映射查询接口
/// </summary>
/// <param name="PddGoodsId">拼多多商品id</param>
public async Task<RelationGoodsGetApiResult> RelationGoodsGetAsync(json list PddGoodsId)
{
    var dic = new Dictionary<string, object>();
    dic.Add("pdd_goods_id",PddGoodsId);
    
    var result = await PostAsync<RelationGoodsGetApiResult>("pdd.goods.get.relation",dic);
    return result;
}
    }
}
