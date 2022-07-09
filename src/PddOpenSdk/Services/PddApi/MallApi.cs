
using PddOpenSdk.Models.Request.Mall;
using PddOpenSdk.Models.Response.Mall;

namespace PddOpenSdk.Services.PddApi;
public class MallApi : PddCommonApi
{
    public MallApi() { }
    public MallApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 新增门店组
    /// </summary>
    public async Task<PostMallInfoGroupAddResponse> PostMallInfoGroupAddAsync(PostMallInfoGroupAdd postMallInfoGroupAdd)
    {
        var result = await PostAsync<PostMallInfoGroupAdd, PostMallInfoGroupAddResponse>("pdd.mall.info.group.add.post", postMallInfoGroupAdd);
        return result;
    }

    /// <summary>
    /// 门店组添加门店
    /// </summary>
    public async Task<PostMallInfoGroupAddStoreResponse> PostMallInfoGroupAddStoreAsync(PostMallInfoGroupAddStore postMallInfoGroupAddStore)
    {
        var result = await PostAsync<PostMallInfoGroupAddStore, PostMallInfoGroupAddStoreResponse>("pdd.mall.info.group.add.store.post", postMallInfoGroupAddStore);
        return result;
    }

    /// <summary>
    /// 删除门店组
    /// </summary>
    public async Task<PostMallInfoGroupDeleteResponse> PostMallInfoGroupDeleteAsync(PostMallInfoGroupDelete postMallInfoGroupDelete)
    {
        var result = await PostAsync<PostMallInfoGroupDelete, PostMallInfoGroupDeleteResponse>("pdd.mall.info.group.delete.post", postMallInfoGroupDelete);
        return result;
    }

    /// <summary>
    /// 查询门店组下门店
    /// </summary>
    public async Task<GetMallInfoGroupListStoreResponse> GetMallInfoGroupListStoreAsync(GetMallInfoGroupListStore getMallInfoGroupListStore)
    {
        var result = await PostAsync<GetMallInfoGroupListStore, GetMallInfoGroupListStoreResponse>("pdd.mall.info.group.list.store.get", getMallInfoGroupListStore);
        return result;
    }

    /// <summary>
    /// 查询店铺下门店组列表
    /// </summary>
    public async Task<PostMallInfoGroupQueryResponse> PostMallInfoGroupQueryAsync(PostMallInfoGroupQuery postMallInfoGroupQuery)
    {
        var result = await PostAsync<PostMallInfoGroupQuery, PostMallInfoGroupQueryResponse>("pdd.mall.info.group.query.post", postMallInfoGroupQuery);
        return result;
    }

    /// <summary>
    /// 门店组删除门店
    /// </summary>
    public async Task<GetMallInfoGroupRemoveStoreResponse> GetMallInfoGroupRemoveStoreAsync(GetMallInfoGroupRemoveStore getMallInfoGroupRemoveStore)
    {
        var result = await PostAsync<GetMallInfoGroupRemoveStore, GetMallInfoGroupRemoveStoreResponse>("pdd.mall.info.group.remove.store.get", getMallInfoGroupRemoveStore);
        return result;
    }

    /// <summary>
    /// 编辑门店组
    /// </summary>
    public async Task<PostMallInfoGroupUpdateResponse> PostMallInfoGroupUpdateAsync(PostMallInfoGroupUpdate postMallInfoGroupUpdate)
    {
        var result = await PostAsync<PostMallInfoGroupUpdate, PostMallInfoGroupUpdateResponse>("pdd.mall.info.group.update.post", postMallInfoGroupUpdate);
        return result;
    }

    /// <summary>
    /// 创建店铺门店
    /// </summary>
    public async Task<PostMallInfoStoreCreateResponse> PostMallInfoStoreCreateAsync(PostMallInfoStoreCreate postMallInfoStoreCreate)
    {
        var result = await PostAsync<PostMallInfoStoreCreate, PostMallInfoStoreCreateResponse>("pdd.mall.info.store.create.post", postMallInfoStoreCreate);
        return result;
    }

    /// <summary>
    /// 开放平台无PoiId创建门店
    /// </summary>
    public async Task<NopoiMallInfoStoreCreatePostResponse> NopoiMallInfoStoreCreatePostAsync(NopoiMallInfoStoreCreatePost nopoiMallInfoStoreCreatePost)
    {
        var result = await PostAsync<NopoiMallInfoStoreCreatePost, NopoiMallInfoStoreCreatePostResponse>("pdd.mall.info.store.create.post.nopoi", nopoiMallInfoStoreCreatePost);
        return result;
    }

    /// <summary>
    /// 删除店铺门店
    /// </summary>
    public async Task<PostMallInfoStoreDeleteResponse> PostMallInfoStoreDeleteAsync(PostMallInfoStoreDelete postMallInfoStoreDelete)
    {
        var result = await PostAsync<PostMallInfoStoreDelete, PostMallInfoStoreDeleteResponse>("pdd.mall.info.store.delete.post", postMallInfoStoreDelete);
        return result;
    }

    /// <summary>
    /// 开放平台查询门店信息
    /// </summary>
    public async Task<GetMallInfoStoreResponse> GetMallInfoStoreAsync(GetMallInfoStore getMallInfoStore)
    {
        var result = await PostAsync<GetMallInfoStore, GetMallInfoStoreResponse>("pdd.mall.info.store.get", getMallInfoStore);
        return result;
    }

    /// <summary>
    /// 修改店铺门店
    /// </summary>
    public async Task<PostMallInfoStoreUpdateResponse> PostMallInfoStoreUpdateAsync(PostMallInfoStoreUpdate postMallInfoStoreUpdate)
    {
        var result = await PostAsync<PostMallInfoStoreUpdate, PostMallInfoStoreUpdateResponse>("pdd.mall.info.store.update.post", postMallInfoStoreUpdate);
        return result;
    }

    /// <summary>
    /// 开放平台无PoiId编辑门店
    /// </summary>
    public async Task<NopoiMallInfoStoreUpdatePostResponse> NopoiMallInfoStoreUpdatePostAsync(NopoiMallInfoStoreUpdatePost nopoiMallInfoStoreUpdatePost)
    {
        var result = await PostAsync<NopoiMallInfoStoreUpdatePost, NopoiMallInfoStoreUpdatePostResponse>("pdd.mall.info.store.update.post.nopoi", nopoiMallInfoStoreUpdatePost);
        return result;
    }

    /// <summary>
    /// 交易二维码-参数注册接口
    /// </summary>
    public async Task<RegisterQrpayPayeeResponse> RegisterQrpayPayeeAsync(RegisterQrpayPayee registerQrpayPayee)
    {
        var result = await PostAsync<RegisterQrpayPayee, RegisterQrpayPayeeResponse>("pdd.qrpay.payee.register", registerQrpayPayee);
        return result;
    }

}
