using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Stock;
using PddOpenSdk.Models.Response.Stock;
namespace PddOpenSdk.Services.PddApi
{
    public class StockApi : PddCommonApi
    {
        /// <summary>
        /// 家电分仓库存-库存信息调整
        /// </summary>
        public async Task<MoveStockWareResponseModel> MoveStockWareAsync(MoveStockWareRequestModel moveStockWare)
        {
            var result = await PostAsync<MoveStockWareRequestModel, MoveStockWareResponseModel>("pdd.stock.ware.move", moveStockWare);
            return result;
        }

    }
}
