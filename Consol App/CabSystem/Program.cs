using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CSB_DATAACCESS;
using CSB.MODULE;
namespace CabSystem
{
    class Program 
    {
        static void Main(string[] args)
        {
            //BookingDetail bookingDetail = new BookingDetail();
            //bookingDetail.charge = 100;
            //locationMapping lm = new locationMapping();
            //lm.id = 1;
            //Console.WriteLine(bookingDetail.charge);
            //Console.WriteLine(lm.id );
            //Console.ReadKey();
            new spd().spuserdetail();
        }
    }
}
