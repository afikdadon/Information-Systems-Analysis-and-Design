using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_1
{
    public enum Invoicestatus
    {
        [Description("invoice is not checked yet")] invoiceIsNotCheckedYet,
        [Description("invoice in negotiation")] invoiceInNegotiation,
        [Description("invoice incorrect")] invoiceIncorrect,
        [Description("invoice ready for payment")] invoiceReadyForPayment,
        [Description("invoice is placed")] invoiceIsPlaced,
        [Description("invoice archived")] invoiceArchived,
        [Description("invoice is deleted")] invoiceIsDeleted
    }
}
