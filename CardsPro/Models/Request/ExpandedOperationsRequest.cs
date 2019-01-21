using Newtonsoft.Json;
using System;

namespace CardsPro.Models.Request
{
    public class ExpandedOperationsRequest
    {
        /// <summary>
        /// Идентификатор операции.
        /// </summary>
        [JsonProperty("operationId")]
        public int? OperationId { get; set; }

        /// <summary>
        /// Уникальный идентификатор операции, по которой запрашивается информация.
        /// </summary>
        [JsonProperty("requestId")]
        public Guid RequestId { get; set; }

        /// <summary>
        /// Номер чека.
        /// </summary>
        [JsonProperty("orderNumber")]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Дополнительные параметры.
        /// </summary>
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }

        public ExpandedOperationsRequest()
        {
            RequestId = Guid.NewGuid();
        }
    }
}