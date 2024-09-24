using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_1
{
    public enum ClassificationType
    {
        [Description("project")] project,
        [Description("invoice")] invoice,
        [Description("employee")] employee,
        [Description("vehicle")] vehicle,
        [Description("office")] office
    }
}
