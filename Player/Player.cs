using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Text_Based_Survival_RPG
{
    public class Player
    {
        public short playerHP = 100;
       
        public Dictionary<string, int> Inventory = new Dictionary<string, int>();
        public void ShowInventory()
        {
            Console.WriteLine("--- Your Inventory ---");
            foreach (var item in Inventory)
            {
                Console.WriteLine($"{item.Key}: {item.Value} ədəd");
            }
        }
    }
}
