using Newtonsoft.Json;

namespace Roblox.AccountInformation.Models
{
    public class AccountInformationMetadata
    {
        [JsonProperty("isAllowedNotificationsEndpointDisabled")]
        public bool IsAllowedNotificationsEndpointDisabled { get; set; }

        [JsonProperty("isAccountSettingsPolicyEnabled")]
        public bool IsAccountSettingsPolicyEnabled { get; set; }

        [JsonProperty("isPhoneNumberEnabled")] public bool IsPhoneNumberEnabled { get; set; }

        [JsonProperty("MaxUserDescriptionLength")]
        public int MaxUserDescriptionLength { get; set; }

        [JsonProperty("isUserDescriptionEnabled")]
        public bool IsUserDescriptionEnabled { get; set; }

        [JsonProperty("isUserBlockEndpointsUpdated")]
        public bool IsUserBlockEndpointsUpdated { get; set; }

        [JsonProperty("isPasswordRequiredForAgingDown")]
        public bool IsPasswordRequiredForAgingDown { get; set; }
    }
}