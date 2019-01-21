using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CardsPro.Models
{
    public class PurchaseOrder
    {
        /// <summary>
        /// Блок с дополнительными параметрами чека.
        /// </summary>
        [JsonProperty("addons")]
        public List<OrderAddon> Addons { get; set; }

        /// <summary>
        /// Сумма чека.
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// Блок с информацией о товарах в чеке (покупке).
        /// </summary>
        [JsonProperty("goods")]
        public List<OrderGoods> Goods { get; set; }

        /// <summary>
        /// Номер чека.
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// Дата/время чека.
        /// </summary>
        [JsonProperty("orderDate")]
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Блок с информацией об оплате.
        /// </summary>
        [JsonProperty("payments")]
        public List<Payment> Payments { get; set; }

        /// <summary>
        /// Сумма операции возврата.
        /// </summary>
        [JsonProperty("refundAmount")]
        public int? RefundAmount { get; set; }
    }
}