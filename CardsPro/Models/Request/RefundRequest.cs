using Newtonsoft.Json;

namespace CardsPro.Models.Request
{
    public class RefundRequest : BaseRequest
    {
        /// <summary>
        /// Идентификатор операции.
        /// </summary>
        [JsonProperty("operationId")]
        public int OperationId { get; set; }

        /// <summary>
        /// Сумма возврата для возврата по операции списания 
        /// или сумма возврата при частичном возврате покупки.
        /// </summary>
        [JsonProperty("refundAmount")]
        public int? RefundAmount { get; set; }

        /// <summary>
        /// Информация о возвращаемых товарах.
        /// </summary>
        [JsonProperty("reversedPurchaseOrder")]
        public PurchaseOrder ReversedPurchaseOrder { get; set; }

        /// <summary>
        /// Дополнительные параметры.
        /// </summary>
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
    }
}