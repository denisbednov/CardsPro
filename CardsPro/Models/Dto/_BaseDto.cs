using Newtonsoft.Json;

namespace CardsPro.Models.Dto
{
    public abstract class BaseDto
    {
        /// <summary>
        /// Информация о запросе партнёра.
        /// </summary>
        [JsonProperty("partnerInfo")]
        public PartnerInfo PartnerInfo { get; set; }
    }
}