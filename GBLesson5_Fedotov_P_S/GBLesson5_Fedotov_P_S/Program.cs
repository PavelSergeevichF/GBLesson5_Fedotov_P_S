using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBLesson5_Fedotov_P_S
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Properties.Class1 cl1 = new Properties.Class1();
            Console.WriteLine("Без использования регулярных выражений");
            cl1.CheckInputDataNotReg();
            Console.WriteLine("С использованием регулярных выражений");
            cl1.CheckInputDataReg();

            Properties.Class2.Message('g');
        }
    }
}
