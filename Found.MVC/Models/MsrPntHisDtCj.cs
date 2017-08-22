using System;
using System.Collections.Generic;

namespace Found.MVC.Models
{
    public partial class MsrPntHisDtCj
    {
        public string MsrPntHisDtCjId { get; set; }
        public string MsrPntRdId { get; set; }
        public DateTime MsrTm { get; set; }
        public string MsrPntNm { get; set; }
        public decimal? InitValue { get; set; }
        public decimal? CutValue { get; set; }
        public decimal? ThisDefValue { get; set; }
        public decimal? TotalDefValue { get; set; }
        public decimal? DefRateValue { get; set; }
        public decimal? WrnValue { get; set; }
        public decimal? CtlValue { get; set; }
        public string DtSrc { get; set; }
        public decimal? Extend1 { get; set; }
        public decimal? Extend2 { get; set; }
        public decimal? Extend3 { get; set; }
        public decimal? Extend4 { get; set; }
        public decimal? Extend5 { get; set; }
        public decimal? Extend6 { get; set; }
        public DateTime? CrtTm { get; set; }
        public DateTime? UpdTm { get; set; }
        public string CrtUsrId { get; set; }
        public string UpdUsrId { get; set; }
        public short? Vld { get; set; }
        public string MsrPntAmsId { get; set; }

        public MsrPntRd MsrPntRd { get; set; }
    }
}
