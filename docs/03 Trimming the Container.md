# Trimming the container

Still the container is quite big. And while Microsoft worked already to get it smaller, it wasn't enough.
Some people started to build the containers just by collecting a few files (distroless). This has some huge disadvantages for patching.
Ubuntu jumped into this by enhancing the Debian package system with a further dimm-down. Welcome `chisl` and welcome `chiseled` containers.
More details: https://www.youtube.com/watch?v=o8NILnbjhQ4

``` xml
<ContainerBaseImage>mcr.microsoft.com/dotnet/aspnet:9.0-noble-chiseled</ContainerBaseImage>
```