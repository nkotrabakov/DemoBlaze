using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBlaze.Common.Helpers
{
    public class Helper
    { 
        public static string GetRandomUser()
        {
            Random random = new Random();

            string user = string.Format("test{0:000000}", random.Next(100000));

            return user;
        }
    }
}