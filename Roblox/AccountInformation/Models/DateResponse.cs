using Newtonsoft.Json;

namespace Roblox.AccountInformation.Models
{
    /// <summary>
    ///     Models a date.
    /// </summary>
    public class DateResponse
    {
        /// <summary>
        ///     The day of the month.
        /// </summary>
        [JsonProperty("birthDay")]
        public int Day { get; set; }

        /// <summary>
        ///     The month of the year.
        /// </summary>
        [JsonProperty("birthMonth")]
        public int Month { get; set; }

        /// <summary>
        ///     The year.
        /// </summary>
        [JsonProperty("birthYear")]
        public int Year { get; set; }
    }
}