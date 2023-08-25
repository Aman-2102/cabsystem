using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSB.MODULE
{
    public class BookingDetail 
    {
        public int BookingId { get; set; }
        public int UserDriveId { get; set; }
        public int Driverid { get; set; }
        public int charge { get; set; }
        public int paymentType { get; set; }
        public int BookingTime { get; set; }
    }
}
