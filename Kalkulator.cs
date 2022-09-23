using System;
namespace SkilvulLearning {
class Program {
    static void Main(string[] args) {

        Console.WriteLine("Welcome.");

        int number1 = 0;
        int number2 = 0;
        int total = 0; 

        Console.WriteLine("Type the 1st input"); 
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Type the 2nd input");
        number2 = Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine("Enter the operator");
        switch (Console.ReadLine())
        {
            case "*":
            total = number1 * number2; 
            Console.WriteLine("Result : " + total); 
            break;

            case "/":
            total = number1 / number2; 
            Console.WriteLine("Result : " + total); 
            break; 

            case "+":
            total = number1 + number2; 
            Console.WriteLine("Result : " + total); 
            break; 

            case "-":
            total = number1 - number2; 
            Console.WriteLine("Result : " + total); 
            break; 


        }

    }
}
    }
