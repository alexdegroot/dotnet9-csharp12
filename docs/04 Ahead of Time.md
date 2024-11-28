# Ahead of Time
When you take this all one step further, we might be able to no longer depend at all on the entire .NET runtime & framework at all.
There's trimming for getting rid of the assemblies / liraries which are not used, and then there's is  Ahead of Time compilation (AOT) which embed the runtime components into your assembly.

https://learn.microsoft.com/en-gb/dotnet/core/deploying/native-aot/

``` xml
    <PublishAot>true</PublishAot>
    <PublishTrimmed>true</PublishTrimmed>
```