using Newtonsoft.Json;
using CardsPro.Models.Request;

namespace CardsPro.Models.Dto
{
    public class PasswordRestoreDto : BaseDto
    {
        /// <summary>
        /// Данные для восстановления пароля.
        /// </summary>
        [JsonProperty("restorePasswordRequest")]
        public RestorePasswordRequest RestorePasswordRequest { get; set; }
    }
}