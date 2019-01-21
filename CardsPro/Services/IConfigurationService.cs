using System.Security.Cryptography.X509Certificates;

namespace CardsPro.Services
{
    public interface IConfigurationService
    {
        X509CertificateCollection GetSslCertificates();

        string GetApiUrl();
    }
}