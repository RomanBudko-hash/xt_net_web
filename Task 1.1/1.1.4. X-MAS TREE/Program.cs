using System;
 
public class Test
{
	public static void Main()
	{
		Console.ForegroundColor = ConsoleColor.Green;

		var numberOflevelTree = 0;

		if(int.TryParse(Console.ReadLine(), out int x))
        {
			numberOflevelTree = x;
        }
        else
        {
        Console.WriteLine("Введите корректное число");
		}
		if (numberOflevelTree > 0)
		{
			for (int i = 1; i <= numberOflevelTree; i++)
			{
		    for (int j = 0; j < i; j++)
		    {
		        string branch = new String('*', j);
		        Console.WriteLine(branch.PadLeft(numberOflevelTree + 3) + "*" + branch);
		    }
			}
		}
	}
}