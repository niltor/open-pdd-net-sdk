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
