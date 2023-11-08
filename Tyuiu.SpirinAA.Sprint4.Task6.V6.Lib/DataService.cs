using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SpirinAA.Sprint4.Task6.V6.Lib
{
    public class DataService : ISprint4Task6V6
    {
        public string[] Calculate(string[] array)
        {
            string[] res = Array.FindAll(array, x => x.Length == 5);
            return res;
        }
    }
}
