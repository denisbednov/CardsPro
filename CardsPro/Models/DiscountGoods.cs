using Newtonsoft.Json;

namespace CardsPro.Models
{
    public class DiscountGoods
    {
        /// <summary>
        /// Количество товаров, на которое была рассчитана скидка.
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Сумма скидки по товару.
        /// </summary>
        [JsonProperty("discountAmount")]
        public int? DiscountAmount { get; set; }

        /// <summary>
        /// Артикул товара.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Номер строки в чеке.
        /// </summary>
        [JsonProperty("lineNumber")]
        public int? LineNumber { get; set; }

        /// <summary>
        /// Номер строки в чеке.
        /// </summary>
        [JsonProperty("giftCount")]
        public string GiftCount { get; set; }
    }
}