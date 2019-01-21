using Newtonsoft.Json;
using CardsPro.Models.Request;

namespace CardsPro.Models.Dto
{
    public class InfoChangeDto : BaseDto
    {
        /// <summary>
        /// Параметры изменения анкетных данных.
        /// </summary>
        [JsonProperty("request")]
        public UpdateUserInfoRequest Request { get; set; }
    }
}