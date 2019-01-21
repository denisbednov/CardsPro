using Newtonsoft.Json;

namespace CardsPro.Models.Response
{
    public class CalculateDiscountResponse : BaseResponse
    {
        /// <summary>
        /// Блок с информацией о скидке.
        /// </summary>
        [JsonProperty("discountOrder")]
        public DiscountOrder DiscountOrder { get; set; }
    }
}