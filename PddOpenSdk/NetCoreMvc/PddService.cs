using Microsoft.Extensions.Options;
using PddOpenSdk.Services;

namespace NetCoreMvc
{
    /// <summary>
    /// 批多多服务
    /// </summary>
    public class PddService
    {
        public AuthApi AuthApi { get; set; } = new AuthApi();
        private readonly IOptions<PddOptions> _options;

        public PddService(IOptions<PddOptions> options)
        {
            _options = options;
            PddCommonApi.ClientId = _options.Value.ClientId;
            PddCommonApi.ClientSecret = _options.Value.ClientSecret;
            PddCommonApi.RedirectUri = _options.Value.CallbackUrl;
        }


        public void Test()
        {
    
            System.Console.WriteLine(PddCommonApi.ClientId);

        }
    }
}
