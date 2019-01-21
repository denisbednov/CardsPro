using Newtonsoft.Json;

namespace CardsPro.Models.Request
{
    /// <summary>
    /// Параметры отмены.
    /// </summary>
    public class CancelRequest : BaseRequest
    {
        /// <summary>
        /// Идентификатор операции.
        /// </summary>
        [JsonProperty("operationId")]
        public int OperationId { get; set; }

        /// <summary>
        /// Дополнителные параметры.
        /// </summary>
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
    }
}