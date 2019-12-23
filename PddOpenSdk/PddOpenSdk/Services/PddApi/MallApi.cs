using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Mall;
using PddOpenSdk.Models.Response.Mall;
namespace PddOpenSdk.Services.PddApi
{
    public class MallApi : PddCommonApi
    {
        /// <summary>
        /// 查询店铺是否签署多多进宝协议接口
        /// </summary>
        public async Task<QueryMallCpsProtocolStatusResponseModel> QueryMallCpsProtocolStatusAsync(QueryMallCpsProtocolStatusRequestModel queryMallCpsProtocolStatus)
        {
            var result = await PostAsync<QueryMallCpsProtocolStatusRequestModel, QueryMallCpsProtocolStatusResponseModel>("pdd.mall.cps.protocol.status.query", queryMallCpsProtocolStatus);
            return result;
        }
        /// <summary>
        /// 保税仓信息查询接口
        /// </summary>
        public async Task<GetMallInfoBondedWarehouseResponseModel> GetMallInfoBondedWarehouseAsync(GetMallInfoBondedWarehouseRequestModel getMallInfoBondedWarehouse)
        {
            var result = await PostAsync<GetMallInfoBondedWarehouseRequestModel, GetMallInfoBondedWarehouseResponseModel>("pdd.mall.info.bonded.warehouse.get", getMallInfoBondedWarehouse);
            return result;
        }
        /// <summary>
        /// 店铺信息接口
        /// </summary>
        public async Task<GetMallInfoResponseModel> GetMallInfoAsync(GetMallInfoRequestModel getMallInfo)
        {
            var result = await PostAsync<GetMallInfoRequestModel, GetMallInfoResponseModel>("pdd.mall.info.get", getMallInfo);
            return result;
        }
        /// <summary>
        /// 门店组添加门店
        /// </summary>
        public async Task<PostMallInfoGroupAddStoreResponseModel> PostMallInfoGroupAddStoreAsync(PostMallInfoGroupAddStoreRequestModel postMallInfoGroupAddStore)
        {
            var result = await PostAsync<PostMallInfoGroupAddStoreRequestModel, PostMallInfoGroupAddStoreResponseModel>("pdd.mall.info.group.add.store.post", postMallInfoGroupAddStore);
            return result;
        }
        /// <summary>
        /// 查询门店组下门店
        /// </summary>
        public async Task<GetMallInfoGroupListStoreResponseModel> GetMallInfoGroupListStoreAsync(GetMallInfoGroupListStoreRequestModel getMallInfoGroupListStore)
        {
            var result = await PostAsync<GetMallInfoGroupListStoreRequestModel, GetMallInfoGroupListStoreResponseModel>("pdd.mall.info.group.list.store.get", getMallInfoGroupListStore);
            return result;
        }
        /// <summary>
        /// 门店组删除门店
        /// </summary>
        public async Task<GetMallInfoGroupRemoveStoreResponseModel> GetMallInfoGroupRemoveStoreAsync(GetMallInfoGroupRemoveStoreRequestModel getMallInfoGroupRemoveStore)
        {
            var result = await PostAsync<GetMallInfoGroupRemoveStoreRequestModel, GetMallInfoGroupRemoveStoreResponseModel>("pdd.mall.info.group.remove.store.get", getMallInfoGroupRemoveStore);
            return result;
        }
        /// <summary>
        /// 创建店铺门店
        /// </summary>
        public async Task<PostMallInfoStoreCreateResponseModel> PostMallInfoStoreCreateAsync(PostMallInfoStoreCreateRequestModel postMallInfoStoreCreate)
        {
            var result = await PostAsync<PostMallInfoStoreCreateRequestModel, PostMallInfoStoreCreateResponseModel>("pdd.mall.info.store.create.post", postMallInfoStoreCreate);
            return result;
        }
        /// <summary>
        /// 删除店铺门店
        /// </summary>
        public async Task<PostMallInfoStoreDeleteResponseModel> PostMallInfoStoreDeleteAsync(PostMallInfoStoreDeleteRequestModel postMallInfoStoreDelete)
        {
            var result = await PostAsync<PostMallInfoStoreDeleteRequestModel, PostMallInfoStoreDeleteResponseModel>("pdd.mall.info.store.delete.post", postMallInfoStoreDelete);
            return result;
        }
        /// <summary>
        /// 修改店铺门店
        /// </summary>
        public async Task<PostMallInfoStoreUpdateResponseModel> PostMallInfoStoreUpdateAsync(PostMallInfoStoreUpdateRequestModel postMallInfoStoreUpdate)
        {
            var result = await PostAsync<PostMallInfoStoreUpdateRequestModel, PostMallInfoStoreUpdateResponseModel>("pdd.mall.info.store.update.post", postMallInfoStoreUpdate);
            return result;
        }
        /// <summary>
        /// 交易二维码-参数注册接口
        /// </summary>
        public async Task<RegisterQrpayPayeeResponseModel> RegisterQrpayPayeeAsync(RegisterQrpayPayeeRequestModel registerQrpayPayee)
        {
            var result = await PostAsync<RegisterQrpayPayeeRequestModel, RegisterQrpayPayeeResponseModel>("pdd.qrpay.payee.register", registerQrpayPayee);
            return result;
        }

    }
}
