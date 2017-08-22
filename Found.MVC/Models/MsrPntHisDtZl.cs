using System;
using System.Collections.Generic;

namespace Found.MVC.Models
{
    public partial class MsrPntHisDtZl
    {
        public string MsrPntHisDtZlId { get; set; }
        public string MsrPntRdId { get; set; }
        public DateTime MsrTm { get; set; }
        public string MsrPntNm { get; set; }
        public decimal? KValue { get; set; }
        public decimal? InitValue { get; set; }
        public decimal? CutValue { get; set; }
        public decimal? AxlValue { get; set; }
        public decimal? ThisDefAxlValue { get; set; }
        public decimal? TotalDefAxlValue { get; set; }
        public decimal? WrnValue { get; set; }
        public decimal? CtlValue { get; set; }
        public string DtSrc { get; set; }
        public DateTime? CrtTm { get; set; }
        public DateTime? UpdTm { get; set; }
        public string CrtUsrId { get; set; }
        public string UpdUsrId { get; set; }
        public short? Vld { get; set; }
        public string MsrPntAmsId { get; set; }

        public MsrPntRd MsrPntRd { get; set; }
    }
}
