using Newtonsoft.Json;
using CardsPro.Models.Request;

namespace CardsPro.Models.Dto
{
    public class RefundDto : BaseDto
    {
        /// <summary>
        /// Параметры возврата.
        /// </summary>
        [JsonProperty("refundRequest")]
        public RefundRequest RefundRequest { get; set; }
    }
}