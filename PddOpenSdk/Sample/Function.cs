using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Sample
{
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
            var json = JsonConvert.SerializeObject(obj);
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, TValue>>(json);
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
    }


    public enum OrderType
    {
        NONE,
        ASC,
        DESC
    }
}
