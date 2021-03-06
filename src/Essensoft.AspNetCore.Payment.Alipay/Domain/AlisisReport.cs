using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlisisReport Data Structure.
    /// </summary>
    public class AlisisReport : AlipayObject
    {
        /// <summary>
        /// ：   报表可过滤字段条件
        /// </summary>
        [JsonProperty("conditions")]
        public List<ReportCondition> Conditions { get; set; }

        /// <summary>
        /// 报表描述
        /// </summary>
        [JsonProperty("report_desc")]
        public string ReportDesc { get; set; }

        /// <summary>
        /// 报表名称
        /// </summary>
        [JsonProperty("report_name")]
        public string ReportName { get; set; }

        /// <summary>
        /// 报表唯一标识
        /// </summary>
        [JsonProperty("report_uk")]
        public string ReportUk { get; set; }
    }
}
