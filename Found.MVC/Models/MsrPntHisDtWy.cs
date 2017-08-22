using System;
using System.Collections.Generic;

namespace Found.MVC.Models
{
    public partial class MsrPntHisDtWy
    {
        public string MsrPntHisDtWyId { get; set; }
        public string MsrPntRdId { get; set; }
        public DateTime MsrTm { get; set; }
        public string MsrPntNm { get; set; }
        public decimal? InitValueX { get; set; }
        public decimal? InitValueY { get; set; }
        public decimal? LastCutValueY { get; set; }
        public decimal? LastCutValueX { get; set; }
        public decimal? ThisCutValueY { get; set; }
        public decimal? ThisCutValueX { get; set; }
        public decimal? DefRateValueY { get; set; }
        public decimal? DefRateValueX { get; set; }
        public decimal? ThisDefValueX { get; set; }
        public decimal? ThisDefValueY { get; set; }
        public decimal? TotalDefValueY { get; set; }
        public decimal? TotalDefValueX { get; set; }
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
