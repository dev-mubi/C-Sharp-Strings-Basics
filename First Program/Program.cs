using Microsoft.VisualBasic;

namespace First_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, Mubashir Shahzaib!");
            Console.WriteLine("It seems like you will need more RAM!");

            //Length is a property not a method as there are no ()
            string a = "  Mubi Shahzaib ";
            Console.WriteLine("String Length: " +a.Length);
            //toUpper
            Console.WriteLine("Orignal: " + a);
            Console.WriteLine("Upper Case: " +a.ToUpper());
            //toLower
            Console.WriteLine("Orignal: " + a);
            Console.WriteLine("Lower Case: " +a.ToLower());

            //Trim
            Console.WriteLine("Orignal: " + a);
            Console.WriteLine("Trimmed Version Both sides: " + a.Trim());//from both sides
            Console.WriteLine("Trimmed Version only Start: " + a.TrimStart());//from start only
            Console.WriteLine("Trimmed Version only End: " + a.TrimEnd());//from end only

            //Sub Strings --> msg.SubString(int startindex, int length) Length is how many chars we need
            Console.WriteLine("Orignal: " + a);
            Console.WriteLine("Sub-String: " + a.Substring(2,4));
            //Variation 2 --> msg.substring(int startindex)
            Console.WriteLine("Sub-String(Start Index): " + a.Substring(2));
            //msg.Indexof("word") --> will return index of "w"
            Console.WriteLine("Index: " +a.IndexOf("Mubi"));
            //LastIndexof --> Last occurance
            Console.WriteLine("Last Index: " + a.LastIndexOf("b")); //If no occurance --> Output:-1

            //Contains --> True/False --> Search any word
            Console.WriteLine("Search: " + a.Contains("mubi")); //Case Sensitive
            //Check Start and End of String
            Console.WriteLine("Check Start of String: " + a.StartsWith("  Mubi"));
            Console.WriteLine("Check End of String: " + a.EndsWith("zaib "));

            //Replacing String --> Replace(oldString, newString) @Orignal string remains same
            Console.WriteLine("Orignal: " + a);
            Console.WriteLine("Replaced Version: " +a.Replace(a,"I am the Replaced Version"));

            //Remove --> msg.remove(int startindex, int length)
            Console.WriteLine("Remove Version: " + a.Remove(1)); //Keeps 0 char and removes rest
            Console.WriteLine("Remove Version 2: " + a.Remove(1,6));

            //Insert --> msg.insert(int index, "String")]
            Console.WriteLine("Orignal: " + a);
            Console.WriteLine("Inserted Version: " + a.Insert(6," I GOT INSERTED HERE "));

            //Split --> Converts string to string array --> Returns string array --> Takes delimeter/seperator as argument --> Can be a space or any chracter(It is excluded)
            string msg = "Orange,Apple,Banana,Grape";
            string[] fruits = msg.Split(',');
            Console.WriteLine(fruits[0]);
            Console.WriteLine(fruits[1]);
            Console.WriteLine(fruits[2]);
            Console.WriteLine(fruits[3]);

            //Join --> string.Join("delimeter", arr) -- It is a class method?
            Console.WriteLine("String array to String: " +String.Join(',', msg));

            // @@@
            string[] names = { "Ali", "Mubi", "Fariha Ali" };
            string test = string.Join(" ", names);
            Console.WriteLine("Array to String: " + test);
            //Now convert test 
            Console.WriteLine("Back Conversion: " + String.Join(',',test)); //Gives 4 names
            string ss = String.Join(',', test);
            Console.WriteLine("Here we check length after conversion: " + ss.Split(' ').Length);


            //Type Conversion (To change one data type to another  types)

            //Implicit Conversion 

            //Compiler automatically converts if its safe --> safety depends on DATA RANKING
            //Captain 1
            //Major 1
            //Colonel 1
            //You have to send 2 individuals of same rank so we will promote captain to major(Type conversion)
            //short
            //int
            //long
            //float
            //double
            //decimal
            //Implicit when --> left upper rank = lower rank (major ko demote nhi krr skte captain rank prr)
            // eg) int = short  --> Safe Conversion
            // eg) short = int --> Unsafe Conversion --> May result in data loss due to size constraints




            //Explicit  Conversion(Casting)

            //Dev is responsible for the consequence
            //Cast operator is used. Can be risky(Data Loss).
            //Its forced Unsafe Conversion

            short x = 20500;
            int y = x;
            Console.WriteLine("Short to Int: " + y);

            short c;
            int b = 500;
            //c = b;  unsafe
            c = (short)b;
            Console.WriteLine("Int to Short: " +c);

            short p;
            //int o = 32767; //Will work fine
            int o = 65536;
            p  = (short)o;
            Console.WriteLine("Check: " +p); //gives 0 b/c casting is risky


            //Conversion b/w non - compatible types

            //Numeric types are compatible
            //Class types are not?

            string g = "5";
            //int h = (int)g; Type is not compatible --> Use parsing or CONVERT

            //Using Convert -- Most Powerful -- Supports many types
            string e = "5";
            int q = Convert.ToInt32(e);
            Console.WriteLine("Sting to Int as non compatible types using convert: " + q);

            string date = "2025-09-08";
            //DateTime dt = Convert.ToDateTime(date);
            DateTime dt = DateAndTime.Now;
            //Console.WriteLine( $"String to Date using Convert: {dt:d}");
            Console.WriteLine($"String to Date using Convert: {dt}");


            //Parsing
            string t = "M";
            //int v = int.Parse(t);  //Error b/c incompatible
            //Console.WriteLine(v);

            //Parsing is not prefered over Convert
            string d = "5";
            //int u = int.Parse(null);
            //Console.WriteLine(u); //Results in Error --> Convert will give 0
            int u = Convert.ToInt32(null);
            Console.WriteLine("Pass null to Convert: " +u);


            //Math Class Functions
            Console.WriteLine("Max Value: " + Math.Max(4, 9));
            //Math.Min
            //Math.sqrt
            //Math.Round -- Uses Bankers Algo
            //Math.Abs -- Absoulute -- Negative number to Positive

            //double aa = 3.5; //4
            double aa = 4.5; //4
            Console.WriteLine("Round of value: " + Math.Round(aa)); // Concept of Even/Odd
            //If there is 5 --> Value will lean towards even number IMPORTANT --> b/c of Banker Algo




        }
    }
}
