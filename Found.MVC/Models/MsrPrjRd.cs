using System;
using System.Collections.Generic;

namespace Found.MVC.Models
{
    public partial class MsrPrjRd
    {
        public MsrPrjRd()
        {
            MsrPntRd = new HashSet<MsrPntRd>();
        }

        public string MsrPrjRdId { get; set; }
        public string PrjStrcId { get; set; }
        public string MsrTpCd { get; set; }
        public string MsrPrjNm { get; set; }
        public string UntNm { get; set; }
        public decimal? WrnCtrlTV { get; set; }
        public decimal? WrnCtrlRV { get; set; }
        public decimal? WrnRTP { get; set; }
        public decimal? WrnOTP { get; set; }
        public decimal? WrnYTP { get; set; }
        public decimal? WrnRRP { get; set; }
        public decimal? WrnORP { get; set; }
        public decimal? WrnYRP { get; set; }
        public decimal? WrnRTV { get; set; }
        public decimal? WrnOTV { get; set; }
        public decimal? WrnYTV { get; set; }
        public decimal? WrnRRV { get; set; }
        public decimal? WrnORV { get; set; }
        public decimal? WrnYRV { get; set; }
        public short? IsAsm { get; set; }
        public string Dscr { get; set; }
        public DateTime? CrtTm { get; set; }
        public DateTime? UpdTm { get; set; }
        public string CrtUsrId { get; set; }
        public string UpdUsrId { get; set; }
        public short? Vld { get; set; }
        public string MsrPntMarked { get; set; }
        public string MsrDtSrc { get; set; }

        public ICollection<MsrPntRd> MsrPntRd { get; set; }
    }
}
