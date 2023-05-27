using System;
using Imperative;

class Exam
{
    //Imparative programming constructs.
    static TypeHandling typeHandling = new TypeHandling();
    static NullHandling nullHandling = new NullHandling(); 
    static StringInterpolation stringInterpolation = new StringInterpolation(); 
    static PatternMatching patternMatching = new PatternMatching(); 
    
    public static void Main()
    {   
        //Imparative programming constructs. 
        Console.WriteLine(typeHandling.sum("12", 10));
        nullHandling.printNullableInt(12);
        stringInterpolation.printString("Niels", 35); 
        patternMatching.Types(true);
    }
}
