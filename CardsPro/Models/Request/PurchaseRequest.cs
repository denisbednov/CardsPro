using Newtonsoft.Json;

namespace CardsPro.Models.Request
{
    /// <summary>
    /// Параметры покупки (чека).
    /// </summary>
    public class PurchaseRequest : BaseRequest
    {
        /// <summary>
        /// Информация о чеке.
        /// </summary>
        [JsonProperty("order")]
        public PurchaseOrder Order { get; set; }

        /// <summary>
        /// Идентификатор операции списания.
        /// Указывается, если необходимо связать операцию покупки с операцией списания (например, для осуществления будущего возврата).
        /// </summary>
        public int? WriteOffOperationId { get; set; }

        /// <summary>
        /// Код идентификации (OTP-код подтверждения из СМС).
        /// </summary>
        [JsonProperty("identCode")]
        public int? IdentCode { get; set; }

        // <summary>
        /// Дополнительные параметры.
        /// </summary>
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
    }
}