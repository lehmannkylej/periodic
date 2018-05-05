using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Periodic.Services;
using System.Threading.Tasks;

namespace Periodic.Services
{
    public class GetDateAndTime
    {
        public static string GetDate()
        {
            DateTime date = DateTime.Now;
            string format = "ddd, MMMMM d";
            return date.ToString(format);
        }
    }
}
