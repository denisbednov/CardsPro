using Newtonsoft.Json;
using CardsPro.Enums;
using System;

namespace CardsPro.Models.Dto
{
    /// <summary>
    /// Информация о правиле.
    /// </summary>
    public class LoyaltyRuleDto
    {
        /// <summary>
        /// Идентификатор транзакции.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Признак действующей акции.
        /// </summary>
        [JsonProperty("disable")]
        public bool? Disable { get; set; }

        /// <summary>
        /// Тип события, инициирующего обработку правила лояльности.
        /// </summary>
        [JsonProperty("eventType")]
        public string EventType { get; set; }

        /// <summary>
        /// Идентификатор акции.
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Тип бонусов.
        /// </summary>
        [JsonProperty("label")]
        public BonusType Label { get; set; }

        /// <summary>
        /// Название акции.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Код партнерской точки, для которой действует правило.
        /// </summary>
        [JsonProperty("partnerNodeCode")]
        public string PartnerNodeCode { get; set; }

        /// <summary>
        /// Код продукта, для которого действует правило.
        /// </summary>
        [JsonProperty("productCode")]
        public string ProductCode { get; set; }

        /// <summary>
        /// Правило обработки правила (JSON-строка).
        /// </summary>
        [JsonProperty("rule")]
        public string Rule { get; set; }

        /// <summary>
        /// Тип правила.
        /// </summary>
        [JsonProperty("type")]
        public LoyaltyRuleType Type { get; set; }

        /// <summary>
        /// Описание правила.
        /// </summary>
        [JsonProperty("typeDescription")]
        public string TypeDescription { get; set; }

        /// <summary>
        /// Начало действия акции.
        /// </summary>
        [JsonProperty("validFrom")]
        public DateTime? ValidFrom { get; set; }

        /// <summary>
        /// Окончание действия акции.
        /// </summary>
        [JsonProperty("validTo")]
        public DateTime? ValidTo { get; set; }
    }
}