using Newtonsoft.Json;

namespace CardsPro.Models.Response
{
    public class WriteOffResponse : BaseResponse
    {
        /// <summary>
        /// Информационное сообщение.
        /// Например, может использоваться для печати в чеке.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}