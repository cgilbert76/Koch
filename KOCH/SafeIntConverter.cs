using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOCH
{
    /// <summary>
    /// KOCH interview ToSafeInt class method
    /// Author: Colin Gilbert
    /// </summary>
    public class SafeIntConverter
    {
        private const int _defaultValue = 76;

        public int ToSafeInt(string str)
        {
            try
            {
                var intValue = Convert.ToInt32(str);
                Console.WriteLine($"value ({str}) converted successfully!");
                return intValue;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine($"could not convert value ('{str}') successfully.");
                Console.WriteLine($"returning default value {_defaultValue} instead");
                return _defaultValue;
            }
        }
    }
}
