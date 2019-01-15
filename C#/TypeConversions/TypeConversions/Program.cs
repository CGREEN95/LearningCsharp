using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProcessBytes();
            DeclareExplicitVars();
            DeclareImplicitVars();
        }

        static void DeclareImplicitVars()
        {
            // Implicitly typed local variables
            // are declared as follows:
            // var variableNames = initialValue;
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";

            // Print out the underlying type.
            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);
        }

        static void DeclareExplicitVars()
        {
            // Explicityly typed local variables
            // are declared as follows:
            // dataTypef variableName = initialValue;
            int myInt = 0;
            bool myBool = true;
            string myString = "Time, marches on...";
            Console.WriteLine($"{myInt} {myBool} {myString}");
        }

        /*
        static int Add(int x, int y)
        {
            return x + y;
        }

        static void ProcessBytes()
        {
            byte b1 = 100;
            byte b2 = 250;

            // This time, tell the compiler to add CIL code
            // to throw an exception if overflow/underflow
            // takes place.
            try
            {
                byte sum = checked((byte)Add(b1, b2));
                Console.WriteLine("Sum = {0}", sum);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            */
    }
}
