using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOfflineMarketShopSummaryBatchqueryResponse.
    /// </summary>
    public class AlipayOfflineMarketShopSummaryBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonProperty("current_page_no")]
        public string CurrentPageNo { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [JsonProperty("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 支付宝门店摘要信息列表
        /// </summary>
        [JsonProperty("shop_summary_infos")]
        public List<ShopSummaryQueryResponse> ShopSummaryInfos { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonProperty("total_items")]
        public string TotalItems { get; set; }

        /// <summary>
        /// 总页码数目
        /// </summary>
        [JsonProperty("total_page_no")]
        public string TotalPageNo { get; set; }
    }
}
