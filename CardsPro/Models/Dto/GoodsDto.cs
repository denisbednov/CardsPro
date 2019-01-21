using Newtonsoft.Json;

namespace CardsPro.Models.Dto
{
    public class GoodsDto
    {
        /// <summary>
        /// Артикул товара (подарка).
        /// </summary>
        [JsonProperty("goodsExternalId")]
        public string GoodsExternalId { get; set; }

        /// <summary>
        /// Внутренний идентификатор товара (подарка).
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Наименование товара (подарка).
        /// </summary>
        [JsonProperty("goodsName")]
        public string GoodsName { get; set; }
    }
}