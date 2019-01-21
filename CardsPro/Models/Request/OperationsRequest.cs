using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using CardsPro.Enums;
using System;
using System.Collections.Generic;

namespace CardsPro.Models.Request
{
    /// <summary>
    /// Параметры запрашиваемых операций.
    /// </summary>
    public class OperationsRequest : BaseRequest
    {
        /// <summary>
        /// Начальная дата (включительно).
        /// </summary>
        [JsonProperty("dateFrom")]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Конечная дата (включительно).
        /// </summary>
        [JsonProperty("dateTo")]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Количество выводимых страниц и операций.
        /// </summary>
        [JsonProperty("pageable")]
        public Pageable Pageable { get; set; }

        /// <summary>
        /// Точка продаж.
        /// </summary>
        [JsonProperty("partnerNodeCode")]
        public string PartnerNodeCode { get; set; }

        /// <summary>
        /// Показывать ли отмененные операции.
        /// </summary>
        [JsonProperty("cancelled")]
        public bool? Cancelled { get; set; }

        /// <summary>
        /// Типы операций.
        /// </summary>
        [JsonProperty("types")]
        [JsonConverter(typeof(StringEnumConverter))]
        public List<OperationType> Types { get; set; }

        /// <summary>
        /// Порядок сортировки по дате операции.
        /// </summary>
        [JsonProperty("order")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SortOrder? Order { get; set; }

        /// <summary>
        /// Дополнителная информация.
        /// </summary>
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Тип продукта (карты).
        /// </summary>
        [JsonProperty("productKinds")]
        [JsonConverter(typeof(StringEnumConverter))]
        public List<CardKind> ProductKinds { get; set; }
    }
}