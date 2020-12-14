using System;
using MagicTheGathering.Models;

namespace MagicTheGathering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the card.");
            string name = new string(Console.ReadLine());
            int power = new int();
            int toughness = new int();
            Console.WriteLine("Enter the card's power, if it has any.");
            power = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the card's toughness, if any.");
            toughness = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the card's rules text.");
            string rules_Text = new string(Console.ReadLine());


            var myCard = new Cards(name, power, toughness, rules_Text);

            Console.WriteLine("\n\nYour card is:");
            Console.WriteLine(myCard.Name);
            Console.WriteLine($"{myCard.Power}/{myCard.Toughness}");
            Console.WriteLine(myCard.Rules_Text);
            //var mySuperList = new SuperTypeList();

            //Card property fields must be lists of integers.
            //The enumerator must be converted to int before adding.
        }
    }
}
