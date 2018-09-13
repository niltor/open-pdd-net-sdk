using App.Models.PddApiRequest;
using App.Models.PddApiResponse;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace App.Services.PddApiRequest
{
    public class GoodsApiRequest : PddRequest {
        /// <summary>
/// 商品列表接口
/// </summary>
public async Task<GetGoodsListResponseModel> GetGoodsListAsync(GetGoodsListRequestModel getGoodsList)
{
    var result = await PostAsync<GetGoodsListRequestModel,GetGoodsListResponseModel>("pdd.goods.list.get",getGoodsList);
    return result;
}
/// <summary>
/// 商品详情接口
/// </summary>
public async Task<GetGoodsInformationResponseModel> GetGoodsInformationAsync(GetGoodsInformationRequestModel getGoodsInformation)
{
    var result = await PostAsync<GetGoodsInformationRequestModel,GetGoodsInformationResponseModel>("pdd.goods.information.get",getGoodsInformation);
    return result;
}
/// <summary>
/// 商品全量修改接口
/// </summary>
public async Task<UpdateGoodsSkuStockResponseModel> UpdateGoodsSkuStockAsync(UpdateGoodsSkuStockRequestModel updateGoodsSkuStock)
{
    var result = await PostAsync<UpdateGoodsSkuStockRequestModel,UpdateGoodsSkuStockResponseModel>("pdd.goods.sku.stock.update",updateGoodsSkuStock);
    return result;
}
/// <summary>
/// 商品增量修改接口
/// </summary>
public async Task<UpdateGoodsSkuStockIncrementResponseModel> UpdateGoodsSkuStockIncrementAsync(UpdateGoodsSkuStockIncrementRequestModel updateGoodsSkuStockIncrement)
{
    var result = await PostAsync<UpdateGoodsSkuStockIncrementRequestModel,UpdateGoodsSkuStockIncrementResponseModel>("pdd.goods.sku.stock.increment.update",updateGoodsSkuStockIncrement);
    return result;
}
/// <summary>
/// 商品标准类目接口
/// </summary>
public async Task<GetGoodsCatsResponseModel> GetGoodsCatsAsync(GetGoodsCatsRequestModel getGoodsCats)
{
    var result = await PostAsync<GetGoodsCatsRequestModel,GetGoodsCatsResponseModel>("pdd.goods.cats.get",getGoodsCats);
    return result;
}
/// <summary>
/// 商品运费模版接口
/// </summary>
public async Task<GetGoodsLogisticsTemplateResponseModel> GetGoodsLogisticsTemplateAsync(GetGoodsLogisticsTemplateRequestModel getGoodsLogisticsTemplate)
{
    var result = await PostAsync<GetGoodsLogisticsTemplateRequestModel,GetGoodsLogisticsTemplateResponseModel>("pdd.goods.logistics.template.get",getGoodsLogisticsTemplate);
    return result;
}
/// <summary>
/// 商品图片上传接口
/// </summary>
public async Task<UploadGoodsImageResponseModel> UploadGoodsImageAsync(UploadGoodsImageRequestModel uploadGoodsImage)
{
    var result = await PostAsync<UploadGoodsImageRequestModel,UploadGoodsImageResponseModel>("pdd.goods.image.upload",uploadGoodsImage);
    return result;
}
/// <summary>
/// 商品国家接口
/// </summary>
public async Task<GetGoodsCountryResponseModel> GetGoodsCountryAsync(GetGoodsCountryRequestModel getGoodsCountry)
{
    var result = await PostAsync<GetGoodsCountryRequestModel,GetGoodsCountryResponseModel>("pdd.goods.country.get",getGoodsCountry);
    return result;
}
/// <summary>
/// 生成商家自定义的规格
/// </summary>
public async Task<GetGoodsSpecIdResponseModel> GetGoodsSpecIdAsync(GetGoodsSpecIdRequestModel getGoodsSpecId)
{
    var result = await PostAsync<GetGoodsSpecIdRequestModel,GetGoodsSpecIdResponseModel>("pdd.goods.spec.id.get",getGoodsSpecId);
    return result;
}
/// <summary>
/// 商品属性类目接口
/// </summary>
public async Task<GetGoodsSpecResponseModel> GetGoodsSpecAsync(GetGoodsSpecRequestModel getGoodsSpec)
{
    var result = await PostAsync<GetGoodsSpecRequestModel,GetGoodsSpecResponseModel>("pdd.goods.spec.get",getGoodsSpec);
    return result;
}
/// <summary>
/// 获取当前授权商家可发布的商品类目信息
/// </summary>
public async Task<CatsGoodsAuthorizationResponseModel> CatsGoodsAuthorizationAsync(CatsGoodsAuthorizationRequestModel catsGoodsAuthorization)
{
    var result = await PostAsync<CatsGoodsAuthorizationRequestModel,CatsGoodsAuthorizationResponseModel>("pdd.goods.authorization.cats",catsGoodsAuthorization);
    return result;
}
/// <summary>
/// 获取服饰成分含量信息
/// </summary>
public async Task<GetGoodsFabricContentResponseModel> GetGoodsFabricContentAsync(GetGoodsFabricContentRequestModel getGoodsFabricContent)
{
    var result = await PostAsync<GetGoodsFabricContentRequestModel,GetGoodsFabricContentResponseModel>("pdd.goods.fabric.content.get",getGoodsFabricContent);
    return result;
}
/// <summary>
/// 获取服饰面料信息
/// </summary>
public async Task<GetGoodsFabricResponseModel> GetGoodsFabricAsync(GetGoodsFabricRequestModel getGoodsFabric)
{
    var result = await PostAsync<GetGoodsFabricRequestModel,GetGoodsFabricResponseModel>("pdd.goods.fabric.get",getGoodsFabric);
    return result;
}
/// <summary>
/// 商品新增接口
/// </summary>
public async Task<AddGoodsResponseModel> AddGoodsAsync(AddGoodsRequestModel addGoods)
{
    var result = await PostAsync<AddGoodsRequestModel,AddGoodsResponseModel>("pdd.goods.add",addGoods);
    return result;
}
/// <summary>
/// 商品编辑
/// </summary>
public async Task<UpdateGoodsInformationResponseModel> UpdateGoodsInformationAsync(UpdateGoodsInformationRequestModel updateGoodsInformation)
{
    var result = await PostAsync<UpdateGoodsInformationRequestModel,UpdateGoodsInformationResponseModel>("pdd.goods.information.update",updateGoodsInformation);
    return result;
}
/// <summary>
/// 商品明细
/// </summary>
public async Task<GetGoodsDetailResponseModel> GetGoodsDetailAsync(GetGoodsDetailRequestModel getGoodsDetail)
{
    var result = await PostAsync<GetGoodsDetailRequestModel,GetGoodsDetailResponseModel>("pdd.goods.detail.get",getGoodsDetail);
    return result;
}
/// <summary>
/// 商品上架状态设置
/// </summary>
public async Task<SetGoodsSaleStatusResponseModel> SetGoodsSaleStatusAsync(SetGoodsSaleStatusRequestModel setGoodsSaleStatus)
{
    var result = await PostAsync<SetGoodsSaleStatusRequestModel,SetGoodsSaleStatusResponseModel>("pdd.goods.sale.status.set",setGoodsSaleStatus);
    return result;
}
/// <summary>
/// 查询商品标签列表
/// </summary>
public async Task<GetGoodsOptResponseModel> GetGoodsOptAsync(GetGoodsOptRequestModel getGoodsOpt)
{
    var result = await PostAsync<GetGoodsOptRequestModel,GetGoodsOptResponseModel>("pdd.goods.opt.get",getGoodsOpt);
    return result;
}
/// <summary>
/// 创建商品物流模版
/// </summary>
public async Task<CreateGoodsLogisticsTemplateResponseModel> CreateGoodsLogisticsTemplateAsync(CreateGoodsLogisticsTemplateRequestModel createGoodsLogisticsTemplate)
{
    var result = await PostAsync<CreateGoodsLogisticsTemplateRequestModel,CreateGoodsLogisticsTemplateResponseModel>("pdd.goods.logistics.template.create",createGoodsLogisticsTemplate);
    return result;
}
/// <summary>
/// 获取商品提交的商品详情
/// </summary>
public async Task<GetGoodsCommitDetailResponseModel> GetGoodsCommitDetailAsync(GetGoodsCommitDetailRequestModel getGoodsCommitDetail)
{
    var result = await PostAsync<GetGoodsCommitDetailRequestModel,GetGoodsCommitDetailResponseModel>("pdd.goods.commit.detail.get",getGoodsCommitDetail);
    return result;
}
/// <summary>
/// 商品关联信息设置接口
/// </summary>
public async Task<SetGoodsRelationResponseModel> SetGoodsRelationAsync(SetGoodsRelationRequestModel setGoodsRelation)
{
    var result = await PostAsync<SetGoodsRelationRequestModel,SetGoodsRelationResponseModel>("pdd.goods.relation.set",setGoodsRelation);
    return result;
}
/// <summary>
/// 新增或编辑草稿接口
/// </summary>
public async Task<CommitGoodsEditGoodsResponseModel> CommitGoodsEditGoodsAsync(CommitGoodsEditGoodsRequestModel commitGoodsEditGoods)
{
    var result = await PostAsync<CommitGoodsEditGoodsRequestModel,CommitGoodsEditGoodsResponseModel>("pdd.goods.edit.goods.commit",commitGoodsEditGoods);
    return result;
}
/// <summary>
/// 编辑并提交草稿接口
/// </summary>
public async Task<CommitGoodsSubmitGoodsResponseModel> CommitGoodsSubmitGoodsAsync(CommitGoodsSubmitGoodsRequestModel commitGoodsSubmitGoods)
{
    var result = await PostAsync<CommitGoodsSubmitGoodsRequestModel,CommitGoodsSubmitGoodsResponseModel>("pdd.goods.submit.goods.commit",commitGoodsSubmitGoods);
    return result;
}
/// <summary>
/// 查询模板接口
/// </summary>
public async Task<GetGoodsMallTemplateResponseModel> GetGoodsMallTemplateAsync(GetGoodsMallTemplateRequestModel getGoodsMallTemplate)
{
    var result = await PostAsync<GetGoodsMallTemplateRequestModel,GetGoodsMallTemplateResponseModel>("pdd.goods.mall.template.get",getGoodsMallTemplate);
    return result;
}
/// <summary>
/// 搜索属性值接口
/// </summary>
public async Task<SearchGoodsTemplateValueResponseModel> SearchGoodsTemplateValueAsync(SearchGoodsTemplateValueRequestModel searchGoodsTemplateValue)
{
    var result = await PostAsync<SearchGoodsTemplateValueRequestModel,SearchGoodsTemplateValueResponseModel>("pdd.goods.template.value.search",searchGoodsTemplateValue);
    return result;
}
/// <summary>
/// 查询子属性接口
/// </summary>
public async Task<GetGoodsTemplateSubPropertyResponseModel> GetGoodsTemplateSubPropertyAsync(GetGoodsTemplateSubPropertyRequestModel getGoodsTemplateSubProperty)
{
    var result = await PostAsync<GetGoodsTemplateSubPropertyRequestModel,GetGoodsTemplateSubPropertyResponseModel>("pdd.goods.template.sub.property.get",getGoodsTemplateSubProperty);
    return result;
}
/// <summary>
/// 修改商品sku价格
/// </summary>
public async Task<UpdateGoodsSkuPriceResponseModel> UpdateGoodsSkuPriceAsync(UpdateGoodsSkuPriceRequestModel updateGoodsSkuPrice)
{
    var result = await PostAsync<UpdateGoodsSkuPriceRequestModel,UpdateGoodsSkuPriceResponseModel>("pdd.goods.sku.price.update",updateGoodsSkuPrice);
    return result;
}
/// <summary>
/// 第三方平台商详字段转化到拼多多草稿箱
/// </summary>
public async Task<FieldExchangeThirdResponseModel> FieldExchangeThirdAsync(FieldExchangeThirdRequestModel fieldExchangeThird)
{
    var result = await PostAsync<FieldExchangeThirdRequestModel,FieldExchangeThirdResponseModel>("pdd.exchange.third.field",fieldExchangeThird);
    return result;
}
/// <summary>
/// 查询商品推广API
/// </summary>
public async Task<QueryGoodsCpsUnitResponseModel> QueryGoodsCpsUnitAsync(QueryGoodsCpsUnitRequestModel queryGoodsCpsUnit)
{
    var result = await PostAsync<QueryGoodsCpsUnitRequestModel,QueryGoodsCpsUnitResponseModel>("pdd.goods.cps.unit.query",queryGoodsCpsUnit);
    return result;
}
/// <summary>
/// 设置全店推广API
/// </summary>
public async Task<CreateGoodsCpsMallUnitResponseModel> CreateGoodsCpsMallUnitAsync(CreateGoodsCpsMallUnitRequestModel createGoodsCpsMallUnit)
{
    var result = await PostAsync<CreateGoodsCpsMallUnitRequestModel,CreateGoodsCpsMallUnitResponseModel>("pdd.goods.cps.mall.unit.create",createGoodsCpsMallUnit);
    return result;
}
/// <summary>
/// 设置单品推广API
/// </summary>
public async Task<CreateGoodsCpsUnitResponseModel> CreateGoodsCpsUnitAsync(CreateGoodsCpsUnitRequestModel createGoodsCpsUnit)
{
    var result = await PostAsync<CreateGoodsCpsUnitRequestModel,CreateGoodsCpsUnitResponseModel>("pdd.goods.cps.unit.create",createGoodsCpsUnit);
    return result;
}
/// <summary>
/// 修改商品推广API
/// </summary>
public async Task<ChangeGoodsCpsUnitResponseModel> ChangeGoodsCpsUnitAsync(ChangeGoodsCpsUnitRequestModel changeGoodsCpsUnit)
{
    var result = await PostAsync<ChangeGoodsCpsUnitRequestModel,ChangeGoodsCpsUnitResponseModel>("pdd.goods.cps.unit.change",changeGoodsCpsUnit);
    return result;
}
/// <summary>
/// 商品映射查询接口
/// </summary>
public async Task<RelationGoodsGetResponseModel> RelationGoodsGetAsync(RelationGoodsGetRequestModel relationGoodsGet)
{
    var result = await PostAsync<RelationGoodsGetRequestModel,RelationGoodsGetResponseModel>("pdd.goods.get.relation",relationGoodsGet);
    return result;
}

    }
}
