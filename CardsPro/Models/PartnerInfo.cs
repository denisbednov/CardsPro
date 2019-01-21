using Newtonsoft.Json;
using CardsPro.Core;
using System;

namespace CardsPro.Models
{
    public class PartnerInfo
    {
        /// <summary>
        /// Уникальное ID запроса.
        /// </summary>
        [JsonProperty("requestId")]
        public Guid RequestId { get; set; }

        /// <summary>
        /// Код точки партнера.
        /// </summary>
        [JsonProperty("partnerCode")]
        public string PartnerCode { get; set; }

        /// <summary>
        /// Дата и время формирования запроса.
        /// </summary>
        [JsonProperty("requestDate")]
        public DateTime RequestDate { get; set; }

        /// <summary>
        /// Id заказа.
        /// </summary>
        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        [JsonProperty("userIdentifier")]
        public string UserIdentifier { get; set; }

        /// <summary>
        /// Валюта.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonConstructor]
        public PartnerInfo()
        {
        }

        public PartnerInfo(string partnerCode, Guid? requestId = null, DateTime? requestDate = null)
        {
            partnerCode.ThrowIfNullOrWhiteSpace(nameof(partnerCode));

            PartnerCode = partnerCode;
            RequestId = requestId ?? Guid.NewGuid();
            RequestDate = requestDate ?? DateTime.UtcNow;
        }
    }
}