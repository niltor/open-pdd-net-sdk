using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ad
{
public partial class CreateAdApiPlanRequestModel : PddRequestModel
{
/// <summary>
/// 计划创建信息
/// </summary>
[JsonProperty("adPlanCreateMessage")]
public AdPlanCreateMessageRequestModel AdPlanCreateMessage {get;set;}
/// <summary>
/// 单元创建信息列表
/// </summary>
[JsonProperty("adUnitCreateComplexMessageList")]
public List<AdUnitCreateComplexMessageListRequestModel> AdUnitCreateComplexMessageList {get;set;}
/// <summary>
/// 推广策略。1：自定义推广，3：展示ocpc智能推广。不传时表示自定义推广
/// </summary>
[JsonProperty("planStrategy")]
public int? PlanStrategy {get;set;}
/// <summary>
/// 场景类型。0表示搜索，2表示展示。
/// </summary>
[JsonProperty("scenesType")]
public int ScenesType {get;set;}
public partial class AdPlanCreateMessageRequestModel : PddRequestModel
{
/// <summary>
/// 单日消耗
/// </summary>
[JsonProperty("maxCost")]
public long MaxCost {get;set;}
/// <summary>
/// 分时折扣
/// </summary>
[JsonProperty("planDiscount")]
public PlanDiscountRequestModel PlanDiscount {get;set;}
/// <summary>
/// 计划名称
/// </summary>
[JsonProperty("planName")]
public string PlanName {get;set;}
public partial class PlanDiscountRequestModel : PddRequestModel
{
/// <summary>
/// 分时折扣配置
/// </summary>
[JsonProperty("discounts")]
public List<DiscountsRequestModel> Discounts {get;set;}
public partial class DiscountsRequestModel : PddRequestModel
{
/// <summary>
/// 小时。0-23分别表示第1个小时到第24个小时。
/// </summary>
[JsonProperty("index")]
public int Index {get;set;}
/// <summary>
/// 折扣比例。千分比（即rate等于1000表示比例100%）。
/// </summary>
[JsonProperty("rate")]
public int Rate {get;set;}

}

}

}
public partial class AdUnitCreateComplexMessageListRequestModel : PddRequestModel
{
/// <summary>
/// 创意创建信息列表
/// </summary>
[JsonProperty("adCreativeCreateMessagesList")]
public List<AdCreativeCreateMessagesListRequestModel> AdCreativeCreateMessagesList {get;set;}
/// <summary>
/// 关键词创建列表
/// </summary>
[JsonProperty("adKeywordCreateMessageList")]
public List<AdKeywordCreateMessageListRequestModel> AdKeywordCreateMessageList {get;set;}
/// <summary>
/// 智能词包相关信息
/// </summary>
[JsonProperty("adKeywordSetMessage")]
public AdKeywordSetMessageRequestModel AdKeywordSetMessage {get;set;}
/// <summary>
/// 商品创建信息
/// </summary>
[JsonProperty("adProductCreateMessage")]
public AdProductCreateMessageRequestModel AdProductCreateMessage {get;set;}
/// <summary>
/// 单元创建信息
/// </summary>
[JsonProperty("adUnitCreateMessage")]
public AdUnitCreateMessageRequestModel AdUnitCreateMessage {get;set;}
/// <summary>
/// 人群定向创建信息列表
/// </summary>
[JsonProperty("audienceBidCreateMessageList")]
public List<AudienceBidCreateMessageListRequestModel> AudienceBidCreateMessageList {get;set;}
/// <summary>
/// 资源位定向创建信息列表。仅支持展示广告。
/// </summary>
[JsonProperty("locationBidCreateMessageList")]
public List<LocationBidCreateMessageListRequestModel> LocationBidCreateMessageList {get;set;}
/// <summary>
/// 智能创意创建信息
/// </summary>
[JsonProperty("smartCreativeCreateMessage")]
public SmartCreativeCreateMessageRequestModel SmartCreativeCreateMessage {get;set;}
public partial class AdCreativeCreateMessagesListRequestModel : PddRequestModel
{
/// <summary>
/// 创意图片列表
/// </summary>
[JsonProperty("adImageVOList")]
public List<AdImageVOListRequestModel> AdImageVOList {get;set;}
/// <summary>
/// 创意标题列表
/// </summary>
[JsonProperty("adTextVOList")]
public List<AdTextVOListRequestModel> AdTextVOList {get;set;}
/// <summary>
/// 创意规格，6：商品轮播图，7：商品长图，其余规格暂不支持
/// </summary>
[JsonProperty("creativeSpecificationId")]
public long CreativeSpecificationId {get;set;}
public partial class AdImageVOListRequestModel : PddRequestModel
{
/// <summary>
/// 图片链接，可用图片参考以下接口返回：pdd.ad.api.goods.query.gallery.images（轮播图），pdd.ad.api.goods.query.long.images（长图）
/// </summary>
[JsonProperty("imageUrl")]
public string ImageUrl {get;set;}

}
public partial class AdTextVOListRequestModel : PddRequestModel
{
/// <summary>
/// 标题
/// </summary>
[JsonProperty("text")]
public string Text {get;set;}

}

}
public partial class AdKeywordCreateMessageListRequestModel : PddRequestModel
{
/// <summary>
/// 关键词出价
/// </summary>
[JsonProperty("bid")]
public long Bid {get;set;}
/// <summary>
/// 关键词溢价比例。万分比
/// </summary>
[JsonProperty("premiumRate")]
public long? PremiumRate {get;set;}
/// <summary>
/// 关键词
/// </summary>
[JsonProperty("word")]
public string Word {get;set;}

}
public partial class AdKeywordSetMessageRequestModel : PddRequestModel
{
/// <summary>
/// 词包出价。出价需在[0.10, 99.00]之间。
/// </summary>
[JsonProperty("keywordSetBid")]
public long? KeywordSetBid {get;set;}

}
public partial class AdProductCreateMessageRequestModel : PddRequestModel
{
/// <summary>
/// 商品Id
/// </summary>
[JsonProperty("goodsId")]
public long? GoodsId {get;set;}

}
public partial class AdUnitCreateMessageRequestModel : PddRequestModel
{
/// <summary>
/// 推广单元名称
/// </summary>
[JsonProperty("adName")]
public string AdName {get;set;}
/// <summary>
/// 基础出价。单位厘。
/// </summary>
[JsonProperty("bid")]
public long? Bid {get;set;}
/// <summary>
/// 智能优化广告相关。当单元使用自定义推广时，不要使用该字段。
/// </summary>
[JsonProperty("optimizationMessage")]
public OptimizationMessageRequestModel OptimizationMessage {get;set;}
public partial class OptimizationMessageRequestModel : PddRequestModel
{
/// <summary>
/// 数据积累期出价。当使用OCPX时对该字段赋值。
/// </summary>
[JsonProperty("accumulationBid")]
public long? AccumulationBid {get;set;}
/// <summary>
/// 智能投放期出价。当使用OCPX时对该字段赋值。
/// </summary>
[JsonProperty("optimizationBid")]
public long? OptimizationBid {get;set;}
/// <summary>
/// 优化目标。0表示不优化。1表示优化ROI，2表示优化转化成本.自定义单元时，该值必传0；当单元使用展示自动调价功能(ECPC)时，该值必须传1；当单元使用展示OCPC功能（plan_strategy=3）时，该值必须传2。
/// </summary>
[JsonProperty("optimizationGoal")]
public int OptimizationGoal {get;set;}
/// <summary>
/// 优化方式。0表示不优化，1表示ECPC，2表示OCPC。当单元使用ECPC时，该值必须传1；当使用OCPC时，该值必须传2。
/// </summary>
[JsonProperty("optimizationMethod")]
public int? OptimizationMethod {get;set;}
/// <summary>
/// 可选优化出价列表。当使用OCPX时对该字段赋值。
/// </summary>
[JsonProperty("optionalOptimizationBidMessageList")]
public List<OptionalOptimizationBidMessageListRequestModel> OptionalOptimizationBidMessageList {get;set;}
public partial class OptionalOptimizationBidMessageListRequestModel : PddRequestModel
{
/// <summary>
/// 可选优化出价价格
/// </summary>
[JsonProperty("optimizationBid")]
public long OptimizationBid {get;set;}
/// <summary>
/// 可选优化出价目标。3表示优化店铺关注，4表示优化商品收藏，5表示优化询单
/// </summary>
[JsonProperty("optimizationGoal")]
public int OptimizationGoal {get;set;}

}

}

}
public partial class AudienceBidCreateMessageListRequestModel : PddRequestModel
{
/// <summary>
/// 定向创建信息
/// </summary>
[JsonProperty("adTargetingCreateMessage")]
public AdTargetingCreateMessageRequestModel AdTargetingCreateMessage {get;set;}
/// <summary>
/// 人群定向类型，可用枚举值，参考接口：pdd.ad.api.unit.bid.query.base.target.profile
/// </summary>
[JsonProperty("bidReferenceId")]
public long BidReferenceId {get;set;}
/// <summary>
/// 出价，万分比
/// </summary>
[JsonProperty("bidValue")]
public long BidValue {get;set;}
/// <summary>
/// 人群定向二级Id。默认为0。
/// </summary>
[JsonProperty("subBidReferenceId")]
public long SubBidReferenceId {get;set;}
public partial class AdTargetingCreateMessageRequestModel : PddRequestModel
{
/// <summary>
/// 定向集合
/// </summary>
[JsonProperty("adTargetingSet")]
public AdTargetingSetRequestModel AdTargetingSet {get;set;}
/// <summary>
/// 定向名称
/// </summary>
[JsonProperty("targetingName")]
public string TargetingName {get;set;}
public partial class AdTargetingSetRequestModel : PddRequestModel
{
/// <summary>
/// 地域定向
/// </summary>
[JsonProperty("areaStruct")]
public AreaStructRequestModel AreaStruct {get;set;}
public partial class AreaStructRequestModel : PddRequestModel
{
/// <summary>
/// 地域Id列表。具体地域Id编码参见接口返回：pdd.ad.api.unit.bid.query.targeting.tag.list
/// </summary>
[JsonProperty("areaIds")]
public List<int> AreaIds {get;set;}

}

}

}

}
public partial class LocationBidCreateMessageListRequestModel : PddRequestModel
{
/// <summary>
/// 资源位定向类型。可取值参考接口：pdd.ad.api.unit.bid.query.available.location
/// </summary>
[JsonProperty("bidReferenceId")]
public long BidReferenceId {get;set;}
/// <summary>
/// 出价，万分比
/// </summary>
[JsonProperty("bidValue")]
public long BidValue {get;set;}

}
public partial class SmartCreativeCreateMessageRequestModel : PddRequestModel
{
/// <summary>
/// 智能创意流量分配比例
/// </summary>
[JsonProperty("creativeFlowRate")]
public int? CreativeFlowRate {get;set;}
/// <summary>
/// 是否启用智能创意标识
/// </summary>
[JsonProperty("enableSmartCreative")]
public int? EnableSmartCreative {get;set;}
/// <summary>
/// 智能创意标题
/// </summary>
[JsonProperty("smartCreativeTitle")]
public string SmartCreativeTitle {get;set;}

}

}

}

}
