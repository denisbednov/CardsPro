using Newtonsoft.Json;

namespace CardsPro.Models.Response
{
    public class PurchaseResponse : BaseResponse
    {
        /// <summary>
        /// Информационное сообщение.
        /// Например, может использоваться для печати в чеке.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}