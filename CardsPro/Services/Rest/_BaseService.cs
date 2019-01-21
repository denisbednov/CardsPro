using Newtonsoft.Json;
using CardsPro.Core;
using RestSharp;
using System;

namespace CardsPro.Services.Rest
{
    public abstract class BaseService
    {
        protected abstract string Name { get; }

        protected IConfigurationService ConfigurationService { get; }

        public BaseService(IConfigurationService configurationService)
        {
            ConfigurationService = configurationService;
        }

        protected T Post<T>(string apiMethod, object dto) where T : new()
        {
            var request = new RestRequest($"/{Name}/{apiMethod}", Method.POST);

            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer = new RestSharpJsonNetSerializer();
            request.AddJsonBody(dto);

            return Execute<T>(request);
        }

        protected virtual T Execute<T>(IRestRequest request) where T : new()
        {
            T result = default(T);

            var client = new RestClient(ConfigurationService.GetApiUrl());

            client.ClientCertificates = ConfigurationService.GetSslCertificates();

            var response = client.Execute<T>(request);

            if (response.Content != null)
            {
                result = JsonConvert.DeserializeObject<T>(response.Content);
            }
            else if (response.ResponseStatus == ResponseStatus.Error && response.Content == null)
            {
                throw new ApplicationException($"Произошла ошибка во время выполнения запроса.", response.ErrorException);
            }

            return result;
        }
    }
}