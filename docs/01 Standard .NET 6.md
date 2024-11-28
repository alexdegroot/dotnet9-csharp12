# Standard .NET 6 API

Let's containerize this thing.

``` xml
<IsPublishable>true</IsPublishable>
<EnableSdkContainerSupport>true</enableSdkContainerSupport>
```

And then run

``` bash
dotnet publish /t:PublishContainer

docker images

docker image inspect 01
```

## Notice a few things
Quite some things wrong with it:
- Running as Admin
- Exposing port 80 by default?
- 200 mb big for a static endpoint?