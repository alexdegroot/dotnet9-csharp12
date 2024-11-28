# Ahead of Time ++
Microsoft learned that by default the ASP.NET part of the framework was still pretty verbose. So they decided to make an optimized version of ASP.NET for AOT which optimizes for disk size and startup time.

https://learn.microsoft.com/en-us/aspnet/core/fundamentals/native-aot?view=aspnetcore-9.0

``` bash
dotnet new webapiaot
```