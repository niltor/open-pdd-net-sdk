using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Pmc;
using PddOpenSdk.Models.Response.Pmc;
namespace PddOpenSdk.Services.PddApi
{
    public class PmcApi : PddCommonApi
    {
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
