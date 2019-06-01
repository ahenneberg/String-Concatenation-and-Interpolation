/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Concatenation_and_Interpolation
{
    class Program
    {
        static void Main()
        {
            // String Concatenation
            // The + operator is able to concatenate (link together) two strings
            string s1 = "a" + "b";  //ab
            Console.WriteLine(s1);
            // One of the operands may be a nonstring value, in which case ToString is called on that value.
            string s2 = "a" + 5;    //a5
            // However, repeatedly using the + character to build up a string is inefficient.
            // Using System.Text.StringBuilder is a better solution (In CH.6)
            Console.WriteLine(s2);

            // String Interpolation
            // A string preceded with the $ character is called an interpolated string.
            // This allows us to include expressions inside braces:
            int x1 = 4;
            Console.WriteLine($"A square has {x1} sides");   // Prints: A square has 4 sides
            // Any valid C# expression of any type can appear within braces
            // C# will convert these types to string with the ToString method or equivalent.
            // You can change the formatting by appending the expression with a colon and a format string
            string s3 = $"255 in hex is {byte.MaxValue:X2}";    // X2 = 2-digit Hexadecimal
            Console.WriteLine(s3);  // Prints: 255 in hex is FF.
            // Interloped strings must complete on a single line of code.
            // However, you also specify the verbatim string operator.
            // You must place the $ operator before @
            int x2 = 2;
            string s4 = $@"this spans
{x2} lines";
            Console.WriteLine(s4);  // Prints above expression.
            Console.ReadKey();
            // Additional note: if you want to compare strings, < and > operators are not supported.
            // You need to use the string's CompareTo method, further explained in CH. 6
        }
    }
}
