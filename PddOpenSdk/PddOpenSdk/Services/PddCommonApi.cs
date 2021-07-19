using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PddOpenSdk.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PddOpenSdk.Services
{
    /// <summary>
    /// 拼多多请求
    /// </summary>
    public class PddCommonApi
    {
        /// <summary>
        /// 请求接口
        /// </summary>
        private static readonly string ApiUrl = "http://gw-api.pinduoduo.com/api/router";

        public string AccessToken { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string RedirectUri { get; set; }
        public string Ace { get; set; }
        protected static HttpClient client = new HttpClient() { Timeout = TimeSpan.FromSeconds(10) };

        public ErrorResponse ErrorResponse;

        public PddCommonApi()
        {
        }
        public PddCommonApi(string clientId, string clientSecret, string accessToken)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            AccessToken = accessToken;
        }
        public async Task<TResult> PostFileAsync<TModel, TResult>(string type, TModel model)
        {
            // 类型转换到字典
            var dic = Function.ToDictionary(model);
            var filePath = dic.Where(d => d.Key == "file_path")
                .Select(s => s.Value)
                .FirstOrDefault()?.ToString();

            if (!File.Exists(filePath))
            {
                return default;
            }

            // 添加公共参数
            dic.Add("client_id", ClientId);
            dic.Add("data_type", "JSON");
            if (string.IsNullOrEmpty(AccessToken))
            {
                Console.WriteLine("当前请求未设置AccessToken");
            }
            else
            {
                dic.Add("access_token", AccessToken);
            }
            dic.Add("timestamp", DateTimeOffset.Now.ToUnixTimeSeconds());
            if (dic.Keys.Any(k => k == "type"))
            {
                dic.Remove("type");
            }
            if (dic.Keys.Any(k => k == "file_path"))
            {
                dic.Remove("file_path");
            }
            dic.Add("type", type);
            // 添加签名
            var paramsDic = BuildSign(dic);
            var data = paramsDic.ToDictionary(s => s.Key, s => s.Value.ToString());
            using var content = new MultipartFormDataContent("------WebKitFormBoundaryxIAL5jDsXOFEIKEN");

            var streamContent = new StreamContent(new FileStream(filePath, FileMode.Open));
            content.Add(streamContent, "file", "upload.jpg");
            foreach (var item in data)
            {
                content.Add(new StringContent(item.Value), item.Key);
            }
            using var client = new HttpClient();
            try
            {
                var response = await client.PostAsync("https://gw-upload.pinduoduo.com/api/upload", content);
                //ErrorResponse = new ErrorResponse();
                if (response.IsSuccessStatusCode)
                {
                    var jsonResult = await response.Content.ReadAsStringAsync();
                    var jObject = JObject.Parse(jsonResult);
                    if (jObject.TryGetValue("error_response", out var errorResponse))
                    {
                        //ErrorResponse = JsonConvert.DeserializeObject<ErrorResponse>(jsonResult);
                        Console.WriteLine("错误信息:" + errorResponse.ToString());
                        return default;
                    }
                    else
                    {
                        return JsonConvert.DeserializeObject<TResult>(jsonResult);
                    }
                }
                else
                {
                    Console.WriteLine("网络请求错误：" + response.ReasonPhrase + ":" + response.StatusCode);
                }
                return default;
            }
            catch (Exception e)
            {
                // TODO:异常处理
                Console.WriteLine(e.Message);
                return default;
            }
        }



        /// <summary>
        /// post请求封装
        /// </summary>
        /// <typeparam name="TModel">请求参数类型</typeparam>
        /// <typeparam name="TResult">返回参数类型</typeparam>
        /// <param name="type"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        protected async Task<TResult> PostAsync<TModel, TResult>(string type, TModel model)
        {
            if (string.IsNullOrEmpty(ClientId) || string.IsNullOrEmpty(ClientSecret))
            {
                throw new Exception("请检查是否设置ClientId、ClientSecret");
            }

            // 类型转换到字典
            var dic = Function.ToDictionary(model);

            // 判断是否为文件上传
            if (dic.Keys.Any(k => k == "file_path"))
            {
                return await PostFileAsync<TModel, TResult>(type, model);
            }
            // 添加公共参数
            dic.Add("client_id", ClientId);
            dic.Add("data_type", "JSON");
            if (string.IsNullOrEmpty(AccessToken))
            {
                Console.WriteLine("当前请求未设置AccessToken");
            }
            else
            {
                dic.Add("access_token", AccessToken);
            }
#if NET452
            var Unix = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            dic.Add("timestamp", (long)(DateTime.UtcNow - Unix).TotalMilliseconds);
#endif
#if NETSTANDARD2_0
            dic.Add("timestamp", DateTimeOffset.Now.ToUnixTimeSeconds());

#endif
            if (dic.Keys.Any(k => k == "type"))
            {
                dic.Remove("type");
            }
            dic.Add("type", type);
            // 添加签名
            var paramsDic = BuildSign(dic);
            var jsonBody = JsonConvert.SerializeObject(paramsDic);
            var data = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(ApiUrl, data);
                ErrorResponse = new ErrorResponse();
                if (response.IsSuccessStatusCode)
                {
                    var jsonResult = await response.Content.ReadAsStringAsync();
                    var jObject = JObject.Parse(jsonResult);
                    if (jObject.TryGetValue("error_response", out var errorResponse))
                    {
                        ErrorResponse = JsonConvert.DeserializeObject<ErrorResponse>(jsonResult);
                        Console.WriteLine("错误信息:" + errorResponse.ToString());
                        return default;
                    }
                    else
                    {
                        return JsonConvert.DeserializeObject<TResult>(jsonResult);
                    }
                }
                else
                {
                    Console.WriteLine("网络请求错误：" + response.ReasonPhrase + ":" + response.StatusCode);
                }
                return default;
            }
            catch (Exception e)
            {
                // TODO:异常处理
                Console.WriteLine(e.Message);
                return default;
            }

        }



        /// <summary>
        /// 生成签名
        /// </summary>
        /// <param name="type"></param>
        /// <param name="dic"></param>
        /// <returns></returns>
        public Dictionary<string, object> BuildSign(Dictionary<string, object> dic)
        {
            var result = new Dictionary<string, object>();
            // 去除空值并排序
            dic = dic.Where(d => d.Value != null)
                .OrderBy(d => d.Key)
                .ToDictionary((d) => d.Key, (d) => d.Value);
            // 拼接
            string signString = "";
            // 反射处理非基本类型字段的json转换
            string[] types = { "String", "DateTime", "Int64", "Boolean", "Float", "Double", "Long", "Int32" };
            foreach (var item in dic.Keys.ToArray())
            {
                if (!types.Contains(dic[item]?.GetType().Name))
                {
                    dic[item] = JsonConvert.SerializeObject(dic[item]);
                }
                dic.TryGetValue(item, out var value);
                // 布尔值大写造成的签名错误
                if (value.ToString().ToLower().Equals("false"))
                {
                    value = "false";
                }

                if (value.ToString().ToLower().Equals("true"))
                {
                    value = "true";
                }

                signString += item + value.ToString();
                result.Add(item, value.ToString());
            }
            signString = ClientSecret + signString + ClientSecret;
            Console.WriteLine("拼接内容:" + signString);
            // MD5加密
            using (var md5 = MD5.Create())
            {
                signString = Function.GetMd5Hash(md5, signString).ToUpper();
            }
            Console.WriteLine("签名:" + signString);
            result.Add("sign", signString);
            return result;
        }
    }

    /// <summary>
    /// 公共请求参数
    /// </summary>
    public class CommonReqeustParams
    {
        /// <summary>
        /// API接口名称
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// POP分配给应用的client_id
        /// </summary>
        public string Client_Id { get; set; }
        /// <summary>
        /// 通过code获取的access_token(无需授权的接口，该字段不参与sign签名运算)
        /// </summary>
        public string Access_Token { get; set; }
        /// <summary>
        /// UNIX时间戳
        /// </summary>
        public string TimeStamp { get; set; }
        /// <summary>
        /// 响应格式，即返回数据的格式，JSON或者XML（二选一），默认JSON，注意是大写
        /// </summary>
        public string Data_Type { get; set; } = "JSON";
        public string Version { get; set; } = "V1";
        /// <summary>
        /// API输入参数签名结果，签名算法参考开放平台接入指南第三部分底部
        /// </summary>
        public string Sign { get; set; }
    }


    public class ErrorResponse
    {
        public Error_Response Error_Response { get; set; }
    }

    public class Error_Response
    {
        public string Error_msg { get; set; }
        public string Sub_msg { get; set; }
        public object Sub_code { get; set; }
        public int Error_code { get; set; }
        public string Request_id { get; set; }
    }

}
