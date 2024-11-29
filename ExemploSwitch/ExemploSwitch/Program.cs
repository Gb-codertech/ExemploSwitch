using System;
public class ExemploSwitch
{
    public static void Main(string[] args)
    {
        int grade = 12;
        // E = && , OU = ||
        switch (grade)
        {
            case >= 18 and <= 20:
                Console.WriteLine("Excelent");
                break;

            case >= 14 and <= 17:
                Console.WriteLine("Good");
                break;

            case >= 10 and <= 13:
                Console.WriteLine("Enought");
                break;

            case >= 0 and <= 9:
                Console.WriteLine("Not Enought");
                break;

            default:
                Console.WriteLine("Nota inválida");
                break;
        }
    }
}