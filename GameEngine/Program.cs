using Materials_for_RPG;
using System;
using System.Numerics;
using Text_Based_Survival_RPG;
namespace Text_Based_Survival_RPG
{
    public class GameEngine
    {
        public  static void Main(string[] args)
        {
            Player player = new Player();
            player.Loot_Energy_system();
            while (true)
            {
                Additions additions = new Additions();
                Create_for_Materials materialsObject = new Create_for_Materials();
                Item item = new Item();
                int lootKey = additions.exception_Handling(0);
                if (lootKey == 1 && player.Energy_Check)
                {
                  foreach (var material in materialsObject.MaterialsAndValueLooting())
                  {
                            Console.WriteLine(material);
                  }
                }
                else if (lootKey == 2)
                {
                    Console.WriteLine(item.info_Item());
                }
                else if (lootKey == 3)
                {
                    materialsObject.showInventory();
                }
                else if(lootKey == 1 && player.Energy_Check == false)
                {
                    Console.WriteLine("Player has not energy for that please recharge with fight");
                }
            }
        }
    }
}