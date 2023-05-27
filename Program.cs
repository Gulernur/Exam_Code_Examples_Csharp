using System;
using System.Reflection;
using Imperative;
using MethodsAndErrors;

class Exam
{
    //Imparative programming constructs.
    static TypeHandling typeHandling = new TypeHandling();
    static NullHandling nullHandling = new NullHandling(); 
    static StringInterpolation stringInterpolation = new StringInterpolation(); 
    static PatternMatching patternMatching = new PatternMatching(); 

    //Methods and error handling.
    static MethodExample methodExample = new MethodExample();
    static TupleExample tupleExample = new TupleExample(); 
    static ExeptionHandling exeptionHandling = new ExeptionHandling();
    static AttributeExample attributeExample = new AttributeExample("Oskar", 39);
    
    public static void Main()
    {   
        //Imparative programming constructs. 
        Console.WriteLine(typeHandling.sum("12", 10));
        nullHandling.printNullableInt(12);
        stringInterpolation.printString("Niels", 35); 
        patternMatching.Types(true);

        //Methods and error handling.
        Console.WriteLine(methodExample.method(2, 2)); 
        tupleExample.tuple("Peter", 35);
        exeptionHandling.exeption("3");
        attributeExample.person(attributeExample);

    }
}
