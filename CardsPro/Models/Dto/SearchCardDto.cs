using Newtonsoft.Json;

namespace CardsPro.Models.Dto
{
    public class SearchCardDto : BaseDto
    {
        [JsonProperty("userForm")]
        public UserForm UserForm { get; set; }

        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
    }
}