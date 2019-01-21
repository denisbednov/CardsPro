using Newtonsoft.Json;
using CardsPro.Models.Request;

namespace CardsPro.Models.Dto
{
    public class PurchaseDto : BaseDto
    {
        [JsonProperty("purchaseRequest")]
        public PurchaseRequest PurchaseRequest { get; set; }
    }
}