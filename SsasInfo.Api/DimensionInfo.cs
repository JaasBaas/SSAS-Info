using Microsoft.AnalysisServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SsasInfo.Api
{
    public class DimensionInfo:DatabaseInfo
    {
        public DimensionInfo()
        {
            this.ObjectType = DatabaseObjectType.Dimension;
        }

        internal Dimension DimensionInternal { get; set; }
    }
}
