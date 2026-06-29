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
        public Dictionary<string, int> TotalInventory = new Dictionary<string, int>();

        public static Action<short>? OnLootPerformed;
        WoodAge WoodWeopen =new WoodAge();
        MaterialsAmount Materials_Amount = new MaterialsAmount();
        public Dictionary<string, int> MaterialsAndValueLooting()
        {

                Random MaterialsValueRND = new Random();
      
                //WoodWeapen
             
                AddToTotal(Iron.materials_Name_Iron, MaterialsValueRND.Next(2, 4));
                AddToTotal(Gold.materials_Name_Gold, MaterialsValueRND.Next(1, 3));
                AddToTotal(Wood.materials_Name_Wood, MaterialsValueRND.Next(3, 5));
                AddToTotal(Stone.materials_Name_Stone, MaterialsValueRND.Next(3, 5));
                
                OnLootPerformed?.Invoke(30);
                return TotalInventory;
           
        }
        public Dictionary<string,int> CreatingWeapen()
        {
            CreateToTotal(Wood.materials_Name_Wood, Wood.materials_Amount_Wood);
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
        private void CreateToTotal(string Wname, int Wamount)
        {
            if (TotalInventory.ContainsKey(Wname))
            {
                if (TotalInventory[Wname] >= WoodWeopen.woodenKnife.WoodenKnife_RequiredWood)
                {
                    TotalInventory[Wname] -= WoodWeopen.woodenKnife.WoodenKnife_RequiredWood;
                    WoodWeopen.woodenKnife.WoodenKnife++;
                    AddToTotal(WoodWeopen.woodenKnife.WoodenKnife_Name,WoodWeopen.woodenKnife.WoodenKnife);
                    Console.WriteLine("as");
                }
            }
        } //crafting sistemi 
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
