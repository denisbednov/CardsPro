using Newtonsoft.Json;
using CardsPro.Models;

namespace CardsPro.Params
{
    /// <summary>
    /// Параметры поиска карт.
    /// </summary>
    public class CardSearchParams
    {
        /// <summary>
        /// Информация о запросе партнёра.
        /// </summary>
        [JsonProperty("partnerInfo")]
        public PartnerInfo PartnerInfo { get; set; }

        /// <summary>
        /// Блок с информацией о клиенте, где указывается номер телефона в формате +7ХХХХХХХХХХ.
        /// </summary>
        [JsonProperty("userForm")]
        public UserForm UserForm { get; set; }

        /// <summary>
        /// Дополнительная информация.
        /// </summary>
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
    }
}