//CONFIRMED from AKrAndreev!
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Receive numbers from console
            var n1Changed = double.Parse(Console.ReadLine());
            var n2 = double.Parse(Console.ReadLine());
            var n3 = double.Parse(Console.ReadLine());
            var n4 = double.Parse(Console.ReadLine());

            //modus divide first num
            var n11 = n1Changed % 10;
            var n12 = (n1Changed % 100) / 10;
            var n13 = (n1Changed % 1000) / 100;
            var n14 = n1Changed / 1000;

            //modus divide second num
            var n21 = n2 % 10;
            var n22 = (n2 % 100) / 10;
            var n23 = (n2 % 1000) / 100;
            var n24 = n2 / 1000;

            //modus divide third num
            var n31 = n3 % 10;
            var n32 = (n3 % 100) / 10;
            var n33 = (n3 % 1000) / 100;
            var n34 = n3 / 1000;
            
            //modus divide forth num
            var n41 = n4 % 10;
            var n42 = (n4 % 100) / 10;
            var n43 = (n4 % 1000) / 100;
            var n44 = n4 / 1000;


            //Print First Num
            Console.Write("{0}", Math.Floor(0 + n14));
            Console.Write("{0}", Math.Floor(0 + n13));
            Console.Write("{0}", Math.Floor(0 + n12));
            Console.Write("{0} ", Math.Floor(0 + n11));
            
            //Print second Num
            Console.Write("{0}", Math.Floor(0 + n24));
            Console.Write("{0}", Math.Floor(0 + n23));
            Console.Write("{0}", Math.Floor(0 + n22));
            Console.Write("{0} ", Math.Floor(0 + n21));

            //Print third Num
            Console.Write("{0}", Math.Floor(0 + n34));
            Console.Write("{0}", Math.Floor(0 + n33));
            Console.Write("{0}", Math.Floor(0 + n32));
            Console.Write("{0} ", Math.Floor(0 + n31));
            
            //Print forth Num
            Console.Write("{0}", Math.Floor(0 + n44));
            Console.Write("{0}", Math.Floor(0 + n43));
            Console.Write("{0}", Math.Floor(0 + n42));
            Console.WriteLine("{0} ", Math.Floor(0 + n41));
        }
    }
}
