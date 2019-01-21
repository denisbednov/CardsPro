using Newtonsoft.Json;
using System.Collections.Generic;

namespace CardsPro.Models.Response
{
    public class CardSearchResponse : BaseResponse
    {
        /// <summary>
        /// Информация о картах.
        /// </summary>
        [JsonProperty("userCard")]
        public List<CardInfo> UserCard { get; set; }
    }
}