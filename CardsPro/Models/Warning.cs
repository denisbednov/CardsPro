using Newtonsoft.Json;

namespace CardsPro.Models
{
    public class Warning
    {
        /// <summary>
        /// Предупреждение.
        /// </summary>
        [JsonProperty("warningMessage")]
        public string Message { get; set; }
    }
}