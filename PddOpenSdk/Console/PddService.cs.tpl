namespace PddOpenSdk.AspNetCore;
    /// <summary>
    /// 批多多服务
    /// </summary>
    public class PddService
    {
{{$Properties}}

        public ErrorResponse ErrorResponse;
        private readonly PddOptions _options;
        private ILogger<PddService> _logger;
        public static readonly string TokenUrl = "https://open-api.pinduoduo.com/oauth/token";

        public PddService(IOptions<PddOptions> options, ILogger<PddService> logger)
        {
            _options = options.Value;
            _logger = logger;

            {{$Ctor}}
        }

        public PddService(PddOptions options)
        {
            {{$CtorOption}}
        }
        protected void SetToken(string accessToken)
        {
{{$SetToken}}
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

