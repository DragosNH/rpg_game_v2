using RPG_Game_V2;

public class Program
{
    public static void Main(string[] args)
    {

        // Order for the new character
        // - name - strength - intellect
        Warrior sam = new Warrior("Sam", 8, 2);
        Warrior bob = new Warrior("Bob", 5, 5);

        sam.narmalAttack(bob);
        Console.WriteLine("-------------- Stats after attack ------------------");
        Console.WriteLine(sam);
        Console.WriteLine("--------------");
        Console.WriteLine(bob);


    }
}