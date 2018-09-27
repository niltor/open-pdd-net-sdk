using Microsoft.Extensions.Options;
using PddOpenSdk.Services;
using PddOpenSdk.Services.PddApi;

namespace PddOpenSdk.AspNetCore
{
    /// <summary>
    /// 批多多服务
    /// </summary>
    public class PddService
    {
        public AuthApi AuthApi { get; set; } = new AuthApi();
        public AdApi AdApi { get; set; } = new AdApi();
        public DdkApi DdkApi { get; set; } = new DdkApi();
        public DdkOauthApi DdkOauthApi { get; set; } = new DdkOauthApi();
        public ErpApi ErpApi { get; set; } = new ErpApi();
        public GoodsApi GoodsApi { get; set; } = new GoodsApi();
        public InvoiceApi InvoiceApi { get; set; } = new InvoiceApi();
        public LogisticsApi LogisticsApi { get; set; } = new LogisticsApi();
        public LogisticsCsApi LogisticsCsApi { get; set; } = new LogisticsCsApi();
        public MallApi MallApi { get; set; } = new MallApi();
        public PromotionApi PromotionApi { get; set; } = new PromotionApi();
        public RefundApi RefundApi { get; set; } = new RefundApi();
        public SmsApi SmsApi { get; set; } = new SmsApi();
        public TimeApi TimeApi { get; set; } = new TimeApi();
        public VirtualApi VirtualApi { get; set; } = new VirtualApi();
        public VoucherApi VoucherApi { get; set; } = new VoucherApi();

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
