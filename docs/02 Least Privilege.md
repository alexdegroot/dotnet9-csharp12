# Least Privilege

When packaging the exact same project in .NET 9 we see quite a difference:

``` bash
dotnet publish /t:PublishContainer

docker images

docker image inspect 01
```

## Notable changes
- No longer running as root
- 8080 exposed instead of 80