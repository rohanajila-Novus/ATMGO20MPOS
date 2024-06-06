using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class TblOtherBankBinConfiguration
    {
        public int Bid { get; set; }
        public string BankName { get; set; } = null!;
        public string? BankAbrevation { get; set; }
        public string? IssuerCode { get; set; }
        public long BinNo { get; set; }
        public string? CardName { get; set; }
        public string CardType { get; set; } = null!;
        public string CardBrand { get; set; } = null!;
    }
}
