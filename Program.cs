using System;

namespace Cabinets
{
    class Program
    {
        static void Main(string[] args)
        {
            UpperCabinet upperCabinet = new UpperCabinet(1,2,3,4,5,6);
            Console.WriteLine(upperCabinet.height);

            
        }
    }
}
