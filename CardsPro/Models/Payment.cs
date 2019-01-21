using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using CardsPro.Enums;

namespace CardsPro.Models
{
    public class Payment
    {
        /// <summary>
        /// Сумма оплаты.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Тип платежного инструмента
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentType Type { get; set; }
    }
}