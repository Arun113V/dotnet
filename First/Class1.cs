using System;

namespace First
{
    public class Class1
    {
    
        public Class1() {

            Console.WriteLine("THis is inside constructor");

        } 

        public static void Main(string[] args)
        {
            Class1 obj = new Class1();
            Console.WriteLine("This print is from inside main function");
        }
    
    
    }
}
