
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace MethodsAndErrors
{
    //Method that return the sum of two numbers.
    public class MethodExample
    {
        public string method(int num1, int num2)
        {
            int result = num1 + num2;
            return $"This is a method that adds to numbers together. Your result is {result}";
        }
    }

    public class TupleExample
    {
        //Method that creates a tuple, decunstruct the values and prints the values. 
        public void tuple(string name, int age)
        {
            //Tuple
            (string, int) person = (name, age); 

            //Deconstruction
            var (name2, age2) = person; 

            Console.WriteLine($"{name}");
            Console.WriteLine($"{age}");
        }
    }

    public class ExeptionHandling
    {
        //Method that takes an input that is a number and parses it. 
        //If the input is not valid, i handles it by throwing and exemption. 
        public void exeption(string number)
        {
            try{ 
                int parsedNumber = int.Parse(number); 
                Console.WriteLine($"Parsed number is {number}");

            }catch (Exception e)
            {
                Console.WriteLine($"Something happened: {e}");
            }
        }
    }
    
    public class AttributeExample
    {
        //Required attribute. 
        [Required]
        public string? Name {get; set;}

        //Range attribute. 
        [Range(0, 120)]
        public int Age {get; set;}

        public AttributeExample(string name, int age)
        {
            this.Name = name; 
            this.Age = age; 
        }

        //Method that validates if there is provided a name and if the age is in the correct range.  
        public bool person(AttributeExample attributeExample)
        {
            //Holds the list of results. 
            List<ValidationResult> result = new List<ValidationResult>();

            //Provides information that helps perform validation.
            ValidationContext context = new ValidationContext(attributeExample);

            //Performs the validation operation by taking 4 argumnets, and returns either true or false.
            //The 'True' at the end, ensures that all objects are checked for validity based on their attributes. 
            var value = Validator.TryValidateObject(attributeExample, context, result, true);

            foreach (ValidationResult r in result)
            {
                Console.WriteLine("Error is " + r);
            }
            return value;

        }
    }
}