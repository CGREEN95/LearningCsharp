using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleIO
{
    class Program
    {

        static void Main(string[] args)
        {
            //GetUserData();
            //FormatNumericalData();
            //DisplayMessage();
            //LocalVarDeclarations();
            //NewingDataTypes();
            //ObjectFunctionality();
            //DataTypeFunctionality();
            //CharFunctionality();
            //ParseFromStrings();
            //UseDatesAndTimes();
            //BasicStringFunctionality();
            //StringConcatenation();
            //EscapeChars();
            //StringEquality();
            //StringsAreImmutable();
            //StringsAreImmutable2();
            //FunWithStringBuilder();
            //StringInterpolation();
        }

        /*
        static void StringInterpolation()
        {
            // Some local variables we will plug into our larger string
            int age = 4;
            string name = "Soren";

            // Using curly bracket syntax
            string greeting = string.Format("Hello {0} you are {1} years old.", name, age);

            // Using strin interpolation
            string greeting2 = $"Hello {name} you are {age} years old.";
        }
        
        static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder:");
            StringBuilder sb = new StringBuilder("**** Fantastic Games ****");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" + "2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", " Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
            Console.WriteLine();
        }

        
        static void StringsAreImmutable2()
        {
            string s2 = "My other string";
            s2 = "New string value";
        }

        
        static void StringsAreImmutable()
        {
            // Set initial string value.
            string s1 = "This is my string.";
            Console.WriteLine("s1 = {0}", s1);

            // Uppercase s1?
            string upperString = s1.ToUpper();
            Console.WriteLine("upperString = {0}", upperString);

            // Nope! s1 is in the same format!
            Console.WriteLine("s1 = {0}", s1);
        }

    
        static void StringEquality()
        {
            Console.WriteLine("=> String equality:");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            // Test these strings for equality.
            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
            Console.WriteLine();
        }

        static void EscapeChars()
        {
            Console.WriteLine("=> Escape characters:\a");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
            Console.WriteLine(strWithTabs);
            Console.WriteLine("Everyone loves \"Hello World\"\a ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");
            // Adds a total of 4 blank lines (then beep again!).
            Console.WriteLine("All finished.\n\n\n\a ");
            Console.WriteLine();

            // The following string is printed verbatim,
            // thus all escape characters are displayed.
            Console.WriteLine(@"C:\MyApp\bin\debug");

            // White Space is preservered with verbatim strings.
            string myLongString = @"This is a very
                very
                        very
                                very
                                        long string";
            Console.WriteLine(myLongString);

            Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");
        }

        static void StringConcatenation()
        {
            Console.WriteLine("=> String concatenation:");
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            string s3 = s1 + s2;
            string s4 = "Hello my name is ";
            string s5 = "Cody!";
            string s6 = String.Concat(s4, s5);

            Console.WriteLine(s3);
            Console.WriteLine();
            Console.WriteLine(s6);
            Console.WriteLine();
        }

        
        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String Functionality:");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contain the letter y?: {0}",
                firstName.Contains("y"));
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();
        }

        
        static void UseDatesAndTimes()
        {
            Console.WriteLine("=> Dates and Times:");

            // This constrctor takes (year, month, day)
            DateTime dt = new DateTime(2015, 10, 17);

            // What day of the month is this?
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

            // Month is December
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

            // This constructor takes (hours, minutes, seconds)
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);

            // Subtract 15 minutes from the current TimeSpace and
            // print the result.
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
        }

        
        static void ParseFromStrings()
        {
            Console.WriteLine("=> Data Type Parsing:");

            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);

            double d = double.Parse("99.884");
            Console.WriteLine("Value of d: {0}", d);

            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);

            char c = Char.Parse("w");
            Console.WriteLine("Value of c: {0}", c);

            Console.WriteLine();
        }

        
        static void CharFunctionality()
        {
            Console.WriteLine("=> char type Functionality:");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}", 
                char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", 
                char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", 
                char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}",
                char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", 
                char.IsPunctuation('?'));
            Console.WriteLine();
        }
        
        static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data Type Functionality:");

            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfintiy {0}", double.NegativeInfinity);
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
            Console.WriteLine();
        }
        
        static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality:");

            // A C# int is really a shorthand for System.Int32,
            // which inherits the following members from System.Object
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();
        }
        
        static void NewingDataTypes()
        {
            Console.WriteLine("=> Using new to create variables:");
            bool b = new bool();
            int i = new int();
            double d = new double();
            DateTime dt = new DateTime();
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();
        }
        
        static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Data Declarations:");
            // Local variables are declared and initialized as follows:
            // dataType varName = initialValue;
            int myInt = 0;
            string myString;
            myString = "This is my character data";
            // Declare 3 bools on a single line.
            bool b1 = true, b2 = false, b3 = b1;
            // Use System.Boolean data type to declare a bool.
            System.Boolean b4 = false;
            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}",
                myInt, myString, b1, b2, b3, b4);
            Console.WriteLine();
        }
        
        static void DisplayMessage()
        {
            // Using string.Format() to format a string literal.
            string userMessage = string.Format("100000 in hex is {0:x}", 100000);

            // You need to reference PresentationFramework.dll
            // in order to compile this line of code!
            System.Windows.MessageBox.Show(userMessage);
        }

        private static void GetUserData()
        {
            // Get name and age
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string userAge = Console.ReadLine();

            // Change Echo color, just for fun
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Echo to the console
            Console.WriteLine("Hello {0}!  You are {1} years old.",
                userName, userAge);

            // Restore previous color.
            Console.ForegroundColor = prevColor;
        }

        private static void FormatNumericalData()
        {
            // Now make use of some format tags
            Console.WriteLine("The value 99999 in various formats:");
            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);

            // Notice that the upper- or lowercasing for hex
            // determines if the letters are upper- or lowercase.
            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);
        }
        */
    }
}
