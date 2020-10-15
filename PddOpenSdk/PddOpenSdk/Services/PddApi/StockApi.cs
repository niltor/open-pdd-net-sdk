
using PddOpenSdk.Models.Request.Stock;
using PddOpenSdk.Models.Response.Stock;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApi
{
    public class StockApi : PddCommonApi
    {
        public StockApi() { }
        public StockApi(string accessToken) { AccessToken = accessToken; }
        /// <summary>
        /// 增加仓库
        /// </summary>
        public async Task<DepotExpressAddResponseModel> DepotExpressAddAsync(DepotExpressAddRequestModel depotExpressAdd)
        {
            var result = await PostAsync<DepotExpressAddRequestModel, DepotExpressAddResponseModel>("pdd.express.add.depot", depotExpressAdd);
            return result;
        }
        /// <summary>
        /// 修改仓库信息
        /// </summary>
        public async Task<InfoExpressChangeDepotResponseModel> InfoExpressChangeDepotAsync(InfoExpressChangeDepotRequestModel infoExpressChangeDepot)
        {
            var result = await PostAsync<InfoExpressChangeDepotRequestModel, InfoExpressChangeDepotResponseModel>("pdd.express.change.depot.info", infoExpressChangeDepot);
            return result;
        }
        /// <summary>
        /// 仓库详细信息
        /// </summary>
        public async Task<GetExpressDepotInfoResponseModel> GetExpressDepotInfoAsync(GetExpressDepotInfoRequestModel getExpressDepotInfo)
        {
            var result = await PostAsync<GetExpressDepotInfoRequestModel, GetExpressDepotInfoResponseModel>("pdd.express.depot.info.get", getExpressDepotInfo);
            return result;
        }
        /// <summary>
        /// 仓库列表
        /// </summary>
        public async Task<GetExpressDepotListResponseModel> GetExpressDepotListAsync(GetExpressDepotListRequestModel getExpressDepotList)
        {
            var result = await PostAsync<GetExpressDepotListRequestModel, GetExpressDepotListResponseModel>("pdd.express.depot.list.get", getExpressDepotList);
            return result;
        }
        /// <summary>
        /// 商家全部仓库的简要信息列表
        /// </summary>
        public async Task<GetExpressMallDepotSimpleResponseModel> GetExpressMallDepotSimpleAsync(GetExpressMallDepotSimpleRequestModel getExpressMallDepotSimple)
        {
            var result = await PostAsync<GetExpressMallDepotSimpleRequestModel, GetExpressMallDepotSimpleResponseModel>("pdd.express.mall.depot.simple.get", getExpressMallDepotSimple);
            return result;
        }
        /// <summary>
        /// 根据仓库名称和仓库编码查询仓库
        /// </summary>
        public async Task<DepotExpressSearchResponseModel> DepotExpressSearchAsync(DepotExpressSearchRequestModel depotExpressSearch)
        {
            var result = await PostAsync<DepotExpressSearchRequestModel, DepotExpressSearchResponseModel>("pdd.express.search.depot", depotExpressSearch);
            return result;
        }
        /// <summary>
        /// 仓库优先级列表
        /// </summary>
        public async Task<ListStockDepotPriorityResponseModel> ListStockDepotPriorityAsync(ListStockDepotPriorityRequestModel listStockDepotPriority)
        {
            var result = await PostAsync<ListStockDepotPriorityRequestModel, ListStockDepotPriorityResponseModel>("pdd.stock.depot.priority.list", listStockDepotPriority);
            return result;
        }
        /// <summary>
        /// 批量更新仓库优先级
        /// </summary>
        public async Task<UpdateStockDepotPriorityResponseModel> UpdateStockDepotPriorityAsync(UpdateStockDepotPriorityRequestModel updateStockDepotPriority)
        {
            var result = await PostAsync<UpdateStockDepotPriorityRequestModel, UpdateStockDepotPriorityResponseModel>("pdd.stock.depot.priority.update", updateStockDepotPriority);
            return result;
        }
        /// <summary>
        /// 根据商品id查询sku信息
        /// </summary>
        public async Task<QueryStockGoodsIdToSkuResponseModel> QueryStockGoodsIdToSkuAsync(QueryStockGoodsIdToSkuRequestModel queryStockGoodsIdToSku)
        {
            var result = await PostAsync<QueryStockGoodsIdToSkuRequestModel, QueryStockGoodsIdToSkuResponseModel>("pdd.stock.goods.id.to.sku.query", queryStockGoodsIdToSku);
            return result;
        }
        /// <summary>
        /// 创建货品
        /// </summary>
        public async Task<CreateStockWareResponseModel> CreateStockWareAsync(CreateStockWareRequestModel createStockWare)
        {
            var result = await PostAsync<CreateStockWareRequestModel, CreateStockWareResponseModel>("pdd.stock.ware.create", createStockWare);
            return result;
        }
        /// <summary>
        /// 删除货品
        /// </summary>
        public async Task<DeleteStockWareResponseModel> DeleteStockWareAsync(DeleteStockWareRequestModel deleteStockWare)
        {
            var result = await PostAsync<DeleteStockWareRequestModel, DeleteStockWareResponseModel>("pdd.stock.ware.delete", deleteStockWare);
            return result;
        }
        /// <summary>
        /// 查询货品详情
        /// </summary>
        public async Task<QueryStockWareDetailResponseModel> QueryStockWareDetailAsync(QueryStockWareDetailRequestModel queryStockWareDetail)
        {
            var result = await PostAsync<QueryStockWareDetailRequestModel, QueryStockWareDetailResponseModel>("pdd.stock.ware.detail.query", queryStockWareDetail);
            return result;
        }
        /// <summary>
        /// 货品列表的查询接口
        /// </summary>
        public async Task<ListStockWareInfoResponseModel> ListStockWareInfoAsync(ListStockWareInfoRequestModel listStockWareInfo)
        {
            var result = await PostAsync<ListStockWareInfoRequestModel, ListStockWareInfoResponseModel>("pdd.stock.ware.info.list", listStockWareInfo);
            return result;
        }
        /// <summary>
        /// 查询货品列表
        /// </summary>
        public async Task<ListStockWareResponseModel> ListStockWareAsync(ListStockWareRequestModel listStockWare)
        {
            var result = await PostAsync<ListStockWareRequestModel, ListStockWareResponseModel>("pdd.stock.ware.list", listStockWare);
            return result;
        }
        /// <summary>
        /// 家电分仓库存-库存信息调整
        /// </summary>
        public async Task<MoveStockWareResponseModel> MoveStockWareAsync(MoveStockWareRequestModel moveStockWare)
        {
            var result = await PostAsync<MoveStockWareRequestModel, MoveStockWareResponseModel>("pdd.stock.ware.move", moveStockWare);
            return result;
        }
        /// <summary>
        /// 货品关联sku
        /// </summary>
        public async Task<UpdateStockWareSkuResponseModel> UpdateStockWareSkuAsync(UpdateStockWareSkuRequestModel updateStockWareSku)
        {
            var result = await PostAsync<UpdateStockWareSkuRequestModel, UpdateStockWareSkuResponseModel>("pdd.stock.ware.sku.update", updateStockWareSku);
            return result;
        }
        /// <summary>
        /// 编辑货品
        /// </summary>
        public async Task<UpdateStockWareResponseModel> UpdateStockWareAsync(UpdateStockWareRequestModel updateStockWare)
        {
            var result = await PostAsync<UpdateStockWareRequestModel, UpdateStockWareResponseModel>("pdd.stock.ware.update", updateStockWare);
            return result;
        }

    }
}
