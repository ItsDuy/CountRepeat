namespace CountRepeat;

class Program
{
    static void Main(string[] args)
    {
        string str = "Hello World! and Have A Nice Day";
        char character;
        
        Console.Write("Enter a character: ");
        character = Console.ReadKey().KeyChar;
        Console.WriteLine();

        int count = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == character)
            {
                count++;
            }
        }

        Console.WriteLine($"The character '{character}' appears {count} times in the string.");
    }
}
