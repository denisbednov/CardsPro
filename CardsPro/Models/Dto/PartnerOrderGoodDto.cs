using Newtonsoft.Json;

namespace CardsPro.Models.Dto
{
    /// <summary>
    /// Товар из чека.
    /// </summary>
    public class PartnerOrderGoodDto
    {
        /// <summary>
        /// Артикул товара.
        /// </summary>
        [JsonProperty("name")]
        public int? Name { get; set; }

        /// <summary>
        /// Цена товара.
        /// </summary>
        [JsonProperty("price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// Количество товара.
        /// </summary>
        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// Количество возвращенного товара.
        /// </summary>
        [JsonProperty("refundQuantity")]
        public int? RefundQuantity { get; set; }

        /// <summary>
        /// Описание товара.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}