using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLicensedConsoleApp
{
    public class SystemDateTimeProvider
    {
        public SystemDateTimeProvider()
        {
        }

        public DateTime GetDateTime()
        {
            return System.DateTime.Now;
        }

        public void WriteDateTime()
        {
            Console.WriteLine("{0}", this.GetDateTime());
        }
    }
}
