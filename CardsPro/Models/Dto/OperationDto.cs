using Newtonsoft.Json;

namespace CardsPro.Models.Dto
{
    public class OperationDto
    {
        /// <summary>
        /// Код валюты, в которой совершена операция.
        /// </summary>
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Идентификатор операции.
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Тип операции.
        /// </summary>
        [JsonProperty("operationType")]
        public string OperationType { get; set; }

        /// <summary>
        /// Сумма баллов.
        /// </summary>
        [JsonProperty("pointsAmount")]
        public int? PointsAmount { get; set; }
    }
}