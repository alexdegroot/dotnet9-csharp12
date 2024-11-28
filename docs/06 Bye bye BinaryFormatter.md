# BinaryFormatter > /dev/null
Deserialization of objects which can tell the system how to work(e.g. how much memory to allocate) are by definition an issue. Hence, the BinaryFormatter is removed. From .NET 9 onwards it's going to throw an error as well.
Backwards upport using this NuGet package (unsupported!!): 
https://www.nuget.org/packages/System.Runtime.Serialization.Formatters 


More details: https://devblogs.microsoft.com/dotnet/binaryformatter-removed-from-dotnet-9/