using Newtonsoft.Json;

namespace Roblox.AccountInformation.Models;

public class PhoneResponse : Phone
{
    [JsonProperty("isVerified")] public bool IsVerified { get; set; }

    [JsonProperty("verificationCodeLength")]
    public int VerificationCodeLength { get; set; }

    [JsonProperty("canBypassPasswordForPhoneUpdate")]
    public bool CanBypassPasswordForPhoneUpdate { get; set; }
}