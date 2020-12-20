using System;
using MagicTheGathering.Models;
using MagicTheGathering.Models.Enums;

namespace MagicTheGathering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the card.");
            string name = new string(Console.ReadLine());
            int rarity = new int();

            Console.WriteLine("Enter the card's rarity type.");
            Console.WriteLine("Common, Uncommon, Rare, Mythic, or Land");
            switch(Console.ReadLine())
            {
                case "Common":
                    rarity = (int) Rarity.Common;
                    break;
                case "Uncommon":
                    rarity = (int) Rarity.Uncommon;
                    break;
                case "Rare":
                    rarity = (int) Rarity.Rare;
                    break;
                case "Mythic":
                    rarity = (int) Rarity.Mythic_Rare;
                    break;
                case "Land":
                    rarity = (int) Rarity.Land;
                    break;
                default:
                    Console.WriteLine("Incorrect Rarity, quitting");
                    break;
            }

            Console.WriteLine("Enter the set this card is part of:");
            string Set_Name = new string(Console.ReadLine());


            var myCard = new Cards(name, rarity, Set_Name);

            Console.WriteLine("\n\nYour card is:");
            Console.WriteLine(myCard.Name);
            Console.WriteLine(myCard.Rarity);
            Console.WriteLine(myCard.Set_Name);
            //var mySuperList = new SuperTypeList();

            //Card property fields must be lists of integers.
            //The enumerator must be converted to int before adding.
        }
    }
}
