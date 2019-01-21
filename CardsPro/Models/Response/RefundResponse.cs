using Newtonsoft.Json;

namespace CardsPro.Models.Response
{
    public class RefundResponse : BaseResponse
    {
        /// <summary>
        /// Информация о возвращаемых товарах.
        /// </summary>
        [JsonProperty("reversedPurchaseOrder")]
        public PurchaseOrder ReversedPurchaseOrder { get; set; }
    }
}