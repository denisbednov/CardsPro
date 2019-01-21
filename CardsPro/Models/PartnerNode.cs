using Newtonsoft.Json;

namespace CardsPro.Models
{
    /// <summary>
    /// Информация о торговой точке партнёра.
    /// </summary>
    public class PartnerNode
    {
        /// <summary>
        /// Идентификатор точки.
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Название точки.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}