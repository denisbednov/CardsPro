using Newtonsoft.Json;

namespace CardsPro.Models.Dto
{
    public class FindInfoDto : BaseDto
    {
        [JsonProperty("cardIdentifier")]
        public CardIdentifier CardIdentifier { get; set; }

        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }

        [JsonProperty("withoutMarkedBonuses")]
        public bool WithoutMarkedBonuses { get; set; }
    }
}