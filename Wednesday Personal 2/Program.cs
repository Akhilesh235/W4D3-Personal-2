using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Personal_2
{
    public delegate void SampleDelegate(); // create delegate
    class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate del = new SampleDelegate(SampleMethod1); //create instance of delegate // pass method to delegate
            del(); // invoke delegate

        }

        public static void SampleMethod1()
        {
            Console.WriteLine("Method 1 invoked");
            Console.ReadLine();
        }
    }

    
}
