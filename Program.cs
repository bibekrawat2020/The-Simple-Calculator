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
string Action = Console.ReadLine();

//Switch case for performing the operation
void operation (int num1, int num2, string Action)
{
    switch (Action)
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
}
operation(num1, num2, Action);
//For waiting response from the user before closing
Console.WriteLine("Press any key to close the app....");
Console.ReadKey();