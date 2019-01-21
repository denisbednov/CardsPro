using Newtonsoft.Json;

namespace CardsPro.Models.Dto
{
    /// <summary>
    /// Информация о транзации.
    /// </summary>
    public class TransactionDto
    {
        /// <summary>
        /// Сумма транзации.
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        /// <summary>
        /// Идентификатор транзакции.
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Описание транзакции.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Информация о правиле.
        /// </summary>
        [JsonProperty("loyaltyRule")]
        public LoyaltyRuleDto LoyaltyRule { get; set; }
    }
}