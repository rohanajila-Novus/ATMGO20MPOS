using System;
using System.Collections.Generic;

namespace ATMGO20MPOS.Models
{
    public partial class TranTypeAccess
    {
        public int? MainTxnType { get; set; }
        public int? SubTxnType { get; set; }
        public bool? SubTxnAccessible { get; set; }
    }
}
