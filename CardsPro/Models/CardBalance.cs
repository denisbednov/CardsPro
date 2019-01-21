using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using CardsPro.Enums;
using CardsPro.Models.Dto;
using System;
using System.Collections.Generic;

namespace CardsPro.Models
{
    public class CardBalance
    {
        /// <summary>
        /// Дата активации счёта (баланса) карты.
        /// </summary>
        [JsonProperty("activatedAt")]
        public DateTime? ActivatedAt { get; set; }

        /// <summary>
        /// Дата истечения срока действия счёта карты.
        /// </summary>
        [JsonProperty("expireDate")]
        public DateTime? ExpireDate { get; set; }

        /// <summary>
        /// Дизайн карты для определенного счёта.
        /// </summary>
        [JsonProperty("design")]
        public CardDesign Design { get; set; }

        /// <summary>
        /// Сумма всех начисленных бонусов.
        /// </summary>
        [JsonProperty("earnedAmount")]
        public int? EarnedAmount { get; set; }

        /// <summary>
        /// Сумма бонусов, ожидающих начисления (захолдированные).
        /// </summary>
        [JsonProperty("holdPointsAmount")]
        public int? HoldPointsAmount { get; set; }

        /// <summary>
        /// Параметр, определяющий нужно ли запрашивать PIN-код при списании.
        /// </summary>
        [JsonProperty("pinExists")]
        public bool? PinExists { get; set; }

        /// <summary>
        /// Доступный баланс.
        /// </summary>
        [JsonProperty("pointsAmount")]
        public int? PointsAmount { get; set; }

        /// <summary>
        /// Идентификатор продукта.
        /// </summary>
        [JsonProperty("productId")]
        public int? ProductId { get; set; }

        /// <summary>
        /// Код продукта.
        /// </summary>
        [JsonProperty("productCode")]
        public string ProductCode { get; set; }

        /// <summary>
        /// Название продукта.
        /// </summary>
        [JsonProperty("productName")]
        public string ProductName { get; set; }

        /// <summary>
        /// Тип продукта (баллы, проходы).
        /// </summary>
        [JsonProperty("productType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ProductType ProductType { get; set; }

        /// <summary>
        /// Код дизайна продукта.
        /// </summary>
        [JsonProperty("productDesignCode")]
        public string ProductDesignCode { get; set; }

        /// <summary>
        /// Количество оставшихся (доступных) списаний/услуг (значение уменьшается после каждого списания с карты).
        /// </summary>
        [JsonProperty("purchaseCount")]
        public int? PurchaseCount { get; set; }

        /// <summary>
        /// Сумма покупок.
        /// </summary>
        [JsonProperty("purchaseAmount")]
        public int? PurchaseAmount { get; set; }

        /// <summary>
        /// Статус счёта карты.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Код статуса счёта карты.
        /// </summary>
        [JsonProperty("statusCode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BalanceStatus StatusCode { get; set; }

        /// <summary>
        /// Количество оставшихся пополнений карты (значение уменьшается после каждого пополнения).
        /// </summary>
        [JsonProperty("topUpCount")]
        public int? TopUpCount { get; set; }

        /// <summary>
        /// Ссылка на описание карты.
        /// </summary>
        [JsonProperty("descriptionUrl")]
        public string DescriptionUrl { get; set; }

        /// <summary>
        /// Тип счёта карты (баланса).
        /// </summary>
        [JsonProperty("kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CardKind Kind { get; set; }

        /// <summary>
        /// Информация о уровне лояльности (ранге) карты.
        /// </summary>
        [JsonProperty("loyaltyLevel")]
        public LoyaltyLevelDto LoyaltyLevel { get; set; }

        /// <summary>
        /// Блок с информацией о подарках, акционных товарах.
        /// </summary>
        [JsonProperty("gifts")]
        public List<GiftDto> Gifts { get; set; }
    }
}