using Newtonsoft.Json;

namespace CardsPro.Models
{
    /// <summary>
    /// Данные о карте.
    /// </summary>
    public class CardIdentifier
    {
        /// <summary>
        /// Идентификатор карты: 19-значный баркод (номер) карты.
        /// </summary>
        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// Идентификатор карты: 20-символьный идентификатор карты (хеш).
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; set; }

        /// <summary>
        /// Идентификатор карты: информация с магнитной полосы карты (содержит номер карты и пин код).
        /// </summary>
        [JsonProperty("magneticTrackIdentifier")]
        public string MagneticTrackIdentifier { get; set; }

        /// <summary>
        /// Проверочный код (пин-код).
        /// </summary>
        [JsonProperty("pin")]
        public string Pin { get; set; }

        /// <summary>
        /// Внешний (партнёрский) идентификатор карты.
        /// </summary>
        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// Номер телефона клиента в формате +7ХХХХХХХХХХ.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}