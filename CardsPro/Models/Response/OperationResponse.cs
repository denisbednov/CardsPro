using Newtonsoft.Json;
using System.Collections.Generic;

namespace CardsPro.Models.Response
{
    public class OperationResponse : BaseResponse
    {
        /// <summary>
        /// Операции.
        /// </summary>
        [JsonProperty("operations")]
        public List<Operation> Operations { get; set; }
    }
}