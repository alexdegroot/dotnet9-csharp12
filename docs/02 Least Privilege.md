# Least Privilege

Since .NET 8 the base images have changed. We run no longer as root user, but instead as a user with just execution rights.

``` bash
dotnet publish /t:PublishContainer

docker images

docker image inspect 01
```

## Notable changes
- No longer running as root
- 8080 exposed instead of 80 (as this requires root)

https://devblogs.microsoft.com/dotnet/securing-containers-with-rootless/