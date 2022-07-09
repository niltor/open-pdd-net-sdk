using System.Globalization;

namespace PddOpenSdk.Common;

public class Function
{
    /// <summary>
    /// 对象转字典
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="sort">排序</param>
    /// <returns></returns>
    public static Dictionary<string, object> ToDictionary(object obj, OrderType? sort = OrderType.ASC)
    {
        var dictionary = new Dictionary<string, object>();
        var properties = obj.GetType().GetProperties().ToList();

        // 优先使用自定义名称，否则使用属性名
        properties.ForEach(p => {
            var attribute = p.GetCustomAttributes(typeof(JsonPropertyNameAttribute), false).LastOrDefault();
            // 空值忽略
            var value = p.GetValue(obj);
            if (value != null)
            {
                if (attribute != null)
                {
                    var jsonPropertyName = (JsonPropertyNameAttribute)attribute;
                    dictionary.Add(jsonPropertyName.Name, value);
                }
                else
                {
                    dictionary.Add(p.Name, value);
                }
            }
        });

        return sort == OrderType.ASC
            ? dictionary.OrderBy(d => d.Key).ToDictionary((d) => d.Key, (d) => d.Value)
            : sort == OrderType.DESC ? dictionary.OrderByDescending(d => d.Key).ToDictionary((d) => d.Key, (d) => d.Value) : dictionary;
    }
    /// <summary>
    /// 将英文转化为首字母大写
    /// </summary>
    /// <param name="words"></param>
    /// <returns></returns>
    public static string ToTitleCase(string words)
    {
        var myTI = new CultureInfo("en-US", false).TextInfo;
        return myTI.ToTitleCase(words);
    }


    /// <summary>
    /// md5加密
    /// </summary>
    /// <param name="md5Hash"></param>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string GetMd5Hash(MD5 md5Hash, string input)
    {
        var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
        var sBuilder = new StringBuilder();
        for (var i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }
        return sBuilder.ToString();
    }

    // md5验证
    public static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
    {
        var hashOfInput = GetMd5Hash(md5Hash, input);
        var comparer = StringComparer.OrdinalIgnoreCase;
        return 0 == comparer.Compare(hashOfInput, hash);
    }
}


public enum OrderType
{
    NONE,
    ASC,
    DESC
}
