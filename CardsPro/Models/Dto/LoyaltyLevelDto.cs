using Newtonsoft.Json;

namespace CardsPro.Models.Dto
{
    public class LoyaltyLevelDto
    {
        /// <summary>
        /// Код уровня.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Название уровня (описание).
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Код дизайна для уровня.
        /// </summary>
        [JsonProperty("designCode")]
        public string DesignCode { get; set; }
    }
}