using Newtonsoft.Json;

namespace CardsPro.Models
{
    public class CardDesign
    {
        /// <summary>
        /// Код дизайна карты.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Идентификатор дизайна карты.
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Наименование дизайна карты.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}