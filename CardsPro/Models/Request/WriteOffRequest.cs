using Newtonsoft.Json;

namespace CardsPro.Models.Request
{
    /// <summary>
    /// Параметры списания.
    /// </summary>
    public class WriteOffRequest : BaseRequest
    {
        /// <summary>
        /// Сумма списания в баллах для карт с типом POINTS в единицах измерения (валюте), указанных в параметре currency PartnerInfo.
        /// Для карт с типом счёта PURCHASE независимо от значения, указанного в данном параметре, будет списан 1 проход/услуга.
        /// </summary>
        [JsonProperty("bonusAmount")]
        public int? BonusAmount { get; set; }        

        /// <summary>
        /// Информация о чеке.
        /// </summary>
        [JsonProperty("order")]
        public PurchaseOrder Order { get; set; }

        /// <summary>
        /// Код идентификации (OTP-код подтверждения из СМС).
        /// </summary>
        [JsonProperty("identCode")]
        public int? IdentCode { get; set; }

        /// <summary>
        /// Дополнительные параметры.
        /// </summary>
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
    }
}