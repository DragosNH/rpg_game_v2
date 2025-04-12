using RPG_Game_V2;
using RPG_Game_V2.Classes;

public class Program
{
    public static void Main(string[] args)
    {

        // Order for the new character
        // - name - strength - intellect
        CharClass war = new CharClass();
        Character sam = new Character("Sam", war,20, 5);

        Console.WriteLine(sam);

    }
}