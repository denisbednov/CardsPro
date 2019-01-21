using Newtonsoft.Json;
using CardsPro.Models.Request;

namespace CardsPro.Models.Dto
{
    public class CardChangeStatusDto : BaseDto
    {
        [JsonProperty("cardChangeStatusRequest")]
        public CardChangeStatusRequest CardChangeStatusRequest { get; set; }
    }
}