using Newtonsoft.Json;
using CardsPro.Models.Request;

namespace CardsPro.Models.Dto
{
    public class ActivateDto : BaseDto
    {
        /// <summary>
        /// Параметры активации.
        /// </summary>
        [JsonProperty("cardActivateRequest")]
        public CardActivateRequest CardActivateRequest { get; set; }
    }
}