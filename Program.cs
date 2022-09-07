// Project Initializer
Console.WriteLine("Calculator");
Console.WriteLine("----------\n");

//Taking input from the user
Console.WriteLine("Enter a first number and press enter");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a second number and press enter");
int num2 = Convert.ToInt32(Console.ReadLine());

//Taking input for the option from the user
Console.WriteLine("Choose an option for performing following operation:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.Write("Your option? ");

//Switch case for performing the operation
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;
}
