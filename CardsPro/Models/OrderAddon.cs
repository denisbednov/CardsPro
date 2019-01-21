using Newtonsoft.Json;

namespace CardsPro.Models
{
    public class OrderAddon
    {
        /// <summary>
        /// Название дополнительного параметра.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Значение дополнительного параметра.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}