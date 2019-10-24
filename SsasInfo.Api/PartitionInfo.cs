using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SsasInfo.Api
{
    public class PartitionInfo:DatabaseInfo
    {
        public PartitionInfo()
        {
            this.ObjectType = DatabaseObjectType.Partition;
        }

        public string MeasureGroupId { get; set; }
        public string MeasureGroupName { get; set; }

        public string CubeId { get; set; }
        public string CubeName { get; set; }

    }
}
