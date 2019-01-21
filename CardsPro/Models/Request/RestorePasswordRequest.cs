using Newtonsoft.Json;

namespace CardsPro.Models.Request
{
    /// <summary>
    /// Данные для восстановления пароля.
    /// </summary>
    public class RestorePasswordRequest : BaseRequest
    {
        /// <summary>
        /// Код идентификации (код подтверждения из СМС).
        /// </summary>
        [JsonProperty("identCode")]
        public int IdentCode { get; set; }

        /// <summary>
        /// Дополнительная информация.
        /// </summary>
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
    }
}