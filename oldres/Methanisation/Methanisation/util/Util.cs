using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methanisation
{
    static class Util
    {
        static Random rnd = new Random((int)DateTime.Now.Ticks);

        public static string GetRndID()
        {
            return rnd.Next(256, 65537).ToString("X");
        }

        public static string GetRandomIDString()
        {
            int length = 9;
            string result = "";
            
            for (int i = 0; i < length; i++)
            {
                int choice = rnd.Next(0, 2);
                if(choice == 0)
                {
                    result += (char)rnd.Next('A', 'Z' + 1);
                }
                else
                {
                    result += (char)rnd.Next('0','9' + 1);
                }
            }
            
            return result;
        }

        public static string ToHex(int val)
        {
            return val.ToString("X");
        }
    }
}
