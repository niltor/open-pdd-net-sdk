using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PddOpenSdk.Models;
using PddOpenSdk.Services;
using PddOpenSdk.Services.PddApi;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PddOpenSdk.AspNetCore
{
    /// <summary>
    /// 批多多服务
    /// </summary>
    public class PddService
    {
        /// <summary>
        /// 授权验证
        /// </summary>
        public AuthApi AuthApi { get; }
        /// <summary>
        /// 推广API
        /// </summary>
        public AdApi AdApi { get; }
        /// <summary>
        /// 多多客户API
        /// </summary>
        public DdkApi DdkApi { get; }
        /// <summary>
        /// 多多客户工具API
        /// </summary>
        public DdkToolsApi DdkOauthApi { get; }
        /// <summary>
        /// 订单API
        /// </summary>
        public OrderApi ErpApi { get; }
        /// <summary>
        /// 订单API
        /// </summary>
        public OrderApi OrderApi { get; }
        /// <summary>
        /// 商品API
        /// </summary>
        public GoodsApi GoodsApi { get; }
        /// <summary>
        /// 发票API
        /// </summary>
        public InvoiceApi InvoiceApi { get; }
        /// <summary>
        /// 物流API
        /// </summary>
        public LogisticsApi LogisticsApi { get; }
        /// <summary>
        /// 物流商API
        /// </summary>
        public LogisticsCompanyApi LogisticsCsApi { get; }
        /// <summary>
        /// 店铺API
        /// </summary>
        public MallApi MallApi { get; }
        /// <summary>
        /// 营销API
        /// </summary>
        public PromotionApi PromotionApi { get; }
        /// <summary>
        /// 售后API
        /// </summary>
        public RefundApi RefundApi { get; }
        /// <summary>
        /// 工具API
        /// </summary>
        public UtilApi UtilApi { get; }
        /// <summary>
        /// 虚拟类目API
        /// </summary>
        public VirtualApi VirtualApi { get; }
        /// <summary>
        /// 卡券API
        /// </summary>
        public VoucherApi VoucherApi { get; }
        /// <summary>
        /// 仓储API
        /// </summary>
        public StockApi StockApi { get; }
        /// <summary>
        /// 消息服务
        /// </summary>
        public PmcApi PmcApi { get; }
        /// <summary>
        /// 财务API
        /// </summary>
        public FinanceApi FinanceApi { get; }
        /// <summary>
        /// 开平短信
        /// </summary>
        public OpenMsgApi OpenApi { get; }
        /// <summary>
        /// 电子面单API
        /// </summary>
        public WayBillApi WaybillApi { get; }
        /// <summary>
        /// 服务市场API
        /// </summary>
        public ServiceMarketApi ServiceMarketApi { get; }
        /// <summary>
        /// 短信供应商API
        /// </summary>
        public SmsVendorApi SmsVendorApi { get; }

        public ErrorResponse ErrorResponse;
        private readonly PddOptions _options;
        private ILogger<PddService> _logger;
        public static readonly string TokenUrl = "https://open-api.pinduoduo.com/oauth/token";

        public PddService(IOptions<PddOptions> options, ILogger<PddService> logger)
        {
            _options = options.Value;
            _logger = logger;

            AuthApi = new AuthApi(_options.ClientId, _options.ClientSecret, _options.AccessToken, _options.CallbackUrl);
            SmsVendorApi = new SmsVendorApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
            AdApi = new AdApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
            DdkApi = new DdkApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
            OrderApi = new OrderApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
            GoodsApi = new GoodsApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
            InvoiceApi = new InvoiceApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
            LogisticsApi = new LogisticsApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
            MallApi = new MallApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
            PromotionApi = new PromotionApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
            RefundApi = new RefundApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
            UtilApi = new UtilApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
            VirtualApi = new VirtualApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
            VoucherApi = new VoucherApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
            StockApi = new StockApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
            PmcApi = new PmcApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
            FinanceApi = new FinanceApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
            ServiceMarketApi = new ServiceMarketApi(_options.ClientId, _options.ClientSecret, _options.AccessToken);
        }

        public PddService(PddOptions options)
        {
            AuthApi = new AuthApi(options.ClientId, options.ClientSecret, options.AccessToken, options.CallbackUrl);
            SmsVendorApi = new SmsVendorApi(options.ClientId, options.ClientSecret, options.AccessToken);
            AdApi = new AdApi(options.ClientId, options.ClientSecret, options.AccessToken);
            DdkApi = new DdkApi(options.ClientId, options.ClientSecret, options.AccessToken);
            OrderApi = new OrderApi(options.ClientId, options.ClientSecret, options.AccessToken);
            GoodsApi = new GoodsApi(options.ClientId, options.ClientSecret, options.AccessToken);
            InvoiceApi = new InvoiceApi(options.ClientId, options.ClientSecret, options.AccessToken);
            LogisticsApi = new LogisticsApi(options.ClientId, options.ClientSecret, options.AccessToken);
            MallApi = new MallApi(options.ClientId, options.ClientSecret, options.AccessToken);
            PromotionApi = new PromotionApi(options.ClientId, options.ClientSecret, options.AccessToken);
            RefundApi = new RefundApi(options.ClientId, options.ClientSecret, options.AccessToken);
            UtilApi = new UtilApi(options.ClientId, options.ClientSecret, options.AccessToken);
            VirtualApi = new VirtualApi(options.ClientId, options.ClientSecret, options.AccessToken);
            VoucherApi = new VoucherApi(options.ClientId, options.ClientSecret, options.AccessToken);
            StockApi = new StockApi(options.ClientId, options.ClientSecret, options.AccessToken);
            PmcApi = new PmcApi(options.ClientId, options.ClientSecret, options.AccessToken);
            FinanceApi = new FinanceApi(options.ClientId, options.ClientSecret, options.AccessToken);
            ServiceMarketApi = new ServiceMarketApi(options.ClientId, options.ClientSecret, options.AccessToken);
        }
        protected void SetToken(string accessToken)
        {
            SmsVendorApi.AccessToken = accessToken;
            AdApi.AccessToken = accessToken;
            DdkApi.AccessToken = accessToken;
            OrderApi.AccessToken = accessToken;
            GoodsApi.AccessToken = accessToken;
            InvoiceApi.AccessToken = accessToken;
            LogisticsApi.AccessToken = accessToken;
            MallApi.AccessToken = accessToken;
            PromotionApi.AccessToken = accessToken;
            RefundApi.AccessToken = accessToken;
            UtilApi.AccessToken = accessToken;
            VirtualApi.AccessToken = accessToken;
            VoucherApi.AccessToken = accessToken;
            StockApi.AccessToken = accessToken;
            PmcApi.AccessToken = accessToken;
            FinanceApi.AccessToken = accessToken;
            ServiceMarketApi.AccessToken = accessToken;
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

                var data = new StringContent(JsonConvert.SerializeObject(dic), Encoding.UTF8, "application/json");
                try
                {
                    using (var hc = new HttpClient())
                    {
                        var response = await hc.PostAsync(TokenUrl, data);

                        if (response.IsSuccessStatusCode)
                        {
                            string jsonString = await response.Content.ReadAsStringAsync();
                            var jObject = JObject.Parse(jsonString);
                            if (jObject.TryGetValue("error_response", out var errorResponse))
                            {
                                ErrorResponse = JsonConvert.DeserializeObject<ErrorResponse>(jsonString);
                                _logger.LogError("错误信息:" + errorResponse.ToString());
                                return default;
                            }
                            else
                            {
                                var result = JsonConvert.DeserializeObject<AccessTokenResponseModel>(jsonString);
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

                var data = new StringContent(JsonConvert.SerializeObject(dic), Encoding.UTF8, "application/json");
                using (var hc = new HttpClient())
                {
                    var response = await hc.PostAsync(TokenUrl, data);
                    string jsonString = await response.Content.ReadAsStringAsync();
                    System.Console.WriteLine(jsonString);
                    var result = JsonConvert.DeserializeObject<AccessTokenResponseModel>(jsonString);

                    SetToken(result.AccessToken);
                    return result;
                }
            }
            return default;
        }
    }
}
