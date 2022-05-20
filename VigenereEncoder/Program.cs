namespace MinisExercices;

internal class Vigenere
{
    readonly static char[] charUppercase = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
    readonly static char[] charLowercase = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    readonly static char[] charNumber = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    readonly static char[] charSpecial = { ',', ';', '.', ':', '-', '_', '<', '>', '!', '#', '$', '%', '&', '/', '(', ')', '{', '}', '[', ']', '?', '*', '+', '=' };


    private static char[] charList = BruteForce.GetUppers;
    private static char[,] Table { get; set; }
    private static int[] Dimention { get; set; }


    private static bool AllCharInLine(char[] line)
    {
        bool valid = true;
        for (int i = 0; i < line.Length; i++)
        {
            if (!valid) return false; // If the char does not exist in line it return false
            valid = false; // Reset valid value to false
            for (int j = 0; j < line.Length; j++)
            {
                if (line[i] == charList[j])
                {
                    valid = true;
                    break;
                }
            }
        }
        return true;
    }

    public static void GenerateTableVersion3(int cesar)
    {
        char[] line = new char[charList.Length];
        int actualLength = 0, actualColumn = 0;


        while (!AllCharInLine(line))
        {
            line[i] = charList[actualColumn];
            actualColumn += cesar;
            if (actualColumn >= charList.Length) { actualLength -= charList.Length; }




        }





    }


    public static void GenerateTablePower2(int cesar)
    {
        int column = 0, line = 0, selected = 0, missingLength = charList.Length * 2, actualLength = 0;

        Table = new char[charList.Length, charList.Length];

        while (actualLength < missingLength)
        {
            // Verify that all letters are in the table
            int temp = 0;
            for (int c = 0; c < charList.Length; c++)
            {
                while (charList[selected] == Table[0, c])
                {
                    if (temp == 20)
                    {
                        if (selected + 1 < charList.Length) { selected++; }
                        else
                        {
                            selected -= cesar + 1;
                        }
                    }
                    selected += cesar;
                    temp++;
                }
            }




            Console.Write("{0, 2} |", charList[selected]);
            Table[column, line] = charList[selected];
            selected += cesar;
            if (selected >= tableLength - 1) { selected -= tableLength - 1; }
        }




        for (int column = 0; column < tableLength; column++)
        {
            for (int line = 0; line < tableLength; line++)
            {
                Console.Write("{0, 2} |", charList[selected]);
                Table[column, line] = charList[selected];
                selected += cesar;
                if (selected >= tableLength - 1) { selected -= tableLength - 1; }

            }
            Console.WriteLine();
        }
    }

    public static void ShowTable()
    {
        int tableLength = charList.Length;

        for (int column = 0; column < tableLength; column++)
        {
            for (int line = 0; line < tableLength; line++)
            {
                Console.Write("{0,2} |", Table[column, line]);
            }
            Console.WriteLine();
        }
    }


}
