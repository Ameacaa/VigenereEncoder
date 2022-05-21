namespace VigenereEncoder;

class VigenereEncoder
{
	
	static readonly char[] validChar = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '+', ' ' };

	private static char[,] CreateTable()
	{
		int charI = 0, charLenght = validChar.Length;
		char[,] table = new char[charLenght, charLenght];
		
		for (int l = 0; l < charLenght; l++)
		{
			charI = l;
			for (int c = 0; c < charLenght; c++)
			{
				table[l, c] = validChar[charI];
				if (charI >= charLenght - 1) { charI = 0; }
				else { charI++; }
			}
		}
		return table;
	}

	public static void ShowTable()
    {
		char[,] a = CreateTable();

		for (int i = 0; i < a.GetLength(0); i++)
		{
			for (int j = 0; j < a.GetLength(1); j++)
			{
				Console.Write($"{a[i, j]}  ");
			}
			Console.WriteLine();
		}
	}
	
}
