using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOCH
{
    /// <summary>
    /// KOCH interview ToSafeInt extension method
    /// Author: Colin Gilbert
    /// </summary>
    public static class ExtensionMethod
    {
        public static int ToSafeInt(this string str, int defaultValue)
        {
            try
            {
                var intValue = Convert.ToInt32(str);
                Console.WriteLine($"value ({str}) converted successfully in extension method!");
                return intValue;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine($"could not convert value ('{str}') successfully in extension method.");
                Console.WriteLine($"returning default value supplied ({defaultValue}) instead");
                return defaultValue;
            }
        }
    }
}
