using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02MathsLib
{
   // [Serializable]
    public class Maths
    {
        /// <summary>
        /// This method adds to integers
        /// </summary>
        /// <param name="x">First Param</param>
        /// <param name="y">Second Param</param>
        /// <returns></returns>
        public int Add(int x , int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }
    }
}
