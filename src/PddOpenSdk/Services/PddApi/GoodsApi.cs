
using PddOpenSdk.Models.Request.Goods;
using PddOpenSdk.Models.Response.Goods;

namespace PddOpenSdk.Services.PddApi;
public class GoodsApi : PddCommonApi
{
    public GoodsApi() { }
    public GoodsApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 删除草稿接口
    /// </summary>
    public async Task<CommitDeleteDraftResponse> CommitDeleteDraftAsync(CommitDeleteDraft commitDeleteDraft)
    {
        var result = await PostAsync<CommitDeleteDraft, CommitDeleteDraftResponse>("pdd.delete.draft.commit", commitDeleteDraft);
        return result;
    }

    /// <summary>
    /// 删除商品接口
    /// </summary>
    public async Task<CommitDeleteGoodsResponse> CommitDeleteGoodsAsync(CommitDeleteGoods commitDeleteGoods)
    {
        var result = await PostAsync<CommitDeleteGoods, CommitDeleteGoodsResponse>("pdd.delete.goods.commit", commitDeleteGoods);
        return result;
    }

    /// <summary>
    /// 商品新增接口
    /// </summary>
    public async Task<AddGoodsResponse> AddGoodsAsync(AddGoods addGoods)
    {
        var result = await PostAsync<AddGoods, AddGoodsResponse>("pdd.goods.add", addGoods);
        return result;
    }

    /// <summary>
    /// 商品建议价格获取接口
    /// </summary>
    public async Task<GetGoodsAdvicePriceResponse> GetGoodsAdvicePriceAsync(GetGoodsAdvicePrice getGoodsAdvicePrice)
    {
        var result = await PostAsync<GetGoodsAdvicePrice, GetGoodsAdvicePriceResponse>("pdd.goods.advice.price.get", getGoodsAdvicePrice);
        return result;
    }

    /// <summary>
    /// 获取当前授权商家可发布的商品类目信息
    /// </summary>
    public async Task<CatsGoodsAuthorizationResponse> CatsGoodsAuthorizationAsync(CatsGoodsAuthorization catsGoodsAuthorization)
    {
        var result = await PostAsync<CatsGoodsAuthorization, CatsGoodsAuthorizationResponse>("pdd.goods.authorization.cats", catsGoodsAuthorization);
        return result;
    }

    /// <summary>
    /// 类目商品发布规则查询接口
    /// </summary>
    public async Task<GetGoodsCatRuleResponse> GetGoodsCatRuleAsync(GetGoodsCatRule getGoodsCatRule)
    {
        var result = await PostAsync<GetGoodsCatRule, GetGoodsCatRuleResponse>("pdd.goods.cat.rule.get", getGoodsCatRule);
        return result;
    }

    /// <summary>
    /// 获取商品类目属性(已废弃)
    /// </summary>
    public async Task<GetGoodsCatTemplateResponse> GetGoodsCatTemplateAsync(GetGoodsCatTemplate getGoodsCatTemplate)
    {
        var result = await PostAsync<GetGoodsCatTemplate, GetGoodsCatTemplateResponse>("pdd.goods.cat.template.get", getGoodsCatTemplate);
        return result;
    }

    /// <summary>
    /// 商品标准类目接口
    /// </summary>
    public async Task<GetGoodsCatsResponse> GetGoodsCatsAsync(GetGoodsCats getGoodsCats)
    {
        var result = await PostAsync<GetGoodsCats, GetGoodsCatsResponse>("pdd.goods.cats.get", getGoodsCats);
        return result;
    }

    /// <summary>
    /// 日历库存子SKU新增及编辑接口
    /// </summary>
    public async Task<EditGoodsChildSkuResponse> EditGoodsChildSkuAsync(EditGoodsChildSku editGoodsChildSku)
    {
        var result = await PostAsync<EditGoodsChildSku, EditGoodsChildSkuResponse>("pdd.goods.child.sku.edit", editGoodsChildSku);
        return result;
    }

    /// <summary>
    /// 获取商品提交的商品详情
    /// </summary>
    public async Task<GetGoodsCommitDetailResponse> GetGoodsCommitDetailAsync(GetGoodsCommitDetail getGoodsCommitDetail)
    {
        var result = await PostAsync<GetGoodsCommitDetail, GetGoodsCommitDetailResponse>("pdd.goods.commit.detail.get", getGoodsCommitDetail);
        return result;
    }

    /// <summary>
    /// 草稿列表接口
    /// </summary>
    public async Task<GetGoodsCommitListResponse> GetGoodsCommitListAsync(GetGoodsCommitList getGoodsCommitList)
    {
        var result = await PostAsync<GetGoodsCommitList, GetGoodsCommitListResponse>("pdd.goods.commit.list.get", getGoodsCommitList);
        return result;
    }

    /// <summary>
    /// 草稿状态查询接口
    /// </summary>
    public async Task<GetGoodsCommitStatusResponse> GetGoodsCommitStatusAsync(GetGoodsCommitStatus getGoodsCommitStatus)
    {
        var result = await PostAsync<GetGoodsCommitStatus, GetGoodsCommitStatusResponse>("pdd.goods.commit.status.get", getGoodsCommitStatus);
        return result;
    }

    /// <summary>
    /// 商品地区/国家接口
    /// </summary>
    public async Task<GetGoodsCountryResponse> GetGoodsCountryAsync(GetGoodsCountry getGoodsCountry)
    {
        var result = await PostAsync<GetGoodsCountry, GetGoodsCountryResponse>("pdd.goods.country.get", getGoodsCountry);
        return result;
    }

    /// <summary>
    /// 修改全店推广API
    /// </summary>
    public async Task<ChangeGoodsCpsMallUnitResponse> ChangeGoodsCpsMallUnitAsync(ChangeGoodsCpsMallUnit changeGoodsCpsMallUnit)
    {
        var result = await PostAsync<ChangeGoodsCpsMallUnit, ChangeGoodsCpsMallUnitResponse>("pdd.goods.cps.mall.unit.change", changeGoodsCpsMallUnit);
        return result;
    }

    /// <summary>
    /// 设置全店推广API
    /// </summary>
    public async Task<CreateGoodsCpsMallUnitResponse> CreateGoodsCpsMallUnitAsync(CreateGoodsCpsMallUnit createGoodsCpsMallUnit)
    {
        var result = await PostAsync<CreateGoodsCpsMallUnit, CreateGoodsCpsMallUnitResponse>("pdd.goods.cps.mall.unit.create", createGoodsCpsMallUnit);
        return result;
    }

    /// <summary>
    /// 暂停全店推广API
    /// </summary>
    public async Task<PauseGoodsCpsMallUnitResponse> PauseGoodsCpsMallUnitAsync(PauseGoodsCpsMallUnit pauseGoodsCpsMallUnit)
    {
        var result = await PostAsync<PauseGoodsCpsMallUnit, PauseGoodsCpsMallUnitResponse>("pdd.goods.cps.mall.unit.pause", pauseGoodsCpsMallUnit);
        return result;
    }

    /// <summary>
    /// 查询全店推广API
    /// </summary>
    public async Task<QueryGoodsCpsMallUnitResponse> QueryGoodsCpsMallUnitAsync(QueryGoodsCpsMallUnit queryGoodsCpsMallUnit)
    {
        var result = await PostAsync<QueryGoodsCpsMallUnit, QueryGoodsCpsMallUnitResponse>("pdd.goods.cps.mall.unit.query", queryGoodsCpsMallUnit);
        return result;
    }

    /// <summary>
    /// 恢复全店推广API
    /// </summary>
    public async Task<ResumeGoodsCpsMallUnitResponse> ResumeGoodsCpsMallUnitAsync(ResumeGoodsCpsMallUnit resumeGoodsCpsMallUnit)
    {
        var result = await PostAsync<ResumeGoodsCpsMallUnit, ResumeGoodsCpsMallUnitResponse>("pdd.goods.cps.mall.unit.resume", resumeGoodsCpsMallUnit);
        return result;
    }

    /// <summary>
    /// 修改商品推广API
    /// </summary>
    public async Task<ChangeGoodsCpsUnitResponse> ChangeGoodsCpsUnitAsync(ChangeGoodsCpsUnit changeGoodsCpsUnit)
    {
        var result = await PostAsync<ChangeGoodsCpsUnit, ChangeGoodsCpsUnitResponse>("pdd.goods.cps.unit.change", changeGoodsCpsUnit);
        return result;
    }

    /// <summary>
    /// 设置单品推广API
    /// </summary>
    public async Task<CreateGoodsCpsUnitResponse> CreateGoodsCpsUnitAsync(CreateGoodsCpsUnit createGoodsCpsUnit)
    {
        var result = await PostAsync<CreateGoodsCpsUnit, CreateGoodsCpsUnitResponse>("pdd.goods.cps.unit.create", createGoodsCpsUnit);
        return result;
    }

    /// <summary>
    /// 删除单品计划接口
    /// </summary>
    public async Task<DeleteGoodsCpsUnitResponse> DeleteGoodsCpsUnitAsync(DeleteGoodsCpsUnit deleteGoodsCpsUnit)
    {
        var result = await PostAsync<DeleteGoodsCpsUnit, DeleteGoodsCpsUnitResponse>("pdd.goods.cps.unit.delete", deleteGoodsCpsUnit);
        return result;
    }

    /// <summary>
    /// 查询商品推广API
    /// </summary>
    public async Task<QueryGoodsCpsUnitResponse> QueryGoodsCpsUnitAsync(QueryGoodsCpsUnit queryGoodsCpsUnit)
    {
        var result = await PostAsync<QueryGoodsCpsUnit, QueryGoodsCpsUnitResponse>("pdd.goods.cps.unit.query", queryGoodsCpsUnit);
        return result;
    }

    /// <summary>
    /// 商品明细
    /// </summary>
    public async Task<GetGoodsDetailResponse> GetGoodsDetailAsync(GetGoodsDetail getGoodsDetail)
    {
        var result = await PostAsync<GetGoodsDetail, GetGoodsDetailResponse>("pdd.goods.detail.get", getGoodsDetail);
        return result;
    }

    /// <summary>
    /// 新增或编辑草稿接口
    /// </summary>
    public async Task<CommitGoodsEditGoodsResponse> CommitGoodsEditGoodsAsync(CommitGoodsEditGoods commitGoodsEditGoods)
    {
        var result = await PostAsync<CommitGoodsEditGoods, CommitGoodsEditGoodsResponse>("pdd.goods.edit.goods.commit", commitGoodsEditGoods);
        return result;
    }

    /// <summary>
    /// 文件详情查询
    /// </summary>
    public async Task<GetGoodsFileInfoResponse> GetGoodsFileInfoAsync(GetGoodsFileInfo getGoodsFileInfo)
    {
        var result = await PostAsync<GetGoodsFileInfo, GetGoodsFileInfoResponse>("pdd.goods.file.info.get", getGoodsFileInfo);
        return result;
    }

    /// <summary>
    /// 图片上传到图片空间
    /// </summary>
    public async Task<UploadGoodsFilespaceImageResponse> UploadGoodsFilespaceImageAsync(UploadGoodsFilespaceImage uploadGoodsFilespaceImage)
    {
        var result = await PostFileAsync<UploadGoodsFilespaceImage, UploadGoodsFilespaceImageResponse>("pdd.goods.filespace.image.upload", uploadGoodsFilespaceImage);
        return result;
    }

    /// <summary>
    /// 商品图片上传接口
    /// </summary>
    public async Task<UploadGoodsImageResponse> UploadGoodsImageAsync(UploadGoodsImage uploadGoodsImage)
    {
        var result = await PostAsync<UploadGoodsImage, UploadGoodsImageResponse>("pdd.goods.image.upload", uploadGoodsImage);
        return result;
    }

    /// <summary>
    /// 商品图片上传接口
    /// </summary>
    public async Task<UploadGoodsImgResponse> UploadGoodsImgAsync(UploadGoodsImg uploadGoodsImg)
    {
        var result = await PostFileAsync<UploadGoodsImg, UploadGoodsImgResponse>("pdd.goods.img.upload", uploadGoodsImg);
        return result;
    }

    /// <summary>
    /// 商品详情接口
    /// </summary>
    public async Task<GetGoodsInformationResponse> GetGoodsInformationAsync(GetGoodsInformation getGoodsInformation)
    {
        var result = await PostAsync<GetGoodsInformation, GetGoodsInformationResponse>("pdd.goods.information.get", getGoodsInformation);
        return result;
    }

    /// <summary>
    /// 商品编辑
    /// </summary>
    public async Task<UpdateGoodsInformationResponse> UpdateGoodsInformationAsync(UpdateGoodsInformation updateGoodsInformation)
    {
        var result = await PostAsync<UpdateGoodsInformation, UpdateGoodsInformationResponse>("pdd.goods.information.update", updateGoodsInformation);
        return result;
    }

    /// <summary>
    /// 批量goodsId查询最新的审核状态
    /// </summary>
    public async Task<GetGoodsLatestCommitStatusResponse> GetGoodsLatestCommitStatusAsync(GetGoodsLatestCommitStatus getGoodsLatestCommitStatus)
    {
        var result = await PostAsync<GetGoodsLatestCommitStatus, GetGoodsLatestCommitStatusResponse>("pdd.goods.latest.commit.status.get", getGoodsLatestCommitStatus);
        return result;
    }

    /// <summary>
    /// 商品列表接口
    /// </summary>
    public async Task<GetGoodsListResponse> GetGoodsListAsync(GetGoodsList getGoodsList)
    {
        var result = await PostAsync<GetGoodsList, GetGoodsListResponse>("pdd.goods.list.get", getGoodsList);
        return result;
    }

    /// <summary>
    /// 商品送装服务模版新增
    /// </summary>
    public async Task<CreateGoodsLogisticsSerTemplateResponse> CreateGoodsLogisticsSerTemplateAsync(CreateGoodsLogisticsSerTemplate createGoodsLogisticsSerTemplate)
    {
        var result = await PostAsync<CreateGoodsLogisticsSerTemplate, CreateGoodsLogisticsSerTemplateResponse>("pdd.goods.logistics.ser.template.create", createGoodsLogisticsSerTemplate);
        return result;
    }

    /// <summary>
    /// 商品送装服务模版删除
    /// </summary>
    public async Task<DeleteGoodsLogisticsSerTemplateResponse> DeleteGoodsLogisticsSerTemplateAsync(DeleteGoodsLogisticsSerTemplate deleteGoodsLogisticsSerTemplate)
    {
        var result = await PostAsync<DeleteGoodsLogisticsSerTemplate, DeleteGoodsLogisticsSerTemplateResponse>("pdd.goods.logistics.ser.template.delete", deleteGoodsLogisticsSerTemplate);
        return result;
    }

    /// <summary>
    /// 商品送装服务模版详情
    /// </summary>
    public async Task<DetailGoodsLogisticsSerTemplateResponse> DetailGoodsLogisticsSerTemplateAsync(DetailGoodsLogisticsSerTemplate detailGoodsLogisticsSerTemplate)
    {
        var result = await PostAsync<DetailGoodsLogisticsSerTemplate, DetailGoodsLogisticsSerTemplateResponse>("pdd.goods.logistics.ser.template.detail", detailGoodsLogisticsSerTemplate);
        return result;
    }

    /// <summary>
    /// 商品送装服务模版列表
    /// </summary>
    public async Task<ListGoodsLogisticsSerTemplateResponse> ListGoodsLogisticsSerTemplateAsync(ListGoodsLogisticsSerTemplate listGoodsLogisticsSerTemplate)
    {
        var result = await PostAsync<ListGoodsLogisticsSerTemplate, ListGoodsLogisticsSerTemplateResponse>("pdd.goods.logistics.ser.template.list", listGoodsLogisticsSerTemplate);
        return result;
    }

    /// <summary>
    /// 商品送装服务模版更新
    /// </summary>
    public async Task<UpdateGoodsLogisticsSerTemplateResponse> UpdateGoodsLogisticsSerTemplateAsync(UpdateGoodsLogisticsSerTemplate updateGoodsLogisticsSerTemplate)
    {
        var result = await PostAsync<UpdateGoodsLogisticsSerTemplate, UpdateGoodsLogisticsSerTemplateResponse>("pdd.goods.logistics.ser.template.update", updateGoodsLogisticsSerTemplate);
        return result;
    }

    /// <summary>
    /// 创建商品物流模版
    /// </summary>
    public async Task<CreateGoodsLogisticsTemplateResponse> CreateGoodsLogisticsTemplateAsync(CreateGoodsLogisticsTemplate createGoodsLogisticsTemplate)
    {
        var result = await PostAsync<CreateGoodsLogisticsTemplate, CreateGoodsLogisticsTemplateResponse>("pdd.goods.logistics.template.create", createGoodsLogisticsTemplate);
        return result;
    }

    /// <summary>
    /// 商品运费模版接口
    /// </summary>
    public async Task<GetGoodsLogisticsTemplateResponse> GetGoodsLogisticsTemplateAsync(GetGoodsLogisticsTemplate getGoodsLogisticsTemplate)
    {
        var result = await PostAsync<GetGoodsLogisticsTemplate, GetGoodsLogisticsTemplateResponse>("pdd.goods.logistics.template.get", getGoodsLogisticsTemplate);
        return result;
    }

    /// <summary>
    /// 商品素材创建接口
    /// </summary>
    public async Task<CreateGoodsMaterialResponse> CreateGoodsMaterialAsync(CreateGoodsMaterial createGoodsMaterial)
    {
        var result = await PostAsync<CreateGoodsMaterial, CreateGoodsMaterialResponse>("pdd.goods.material.create", createGoodsMaterial);
        return result;
    }

    /// <summary>
    /// 商品素材删除接口
    /// </summary>
    public async Task<DeleteGoodsMaterialResponse> DeleteGoodsMaterialAsync(DeleteGoodsMaterial deleteGoodsMaterial)
    {
        var result = await PostAsync<DeleteGoodsMaterial, DeleteGoodsMaterialResponse>("pdd.goods.material.delete", deleteGoodsMaterial);
        return result;
    }

    /// <summary>
    /// 商品素材列表查询
    /// </summary>
    public async Task<QueryGoodsMaterialResponse> QueryGoodsMaterialAsync(QueryGoodsMaterial queryGoodsMaterial)
    {
        var result = await PostAsync<QueryGoodsMaterial, QueryGoodsMaterialResponse>("pdd.goods.material.query", queryGoodsMaterial);
        return result;
    }

    /// <summary>
    /// 查询商品标签列表
    /// </summary>
    public async Task<GetGoodsOptResponse> GetGoodsOptAsync(GetGoodsOpt getGoodsOpt)
    {
        var result = await PostAsync<GetGoodsOpt, GetGoodsOptResponse>("pdd.goods.opt.get", getGoodsOpt);
        return result;
    }

    /// <summary>
    /// 站内外属性映射接口
    /// </summary>
    public async Task<GetGoodsOutPropertyMappingResponse> GetGoodsOutPropertyMappingAsync(GetGoodsOutPropertyMapping getGoodsOutPropertyMapping)
    {
        var result = await PostAsync<GetGoodsOutPropertyMapping, GetGoodsOutPropertyMappingResponse>("pdd.goods.out.property.mapping.get", getGoodsOutPropertyMapping);
        return result;
    }

    /// <summary>
    /// 类目预测接口
    /// </summary>
    public async Task<GetGoodsOuterCatMappingResponse> GetGoodsOuterCatMappingAsync(GetGoodsOuterCatMapping getGoodsOuterCatMapping)
    {
        var result = await PostAsync<GetGoodsOuterCatMapping, GetGoodsOuterCatMappingResponse>("pdd.goods.outer.cat.mapping.get", getGoodsOuterCatMapping);
        return result;
    }

    /// <summary>
    /// 商品价格核实
    /// </summary>
    public async Task<CheckGoodsPriceResponse> CheckGoodsPriceAsync(CheckGoodsPrice checkGoodsPrice)
    {
        var result = await PostAsync<CheckGoodsPrice, CheckGoodsPriceResponse>("pdd.goods.price.check", checkGoodsPrice);
        return result;
    }

    /// <summary>
    /// 商品库存更新接口
    /// </summary>
    public async Task<UpdateGoodsQuantityResponse> UpdateGoodsQuantityAsync(UpdateGoodsQuantity updateGoodsQuantity)
    {
        var result = await PostAsync<UpdateGoodsQuantity, UpdateGoodsQuantityResponse>("pdd.goods.quantity.update", updateGoodsQuantity);
        return result;
    }

    /// <summary>
    /// 商品上架状态设置
    /// </summary>
    public async Task<SetGoodsSaleStatusResponse> SetGoodsSaleStatusAsync(SetGoodsSaleStatus setGoodsSaleStatus)
    {
        var result = await PostAsync<SetGoodsSaleStatus, SetGoodsSaleStatusResponse>("pdd.goods.sale.status.set", setGoodsSaleStatus);
        return result;
    }

    /// <summary>
    /// 尺码表分类查询
    /// </summary>
    public async Task<GetGoodsSizespecClassResponse> GetGoodsSizespecClassAsync(GetGoodsSizespecClass getGoodsSizespecClass)
    {
        var result = await PostAsync<GetGoodsSizespecClass, GetGoodsSizespecClassResponse>("pdd.goods.sizespec.class.get", getGoodsSizespecClass);
        return result;
    }

    /// <summary>
    /// 尺码组和尺码参数查询
    /// </summary>
    public async Task<GetGoodsSizespecMetaResponse> GetGoodsSizespecMetaAsync(GetGoodsSizespecMeta getGoodsSizespecMeta)
    {
        var result = await PostAsync<GetGoodsSizespecMeta, GetGoodsSizespecMetaResponse>("pdd.goods.sizespec.meta.get", getGoodsSizespecMeta);
        return result;
    }

    /// <summary>
    /// 新增自定义尺码表模版
    /// </summary>
    public async Task<AddGoodsSizespecTemplateResponse> AddGoodsSizespecTemplateAsync(AddGoodsSizespecTemplate addGoodsSizespecTemplate)
    {
        var result = await PostAsync<AddGoodsSizespecTemplate, AddGoodsSizespecTemplateResponse>("pdd.goods.sizespec.template.add", addGoodsSizespecTemplate);
        return result;
    }

    /// <summary>
    /// 删除自定义尺码表模版
    /// </summary>
    public async Task<DeleteGoodsSizespecTemplateResponse> DeleteGoodsSizespecTemplateAsync(DeleteGoodsSizespecTemplate deleteGoodsSizespecTemplate)
    {
        var result = await PostAsync<DeleteGoodsSizespecTemplate, DeleteGoodsSizespecTemplateResponse>("pdd.goods.sizespec.template.delete", deleteGoodsSizespecTemplate);
        return result;
    }

    /// <summary>
    /// 根据尺码表模板id查询自定义尺码表模版
    /// </summary>
    public async Task<GetGoodsSizespecTemplateResponse> GetGoodsSizespecTemplateAsync(GetGoodsSizespecTemplate getGoodsSizespecTemplate)
    {
        var result = await PostAsync<GetGoodsSizespecTemplate, GetGoodsSizespecTemplateResponse>("pdd.goods.sizespec.template.get", getGoodsSizespecTemplate);
        return result;
    }

    /// <summary>
    /// 更新自定义尺码表模版
    /// </summary>
    public async Task<UpdateGoodsSizespecTemplateResponse> UpdateGoodsSizespecTemplateAsync(UpdateGoodsSizespecTemplate updateGoodsSizespecTemplate)
    {
        var result = await PostAsync<UpdateGoodsSizespecTemplate, UpdateGoodsSizespecTemplateResponse>("pdd.goods.sizespec.template.update", updateGoodsSizespecTemplate);
        return result;
    }

    /// <summary>
    /// 自定义尺码表模版列表
    /// </summary>
    public async Task<GetGoodsSizespecTemplatesResponse> GetGoodsSizespecTemplatesAsync(GetGoodsSizespecTemplates getGoodsSizespecTemplates)
    {
        var result = await PostAsync<GetGoodsSizespecTemplates, GetGoodsSizespecTemplatesResponse>("pdd.goods.sizespec.templates.get", getGoodsSizespecTemplates);
        return result;
    }

    /// <summary>
    /// 修改商品sku价格
    /// </summary>
    public async Task<UpdateGoodsSkuPriceResponse> UpdateGoodsSkuPriceAsync(UpdateGoodsSkuPrice updateGoodsSkuPrice)
    {
        var result = await PostAsync<UpdateGoodsSkuPrice, UpdateGoodsSkuPriceResponse>("pdd.goods.sku.price.update", updateGoodsSkuPrice);
        return result;
    }

    /// <summary>
    /// 根据skuId查询sku详情
    /// </summary>
    public async Task<GetGoodsSkusResponse> GetGoodsSkusAsync(GetGoodsSkus getGoodsSkus)
    {
        var result = await PostAsync<GetGoodsSkus, GetGoodsSkusResponse>("pdd.goods.skus.get", getGoodsSkus);
        return result;
    }

    /// <summary>
    /// 商品属性类目接口
    /// </summary>
    public async Task<GetGoodsSpecResponse> GetGoodsSpecAsync(GetGoodsSpec getGoodsSpec)
    {
        var result = await PostAsync<GetGoodsSpec, GetGoodsSpecResponse>("pdd.goods.spec.get", getGoodsSpec);
        return result;
    }

    /// <summary>
    /// 生成商家自定义的规格
    /// </summary>
    public async Task<GetGoodsSpecIdResponse> GetGoodsSpecIdAsync(GetGoodsSpecId getGoodsSpecId)
    {
        var result = await PostAsync<GetGoodsSpecId, GetGoodsSpecIdResponse>("pdd.goods.spec.id.get", getGoodsSpecId);
        return result;
    }

    /// <summary>
    /// 标品详情接口
    /// </summary>
    public async Task<GetGoodsSpuResponse> GetGoodsSpuAsync(GetGoodsSpu getGoodsSpu)
    {
        var result = await PostAsync<GetGoodsSpu, GetGoodsSpuResponse>("pdd.goods.spu.get", getGoodsSpu);
        return result;
    }

    /// <summary>
    /// 标品搜索接口
    /// </summary>
    public async Task<SearchGoodsSpuResponse> SearchGoodsSpuAsync(SearchGoodsSpu searchGoodsSpu)
    {
        var result = await PostAsync<SearchGoodsSpu, SearchGoodsSpuResponse>("pdd.goods.spu.search", searchGoodsSpu);
        return result;
    }

    /// <summary>
    /// 编辑并提交草稿接口
    /// </summary>
    public async Task<CommitGoodsSubmitGoodsResponse> CommitGoodsSubmitGoodsAsync(CommitGoodsSubmitGoods commitGoodsSubmitGoods)
    {
        var result = await PostAsync<CommitGoodsSubmitGoods, CommitGoodsSubmitGoodsResponse>("pdd.goods.submit.goods.commit", commitGoodsSubmitGoods);
        return result;
    }

    /// <summary>
    /// 模板属性值搜索接口
    /// </summary>
    public async Task<SearchGoodsTemplatePropertyValueResponse> SearchGoodsTemplatePropertyValueAsync(SearchGoodsTemplatePropertyValue searchGoodsTemplatePropertyValue)
    {
        var result = await PostAsync<SearchGoodsTemplatePropertyValue, SearchGoodsTemplatePropertyValueResponse>("pdd.goods.template.property.value.search", searchGoodsTemplatePropertyValue);
        return result;
    }

    /// <summary>
    /// 商品sku计量单位枚举
    /// </summary>
    public async Task<ListGooodsSkuMeasurementResponse> ListGooodsSkuMeasurementAsync(ListGooodsSkuMeasurement listGooodsSkuMeasurement)
    {
        var result = await PostAsync<ListGooodsSkuMeasurement, ListGooodsSkuMeasurementResponse>("pdd.gooods.sku.measurement.list", listGooodsSkuMeasurement);
        return result;
    }

    /// <summary>
    /// 按id获取商品运费模版接口
    /// </summary>
    public async Task<TemplateOneExpressCostResponse> TemplateOneExpressCostAsync(TemplateOneExpressCost templateOneExpressCost)
    {
        var result = await PostAsync<TemplateOneExpressCost, TemplateOneExpressCostResponse>("pdd.one.express.cost.template", templateOneExpressCost);
        return result;
    }

}
