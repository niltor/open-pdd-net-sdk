# 更新日志
## 2023/02/06
- 同步官方接口
- 添加对.net7支持

## 2022/05/12
- socket ack更新，官方更改了类型标识，同步更新。感谢`w2d1`的反馈。

## 2022/05/08 V6.0.1
- 修复: `GetOrderListResponse`对象中`ItemList`中的`goods_id`修改为`long`类型，官方文档为string，实际返回不为string，造成反序列化失败
- 修复: 关于构造的请求内容格式不对的问题，已将对象转字典的方法进行处理，不使用`System.Text.Json`进行处理。
- 修复关于中文在Json转换中显示的是unicode编码而不是中文的问题。

> 感谢[Cherrs](https://github.com/Cherrs)与`一次一片`的反馈和贡献。

# 更新说明
`6.0版本`是基于`.net6.0`提供的SDK。该版本主要有以下改进内容：

- [x] 添加对图片流式上传的支持
- [x] 移除JSON.Net依赖，使用System.Text.Json 替代
- [x] 简化所有请求和返回类型的名称
- [x] 使用C#10语法对代码进行精简
- [x] 消息服务的ack处理

# 迁移指南
相对于之前的SDK版本，所有的`请求模型`名称去除了`RequestModel`后缀，如：
### 之前版本:
```csharp
var model = new GetDdkGoodsRecommendRequestModel
{
    CatId = 20100
});
```

### 现在版本:
```csharp
var model = new GetDdkGoodsRecommend
{
    CatId = 20100
};
```

所有的`返回类型`名称去除了`Model`后缀，如：
`SearchDdkGoodsResponseModel`将变更为`SearchDdkGoodsResponse`。
