using Newtonsoft.Json;

namespace CardsPro.Models.Request
{
    /// <summary>
    /// Параметры пополнения.
    /// </summary>
    public class CardTopUpRequest : BaseRequest
    {
        /// <summary>
        /// Пополняемое количество проходов.
        /// </summary>
        [JsonProperty("purchaseCount")]
        public string purchaseCount { get; set; }

        /// <summary>
        /// Сумма пополнения в единицах измерения (валюте), указанных в параметре currency PartnerInfo..
        /// </summary>
        [JsonProperty("sum")]
        public int? Sum { get; set; }

        /// <summary>
        /// Дополнительные парамеры.
        /// </summary>
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
    }
}