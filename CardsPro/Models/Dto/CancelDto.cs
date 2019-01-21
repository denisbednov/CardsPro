using Newtonsoft.Json;
using CardsPro.Models.Request;

namespace CardsPro.Models.Dto
{
    public class CancelDto : BaseDto
    {
        [JsonProperty("cancelRequest")]
        public CancelRequest CancelRequest { get; set; }
    }
}