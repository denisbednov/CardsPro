using Newtonsoft.Json;
using System.Collections.Generic;

namespace CardsPro.Models.Dto
{
    /// <summary>
    /// Информация о покупке.
    /// </summary>
    public class PartnerOrderDto
    {
        /// <summary>
        /// Сумма чека.
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Товары из чека.
        /// </summary>
        [JsonProperty("goods")]
        public List<PartnerOrderGoodDto> Goods { get; set; }

        [JsonProperty("id")]
        public int? id { get; set; }

        /// <summary>
        /// Номер чека.
        /// </summary>
        [JsonProperty("orderNumber")]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Сумма возврата.
        /// </summary>
        [JsonProperty("refundAmount")]
        public decimal? RefundAmount { get; set; }
    }
}