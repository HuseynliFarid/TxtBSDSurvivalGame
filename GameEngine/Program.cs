using System;
using System.IO;
using NAudio.Wave;
using Text_Based_Survival_RPG.Voice_File;
namespace Text_Based_Survival_RPG
{
    public class GameEngine
    {//elave ai dusmen  + shop + engine yigilmasi
        public static void Main(string[] args)
        {
            Additions additions = new Additions();
            Create_for_Materials materialsObject = new Create_for_Materials();
            Item item = new Item();
            Voices voices = new Voices();
            Player player = new Player();
            player.Loot_Energy_system();
            while (true)
            {  
                int lootKey = additions.exception_Handling(0);  
                if (lootKey == 1 && player.Energy_Check)
                {
                    voices.Voice("LootingVoice.mp3");
                    foreach (var material in materialsObject.MaterialsAndValueLooting())
                    {
                        Thread.Sleep(500);
                        Console.WriteLine(material);
                    }
                }
                else if (lootKey == 2)
                {
                    voices.Voice("GameNotificationinfo.mp3"); 
                    Console.WriteLine(item.info_Item());
                }
                else if (lootKey == 3)
                {
                    voices.Voice("OpeningInventory.mp3");
                    Thread.Sleep(500);
                    materialsObject.showInventory();
                }
                else if (lootKey == 1 && player.Energy_Check == false)
                {
                    voices.Voice("GameNotificationinfo.mp3");
                    Console.WriteLine("Player has not energy for that please recharge with fight");
                  
                }
                else if (lootKey == 4)
                {
                    voices.Voice("WoodCraftingSound.mp3");
                    materialsObject.CreatingWeapen();
                }
            }
        }
    }
}