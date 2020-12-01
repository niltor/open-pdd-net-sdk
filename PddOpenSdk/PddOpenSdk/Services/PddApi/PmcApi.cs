
using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Pmc;
using PddOpenSdk.Models.Response.Pmc;
namespace PddOpenSdk.Services.PddApi
{
    public class PmcApi : PddCommonApi
    {
        public PmcApi() { }
        public PmcApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }
        /// <summary>
        /// 消息队列积压数量查询
        /// </summary>
        public async Task<QueryPmcAccrueResponseModel> QueryPmcAccrueAsync(QueryPmcAccrueRequestModel queryPmcAccrue)
        {
            var result = await PostAsync<QueryPmcAccrueRequestModel, QueryPmcAccrueResponseModel>("pdd.pmc.accrue.query", queryPmcAccrue);
            return result;
        }
        /// <summary>
        /// 取消用户的消息服务
        /// </summary>
        public async Task<CancelPmcUserResponseModel> CancelPmcUserAsync(CancelPmcUserRequestModel cancelPmcUser)
        {
            var result = await PostAsync<CancelPmcUserRequestModel, CancelPmcUserResponseModel>("pdd.pmc.user.cancel", cancelPmcUser);
            return result;
        }
        /// <summary>
        /// 获取用户已开通消息
        /// </summary>
        public async Task<GetPmcUserResponseModel> GetPmcUserAsync(GetPmcUserRequestModel getPmcUser)
        {
            var result = await PostAsync<GetPmcUserRequestModel, GetPmcUserResponseModel>("pdd.pmc.user.get", getPmcUser);
            return result;
        }
        /// <summary>
        /// 为已授权的用户开通消息服务
        /// </summary>
        public async Task<PermitPmcUserResponseModel> PermitPmcUserAsync(PermitPmcUserRequestModel permitPmcUser)
        {
            var result = await PostAsync<PermitPmcUserRequestModel, PermitPmcUserResponseModel>("pdd.pmc.user.permit", permitPmcUser);
            return result;
        }

    }
}
