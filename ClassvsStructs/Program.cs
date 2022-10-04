using System;

namespace ClassvsStructs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player {Health = 100, Armor = 100};
            Player player2 = player1;

            player2.Health = 66;
            player2.Armor = 11;

            Console.WriteLine($"Player1 Health = {player1.Health} and Armor = {player1.Armor}");
            Console.WriteLine($"Player1 Health = {player2.Health} and Armor = {player2.Armor}");
            
        }
    }
}
