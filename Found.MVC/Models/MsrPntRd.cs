using System;
using System.Collections.Generic;

namespace Found.MVC.Models
{
    public partial class MsrPntRd
    {
        public MsrPntRd()
        {
            MsrPntHisDtCj = new HashSet<MsrPntHisDtCj>();
            MsrPntHisDtWy = new HashSet<MsrPntHisDtWy>();
            MsrPntHisDtZl = new HashSet<MsrPntHisDtZl>();
        }

        public string MsrPntRdId { get; set; }
        public string MsrPrjRdId { get; set; }
        public string BimMdlId { get; set; }
        public string MsrTpCd { get; set; }
        public string MsrPntNm { get; set; }
        public short? IsAsm { get; set; }
        public string Dscr { get; set; }
        public string MsrSt { get; set; }
        public string WrnLvlTpCdC { get; set; }
        public string WrnLvlTpCdR { get; set; }
        public DateTime? CrtTm { get; set; }
        public DateTime? UpdTm { get; set; }
        public string CrtUsrId { get; set; }
        public string UpdUsrId { get; set; }
        public short? Vld { get; set; }

        public MsrPrjRd MsrPrjRd { get; set; }
        public ICollection<MsrPntHisDtCj> MsrPntHisDtCj { get; set; }
        public ICollection<MsrPntHisDtWy> MsrPntHisDtWy { get; set; }
        public ICollection<MsrPntHisDtZl> MsrPntHisDtZl { get; set; }
    }
}
