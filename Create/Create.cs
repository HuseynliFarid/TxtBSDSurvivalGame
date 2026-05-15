using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Materials_for_RPG;
namespace Text_Based_Survival_RPG
{

    public class Create_for_Materials
    {
        public static Dictionary<string, int> TotalInventory = new Dictionary<string, int>();
        public static Action<short>? OnLootPerformed;
        public Dictionary<string, int> MaterialsAndValueLooting()
        {

            //Each material should have its own output value. 
            Random MaterialsValueRND = new Random();
            Iron.materials_Amount_Iron = MaterialsValueRND.Next(2, 4);
            Gold.materials_Amount_Gold = MaterialsValueRND.Next(1, 3);
            Wood.materials_Amount_Wood = MaterialsValueRND.Next(3, 6);
            Stone.materials_Amount_Stone = MaterialsValueRND.Next(3, 6);

            AddToTotal(Iron.materials_Name_Iron, Iron.materials_Amount_Iron);
            AddToTotal(Gold.materials_Name_Gold, Gold.materials_Amount_Gold);
            AddToTotal(Wood.materials_Name_Wood, Wood.materials_Amount_Wood);
            AddToTotal(Stone.materials_Name_Stone, Stone.materials_Amount_Stone);
            OnLootPerformed?.Invoke(30);
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