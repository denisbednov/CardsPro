using Newtonsoft.Json;
using CardsPro.Models.Request;

namespace CardsPro.Models.Dto
{
    public class WriteOffDto : BaseDto
    {   
        [JsonProperty("writeOffRequest")]
        public WriteOffRequest WriteOffRequest { get; set; }
    }
}