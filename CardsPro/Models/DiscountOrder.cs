using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CardsPro.Models
{
    public class DiscountOrder
    {
        /// <summary>
        /// Общая сумма скидки.
        /// </summary>
        [JsonProperty("discountAmount")]
        public int? DiscountAmount { get; set; }

        /// <summary>
        /// Информация о товарах и распределении скидок между ними.
        /// </summary>
        [JsonProperty("discountGoods")]
        public List<DiscountGoods> DiscountGoods { get; set; }

        /// <summary>
        /// Номер чека.
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// Дата/время чека.
        /// </summary>
        [JsonProperty("orderDate")]
        public DateTime? OrderDate { get; set; }
    }
}