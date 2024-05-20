using System;
           
// Challenge 1
public class Program
{
    int integerNum = 10;
    int integerNumMath = 15;
    float floatNum = 2.6f;
    float floatNumMath = 5.2f;
    bool booleanValue = true;
    char characterValue = 'C';
    string stringOfText = "Random text that can be stored in strings";
   
    public void Main()
    {
        Console.WriteLine(stringOfText);
        Console.WriteLine(characterValue);
        Console.WriteLine(booleanValue);
        Console.WriteLine(floatNum);
        Console.WriteLine(integerNum);
       
       
        //Challenge 2
        Console.WriteLine("Addition of variables (10 + 15):");
        Console.WriteLine(integerNum + integerNumMath);
        Console.WriteLine("Subtraction of variables (10 - 15):");
        Console.WriteLine(integerNum - integerNumMath);
        Console.WriteLine("Comparison of variables (10 > 15):");
        Console.WriteLine(integerNum > integerNumMath);
        Console.WriteLine("Multiplication of variables (2.6 * 5.2):");
        Console.WriteLine(floatNum * floatNumMath);
        Console.WriteLine("Division of variables (5.2 / 2.6):");
        Console.WriteLine(floatNumMath/floatNum);
       
        //Challenge 3
        Console.WriteLine("Addition process with user input. \nInput the first nuber:");
        int inputNumber1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the second nuber:");
        int inputNumber2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Output is: " + (inputNumber1 + inputNumber2));
       
    }
}
