using Newtonsoft.Json;

namespace CardsPro.Models.Request
{
    /// <summary>
    /// Параметры активации.
    /// </summary>
    public class CardActivateRequest : BaseRequest
    {
        /// <summary>
        /// Идентификационный код (OTP-код подтверждения из СМС).
        /// </summary>
        [JsonProperty("identCode")]
        public int? IdentCode { get; set; }

        /// <summary>
        /// Блок с информацией о клиенте (анкетные данные).
        /// </summary>
        [JsonProperty("user")]
        public UserForm User { get; set; }

        /// <summary>
        /// Цена проданной карты. По умолчанию в копейках.
        /// </summary>
        [JsonProperty("price")]
        public int? Price { get; set; }

        /// <summary>
        /// Если true, то активация будет проходить без проверки кода идентификации (из СМС).
        /// По умолчанию false.
        /// Возможность использования данного параметра настраивается на процессинге.
        /// На телефон клиента будет отправлена СМС со ссылкой, после прохождения по которой произойдет активация карты.
        /// </summary>
        [JsonProperty("offline")]
        public bool? Offline { get; set; }

        /// <summary>
        /// При обычной классической оффлайн активации (отправка токена регистрации на телеофн клиента по СМС и последующая активации через ЛКК), параметр можно не задавать.
        /// Параметр используется только на втором этапе оффлайн активации на кассе или приложении партнёра.На кассе заполняется блок user и передаётся accepted = true.
        /// </summary>
        [JsonProperty("accepted")]
        public bool? Accepted { get; set; }

        /// <summary>
        /// Передает значение промо-кода.
        /// </summary>
        [JsonProperty("promoCode")]
        public string PromoCode { get; set; }
    }
}