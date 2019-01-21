using Newtonsoft.Json;

namespace CardsPro.Models
{
    public class Pageable
    {
        /// <summary>
        /// Номер выводимой страницы.
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Количество операций на одной странице.
        /// </summary>
        [JsonProperty("size")]
        public int? Size { get; set; }
    }
}