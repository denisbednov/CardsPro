using Newtonsoft.Json;
using CardsPro.Models.Request;

namespace CardsPro.Models.Dto
{
    public class OperationInfoExpandDto : BaseDto
    {
        [JsonProperty("data")]
        public ExpandedOperationsRequest ExpandedOperationsRequest { get; set; }
    }
}