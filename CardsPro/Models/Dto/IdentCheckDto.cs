using Newtonsoft.Json;

namespace CardsPro.Models.Dto
{
    public class IdentCheckDto : BaseDto
    {
        /// <summary>
        /// Номер телефона. Формат: +7ХХХХХХХХХХ.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Код идентификации (код подтверждения из СМС).
        /// </summary>
        [JsonProperty("identCode")]        
        public int IdentCode { get; set; }

        /// <summary>
        /// Дополнительные параметры.
        /// </summary>
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
    }
}