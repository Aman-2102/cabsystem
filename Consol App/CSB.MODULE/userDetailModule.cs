using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSB.MODULE
{
   
        public class userdetail : FieldId<int, DateTime>

    {
            public string UserName { get; set; }
            public string Gender { get; set; }
            public int WalletAmount { get; set; }
            public int userType { get; set; }
    }
    
}
