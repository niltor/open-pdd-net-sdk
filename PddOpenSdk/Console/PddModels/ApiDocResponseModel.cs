using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Console.PddModels
{
    public class ApiDocResponseModel
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("errorCode")]
        public long ErrorCode { get; set; }

        [JsonProperty("errorMsg")]
        public object ErrorMsg { get; set; }

        [JsonProperty("result")]
        public ApiDocDetail Result { get; set; }
    }

    public class ApiDocDetail
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("catId")]
        public long CatId { get; set; }

        [JsonProperty("apiName")]
        public string ApiName { get; set; }

        [JsonProperty("scopeName")]
        public string ScopeName { get; set; }

        [JsonProperty("usageScenarios")]
        public string UsageScenarios { get; set; }

        [JsonProperty("needOauth")]
        public long NeedOauth { get; set; }

        [JsonProperty("responseCodeExample")]
        public string ResponseCodeExample { get; set; }

        [JsonProperty("requestParamList")]
        public List<ParamList> RequestParamList { get; set; }

        [JsonProperty("responseParamList")]
        public List<ParamList> ResponseParamList { get; set; }

        [JsonProperty("errorParamList")]
        public List<ErrorParamList> ErrorParamList { get; set; }

        [JsonProperty("limiters")]
        public List<Limiter> Limiters { get; set; }

        [JsonProperty("permissionsPkgs")]
        public List<PermissionsPkg> PermissionsPkgs { get; set; }

        [JsonProperty("sdkDemos")]
        public List<SdkDemo> SdkDemos { get; set; }
    }

    public partial class ErrorParamList
    {
        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("errorMsg")]
        public string ErrorMsg { get; set; }

        [JsonProperty("solution")]
        public string Solution { get; set; }

        [JsonProperty("outerErrorCode")]
        public string OuterErrorCode { get; set; }
    }

    public partial class Limiter
    {
        [JsonProperty("limiterLevel")]
        public long LimiterLevel { get; set; }

        [JsonProperty("timeRange")]
        public long TimeRange { get; set; }

        [JsonProperty("times")]
        public long Times { get; set; }
    }

    public partial class PermissionsPkg
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("appTypeList")]
        public List<AppTypeList> AppTypeList { get; set; }
    }

    public partial class AppTypeList
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class ParamList
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("parentId")]
        public long ParentId { get; set; }

        [JsonProperty("childrenNum")]
        public long ChildrenNum { get; set; }

        [JsonProperty("paramName")]
        public string ParamName { get; set; }

        [JsonProperty("paramType")]
        public ParamType ParamType { get; set; }

        [JsonProperty("isMust", NullValueHandling = NullValueHandling.Ignore)]
        public long? IsMust { get; set; } = 0;

        [JsonProperty("defaultValue", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }

        [JsonProperty("example")]
        public string Example { get; set; }

        [JsonProperty("paramDesc")]
        public string ParamDesc { get; set; }

        [JsonProperty("sourcePath")]
        public object SourcePath { get; set; }
    }

    public partial class SdkDemo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public enum ParamType { Double, Integer, Long, Object, ObjectArray, StringArray, Boolean, String, IntegerArray, LongArray, Map, MapArray };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ParamTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParamTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(ParamType) || t == typeof(ParamType?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "DOUBLE":
                    return ParamType.Double;
                case "INTEGER":
                    return ParamType.Integer;
                case "LONG":
                    return ParamType.Long;
                case "OBJECT":
                    return ParamType.Object;
                case "OBJECT[]":
                    return ParamType.ObjectArray;
                case "STRING[]":
                    return ParamType.StringArray;
                case "LONG[]":
                    return ParamType.LongArray;
                case "INTEGER[]":
                    return ParamType.Integer;
                case "STRING":
                    return ParamType.String;
                case "BOOLEAN":
                    return ParamType.Boolean;
                case "MAP":
                    return ParamType.Map;
                case "MAP[]":
                    return ParamType.MapArray;
            }

            throw new Exception("Cannot unmarshal type ParamType " + value);
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ParamType)untypedValue;
            switch (value)
            {
                case ParamType.Double:
                    serializer.Serialize(writer, "double");
                    return;
                case ParamType.Integer:
                    serializer.Serialize(writer, "int");
                    return;
                case ParamType.IntegerArray:
                    serializer.Serialize(writer, "int[]");
                    return;
                case ParamType.Long:
                    serializer.Serialize(writer, "long");
                    return;
                case ParamType.LongArray:
                    serializer.Serialize(writer, "long[]");
                    return;
                case ParamType.Object:
                    serializer.Serialize(writer, "object");
                    return;
                case ParamType.ObjectArray:
                    serializer.Serialize(writer, "object[]");
                    return;
                case ParamType.StringArray:
                    serializer.Serialize(writer, "string[]");
                    return;
                case ParamType.String:
                    serializer.Serialize(writer, "string");
                    return;
                case ParamType.Boolean:
                    serializer.Serialize(writer, "boolean");
                    return;
                case ParamType.Map:
                    serializer.Serialize(writer, "map");
                    return;
                case ParamType.MapArray:
                    serializer.Serialize(writer, "map[]");
                    return;
            }
            throw new Exception("Cannot marshal type ParamType");
        }

        public static readonly ParamTypeConverter Singleton = new ParamTypeConverter();
    }
}
