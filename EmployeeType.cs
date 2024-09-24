using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_1
{
    public enum EmployeeType
    {
        [Description("team worker")] teamWorker,
        [Description("office manager")] officeManager,
        [Description("project manager")] projectmanager,
        [Description("vice president")] vicePresident,
        [Description("CEO")] ceo
    }
}
