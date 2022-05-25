# OrleansExample

# 1. HelloWorld

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
