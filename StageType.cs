using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_1
{
    public enum StageType
    {
        [Description("preparing underground frastructure")] preparingUndergroundFrastructure,
        [Description("pipeline layout")] pipelineLayout,
        [Description("final installation")] finalInstallation
    }
}
