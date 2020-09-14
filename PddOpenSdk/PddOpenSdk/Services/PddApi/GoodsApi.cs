
using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Goods;
using PddOpenSdk.Models.Response.Goods;
namespace PddOpenSdk.Services.PddApi
{
    public class GoodsApi : PddCommonApi
    {
        public GoodsApi() { }
        public GoodsApi(string accessToken) { AccessToken = accessToken; }
        /// <summary>
        /// 删除草稿接口
        /// </summary>
        public async Task<CommitDeleteDraftResponseModel> CommitDeleteDraftAsync(CommitDeleteDraftRequestModel commitDeleteDraft)
        {
            var result = await PostAsync<CommitDeleteDraftRequestModel, CommitDeleteDraftResponseModel>("pdd.delete.draft.commit", commitDeleteDraft);
            return result;
        }
        /// <summary>
        /// 删除商品接口
        /// </summary>
        public async Task<CommitDeleteGoodsResponseModel> CommitDeleteGoodsAsync(CommitDeleteGoodsRequestModel commitDeleteGoods)
        {
            var result = await PostAsync<CommitDeleteGoodsRequestModel, CommitDeleteGoodsResponseModel>("pdd.delete.goods.commit", commitDeleteGoods);
            return result;
        }
        /// <summary>
        /// 商品新增接口
        /// </summary>
        public async Task<AddGoodsResponseModel> AddGoodsAsync(AddGoodsRequestModel addGoods)
        {
            var result = await PostAsync<AddGoodsRequestModel, AddGoodsResponseModel>("pdd.goods.add", addGoods);
            return result;
        }
        /// <summary>
        /// 获取当前授权商家可发布的商品类目信息
        /// </summary>
        public async Task<CatsGoodsAuthorizationResponseModel> CatsGoodsAuthorizationAsync(CatsGoodsAuthorizationRequestModel catsGoodsAuthorization)
        {
            var result = await PostAsync<CatsGoodsAuthorizationRequestModel, CatsGoodsAuthorizationResponseModel>("pdd.goods.authorization.cats", catsGoodsAuthorization);
            return result;
        }
        /// <summary>
        /// 获取商品类目属性
        /// </summary>
        public async Task<GetGoodsCatTemplateResponseModel> GetGoodsCatTemplateAsync(GetGoodsCatTemplateRequestModel getGoodsCatTemplate)
        {
            var result = await PostAsync<GetGoodsCatTemplateRequestModel, GetGoodsCatTemplateResponseModel>("pdd.goods.cat.template.get", getGoodsCatTemplate);
            return result;
        }
        /// <summary>
        /// 商品标准类目接口
        /// </summary>
        public async Task<GetGoodsCatsResponseModel> GetGoodsCatsAsync(GetGoodsCatsRequestModel getGoodsCats)
        {
            var result = await PostAsync<GetGoodsCatsRequestModel, GetGoodsCatsResponseModel>("pdd.goods.cats.get", getGoodsCats);
            return result;
        }
        /// <summary>
        /// 日历库存子SKU新增及编辑接口
        /// </summary>
        public async Task<EditGoodsChildSkuResponseModel> EditGoodsChildSkuAsync(EditGoodsChildSkuRequestModel editGoodsChildSku)
        {
            var result = await PostAsync<EditGoodsChildSkuRequestModel, EditGoodsChildSkuResponseModel>("pdd.goods.child.sku.edit", editGoodsChildSku);
            return result;
        }
        /// <summary>
        /// 获取商品提交的商品详情
        /// </summary>
        public async Task<GetGoodsCommitDetailResponseModel> GetGoodsCommitDetailAsync(GetGoodsCommitDetailRequestModel getGoodsCommitDetail)
        {
            var result = await PostAsync<GetGoodsCommitDetailRequestModel, GetGoodsCommitDetailResponseModel>("pdd.goods.commit.detail.get", getGoodsCommitDetail);
            return result;
        }
        /// <summary>
        /// 草稿列表接口
        /// </summary>
        public async Task<GetGoodsCommitListResponseModel> GetGoodsCommitListAsync(GetGoodsCommitListRequestModel getGoodsCommitList)
        {
            var result = await PostAsync<GetGoodsCommitListRequestModel, GetGoodsCommitListResponseModel>("pdd.goods.commit.list.get", getGoodsCommitList);
            return result;
        }
        /// <summary>
        /// 草稿状态查询接口
        /// </summary>
        public async Task<GetGoodsCommitStatusResponseModel> GetGoodsCommitStatusAsync(GetGoodsCommitStatusRequestModel getGoodsCommitStatus)
        {
            var result = await PostAsync<GetGoodsCommitStatusRequestModel, GetGoodsCommitStatusResponseModel>("pdd.goods.commit.status.get", getGoodsCommitStatus);
            return result;
        }
        /// <summary>
        /// 商品国家接口
        /// </summary>
        public async Task<GetGoodsCountryResponseModel> GetGoodsCountryAsync(GetGoodsCountryRequestModel getGoodsCountry)
        {
            var result = await PostAsync<GetGoodsCountryRequestModel, GetGoodsCountryResponseModel>("pdd.goods.country.get", getGoodsCountry);
            return result;
        }
        /// <summary>
        /// 修改全店推广API
        /// </summary>
        public async Task<ChangeGoodsCpsMallUnitResponseModel> ChangeGoodsCpsMallUnitAsync(ChangeGoodsCpsMallUnitRequestModel changeGoodsCpsMallUnit)
        {
            var result = await PostAsync<ChangeGoodsCpsMallUnitRequestModel, ChangeGoodsCpsMallUnitResponseModel>("pdd.goods.cps.mall.unit.change", changeGoodsCpsMallUnit);
            return result;
        }
        /// <summary>
        /// 设置全店推广API
        /// </summary>
        public async Task<CreateGoodsCpsMallUnitResponseModel> CreateGoodsCpsMallUnitAsync(CreateGoodsCpsMallUnitRequestModel createGoodsCpsMallUnit)
        {
            var result = await PostAsync<CreateGoodsCpsMallUnitRequestModel, CreateGoodsCpsMallUnitResponseModel>("pdd.goods.cps.mall.unit.create", createGoodsCpsMallUnit);
            return result;
        }
        /// <summary>
        /// 暂停全店推广API
        /// </summary>
        public async Task<PauseGoodsCpsMallUnitResponseModel> PauseGoodsCpsMallUnitAsync(PauseGoodsCpsMallUnitRequestModel pauseGoodsCpsMallUnit)
        {
            var result = await PostAsync<PauseGoodsCpsMallUnitRequestModel, PauseGoodsCpsMallUnitResponseModel>("pdd.goods.cps.mall.unit.pause", pauseGoodsCpsMallUnit);
            return result;
        }
        /// <summary>
        /// 查询全店推广API
        /// </summary>
        public async Task<QueryGoodsCpsMallUnitResponseModel> QueryGoodsCpsMallUnitAsync(QueryGoodsCpsMallUnitRequestModel queryGoodsCpsMallUnit)
        {
            var result = await PostAsync<QueryGoodsCpsMallUnitRequestModel, QueryGoodsCpsMallUnitResponseModel>("pdd.goods.cps.mall.unit.query", queryGoodsCpsMallUnit);
            return result;
        }
        /// <summary>
        /// 恢复全店推广API
        /// </summary>
        public async Task<ResumeGoodsCpsMallUnitResponseModel> ResumeGoodsCpsMallUnitAsync(ResumeGoodsCpsMallUnitRequestModel resumeGoodsCpsMallUnit)
        {
            var result = await PostAsync<ResumeGoodsCpsMallUnitRequestModel, ResumeGoodsCpsMallUnitResponseModel>("pdd.goods.cps.mall.unit.resume", resumeGoodsCpsMallUnit);
            return result;
        }
        /// <summary>
        /// 修改商品推广API
        /// </summary>
        public async Task<ChangeGoodsCpsUnitResponseModel> ChangeGoodsCpsUnitAsync(ChangeGoodsCpsUnitRequestModel changeGoodsCpsUnit)
        {
            var result = await PostAsync<ChangeGoodsCpsUnitRequestModel, ChangeGoodsCpsUnitResponseModel>("pdd.goods.cps.unit.change", changeGoodsCpsUnit);
            return result;
        }
        /// <summary>
        /// 设置单品推广API
        /// </summary>
        public async Task<CreateGoodsCpsUnitResponseModel> CreateGoodsCpsUnitAsync(CreateGoodsCpsUnitRequestModel createGoodsCpsUnit)
        {
            var result = await PostAsync<CreateGoodsCpsUnitRequestModel, CreateGoodsCpsUnitResponseModel>("pdd.goods.cps.unit.create", createGoodsCpsUnit);
            return result;
        }
        /// <summary>
        /// 删除单品计划接口
        /// </summary>
        public async Task<DeleteGoodsCpsUnitResponseModel> DeleteGoodsCpsUnitAsync(DeleteGoodsCpsUnitRequestModel deleteGoodsCpsUnit)
        {
            var result = await PostAsync<DeleteGoodsCpsUnitRequestModel, DeleteGoodsCpsUnitResponseModel>("pdd.goods.cps.unit.delete", deleteGoodsCpsUnit);
            return result;
        }
        /// <summary>
        /// 查询商品推广API
        /// </summary>
        public async Task<QueryGoodsCpsUnitResponseModel> QueryGoodsCpsUnitAsync(QueryGoodsCpsUnitRequestModel queryGoodsCpsUnit)
        {
            var result = await PostAsync<QueryGoodsCpsUnitRequestModel, QueryGoodsCpsUnitResponseModel>("pdd.goods.cps.unit.query", queryGoodsCpsUnit);
            return result;
        }
        /// <summary>
        /// 商品明细
        /// </summary>
        public async Task<GetGoodsDetailResponseModel> GetGoodsDetailAsync(GetGoodsDetailRequestModel getGoodsDetail)
        {
            var result = await PostAsync<GetGoodsDetailRequestModel, GetGoodsDetailResponseModel>("pdd.goods.detail.get", getGoodsDetail);
            return result;
        }
        /// <summary>
        /// 新增或编辑草稿接口
        /// </summary>
        public async Task<CommitGoodsEditGoodsResponseModel> CommitGoodsEditGoodsAsync(CommitGoodsEditGoodsRequestModel commitGoodsEditGoods)
        {
            var result = await PostAsync<CommitGoodsEditGoodsRequestModel, CommitGoodsEditGoodsResponseModel>("pdd.goods.edit.goods.commit", commitGoodsEditGoods);
            return result;
        }
        /// <summary>
        /// 图片上传到图片空间
        /// </summary>
        public async Task<UploadGoodsFilespaceImageResponseModel> UploadGoodsFilespaceImageAsync(UploadGoodsFilespaceImageRequestModel uploadGoodsFilespaceImage)
        {
            var result = await PostAsync<UploadGoodsFilespaceImageRequestModel, UploadGoodsFilespaceImageResponseModel>("pdd.goods.filespace.image.upload", uploadGoodsFilespaceImage);
            return result;
        }
        /// <summary>
        /// 商品图片上传接口
        /// </summary>
        public async Task<UploadGoodsImageResponseModel> UploadGoodsImageAsync(UploadGoodsImageRequestModel uploadGoodsImage)
        {
            var result = await PostAsync<UploadGoodsImageRequestModel, UploadGoodsImageResponseModel>("pdd.goods.image.upload", uploadGoodsImage);
            return result;
        }
        /// <summary>
        /// 商品详情接口
        /// </summary>
        public async Task<GetGoodsInformationResponseModel> GetGoodsInformationAsync(GetGoodsInformationRequestModel getGoodsInformation)
        {
            var result = await PostAsync<GetGoodsInformationRequestModel, GetGoodsInformationResponseModel>("pdd.goods.information.get", getGoodsInformation);
            return result;
        }
        /// <summary>
        /// 商品编辑
        /// </summary>
        public async Task<UpdateGoodsInformationResponseModel> UpdateGoodsInformationAsync(UpdateGoodsInformationRequestModel updateGoodsInformation)
        {
            var result = await PostAsync<UpdateGoodsInformationRequestModel, UpdateGoodsInformationResponseModel>("pdd.goods.information.update", updateGoodsInformation);
            return result;
        }
        /// <summary>
        /// 批量goodsId查询最新的审核状态
        /// </summary>
        public async Task<GetGoodsLatestCommitStatusResponseModel> GetGoodsLatestCommitStatusAsync(GetGoodsLatestCommitStatusRequestModel getGoodsLatestCommitStatus)
        {
            var result = await PostAsync<GetGoodsLatestCommitStatusRequestModel, GetGoodsLatestCommitStatusResponseModel>("pdd.goods.latest.commit.status.get", getGoodsLatestCommitStatus);
            return result;
        }
        /// <summary>
        /// 商品列表接口
        /// </summary>
        public async Task<GetGoodsListResponseModel> GetGoodsListAsync(GetGoodsListRequestModel getGoodsList)
        {
            var result = await PostAsync<GetGoodsListRequestModel, GetGoodsListResponseModel>("pdd.goods.list.get", getGoodsList);
            return result;
        }
        /// <summary>
        /// 商品送装服务模版新增
        /// </summary>
        public async Task<CreateGoodsLogisticsSerTemplateResponseModel> CreateGoodsLogisticsSerTemplateAsync(CreateGoodsLogisticsSerTemplateRequestModel createGoodsLogisticsSerTemplate)
        {
            var result = await PostAsync<CreateGoodsLogisticsSerTemplateRequestModel, CreateGoodsLogisticsSerTemplateResponseModel>("pdd.goods.logistics.ser.template.create", createGoodsLogisticsSerTemplate);
            return result;
        }
        /// <summary>
        /// 商品送装服务模版删除
        /// </summary>
        public async Task<DeleteGoodsLogisticsSerTemplateResponseModel> DeleteGoodsLogisticsSerTemplateAsync(DeleteGoodsLogisticsSerTemplateRequestModel deleteGoodsLogisticsSerTemplate)
        {
            var result = await PostAsync<DeleteGoodsLogisticsSerTemplateRequestModel, DeleteGoodsLogisticsSerTemplateResponseModel>("pdd.goods.logistics.ser.template.delete", deleteGoodsLogisticsSerTemplate);
            return result;
        }
        /// <summary>
        /// 商品送装服务模版详情
        /// </summary>
        public async Task<DetailGoodsLogisticsSerTemplateResponseModel> DetailGoodsLogisticsSerTemplateAsync(DetailGoodsLogisticsSerTemplateRequestModel detailGoodsLogisticsSerTemplate)
        {
            var result = await PostAsync<DetailGoodsLogisticsSerTemplateRequestModel, DetailGoodsLogisticsSerTemplateResponseModel>("pdd.goods.logistics.ser.template.detail", detailGoodsLogisticsSerTemplate);
            return result;
        }
        /// <summary>
        /// 商品送装服务模版列表
        /// </summary>
        public async Task<ListGoodsLogisticsSerTemplateResponseModel> ListGoodsLogisticsSerTemplateAsync(ListGoodsLogisticsSerTemplateRequestModel listGoodsLogisticsSerTemplate)
        {
            var result = await PostAsync<ListGoodsLogisticsSerTemplateRequestModel, ListGoodsLogisticsSerTemplateResponseModel>("pdd.goods.logistics.ser.template.list", listGoodsLogisticsSerTemplate);
            return result;
        }
        /// <summary>
        /// 商品送装服务模版更新
        /// </summary>
        public async Task<UpdateGoodsLogisticsSerTemplateResponseModel> UpdateGoodsLogisticsSerTemplateAsync(UpdateGoodsLogisticsSerTemplateRequestModel updateGoodsLogisticsSerTemplate)
        {
            var result = await PostAsync<UpdateGoodsLogisticsSerTemplateRequestModel, UpdateGoodsLogisticsSerTemplateResponseModel>("pdd.goods.logistics.ser.template.update", updateGoodsLogisticsSerTemplate);
            return result;
        }
        /// <summary>
        /// 创建商品物流模版
        /// </summary>
        public async Task<CreateGoodsLogisticsTemplateResponseModel> CreateGoodsLogisticsTemplateAsync(CreateGoodsLogisticsTemplateRequestModel createGoodsLogisticsTemplate)
        {
            var result = await PostAsync<CreateGoodsLogisticsTemplateRequestModel, CreateGoodsLogisticsTemplateResponseModel>("pdd.goods.logistics.template.create", createGoodsLogisticsTemplate);
            return result;
        }
        /// <summary>
        /// 商品运费模版接口
        /// </summary>
        public async Task<GetGoodsLogisticsTemplateResponseModel> GetGoodsLogisticsTemplateAsync(GetGoodsLogisticsTemplateRequestModel getGoodsLogisticsTemplate)
        {
            var result = await PostAsync<GetGoodsLogisticsTemplateRequestModel, GetGoodsLogisticsTemplateResponseModel>("pdd.goods.logistics.template.get", getGoodsLogisticsTemplate);
            return result;
        }
        /// <summary>
        /// 商品素材创建接口
        /// </summary>
        public async Task<CreateGoodsMaterialResponseModel> CreateGoodsMaterialAsync(CreateGoodsMaterialRequestModel createGoodsMaterial)
        {
            var result = await PostAsync<CreateGoodsMaterialRequestModel, CreateGoodsMaterialResponseModel>("pdd.goods.material.create", createGoodsMaterial);
            return result;
        }
        /// <summary>
        /// 商品素材删除接口
        /// </summary>
        public async Task<DeleteGoodsMaterialResponseModel> DeleteGoodsMaterialAsync(DeleteGoodsMaterialRequestModel deleteGoodsMaterial)
        {
            var result = await PostAsync<DeleteGoodsMaterialRequestModel, DeleteGoodsMaterialResponseModel>("pdd.goods.material.delete", deleteGoodsMaterial);
            return result;
        }
        /// <summary>
        /// 商品素材列表查询
        /// </summary>
        public async Task<QueryGoodsMaterialResponseModel> QueryGoodsMaterialAsync(QueryGoodsMaterialRequestModel queryGoodsMaterial)
        {
            var result = await PostAsync<QueryGoodsMaterialRequestModel, QueryGoodsMaterialResponseModel>("pdd.goods.material.query", queryGoodsMaterial);
            return result;
        }
        /// <summary>
        /// 查询商品标签列表
        /// </summary>
        public async Task<GetGoodsOptResponseModel> GetGoodsOptAsync(GetGoodsOptRequestModel getGoodsOpt)
        {
            var result = await PostAsync<GetGoodsOptRequestModel, GetGoodsOptResponseModel>("pdd.goods.opt.get", getGoodsOpt);
            return result;
        }
        /// <summary>
        /// 站内外属性映射接口
        /// </summary>
        public async Task<GetGoodsOutPropertyMappingResponseModel> GetGoodsOutPropertyMappingAsync(GetGoodsOutPropertyMappingRequestModel getGoodsOutPropertyMapping)
        {
            var result = await PostAsync<GetGoodsOutPropertyMappingRequestModel, GetGoodsOutPropertyMappingResponseModel>("pdd.goods.out.property.mapping.get", getGoodsOutPropertyMapping);
            return result;
        }
        /// <summary>
        /// 类目预测接口
        /// </summary>
        public async Task<GetGoodsOuterCatMappingResponseModel> GetGoodsOuterCatMappingAsync(GetGoodsOuterCatMappingRequestModel getGoodsOuterCatMapping)
        {
            var result = await PostAsync<GetGoodsOuterCatMappingRequestModel, GetGoodsOuterCatMappingResponseModel>("pdd.goods.outer.cat.mapping.get", getGoodsOuterCatMapping);
            return result;
        }
        /// <summary>
        /// 商品库存更新接口
        /// </summary>
        public async Task<UpdateGoodsQuantityResponseModel> UpdateGoodsQuantityAsync(UpdateGoodsQuantityRequestModel updateGoodsQuantity)
        {
            var result = await PostAsync<UpdateGoodsQuantityRequestModel, UpdateGoodsQuantityResponseModel>("pdd.goods.quantity.update", updateGoodsQuantity);
            return result;
        }
        /// <summary>
        /// 商品上架状态设置
        /// </summary>
        public async Task<SetGoodsSaleStatusResponseModel> SetGoodsSaleStatusAsync(SetGoodsSaleStatusRequestModel setGoodsSaleStatus)
        {
            var result = await PostAsync<SetGoodsSaleStatusRequestModel, SetGoodsSaleStatusResponseModel>("pdd.goods.sale.status.set", setGoodsSaleStatus);
            return result;
        }
        /// <summary>
        /// 尺码表分类查询
        /// </summary>
        public async Task<GetGoodsSizespecClassResponseModel> GetGoodsSizespecClassAsync(GetGoodsSizespecClassRequestModel getGoodsSizespecClass)
        {
            var result = await PostAsync<GetGoodsSizespecClassRequestModel, GetGoodsSizespecClassResponseModel>("pdd.goods.sizespec.class.get", getGoodsSizespecClass);
            return result;
        }
        /// <summary>
        /// 尺码组和尺码参数查询
        /// </summary>
        public async Task<GetGoodsSizespecMetaResponseModel> GetGoodsSizespecMetaAsync(GetGoodsSizespecMetaRequestModel getGoodsSizespecMeta)
        {
            var result = await PostAsync<GetGoodsSizespecMetaRequestModel, GetGoodsSizespecMetaResponseModel>("pdd.goods.sizespec.meta.get", getGoodsSizespecMeta);
            return result;
        }
        /// <summary>
        /// 新增自定义尺码表模版
        /// </summary>
        public async Task<AddGoodsSizespecTemplateResponseModel> AddGoodsSizespecTemplateAsync(AddGoodsSizespecTemplateRequestModel addGoodsSizespecTemplate)
        {
            var result = await PostAsync<AddGoodsSizespecTemplateRequestModel, AddGoodsSizespecTemplateResponseModel>("pdd.goods.sizespec.template.add", addGoodsSizespecTemplate);
            return result;
        }
        /// <summary>
        /// 删除自定义尺码表模版
        /// </summary>
        public async Task<DeleteGoodsSizespecTemplateResponseModel> DeleteGoodsSizespecTemplateAsync(DeleteGoodsSizespecTemplateRequestModel deleteGoodsSizespecTemplate)
        {
            var result = await PostAsync<DeleteGoodsSizespecTemplateRequestModel, DeleteGoodsSizespecTemplateResponseModel>("pdd.goods.sizespec.template.delete", deleteGoodsSizespecTemplate);
            return result;
        }
        /// <summary>
        /// 根据尺码表模板id查询自定义尺码表模版
        /// </summary>
        public async Task<GetGoodsSizespecTemplateResponseModel> GetGoodsSizespecTemplateAsync(GetGoodsSizespecTemplateRequestModel getGoodsSizespecTemplate)
        {
            var result = await PostAsync<GetGoodsSizespecTemplateRequestModel, GetGoodsSizespecTemplateResponseModel>("pdd.goods.sizespec.template.get", getGoodsSizespecTemplate);
            return result;
        }
        /// <summary>
        /// 更新自定义尺码表模版
        /// </summary>
        public async Task<UpdateGoodsSizespecTemplateResponseModel> UpdateGoodsSizespecTemplateAsync(UpdateGoodsSizespecTemplateRequestModel updateGoodsSizespecTemplate)
        {
            var result = await PostAsync<UpdateGoodsSizespecTemplateRequestModel, UpdateGoodsSizespecTemplateResponseModel>("pdd.goods.sizespec.template.update", updateGoodsSizespecTemplate);
            return result;
        }
        /// <summary>
        /// 自定义尺码表模版列表
        /// </summary>
        public async Task<GetGoodsSizespecTemplatesResponseModel> GetGoodsSizespecTemplatesAsync(GetGoodsSizespecTemplatesRequestModel getGoodsSizespecTemplates)
        {
            var result = await PostAsync<GetGoodsSizespecTemplatesRequestModel, GetGoodsSizespecTemplatesResponseModel>("pdd.goods.sizespec.templates.get", getGoodsSizespecTemplates);
            return result;
        }
        /// <summary>
        /// 修改商品sku价格
        /// </summary>
        public async Task<UpdateGoodsSkuPriceResponseModel> UpdateGoodsSkuPriceAsync(UpdateGoodsSkuPriceRequestModel updateGoodsSkuPrice)
        {
            var result = await PostAsync<UpdateGoodsSkuPriceRequestModel, UpdateGoodsSkuPriceResponseModel>("pdd.goods.sku.price.update", updateGoodsSkuPrice);
            return result;
        }
        /// <summary>
        /// 商品属性类目接口
        /// </summary>
        public async Task<GetGoodsSpecResponseModel> GetGoodsSpecAsync(GetGoodsSpecRequestModel getGoodsSpec)
        {
            var result = await PostAsync<GetGoodsSpecRequestModel, GetGoodsSpecResponseModel>("pdd.goods.spec.get", getGoodsSpec);
            return result;
        }
        /// <summary>
        /// 生成商家自定义的规格
        /// </summary>
        public async Task<GetGoodsSpecIdResponseModel> GetGoodsSpecIdAsync(GetGoodsSpecIdRequestModel getGoodsSpecId)
        {
            var result = await PostAsync<GetGoodsSpecIdRequestModel, GetGoodsSpecIdResponseModel>("pdd.goods.spec.id.get", getGoodsSpecId);
            return result;
        }
        /// <summary>
        /// 编辑并提交草稿接口
        /// </summary>
        public async Task<CommitGoodsSubmitGoodsResponseModel> CommitGoodsSubmitGoodsAsync(CommitGoodsSubmitGoodsRequestModel commitGoodsSubmitGoods)
        {
            var result = await PostAsync<CommitGoodsSubmitGoodsRequestModel, CommitGoodsSubmitGoodsResponseModel>("pdd.goods.submit.goods.commit", commitGoodsSubmitGoods);
            return result;
        }
        /// <summary>
        /// 模板属性值搜索接口
        /// </summary>
        public async Task<SearchGoodsTemplatePropertyValueResponseModel> SearchGoodsTemplatePropertyValueAsync(SearchGoodsTemplatePropertyValueRequestModel searchGoodsTemplatePropertyValue)
        {
            var result = await PostAsync<SearchGoodsTemplatePropertyValueRequestModel, SearchGoodsTemplatePropertyValueResponseModel>("pdd.goods.template.property.value.search", searchGoodsTemplatePropertyValue);
            return result;
        }
        /// <summary>
        /// 商品sku计量单位枚举
        /// </summary>
        public async Task<ListGooodsSkuMeasurementResponseModel> ListGooodsSkuMeasurementAsync(ListGooodsSkuMeasurementRequestModel listGooodsSkuMeasurement)
        {
            var result = await PostAsync<ListGooodsSkuMeasurementRequestModel, ListGooodsSkuMeasurementResponseModel>("pdd.gooods.sku.measurement.list", listGooodsSkuMeasurement);
            return result;
        }
        /// <summary>
        /// 按id获取商品运费模版接口
        /// </summary>
        public async Task<TemplateOneExpressCostResponseModel> TemplateOneExpressCostAsync(TemplateOneExpressCostRequestModel templateOneExpressCost)
        {
            var result = await PostAsync<TemplateOneExpressCostRequestModel, TemplateOneExpressCostResponseModel>("pdd.one.express.cost.template", templateOneExpressCost);
            return result;
        }

    }
}
