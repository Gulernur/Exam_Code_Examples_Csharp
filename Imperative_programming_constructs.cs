
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO.Compression;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

namespace Imperative
{


    public class TypeHandling
    {
        public int sum(string number1, int number2)
        {
            int number3; 

            if(Int32.TryParse(number1, out number3))
            {
                return number3 + number2; 
            }
            else 
            {
                return -1; 
            }
        }
    }

    public class NullHandling
    {
        public void printNullableInt(Nullable<int> number)
        {
            if(number.HasValue)
            {
                Console.WriteLine(number.Value);
            }
            else 
            {
                Console.WriteLine(number ?? 0);
            }
        }
    }

    public class StringInterpolation
    {
        public void printString(string name, int age)
        {
            Console.WriteLine($"The persons name is {name} and their age is {age}"); 
        }
    }

    public class PatternMatching
    {
        public void Types (object type)
        {
            switch(type)
            {
                case int number: 
                    Console.WriteLine("Data type is an integer");
                    break;
                case string text: 
                    Console.WriteLine("Data type is a string");
                    break;
                case bool boolean: 
                    Console.WriteLine("Data type is a bool");
                    break;
                default: 
                    Console.WriteLine("Unknown data type");
                    break; 
            }
        }
    }
}