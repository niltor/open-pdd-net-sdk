using MSDev.PddOpenSdk.Models;
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
        static readonly string ApiUrl = "http://gw-api.pinduoduo.com/api/router";
        public static string ClientId;
        public static string ClientSecret;
        /// <summary>
        /// token
        /// </summary>
        public static string AccessToken;
        public static string RedirectUri;
        protected static HttpClient client = new HttpClient();


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
            if (string.IsNullOrEmpty(ClientId) || string.IsNullOrEmpty(ClientSecret) || string.IsNullOrEmpty(AccessToken))
            {
                throw new Exception("请检查是否设置ClientId、ClientSecret及AccessToken");
            }
            // 类型转换到字典
            var dic = Function.ToDictionary(model);
            // 添加公共参数
            dic.Add("access_token", AccessToken);
            dic.Add("client_id", ClientId);
            dic.Add("data_type", "JSON");
            dic.Add("timestamp", DateTimeOffset.Now.ToUnixTimeSeconds().ToString());
            if (dic.Keys.Any(k => k == "type"))
            {
                dic.Remove("type");
            }
            dic.Add("type", type);

            // 添加签名
            dic.Add("sign", BuildSign(dic));
            var jsonBody = JsonConvert.SerializeObject(dic);
            var data = new StringContent(jsonBody, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(ApiUrl, data);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var jObject = JObject.Parse(jsonResult);
                if (jObject.TryGetValue("error_response", out var errorResponse))
                {
                    // TODO:处理错误信息
                    Console.WriteLine("错误信息:" + errorResponse.ToString());
                    File.AppendAllText("error.json", jsonResult + "\r\n");
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
        /// <summary>
        /// 生成签名
        /// </summary>
        /// <param name="type"></param>
        /// <param name="dic"></param>
        /// <returns></returns>
        public string BuildSign(Dictionary<string, object> dic)
        {
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
                    //Console.WriteLine("签名转json:" + dic[item].GetType().Name);
                    dic[item] = JsonConvert.SerializeObject(dic[item]);
                }
                dic.TryGetValue(item, out var value);
                // 布尔值大写造成的签名错误
                if (value.ToString().ToLower().Equals("false")) value = "false";
                if (value.ToString().ToLower().Equals("true")) value = "true";
                signString += item + value.ToString();
            }
            signString = ClientSecret + signString + ClientSecret;
            Console.WriteLine("拼接内容:" + signString);
            // MD5加密
            using (var md5 = MD5.Create())
            {
                signString = Function.GetMd5Hash(md5, signString).ToUpper();
            }
            Console.WriteLine("签名:" + signString);
            return signString;
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
}
