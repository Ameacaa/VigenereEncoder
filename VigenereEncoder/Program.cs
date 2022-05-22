namespace MinisExercices;

internal class Vigenere
{
	/*
	readonly static char[] charUppercase = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
	readonly static char[] charLowercase = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
	readonly static char[] charNumber = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
	readonly static char[] charSpecial = { ',', ';', '.', ':', '-', '_', '<', '>', '!', '#', '$', '%', '&', '/', '(', ')', '{', '}', '[', ']', '?', '*', '+', '=' };

	private static char[] charList = BruteForce.GetAlphasAndNumbers;
	private static char[,] Table { get; set; }
	private static int columns { get; set; }
	private static int lines { get; set; }

	private static int GetRealNumber(char c)
	{
		int value = c;
		if (value >= 97 && value <= 122)
		{
			value = value - 97;
		}
		else if (value >= 65 && value <= 90)
		{
			value = (value - 65) + 26;
		}
		else if (value >= 48 && value <= 57)
		{
			value = (value - 48) + 26 + 26;
		}
		else
		{
			value = -1;
		}

		if (value >= Table.Length) { while (value > Table.Length) { value -= Table.Length; } }

		return value;
	}

	public static void SetColumns(int col, int lin)
	{
		columns = col;
		lines = lin;
	}

	public static void SetSequentialTable(bool random = false)
	{
		char[,] table = new char[lines, columns];

		int charI = 0; // The index of actual i in charList
		int charLenght = charList.Length;

		for (int l = 0; l < lines; l++)
		{
			for (int c = 0; c < columns; c++)
			{
				table[l, c] = charList[charI];
				if (charI >= charLenght - 1) { charI = 0; }
				else { charI++; }
			}
		}

		if (random)
		{
			Random r = new Random();
			for (int l = 0; l < lines; l++)
			{
				for (int c = 0; c < columns; c++)
				{
					int a1 = r.Next(l), b1 = r.Next(c), a2 = r.Next(l), b2 = r.Next(c);
					char temp = table[a1, b1];
					table[a1, b1] = table[a2, b2];
					table[a2, b2] = temp;
				}
			}
		}

		Table = table;
	}

	public static void ShowTable()
	{
		Random r = new Random();
		for (int l = 0; l < lines; l++)
		{
			for (int c = 0; c < columns; c++)
			{
				Console.Write(Table[l, c] + "  ");
			}
			Console.WriteLine();
		}
	}

	public static void GetKey(char[] text, char[] key)
	{
		int[,] keyValue = new int[text.Length, 2];
		for (int k = 0; k < text.Length; k++)
		{
			keyValue[k, 0] = GetRealNumber(text[k]);
			Console.Write(keyValue[k, 0] + " - " + text[k] + " | ");
		}

	}

	public static void EncodeText()
	{
		// Enter the informations
		Console.WriteLine("Text to Encode: ");
		char[] textToEncode = Console.ReadLine().Trim().ToCharArray();
		Console.WriteLine("Key: ");
		char[] key = Console.ReadLine().Trim().ToCharArray();
		GetKey(BruteForce.GetAlphasAndNumbers, key);
		

		if ( key.Length == 0 )
		{
			key = new char[textToEncode.Length];
			Random r = new Random();
			for ( int i = 0; i < key.Length; i++ ) { key[i] = charList[r.Next(charList.Length)]; }

		}
		// Get the same number of character
		if ( textToEncode.Length > key.Length )
		{
			char[] temp = new char[textToEncode.Length];
			for ( int i = 0; i < key.Length; i++ ) { temp[i] = key[i]; }
			int k = 0;
			while ( textToEncode.Length > key.Length )
			{
				temp[temp.Length] = temp[k];
				k++;
			}
			key = new char[textToEncode.Length];
			key = temp;
		}
		else if ( textToEncode.Length < key.Length )
		{
			char[] temp = new char[textToEncode.Length];
			for ( int i = 0; i < textToEncode.Length; i++ ) { temp[i] = key[i]; }
			key = new char[textToEncode.Length];
			key = temp;
		}

		char[] EncodeText = new char[textToEncode.Length];
		//int[,] EncodeNumbers = GetKey(textToEncode, key);
		


	}
	*/

	static void Main()
	{
		VigenereEncoder.VigenereEncoder.Encode();
		
			
			
	}

}
