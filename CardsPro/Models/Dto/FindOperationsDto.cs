using Newtonsoft.Json;
using CardsPro.Models.Request;

namespace CardsPro.Models.Dto
{
    public class FindOperationsDto : BaseDto
    {
        [JsonProperty("operationsRequest")]
        public OperationsRequest OperationsRequest { get; set; }
    }
}