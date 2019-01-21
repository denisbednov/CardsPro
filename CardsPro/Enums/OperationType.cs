namespace CardsPro.Enums
{
    /// <summary>
    /// Тип операции.
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// Активация.
        /// </summary>
        ACTIVATION,

        ACTIVATION_OFFLINE,

        ASK_CARD_OPERATIONS,

        ASK_GIFT_CARD_INFO,

        ASK_PARTNER_CARD_INFO,

        BALANCE_CANCEL,

        BLOCK,

        BONUS_ACTIVATION,

        CANCEL,

        CHANGE_LOYALTY_LEVEL,

        CHECK_IDENT,

        DISCOUNT_CALCULATION,

        EARNING_GIFT,

        EARNING_POINTS,

        EARNING_POINTS_CALCULATION,

        EXPIRATION,

        EXPIRATION_POINTS,

        IDENTIFY_CARD_BY_BARCODE,

        IDENTIFY_CARD_BY_HASH,

        IDENTIFY_CARD_BY_MAGNETIC_TRACK,

        IDENTIFY_CARD_BY_PHONE,

        ISSUE_CARD,

        ISSUE_PHYSICAL_CARD,

        /// <summary>
        /// Покупка.
        /// </summary>
        PURCHASE,

        REFUND,

        RESTORE_PASSWORD,

        STATUS_RESET,

        SEARCH_USER_CARD,

        SEND_IDENT,

        TOP_UP,

        UNBLOCK,

        UPDATE_USER_INFO,

        /// <summary>
        /// Списание.
        /// </summary>
        WRITE_OFF
    }
}