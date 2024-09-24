using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_1
{
    public enum Status
    {
        [Description("didnt start progress")] didntStartProgress,
        [Description("in progress")] inProgress,
        [Description("completed")] completed
    }
}
