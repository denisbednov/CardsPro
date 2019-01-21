using Newtonsoft.Json;
using CardsPro.Enums;

namespace CardsPro.Models.Request
{
    /// <summary>
    /// Параметры смены статуса.
    /// </summary>
    public class CardChangeStatusRequest : BaseRequest
    {
        /// <summary>
        /// Новый статус, на который будет изменён статус продукта карты.
        /// </summary>
        [JsonProperty("status")]
        public CardStatus Status { get; set; }

        /// <summary>
        /// Дополнительные парамеры.
        /// </summary>
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
    }
}