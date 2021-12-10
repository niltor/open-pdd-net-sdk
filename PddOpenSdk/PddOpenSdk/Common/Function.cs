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
        var json = JsonSerializer.Serialize(obj, new JsonSerializerOptions {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        });

        var dictionary = JsonSerializer.Deserialize<Dictionary<string, object>>(json);
        dictionary = dictionary
            .Where(d => d.Value != null && !string.IsNullOrEmpty(d.Value?.ToString()))
                .ToDictionary((d) => d.Key, (d) => d.Value);

        if (sort == OrderType.ASC)
        {
            return dictionary.OrderBy(d => d.Key).ToDictionary((d) => d.Key, (d) => d.Value);
        }
        else if (sort == OrderType.DESC)
        {
            return dictionary.OrderByDescending(d => d.Key).ToDictionary((d) => d.Key, (d) => d.Value);
        }
        else
        {
            return dictionary;
        }
    }
    /// <summary>
    /// 将英文转化为首字母大写
    /// </summary>
    /// <param name="words"></param>
    /// <returns></returns>
    public static string ToTitleCase(string words)
    {
        TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
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
        byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
        StringBuilder sBuilder = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }
        return sBuilder.ToString();
    }

    // md5验证
    public static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
    {
        string hashOfInput = GetMd5Hash(md5Hash, input);
        StringComparer comparer = StringComparer.OrdinalIgnoreCase;
        if (0 == comparer.Compare(hashOfInput, hash))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}


public enum OrderType
{
    NONE,
    ASC,
    DESC
}
