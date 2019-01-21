using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using CardsPro.Enums;
using CardsPro.Models.Dto;
using System;
using System.Collections.Generic;

namespace CardsPro.Models
{
    public class Operation
    {
        /// <summary>
        /// Внутренний идентификатор операции.
        /// </summary>
        [JsonProperty("identifier")]
        public int? Identifier { get; set; }

        /// <summary>
        /// Информация о точке, на которой совершена операция.
        /// </summary>
        [JsonProperty("node")]
        public PartnerNode node { get; set; }

        /// <summary>
        /// Дата/время операции.
        /// </summary>
        [JsonProperty("operationDate")]
        public DateTime? OperationDate { get; set; }

        /// <summary>
        /// Тип операции.
        /// </summary>
        [JsonProperty("operationType")]
        public string OperationType { get; set; }

        /// <summary>
        /// Код типа операции.
        /// </summary>
        [JsonProperty("operationTypeCode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OperationType OperationTypeCode { get; set; }

        /// <summary>
        /// Сумма баллов, потраченная в рамках операции.
        /// </summary>
        [JsonProperty("pointsAmount")]
        public int? PointsAmount { get; set; }

        /// <summary>
        /// Информация о продукте, по которому совершена операция.
        /// </summary>
        [JsonProperty("product")]
        public GiftProduct Product { get; set; }

        /// <summary>
        /// Информация о покупке (для типа операции PURCHASE).
        /// </summary>
        [JsonProperty("product")]
        public PartnerOrderDto Order { get; set; }

        /// <summary>
        /// 19-значный номер карты.
        /// </summary>
        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// Короткий номер карты.
        /// </summary>
        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// Признак отмененной операции.
        /// </summary>
        [JsonProperty("cancelled")]
        public bool? Cancelled { get; set; }

        /// <summary>
        /// Код валюты (единицы измерения), в которых проведена операция.
        /// </summary>
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Сумма начисленных бонусов.
        /// </summary>
        [JsonProperty("earnedPoints")]
        public int? EarnedPoints { get; set; }

        /// <summary>
        /// Информация о типах начисленных бонусов (типы бонусов = ['EARN', 'GIFT', 'EVENT', 'DISCOUNT']) и их сумма.
        /// </summary>
        [JsonProperty("earnedPointsAmountByType")]
        public string EarnedPointsAmountByType { get; set; } // TODO: ???

        /// <summary>
        /// Информация о подарках.
        /// </summary>
        [JsonProperty("gifts")]
        public List<GiftDto> Gifts { get; set; }

        /// <summary>
        /// Связанные операции.
        /// </summary>
        [JsonProperty("linkedOperations")]
        public List<OperationDto> LinkedOperations { get; set; }

        /// <summary>
        /// Родительсткая операция.
        /// </summary>
        [JsonProperty("parentOperation")]
        public OperationDto ParentOperation { get; set; }

        /// <summary>
        /// Сумма списанных бонусов.
        /// </summary>
        [JsonProperty("spendBonuses")]
        public int? SpendBonuses { get; set; }

        /// <summary>
        /// Информация о транзациях.
        /// </summary>
        [JsonProperty("transactions")]
        public List<TransactionDto> Transactions { get; set; }
    }
}