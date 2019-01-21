using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using CardsPro.Enums;
using System;

namespace CardsPro.Models
{
    /// <summary>
    /// Анкетные данные клиента.
    /// </summary>
    public class UserForm
    {
        /// <summary>
        /// Фамилия.
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Имя.
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Отчество.
        /// </summary>
        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Дата рождения.
        /// </summary>
        [JsonProperty("birthDate")]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Пол.
        /// </summary>
        [JsonProperty("gender")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Gender? Gender { get; set; }

        /// <summary>
        /// Номер телефона в формате +7ХХХХХХХХХХ.
        /// </summary>
        [JsonProperty("cellPhone")]
        public string CellPhone { get; set; }

        /// <summary>
        /// Адрес электронной почты.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Город (адрес).
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Дополнительная информация.
        /// Например, информация о детях держателя карты:
        /// "additionalInfo": "{\"children\":[ {\"name\": \"Jonh\",\"gender\": \"MALE\",\"birthDate\": \"27.08.1992\"}]}"
        /// </summary>
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Идентификатор клиента на процессинге CardsPro (не указывать при активации).
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }
    }
}