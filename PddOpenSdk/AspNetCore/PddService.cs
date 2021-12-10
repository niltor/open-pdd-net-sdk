namespace PddOpenSdk.AspNetCore;
/// <summary>
/// 批多多服务
/// </summary>
public class PddService
{
    public AuthApi AuthApi { get; }
    /// <summary>
    /// 订单API
    /// </summary>
    public OrderApi OrderApi { get; }
    /// <summary>
    /// 售后API
    /// </summary>
    public RefundApi RefundApi { get; }
    /// <summary>
    /// 物流API
    /// </summary>
    public LogisticsApi LogisticsApi { get; }
    /// <summary>
    /// 虚拟类目API
    /// </summary>
    public VirtualApi VirtualApi { get; }
    /// <summary>
    /// 商品API
    /// </summary>
    public GoodsApi GoodsApi { get; }
    /// <summary>
    /// 多多客API
    /// </summary>
    public DdkApi DdkApi { get; }
    /// <summary>
    /// 多多客工具API
    /// </summary>
    public DdkToolsApi DdkToolsApi { get; }
    /// <summary>
    /// 方舟物流服务商API
    /// </summary>
    public LogisticsCompanyApi LogisticsCompanyApi { get; }
    /// <summary>
    /// 营销API
    /// </summary>
    public PromotionApi PromotionApi { get; }
    /// <summary>
    /// 卡券API
    /// </summary>
    public VoucherApi VoucherApi { get; }
    /// <summary>
    /// 发票服务API
    /// </summary>
    public InvoiceApi InvoiceApi { get; }
    /// <summary>
    /// 店铺API
    /// </summary>
    public MallShopApi MallShopApi { get; }
    /// <summary>
    /// 工具API
    /// </summary>
    public UtilApi UtilApi { get; }
    /// <summary>
    /// 仓储API
    /// </summary>
    public StockApi StockApi { get; }
    /// <summary>
    /// 消息服务API
    /// </summary>
    public PmcApi PmcApi { get; }
    /// <summary>
    /// 电子面单API
    /// </summary>
    public WayBillApi WayBillApi { get; }
    /// <summary>
    /// 财务API
    /// </summary>
    public FinanceApi FinanceApi { get; }
    /// <summary>
    /// 短信服务API
    /// </summary>
    public OpenMsgApi OpenMsgApi { get; }
    /// <summary>
    /// 服务市场API
    /// </summary>
    public ServiceMarketApi ServiceMarketApi { get; }
    /// <summary>
    /// 短信供应商API
    /// </summary>
    public SmsVendorApi SmsVendorApi { get; }
    /// <summary>
    /// 多多推广API
    /// </summary>
    public AdApi AdApi { get; }
    /// <summary>
    /// 电子面单代打API
    /// </summary>
    public FdsApi FdsApi { get; }
    /// <summary>
    /// 门店API
    /// </summary>
    public MallApi MallApi { get; }
    /// <summary>
    /// 多多国际API
    /// </summary>
    public OverseaApi OverseaApi { get; }
    /// <summary>
    /// 方舟旅游门票API
    /// </summary>
    public TicketApi TicketApi { get; }


    public ErrorResponse ErrorResponse;
    private readonly PddOptions _options;
    private ILogger<PddService> _logger;
    public readonly static string TokenUrl = "https://open-api.pinduoduo.com/oauth/token";

    public PddService(IOptions<PddOptions> options, ILogger<PddService> logger)
    {
        _options = options.Value;
        _logger = logger;

        AuthApi = new AuthApi(_options.ClientId, _options.ClientSecret, _options.AccessToken, _options.CallbackUrl);
        OrderApi = new OrderApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        RefundApi = new RefundApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        LogisticsApi = new LogisticsApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        VirtualApi = new VirtualApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        GoodsApi = new GoodsApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        DdkApi = new DdkApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        DdkToolsApi = new DdkToolsApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        LogisticsCompanyApi = new LogisticsCompanyApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        PromotionApi = new PromotionApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        VoucherApi = new VoucherApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        InvoiceApi = new InvoiceApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        MallShopApi = new MallShopApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        UtilApi = new UtilApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        StockApi = new StockApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        PmcApi = new PmcApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        WayBillApi = new WayBillApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        FinanceApi = new FinanceApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        OpenMsgApi = new OpenMsgApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        ServiceMarketApi = new ServiceMarketApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        SmsVendorApi = new SmsVendorApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        AdApi = new AdApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        FdsApi = new FdsApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        MallApi = new MallApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        OverseaApi = new OverseaApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        TicketApi = new TicketApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);

    }

    public PddService(PddOptions options)
    {
        AuthApi = new AuthApi(options.ClientId, options.ClientSecret, options.AccessToken, options.CallbackUrl);
        OrderApi = new OrderApi(options.ClientId, options.ClientSecret, options.AccessToken);
        RefundApi = new RefundApi(options.ClientId, options.ClientSecret, options.AccessToken);
        LogisticsApi = new LogisticsApi(options.ClientId, options.ClientSecret, options.AccessToken);
        VirtualApi = new VirtualApi(options.ClientId, options.ClientSecret, options.AccessToken);
        GoodsApi = new GoodsApi(options.ClientId, options.ClientSecret, options.AccessToken);
        DdkApi = new DdkApi(options.ClientId, options.ClientSecret, options.AccessToken);
        DdkToolsApi = new DdkToolsApi(options.ClientId, options.ClientSecret, options.AccessToken);
        LogisticsCompanyApi = new LogisticsCompanyApi(options.ClientId, options.ClientSecret, options.AccessToken);
        PromotionApi = new PromotionApi(options.ClientId, options.ClientSecret, options.AccessToken);
        VoucherApi = new VoucherApi(options.ClientId, options.ClientSecret, options.AccessToken);
        InvoiceApi = new InvoiceApi(options.ClientId, options.ClientSecret, options.AccessToken);
        MallShopApi = new MallShopApi(options.ClientId, options.ClientSecret, options.AccessToken);
        UtilApi = new UtilApi(options.ClientId, options.ClientSecret, options.AccessToken);
        StockApi = new StockApi(options.ClientId, options.ClientSecret, options.AccessToken);
        PmcApi = new PmcApi(options.ClientId, options.ClientSecret, options.AccessToken);
        WayBillApi = new WayBillApi(options.ClientId, options.ClientSecret, options.AccessToken);
        FinanceApi = new FinanceApi(options.ClientId, options.ClientSecret, options.AccessToken);
        OpenMsgApi = new OpenMsgApi(options.ClientId, options.ClientSecret, options.AccessToken);
        ServiceMarketApi = new ServiceMarketApi(options.ClientId, options.ClientSecret, options.AccessToken);
        SmsVendorApi = new SmsVendorApi(options.ClientId, options.ClientSecret, options.AccessToken);
        AdApi = new AdApi(options.ClientId, options.ClientSecret, options.AccessToken);
        FdsApi = new FdsApi(options.ClientId, options.ClientSecret, options.AccessToken);
        MallApi = new MallApi(options.ClientId, options.ClientSecret, options.AccessToken);
        OverseaApi = new OverseaApi(options.ClientId, options.ClientSecret, options.AccessToken);
        TicketApi = new TicketApi(options.ClientId, options.ClientSecret, options.AccessToken);

    }
    protected void SetToken(string accessToken)
    {
        OrderApi.AccessToken = accessToken;
        RefundApi.AccessToken = accessToken;
        LogisticsApi.AccessToken = accessToken;
        VirtualApi.AccessToken = accessToken;
        GoodsApi.AccessToken = accessToken;
        DdkApi.AccessToken = accessToken;
        DdkToolsApi.AccessToken = accessToken;
        LogisticsCompanyApi.AccessToken = accessToken;
        PromotionApi.AccessToken = accessToken;
        VoucherApi.AccessToken = accessToken;
        InvoiceApi.AccessToken = accessToken;
        MallShopApi.AccessToken = accessToken;
        UtilApi.AccessToken = accessToken;
        StockApi.AccessToken = accessToken;
        PmcApi.AccessToken = accessToken;
        WayBillApi.AccessToken = accessToken;
        FinanceApi.AccessToken = accessToken;
        OpenMsgApi.AccessToken = accessToken;
        ServiceMarketApi.AccessToken = accessToken;
        SmsVendorApi.AccessToken = accessToken;
        AdApi.AccessToken = accessToken;
        FdsApi.AccessToken = accessToken;
        MallApi.AccessToken = accessToken;
        OverseaApi.AccessToken = accessToken;
        TicketApi.AccessToken = accessToken;

    }

    public async Task<AccessTokenResponseModel> GetAccessTokenAsync(string code, string state = null)
    {
        if (code != null)
        {
            // TODO 先读取未过期token，若已过期，则刷新或重新获取
            var dic = new Dictionary<string, string>
                {
                    { "client_id", _options.ClientId },
                    { "client_secret", _options.ClientSecret },
                    { "grant_type", "authorization_code" },
                    { "code", code },
                    { "redirect_uri", _options.CallbackUrl}
                };
            if (state != null)
            {
                dic.Add("state", state);
            }

            var data = new StringContent(JsonSerializer.Serialize(dic), Encoding.UTF8, "application/json");
            try
            {
                using (var hc = new HttpClient())
                {
                    var response = await hc.PostAsync(TokenUrl, data);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();
                        var jObject = JsonDocument.Parse(jsonString);
                        if (jObject.RootElement.TryGetProperty("error_response", out var errorResponse))
                        {
                            ErrorResponse = JsonSerializer.Deserialize<ErrorResponse>(jsonString);
                            _logger.LogError("错误信息:" + errorResponse.ToString());
                            return default;
                        }
                        else
                        {
                            var result = JsonSerializer.Deserialize<AccessTokenResponseModel>(jsonString);
                            SetToken(result.AccessToken);
                            return result;
                        }
                    }
                    else
                    {
                        _logger.LogError(await response.Content.ReadAsStringAsync());
                    }
                }
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex.Message);
            }

        }
        return default;
    }
    public async Task<AccessTokenResponseModel> GetRefreshTokenAsync(string refresh_token, string state = null)
    {
        if (refresh_token != null)
        {
            // TODO 先读取未过期token，若已过期，则刷新或重新获取
            var dic = new Dictionary<string, string>
                {
                    { "client_id", _options.ClientId },
                    { "client_secret", _options.ClientSecret },
                    { "grant_type", "refresh_token" },
                    { "refresh_token", refresh_token }
                };
            if (state != null)
            {
                dic.Add("state", state);
            }

            var data = new StringContent(JsonSerializer.Serialize(dic), Encoding.UTF8, "application/json");
            using (var hc = new HttpClient())
            {
                var response = await hc.PostAsync(TokenUrl, data);
                string jsonString = await response.Content.ReadAsStringAsync();
                System.Console.WriteLine(jsonString);
                var result = JsonSerializer.Deserialize<AccessTokenResponseModel>(jsonString);

                SetToken(result.AccessToken);
                return result;
            }
        }
        return default;
    }
}

