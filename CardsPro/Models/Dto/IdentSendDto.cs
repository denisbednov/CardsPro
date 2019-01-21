using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using CardsPro.Enums;

namespace CardsPro.Models.Dto
{
    public class IdentSendDto : BaseDto
    {
        /// <summary>
        /// Информация о карте (идентификатор карты).
        /// </summary>
        [JsonProperty("cardIdentifier")]
        public CardIdentifier CardIdentifier { get; set; }

        /// <summary>
        /// Номер телефона. Формат: +7ХХХХХХХХХХ.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Тип операции.
        /// </summary>
        [JsonProperty("operationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OperationType OperationType { get; set; }

        /// <summary>
        /// Код продукта.
        /// </summary>
        [JsonProperty("productCode")]
        public string ProductCode { get; set; }

        /// <summary>
        /// Дополнительные параметры.
        /// </summary>
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
    }
}