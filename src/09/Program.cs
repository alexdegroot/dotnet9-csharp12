using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;


// Simple Hashing
var input = Encoding.UTF8.GetBytes("Hello World");
byte[] hash = CryptographicOperations.HashData(HashAlgorithmName.SHA3_512, input);

Console.WriteLine(Encoding.UTF8.GetString(hash));

// Universal cross platform way to load files
// openssl req -new -newkey rsa:2048 -days 365 -nodes -x509 -keyout server.key -out server.crt
var certificate = X509CertificateLoader.LoadCertificateFromFile("server.crt");
Console.WriteLine(certificate.SerialNumber);


// Keyed hashing has now KMac support
if (KmacXof128.IsSupported)
{
    var key = Encoding.UTF8.GetBytes("Very Secure Key");
    var mac = KmacXof128.HashData(key, input, outputLength: 32);

    Console.WriteLine(Encoding.UTF8.GetString(hash));
}

