using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using NAudio.Dmo;
using System.Security.AccessControl;
using System.Runtime.CompilerServices;

namespace Text_Based_Survival_RPG
{
    
    public class Create_for_Materials
    {
        public static Dictionary<string, int> TotalInventory = new Dictionary<string, int>();
        public static Action<short>? OnLootPerformed;
        WoodAge WoodWeopen =new WoodAge();
        public Dictionary<string, int> MaterialsAndValueLooting()
        {
                Random MaterialsValueRND = new Random();
                Iron.materials_Amount_Iron = MaterialsValueRND.Next(2, 4);
                Gold.materials_Amount_Gold = MaterialsValueRND.Next(1, 3);
                Wood.materials_Amount_Wood = MaterialsValueRND.Next(3, 5);
                Stone.materials_Amount_Stone = MaterialsValueRND.Next(3, 5);
                

                AddToTotal(Iron.materials_Name_Iron, Iron.materials_Amount_Iron);
                AddToTotal(Gold.materials_Name_Gold, Gold.materials_Amount_Gold);
                AddToTotal(Wood.materials_Name_Wood, Wood.materials_Amount_Wood);
                AddToTotal(Stone.materials_Name_Stone, Stone.materials_Amount_Stone);
                OnLootPerformed?.Invoke(30);
                return TotalInventory;
           
        }
        public Dictionary<string,int> CreatingWeapen()
        {
            int sum = 1;
            CreateToTotal(Wood.materials_Name_Wood,Wood.materials_Amount_Wood);
            AddToTotal(WoodWeopen.woodenKnife.WoodenKnife_Name,sum++);
            return TotalInventory;
        }
        private void AddToTotal(string name, int amount)
        {
            if (TotalInventory.ContainsKey(name))
            {
                TotalInventory[name] += amount;
            }
            else
            {
                TotalInventory.Add(name, amount);
            }
        }
        private void CreateToTotal(string name, int amount)
        {
            if (TotalInventory.ContainsKey(name))
            {
                TotalInventory["Wood"] -= 5; //oz requirement sistemler olacaq  artiq das da istiyecekler 
            }//crafting sistemi 
        }
        public Dictionary<string,int> showInventory()
        {
            Console.WriteLine("=== Inventory ===");
            foreach (var inventory_ in TotalInventory)
            {
                
                Console.WriteLine(inventory_);
            }
            return TotalInventory;
        }
    }
}