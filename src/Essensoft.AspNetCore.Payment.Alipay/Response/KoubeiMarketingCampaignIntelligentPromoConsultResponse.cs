using Newtonsoft.Json;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoConsultResponse.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentPromoConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 智能营销方案咨询的模型
        /// </summary>
        [JsonProperty("promo")]
        public IntelligentPromo Promo { get; set; }
    }
}
