using Newtonsoft.Json;

namespace CardsPro.Models.Request
{
    /// <summary>
    /// Параметры изменения анкетных данных.
    /// </summary>
    public class UpdateUserInfoRequest
    {
        /// <summary>
        /// Анкетные данные клиента.
        /// </summary>
        [JsonProperty("userForm")]
        public UserForm UserForm { get; set; }

        /// <summary>
        /// Анкетные данные клиента.
        /// </summary>
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
    }
}