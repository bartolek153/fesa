
namespace Algorithms;

public static class Utils
{
	public static void Print(this int[] array)
	{
		Console.Write(" [ ");

		for (int i = 0; i < array.Length; i++)
		{
			Console.Write($"{array[i]}");

			if (i != array.Length - 1)
			{
				Console.Write(", ");
			}
		}

		Console.WriteLine(" ] ");
	}

    public static void Print(this int[] array, string message)
    {
        Console.Write(message);
        Console.Write(" [ ");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}");

            if (i != array.Length - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine(" ] ");
    }
}
