namespace CardsPro.Enums
{
    /// <summary>
    /// Тип платежного инструмента.
    /// </summary>
    public enum PaymentType
    {
        /// <summary>
        /// Бонусы партнёра.
        /// </summary>
        BONUS,

        /// <summary>
        /// Бонусы CardsPro.
        /// </summary>
        BONUS_CARDSPRO,

        /// <summary>
        /// Наличные.
        /// </summary>
        CASH,

        /// <summary>
        /// Скидка.
        /// </summary>
        DISCOUNT,

        /// <summary>
        /// Наценка.
        /// </summary>
        EXTRA_CHARGE,

        /// <summary>
        /// Тип оплаты для подарка, начисленного клиенту.
        /// Передаётся при списании подарка, который был начислен клиенту по какой-либо акции.
        /// </summary>
        GIFT,

        /// <summary>
        /// Иное.
        /// </summary>
        OTHER,

        /// <summary>
        /// Платежная система (например, банковской картой).
        /// </summary>
        PAYMENT_SYSTEM
    }
}