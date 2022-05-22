namespace VigenereEncoder;

class VigenereEncoder
{

	static readonly char[] validChar = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '+', ' ' };

	/// <summary>
	/// Create a table nxn where n is the validChar Array length and use all char in with displacement of 1 for each line 
	/// </summary>
	/// <returns>A nxn Table for encode</returns>
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

	/// <summary>
	/// Show the actual table
	/// </summary>
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

	public static void Encode()
	{
		// Get text to encode and the key
		char[] textInput, key;
		do
		{
			Console.Write("Text to encode: ");
#pragma warning disable CS8602
			textInput = Console.ReadLine().Trim().ToCharArray();
#pragma warning restore CS8602
			Console.WriteLine();
			if (string.IsNullOrEmpty(textInput.ToString()))
			{
				Console.WriteLine("ERROR: Empty value");
				continue;
			}
			else { break; }
		} while (true);
		do
		{
			Console.Write("Encoder key: ");
#pragma warning disable CS8602
			key = Console.ReadLine().Trim().ToCharArray();
#pragma warning restore CS8602
			Console.WriteLine();
			if (string.IsNullOrEmpty(key.ToString()))
			{
				Console.WriteLine("ERROR: Empty value");
				continue;
			}
			else { break; }
		} while (true);
		Console.WriteLine();
		// Make the key have the same length that the textInput
		if (textInput.Length > key.Length)
		{
			char[] temp = new char[textInput.Length];
			for (int i = 0; i < key.Length; i++) { temp[i] = key[i]; }
			int k = 0;
			while (textInput.Length > key.Length)
			{
				temp[temp.Length] = temp[k];
				k++;
			}
			key = new char[textInput.Length];
			key = temp;
		}
		else if (textInput.Length < key.Length)
		{
			char[] temp = new char[textInput.Length];
			for (int i = 0; i < textInput.Length; i++) { temp[i] = key[i]; }
			key = new char[textInput.Length];
			key = temp;
		}
		// Advertise the user if the char array have non valid char and their will be changed to '+'
		for (int i = 0; i < textInput.Length; i++)
		{
			// For the text part
			bool good = false;
			for (int j = 0; j < validChar.Length; j++) { if (Equals(textInput[i], validChar[j])) { good = true; break; } }
			if (!good) { textInput[i] = validChar[^2]; }

			// For the key part
			good = false;
			for (int j = 0; j < validChar.Length; j++) { if (Equals(key[i], validChar[j])) { good = true; break; } }
			if (!good) { key[i] = validChar[^2]; }
		}

		char[] textEncoded = new char[textInput.Length];
		char[,] table = CreateTable();
		for (int i = 0; i < textEncoded.Length; i++) {
			int x = 0, y = 0;
			for (int j = 0; j < validChar.Length; j++) { if(Equals(textInput[i], validChar[j])) { x = j; break; } }
			for (int j = 0; j < validChar.Length; j++) { if (Equals(key[i], validChar[j])) { y = j; break; } }
			textEncoded[i] = table[x, y];
        }
		for (int i = 0; i < textEncoded.Length; i++) { Console.Write(textEncoded[i]); }
		Console.WriteLine();
	}

	public static void Decode()
	{





	}

}
