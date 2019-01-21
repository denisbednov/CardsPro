using Newtonsoft.Json;
using CardsPro.Models.Request;

namespace CardsPro.Models.Dto
{
    public class TopUpDto : BaseDto
    {
        [JsonProperty("cardTopUpRequest")]
        public CardTopUpRequest CardTopUpRequest { get; set; }
    }
}