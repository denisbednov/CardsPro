using Newtonsoft.Json;
using System.Collections.Generic;

namespace CardsPro.Models
{
    public class OrderGoods
    {
        /// <summary>
        /// Количество единиц товара.
        /// </summary>
        [JsonProperty("quantity")]
        public double? Quantity { get; set; }

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
        /// Информация об оплате.
        /// </summary>
        [JsonProperty("payments")]
        public List<Payment> Payments { get; set; }

        /// <summary>
        /// Цена товара.
        /// </summary>
        [JsonProperty("price")]
        public int? Price { get; set; }

        /// <summary>
        /// Наименование товара.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}