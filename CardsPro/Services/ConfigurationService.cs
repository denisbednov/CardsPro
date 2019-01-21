using System;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace CardsPro.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private const string CardsProRestApiUrl = "CardsProRestApiUrl";
        private const string CardsProRestApiSslCertificatePath = "CardsProRestApiSslCertificatePath";
        private const string CardsProRestApiSslCertificatePassword = "CardsProRestApiSslCertificatePassword";

        private string Get(string key, bool throwNotFoundException = false)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException(nameof(key));
            }

            var result = ConfigurationManager.AppSettings[key];

            if (throwNotFoundException && result == null)
            {
                throw new ConfigurationErrorsException($"Значение с ключом \"{key}\" не найдено в конфигурационном файле (секция appSettings).");
            }

            return result;
        }

        public string GetApiUrl() => Get(CardsProRestApiUrl, true);

        public X509CertificateCollection GetSslCertificates() => new X509CertificateCollection
        {
            new X509Certificate2(Get(CardsProRestApiSslCertificatePath, true), Get(CardsProRestApiSslCertificatePassword, true))
        };
    }
}