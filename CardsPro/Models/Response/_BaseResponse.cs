using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CardsPro.Models.Response
{
    public class BaseResponse
    {
        /// <summary>
        /// Блок с информацией об ошибках.
        /// </summary>
        [JsonProperty("errorMessages")]
        public List<ErrorMessage> ErrorMessages { get; set; }

        /// <summary>
        /// Идентификатор операции.
        /// </summary>
        [JsonProperty("operationId")]
        public int? OperationId { get; set; }

        /// <summary>
        /// Уникальный идентификатор от партнера, генерирующийся на его стороне (необходим для идентификации запроса и ответа).
        /// </summary>
        [JsonProperty("requestId")]
        public Guid RequestId { get; set; }

        /// <summary>
        /// Код партнёра.
        /// </summary>
        [JsonProperty("partnerCode")]
        public string PartnerCode { get; set; }
    }
}