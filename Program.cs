using System;
using System.Text;

namespace any
{
    class Program
    {
        static void Main(string[] args)

        {
            string c = "Ajit";
           // c = "Akash";

            Console.WriteLine(c[0]);
          //  c[0] = "b";
            Console.WriteLine(c[0]);
            StringBuilder x = new StringBuilder("Ajit");
            Console.WriteLine(x[0]);
            x[0] ='b';
            Console.WriteLine(x);




        }
    }
}
