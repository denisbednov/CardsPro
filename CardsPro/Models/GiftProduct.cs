using Newtonsoft.Json;
using CardsPro.Enums;

namespace CardsPro.Models
{
    public class GiftProduct
    {
        /// <summary>
        /// Идентификатор продукта.
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Название продукта.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Код продукта.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Тип продукта.
        /// </summary>
        [JsonProperty("type")]
        public ProductType Type { get; set; }

        /// <summary>
        /// Тип счёта карты (баланса).
        /// </summary>
        [JsonProperty("kind")]
        public CardKind Kind { get; set; }

        /// <summary>
        /// Цена.
        /// </summary>
        [JsonProperty("price")]
        public int? Price { get; set; }

        /// <summary>
        /// Код дизайна продукта.
        /// </summary>
        [JsonProperty("cardDesignCode")]
        public string CardDesignCode { get; set; }

        /// <summary>
        /// Код дизайна продукта.
        /// </summary>
        [JsonProperty("cardDesign")]
        public CardDesign CardDesign { get; set; }
    }
}