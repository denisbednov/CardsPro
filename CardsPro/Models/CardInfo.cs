using Newtonsoft.Json;
using System.Collections.Generic;

namespace CardsPro.Models
{
    public class CardInfo
    {
        /// <summary>
        /// Дополнительная информация.
        /// </summary>
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Блок с информацией о состоянии счёта (баланса) карты.
        /// </summary>
        [JsonProperty("balances")]
        public List<CardBalance> Balances { get; set; }

        /// <summary>
        /// Штрих-код карты.
        /// </summary>
        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// Информация о дизайне карты.
        /// </summary>
        [JsonProperty("cardDesign")]
        public CardDesign CardDesign { get; set; }

        /// <summary>
        /// Короткий номер карты.
        /// </summary>
        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// Название карты.
        /// </summary>
        [JsonProperty("cardName")]
        public string CardName { get; set; }

        /// <summary>
        /// Анкетные данные клиента.
        /// </summary>
        [JsonProperty("user")]
        public UserForm User { get; set; }

        /// <summary>
        /// Ссылка до карты OSMI.
        /// </summary>
        [JsonProperty("osmiLink")]
        public string OsmiLink { get; set; }
    }
}