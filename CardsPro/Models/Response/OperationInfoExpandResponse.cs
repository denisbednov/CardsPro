using Newtonsoft.Json;

namespace CardsPro.Models.Response
{
    public class OperationInfoExpandResponse : BaseResponse
    {
        /// <summary>
        /// Информация об операции.
        /// </summary>
        [JsonProperty("operation")]
        public Operation Operation { get; set; }

        /// <summary>
        /// Информация о чеке.
        /// </summary>
        [JsonProperty("order")]
        public PurchaseOrder Order { get; set; }
    }
}