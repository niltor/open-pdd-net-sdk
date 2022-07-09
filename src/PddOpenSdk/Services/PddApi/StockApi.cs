
using PddOpenSdk.Models.Request.Stock;
using PddOpenSdk.Models.Response.Stock;

namespace PddOpenSdk.Services.PddApi;
public class StockApi : PddCommonApi
{
    public StockApi() { }
    public StockApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 增加仓库
    /// </summary>
    public async Task<DepotExpressAddResponse> DepotExpressAddAsync(DepotExpressAdd depotExpressAdd)
    {
        var result = await PostAsync<DepotExpressAdd, DepotExpressAddResponse>("pdd.express.add.depot", depotExpressAdd);
        return result;
    }

    /// <summary>
    /// 修改仓库信息
    /// </summary>
    public async Task<InfoExpressChangeDepotResponse> InfoExpressChangeDepotAsync(InfoExpressChangeDepot infoExpressChangeDepot)
    {
        var result = await PostAsync<InfoExpressChangeDepot, InfoExpressChangeDepotResponse>("pdd.express.change.depot.info", infoExpressChangeDepot);
        return result;
    }

    /// <summary>
    /// 仓库详细信息
    /// </summary>
    public async Task<GetExpressDepotInfoResponse> GetExpressDepotInfoAsync(GetExpressDepotInfo getExpressDepotInfo)
    {
        var result = await PostAsync<GetExpressDepotInfo, GetExpressDepotInfoResponse>("pdd.express.depot.info.get", getExpressDepotInfo);
        return result;
    }

    /// <summary>
    /// 仓库列表
    /// </summary>
    public async Task<GetExpressDepotListResponse> GetExpressDepotListAsync(GetExpressDepotList getExpressDepotList)
    {
        var result = await PostAsync<GetExpressDepotList, GetExpressDepotListResponse>("pdd.express.depot.list.get", getExpressDepotList);
        return result;
    }

    /// <summary>
    /// 商家全部仓库的简要信息列表
    /// </summary>
    public async Task<GetExpressMallDepotSimpleResponse> GetExpressMallDepotSimpleAsync(GetExpressMallDepotSimple getExpressMallDepotSimple)
    {
        var result = await PostAsync<GetExpressMallDepotSimple, GetExpressMallDepotSimpleResponse>("pdd.express.mall.depot.simple.get", getExpressMallDepotSimple);
        return result;
    }

    /// <summary>
    /// 根据仓库名称和仓库编码查询仓库
    /// </summary>
    public async Task<DepotExpressSearchResponse> DepotExpressSearchAsync(DepotExpressSearch depotExpressSearch)
    {
        var result = await PostAsync<DepotExpressSearch, DepotExpressSearchResponse>("pdd.express.search.depot", depotExpressSearch);
        return result;
    }

    /// <summary>
    /// 仓库优先级列表
    /// </summary>
    public async Task<ListStockDepotPriorityResponse> ListStockDepotPriorityAsync(ListStockDepotPriority listStockDepotPriority)
    {
        var result = await PostAsync<ListStockDepotPriority, ListStockDepotPriorityResponse>("pdd.stock.depot.priority.list", listStockDepotPriority);
        return result;
    }

    /// <summary>
    /// 批量更新仓库优先级
    /// </summary>
    public async Task<UpdateStockDepotPriorityResponse> UpdateStockDepotPriorityAsync(UpdateStockDepotPriority updateStockDepotPriority)
    {
        var result = await PostAsync<UpdateStockDepotPriority, UpdateStockDepotPriorityResponse>("pdd.stock.depot.priority.update", updateStockDepotPriority);
        return result;
    }

    /// <summary>
    /// 根据商品id查询sku信息
    /// </summary>
    public async Task<QueryStockGoodsIdToSkuResponse> QueryStockGoodsIdToSkuAsync(QueryStockGoodsIdToSku queryStockGoodsIdToSku)
    {
        var result = await PostAsync<QueryStockGoodsIdToSku, QueryStockGoodsIdToSkuResponse>("pdd.stock.goods.id.to.sku.query", queryStockGoodsIdToSku);
        return result;
    }

    /// <summary>
    /// 创建货品
    /// </summary>
    public async Task<CreateStockWareResponse> CreateStockWareAsync(CreateStockWare createStockWare)
    {
        var result = await PostAsync<CreateStockWare, CreateStockWareResponse>("pdd.stock.ware.create", createStockWare);
        return result;
    }

    /// <summary>
    /// 删除货品
    /// </summary>
    public async Task<DeleteStockWareResponse> DeleteStockWareAsync(DeleteStockWare deleteStockWare)
    {
        var result = await PostAsync<DeleteStockWare, DeleteStockWareResponse>("pdd.stock.ware.delete", deleteStockWare);
        return result;
    }

    /// <summary>
    /// 查询货品详情
    /// </summary>
    public async Task<QueryStockWareDetailResponse> QueryStockWareDetailAsync(QueryStockWareDetail queryStockWareDetail)
    {
        var result = await PostAsync<QueryStockWareDetail, QueryStockWareDetailResponse>("pdd.stock.ware.detail.query", queryStockWareDetail);
        return result;
    }

    /// <summary>
    /// 货品列表的查询接口
    /// </summary>
    public async Task<ListStockWareInfoResponse> ListStockWareInfoAsync(ListStockWareInfo listStockWareInfo)
    {
        var result = await PostAsync<ListStockWareInfo, ListStockWareInfoResponse>("pdd.stock.ware.info.list", listStockWareInfo);
        return result;
    }

    /// <summary>
    /// 查询货品列表
    /// </summary>
    public async Task<ListStockWareResponse> ListStockWareAsync(ListStockWare listStockWare)
    {
        var result = await PostAsync<ListStockWare, ListStockWareResponse>("pdd.stock.ware.list", listStockWare);
        return result;
    }

    /// <summary>
    /// 家电分仓库存-库存信息调整
    /// </summary>
    public async Task<MoveStockWareResponse> MoveStockWareAsync(MoveStockWare moveStockWare)
    {
        var result = await PostAsync<MoveStockWare, MoveStockWareResponse>("pdd.stock.ware.move", moveStockWare);
        return result;
    }

    /// <summary>
    /// 货品关联sku
    /// </summary>
    public async Task<UpdateStockWareSkuResponse> UpdateStockWareSkuAsync(UpdateStockWareSku updateStockWareSku)
    {
        var result = await PostAsync<UpdateStockWareSku, UpdateStockWareSkuResponse>("pdd.stock.ware.sku.update", updateStockWareSku);
        return result;
    }

    /// <summary>
    /// 编辑货品
    /// </summary>
    public async Task<UpdateStockWareResponse> UpdateStockWareAsync(UpdateStockWare updateStockWare)
    {
        var result = await PostAsync<UpdateStockWare, UpdateStockWareResponse>("pdd.stock.ware.update", updateStockWare);
        return result;
    }

    /// <summary>
    /// 货品仓库库存信息查询
    /// </summary>
    public async Task<QueryStockWareWarehouseResponse> QueryStockWareWarehouseAsync(QueryStockWareWarehouse queryStockWareWarehouse)
    {
        var result = await PostAsync<QueryStockWareWarehouse, QueryStockWareWarehouseResponse>("pdd.stock.ware.warehouse.query", queryStockWareWarehouse);
        return result;
    }

}
