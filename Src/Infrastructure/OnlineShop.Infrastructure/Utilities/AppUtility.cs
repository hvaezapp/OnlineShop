using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Utilities
{
    public static class AppUtility
    {

        public static string GetGuid() => Guid.NewGuid()
                                           .ToString()
                                           .Replace("-","");

        public static int ToInt(this object val)
        {
            return Convert.ToInt32(val);
        }
        public static byte ToByte(this object val)
        {
            return Convert.ToByte(val);
        }

        public static long ToLong(this object val)
        {
            return Convert.ToInt64(val);
        }

        public static decimal ToDecimal(this object val)
        {
            return Convert.ToDecimal(val);
        }

    }
}
