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
        public short player_Energy = 100;
        public bool Energy_Check = true; 
        public void Loot_Energy_system()
        {
           Create_for_Materials.OnLootPerformed += SpendEnergy;
        }
        private void SpendEnergy(short amount)
        {
            player_Energy -= amount;
            if (player_Energy <= 0)
            {
                player_Energy = 0;
                Console.WriteLine("Out of Energy please go fight");
                Energy_Check = false;
            }
            else if (player_Energy > 100) player_Energy = 100;
            else if (player_Energy - amount <= 0)
            {
                Console.WriteLine($"Player Energy has just {player_Energy} anymore after that please go fight");
                Energy_Check = false;
            }
            else
            {
                Console.WriteLine($"Looting! Energy {amount} out. remaining: {player_Energy}");
            }
        }//daha yaxsilasdirilmasi
    }    
}