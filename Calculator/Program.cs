using System;
public class Calculator{
    static void Main(string[] args){
        float num1 = 0;
        float num2 = 0;

        Console.WriteLine("Enter action to be performed");
        Console.WriteLine("=============================");
        Console.WriteLine("Press 1 for Addition");
        Console.WriteLine("Press 2 for Subtraction");
        Console.WriteLine("Press 3 for Multiplication");
        Console.WriteLine("Press 4 for Division");
        int proses = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter 1st Input");
        num1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter 2nd Input");
        num2 = float.Parse(Console.ReadLine());

        switch (proses){
            case 1 :
                Console.WriteLine($"Result : {num1} + {num2} = " + (num1 + num2 ));
                break;

            case 2 :
                Console.WriteLine($"Result : {num1} - {num2} = " + (num1 - num2 ));
                break;

            case 3 :
                Console.WriteLine($"Result : {num1} * {num2} = " + (num1 * num2 ));
                break;

            case 4 :
                Console.WriteLine($"Result : {num1} / {num2} = " + (num1 / num2 ));
                break;
        }
    }
}