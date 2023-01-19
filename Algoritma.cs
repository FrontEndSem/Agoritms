// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ( GetPercentageRounds(0.0));
		Console.WriteLine ( GetPercentageRounds(0.1));
		Console.WriteLine ( GetPercentageRounds(0.2));
		Console.WriteLine ( GetPercentageRounds(0.3));
		Console.WriteLine ( GetPercentageRounds(0.4));
		Console.WriteLine ( GetPercentageRounds(0.5));
		Console.WriteLine ( GetPercentageRounds(0.6));
		Console.WriteLine ( GetPercentageRounds(0.7));
		Console.WriteLine ( GetPercentageRounds(0.8));
		Console.WriteLine ( GetPercentageRounds(0.9));
		Console.WriteLine ( GetPercentageRounds(1.0));       
    }
    
    private static string GetPercentageRounds(double percentage)
        {
            if (percentage == 0)
                return "##########";
            if (percentage > 0.0 && percentage <= 0.1)
                return "*#########";
            if (percentage > 0.1 && percentage <= 0.2)
                return "**########";
            if (percentage > 0.2 && percentage <= 0.3)
                return "***#######";
            if (percentage > 0.3 && percentage <= 0.4)
                return "****######";
            if (percentage > 0.4 && percentage <= 0.5)
                return "*****#####";
            if (percentage > 0.5 && percentage <= 0.6)
                return "******####";
            if (percentage > 0.6 && percentage <= 0.7)
                return "*******###";
            if (percentage > 0.7 && percentage <= 0.8)
                return "********##";
            if (percentage > 0.8 && percentage <= 0.9)
                return "*********#";

            return "**********";
        }
}