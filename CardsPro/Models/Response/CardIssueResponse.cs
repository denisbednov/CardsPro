using Newtonsoft.Json;

namespace CardsPro.Models.Response
{
    public class CardIssueResponse : BaseResponse
    {
        /// <summary>
        /// Информация о передаваемом идентификаторе карты.
        /// </summary>
        [JsonProperty("cardIdentifier")]
        public CardIdentifier CardIdentifier { get; set; }
    }
}