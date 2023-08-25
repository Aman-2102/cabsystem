using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSB.MODULE
{
    public class locationMapping :FieldId<int,DateTime>
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
    }
}
