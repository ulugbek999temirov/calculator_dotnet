using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        try
        {
            string command = string.Empty;
            while (command != "/exit")
            {
                Console.WriteLine("Input First Value: ");
                float inputOne = float.Parse(Console.ReadLine());
                Console.WriteLine("Input Second Value: ");
                float inputTwo = float.Parse(Console.ReadLine());
                Console.WriteLine("Please choose the command('+', '-', '*', '/', '/exit')");
                command = Console.ReadLine();
                string output = string.Empty;
                switch (command)
                {
                    case "*":
                        output = $"{inputOne * inputTwo}";
                        break;
                    case "/":
                        output = $"{inputOne / inputTwo}";
                        break;
                    case "+":
                        output = $"{inputOne + inputTwo}";
                        break;
                    case "-":
                        output = $"{inputOne - inputTwo}";
                        break;
                    case "/exit":
                        break;
                    default:
                        output = $"{"Error"}";
                        break;
                }
                Console.WriteLine(output);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}