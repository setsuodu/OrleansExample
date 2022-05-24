# OrleansExample

# 1. HelloWorld

|项目|依赖|类型|备注|
|--|--|--|--|
|Client| Microsoft.Orleans.Client| 控制台 | GateServer, 网关, 客户端，需要多开 |
|Grains| Microsoft.Orleans.CodeGenerator.MSBuild（跨平台）,Microsoft.Oleans.Core.Abstractions | 类库 |实现 |
|GrainInterface| Microsoft.Orleans.CodeGenerator.MSBuild, Microsoft.Oleans.Core.Abstractions | 类库 |接口 |
|Silo| Microsoft.Orleans.Server | 控制台 |CardServer, 服务器，可以多开 |

### Add References

1. `Grains` references `GrainInterfaces`.
2. `Silo` references `GrainInterfaces` and `Grains`.
3. `Client` references `GrainInterfaces`.

## Add Orleans NuGet Packages

| Project          | Nuget Package                               |
| :--------------- | :------------------------------------------ |
| Silo             | `Microsoft.Orleans.Server`                  |
| Silo             | `Microsoft.Extensions.Logging.Console`      |
| Client           | `Microsoft.Extensions.Logging.Console`      |
| Client           | `Microsoft.Orleans.Client`                  |
| Grain Interfaces | `Microsoft.Orleans.Core.Abstractions`       |
| Grain Interfaces | `Microsoft.Orleans.CodeGenerator.MSBuild`   |
| Grains           | `Microsoft.Orleans.CodeGenerator.MSBuild`   |
| Grains           | `Microsoft.Orleans.Core.Abstractions`       |
| Grains           | `Microsoft.Extensions.Logging.Abstractions` |