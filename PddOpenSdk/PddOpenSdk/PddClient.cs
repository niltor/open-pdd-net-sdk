using PddOpenSdk.Services.PddApi;

namespace MSDev.PddOpenSdk;
/// <summary>
/// 批多多服务
/// </summary>
public class PddClient
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
    public ClientConfig Config { get; set; }
    public readonly static string TokenUrl = "https://open-api.pinduoduo.com/oauth/token";

    public PddClient(ClientConfig config)
    {
        Config = config;
        AuthApi = new AuthApi(config.ClientId, config.ClientSecret, config.AccessToken, config.CallbackUrl);
        OrderApi = new OrderApi(config.ClientId, config.ClientSecret, config.AccessToken);
        RefundApi = new RefundApi(config.ClientId, config.ClientSecret, config.AccessToken);
        LogisticsApi = new LogisticsApi(config.ClientId, config.ClientSecret, config.AccessToken);
        VirtualApi = new VirtualApi(config.ClientId, config.ClientSecret, config.AccessToken);
        GoodsApi = new GoodsApi(config.ClientId, config.ClientSecret, config.AccessToken);
        DdkApi = new DdkApi(config.ClientId, config.ClientSecret, config.AccessToken);
        DdkToolsApi = new DdkToolsApi(config.ClientId, config.ClientSecret, config.AccessToken);
        LogisticsCompanyApi = new LogisticsCompanyApi(config.ClientId, config.ClientSecret, config.AccessToken);
        PromotionApi = new PromotionApi(config.ClientId, config.ClientSecret, config.AccessToken);
        VoucherApi = new VoucherApi(config.ClientId, config.ClientSecret, config.AccessToken);
        InvoiceApi = new InvoiceApi(config.ClientId, config.ClientSecret, config.AccessToken);
        MallShopApi = new MallShopApi(config.ClientId, config.ClientSecret, config.AccessToken);
        UtilApi = new UtilApi(config.ClientId, config.ClientSecret, config.AccessToken);
        StockApi = new StockApi(config.ClientId, config.ClientSecret, config.AccessToken);
        PmcApi = new PmcApi(config.ClientId, config.ClientSecret, config.AccessToken);
        WayBillApi = new WayBillApi(config.ClientId, config.ClientSecret, config.AccessToken);
        FinanceApi = new FinanceApi(config.ClientId, config.ClientSecret, config.AccessToken);
        OpenMsgApi = new OpenMsgApi(config.ClientId, config.ClientSecret, config.AccessToken);
        ServiceMarketApi = new ServiceMarketApi(config.ClientId, config.ClientSecret, config.AccessToken);
        SmsVendorApi = new SmsVendorApi(config.ClientId, config.ClientSecret, config.AccessToken);
        AdApi = new AdApi(config.ClientId, config.ClientSecret, config.AccessToken);
        FdsApi = new FdsApi(config.ClientId, config.ClientSecret, config.AccessToken);
        MallApi = new MallApi(config.ClientId, config.ClientSecret, config.AccessToken);
        OverseaApi = new OverseaApi(config.ClientId, config.ClientSecret, config.AccessToken);
        TicketApi = new TicketApi(config.ClientId, config.ClientSecret, config.AccessToken);

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
                    { "client_id", Config.ClientId },
                    { "client_secret", Config.ClientSecret },
                    { "grant_type", "authorization_code" },
                    { "code", code },
                    { "redirect_uri", Config.CallbackUrl}
                };
            if (state != null)
            {
                dic.Add("state", state);
            }

            var data = new StringContent(JsonSerializer.Serialize(dic), Encoding.UTF8, "application/json");
            try
            {
                using var hc = new HttpClient();
                var response = await hc.PostAsync(TokenUrl, data);

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var jObject = JsonDocument.Parse(jsonString);
                    if (jObject.RootElement.TryGetProperty("error_response", out var errorResponse))
                    {
                        ErrorResponse = JsonSerializer.Deserialize<PddErrorResponseModel>(jsonString).ErrorResponse;
                        return default;
                    }
                    else
                    {
                        var result = JsonSerializer.Deserialize<AccessTokenResponseModel>(jsonString);
                        Console.WriteLine(result.AccessToken);
                        SetToken(result.AccessToken);
                        return result;
                    }
                }
                else
                {
                    Console.WriteLine(await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                    { "client_id", Config.ClientId },
                    { "client_secret", Config.ClientSecret },
                    { "grant_type", "refresh_token" },
                    { "refresh_token", refresh_token }
                };
            if (state != null)
            {
                dic.Add("state", state);
            }

            var data = new StringContent(JsonSerializer.Serialize(dic), Encoding.UTF8, "application/json");
            using var hc = new HttpClient();
            var response = await hc.PostAsync(TokenUrl, data);
            var jsonString = await response.Content.ReadAsStringAsync();
            Console.WriteLine(jsonString);
            var result = JsonSerializer.Deserialize<AccessTokenResponseModel>(jsonString);

            SetToken(result.AccessToken);
            return result;
        }
        return default;
    }
}

