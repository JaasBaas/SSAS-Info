using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SsasInfo.Api
{
    public class PartitionInfo
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string State { get; set; }
        public DateTime LastProcessed { get; set; }
        public bool Selected { get; set; } = false;

        public string Display { get
            {
                if (Id == Name)
                    return Name;
                else return $"{Name} ({Id})";
            } }
    }
}
