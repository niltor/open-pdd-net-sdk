
using PddOpenSdk.Models.Request.Mall;
using PddOpenSdk.Models.Response.Mall;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApi
{
    public class MallApi : PddCommonApi
    {
        public MallApi() { }
        public MallApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }
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
        /// 开放平台无PoiId创建门店
        /// </summary>
        public async Task<NopoiMallInfoStoreCreatePostResponseModel> NopoiMallInfoStoreCreatePostAsync(NopoiMallInfoStoreCreatePostRequestModel nopoiMallInfoStoreCreatePost)
        {
            var result = await PostAsync<NopoiMallInfoStoreCreatePostRequestModel, NopoiMallInfoStoreCreatePostResponseModel>("pdd.mall.info.store.create.post.nopoi", nopoiMallInfoStoreCreatePost);
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
        /// 开放平台查询门店信息
        /// </summary>
        public async Task<GetMallInfoStoreResponseModel> GetMallInfoStoreAsync(GetMallInfoStoreRequestModel getMallInfoStore)
        {
            var result = await PostAsync<GetMallInfoStoreRequestModel, GetMallInfoStoreResponseModel>("pdd.mall.info.store.get", getMallInfoStore);
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
        /// 开放平台无PoiId编辑门店
        /// </summary>
        public async Task<NopoiMallInfoStoreUpdatePostResponseModel> NopoiMallInfoStoreUpdatePostAsync(NopoiMallInfoStoreUpdatePostRequestModel nopoiMallInfoStoreUpdatePost)
        {
            var result = await PostAsync<NopoiMallInfoStoreUpdatePostRequestModel, NopoiMallInfoStoreUpdatePostResponseModel>("pdd.mall.info.store.update.post.nopoi", nopoiMallInfoStoreUpdatePost);
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
