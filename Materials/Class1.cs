using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Text_Based_Survival_RPG;

namespace Text_Based_Survival_RPG
{
    public class Item
    {
        private string? name;
        private int amount;

        public (string, int) display_Info(string item_Name, int item_Amount)
        {
            name = item_Name;
            amount = item_Amount;

            return (item_Name, item_Amount);
        }
        public string info_Item()
        {
            string infoItem = $"We are using {Iron.materials_Name_Iron},{Gold.materials_Name_Gold},{Wood.materials_Name_Wood},{Stone.materials_Name_Stone} for create something like Stone Knife and other";
            return infoItem;
        }
    }
    public class Iron : Item
    {
        public static string materials_Name_Iron = "Iron";
        public static int materials_Amount_Iron;
    }
    public class Gold : Item
    {
        public static string materials_Name_Gold = "Gold";
        public static int materials_Amount_Gold;
    }
    public class Wood : Item
    {
        public static string materials_Name_Wood = "Wood";
        public static int materials_Amount_Wood;
    }
    public class Stone : Item
    {
        public static string materials_Name_Stone = "Stone";
        public static int materials_Amount_Stone;
    }
    public class Weopen
    {
        public string info_Weopen()
        {
            string info_Weapen = "Weopens is using for fight also for  to die enemy";
            return info_Weapen;
        }
    
    }
}