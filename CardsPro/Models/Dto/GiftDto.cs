using Newtonsoft.Json;
using System;

namespace CardsPro.Models.Dto
{
    public class GiftDto
    {
        /// <summary>
        /// Дата, до которой доступен подарок.
        /// </summary>
        [JsonProperty("activeTo")]
        public DateTime ActiveTo { get; set; }

        /// <summary>
        /// Дата начисления подарка.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Блок с информацией о товаре (подарке).
        /// </summary>
        [JsonProperty("goods")]
        public GoodsDto Goods { get; set; }

        /// <summary>
        /// Идентификатор начисления подарка.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}