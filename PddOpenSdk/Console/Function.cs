using System.Globalization;

namespace Console;

public class Function
{
    /// <summary>
    /// 对象转字典
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="obj"></param>
    /// <param name="sort">排序</param>
    /// <returns></returns>
    public static Dictionary<string, TValue> ToDictionary<TValue>(object obj, OrderType sort)
    {
        var json = JsonSerializer.Serialize(obj);
        var dictionary = JsonSerializer.Deserialize<Dictionary<string, TValue>>(json);
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
        var title = myTI.ToTitleCase(words);
        if (title == words)
        {
            title = title.First().ToString() + title.Substring(1);
        }
        return title;
    }
    public static string ToPascalCase(string str)
    {
        if (string.IsNullOrWhiteSpace(str))
        {
            return string.Empty;
        }
        StringBuilder resultBuilder = new StringBuilder();
        foreach (char c in str)
        {
            if (!char.IsLetterOrDigit(c))
            {
                resultBuilder.Append(' ');
            }
            else
            {
                resultBuilder.Append(c);
            }
        }
        var result = resultBuilder.ToString();
        result = string.Join(string.Empty, result.Split(' ').Select(r => ToUpperFirst(r)).ToArray());
        return result;
    }
    public static string ToUpperFirst(string str)
    {
        if (string.IsNullOrWhiteSpace(str))
        {
            return string.Empty;
        }
        return char.ToUpper(str[0]) + str.Substring(1);
    }

    /// <summary>
    /// 追加行内容
    /// </summary>
    /// <param name="content"></param>
    /// <param name="append"></param>
    /// <param name="before">是否在前面追加</param>
    /// <returns></returns>
    public static string AppendLine(string content, string append, bool before = false)
    {
        if (before)
        {
            return append + content + Environment.NewLine;
        }
        return content + append + Environment.NewLine;
    }
}


public enum OrderType
{
    NONE,
    ASC,
    DESC
}
