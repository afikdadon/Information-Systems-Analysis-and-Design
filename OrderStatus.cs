using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_1
{
    public enum OrderStatus
    {
        [Description("order is not sent to supplier")] orderIsNotSentToSupplier,
        [Description("order is sent to supplier")] orderIsSentToSupplier,
        [Description("order received")] orderReceived,
        [Description("order has missing products")] orderHasMissingProducts,
        [Description("order is archived")] orderIsArchived,
        [Description("order is deleted")] orderIsDeleted

    }
}
