using Newtonsoft.Json;

namespace CardsPro.Models.Request
{
    public class BaseRequest
    {
        /// <summary>
        /// Информация о передаваемом идентификаторе карты.
        /// </summary>
        [JsonProperty("cardIdentifier")]
        public CardIdentifier CardIdentifier { get; set; }

        /// <summary>
        /// Код продукта.
        /// </summary>
        [JsonProperty("productCode")]
        public string ProductCode { get; set; }
    }
}