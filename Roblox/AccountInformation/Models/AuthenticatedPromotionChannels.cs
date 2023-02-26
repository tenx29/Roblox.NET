using Newtonsoft.Json;

namespace Roblox.AccountInformation.Models
{
    public class AuthenticatedPromotionChannels : PromotionChannels
    {
        [JsonProperty("promotionChannelsVisibilityPrivacy")]
        public PromotionChannelsVisibilityPrivacy PromotionChannelsVisibilityPrivacy { get; set; }
    }
}