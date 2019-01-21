using Newtonsoft.Json;
using System.Collections.Generic;

namespace CardsPro.Models.Response
{
    public class CardInfoResponse : BaseResponse
    {
        /// <summary>
        /// Блок с информацией о карте.
        /// </summary>
        [JsonProperty("cardInfo")]
        public CardInfo CardInfo { get; set; }

        /// <summary>
        /// Информационное сообщение.
        /// Например, может использоваться для печати в чеке.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}