using Newtonsoft.Json;

namespace CardsPro.Models.Dto
{
    public class IssueCardDto : BaseDto
    {
        [JsonProperty("userForm")]
        public UserForm User { get; set; }

        [JsonProperty("productCode")]
        public string ProductCode { get; set; }

        [JsonProperty("identCode")]
        public int? IdentCode { get; set; }

        [JsonProperty("designCode")]
        public string DesignCode { get; set; }

        [JsonProperty("originalBarcode")]
        public string OriginalBarcode { get; set; }

        [JsonProperty("originalCardIdentifier")]
        public CardIdentifier OriginalCardIdentifier { get; set; }

        [JsonProperty("issueCardBarcode")]
        public string IssueCardBarcode { get; set; }

        [JsonProperty("issueCardIdentifier")]
        public CardIdentifier IssueCardIdentifier { get; set; }

        [JsonProperty("offline")]
        public bool Offline { get; set; }

        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }

        [JsonProperty("promoCode")]
        public string PromoCode { get; set; }

        [JsonProperty("newExternalId")]
        public string NewExternalId { get; set; }
    }
}