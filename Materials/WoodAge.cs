using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_Survival_RPG
{
    public class WoodAge : BaseCreateWeopen
    {
      public  Wooden_Club woodenClub =new Wooden_Club();
      public  Wooden_Arrow woodenArrow = new Wooden_Arrow();
      public Wooden_Bow woodenBow = new Wooden_Bow();
      public Wooden_Knife woodenKnife = new Wooden_Knife();
        
        public string info_WoodAge()
        {
            Create_for_Materials materials = new Create_for_Materials();
            string info_WoodAge = "Wood Items is so easy for create but they give just little damage ";
            return info_WoodAge;
        
        }
    }//saylarinin alinmasi -1 dusmesinin qarsisi alinmasi  hemcinin item classda 
    public class Wooden_Club 
    {
        public string WoodenClub_Name = "Wooden Club";
        public int WoodenClub_RequiredWood = 10;
        public int WoodenClub_Damage = 7;
    }
    public class Wooden_Arrow
    {
        public string WoodenArrow_Name = "Wooden Arrow";
        public int WoodenArrow_RequiredWood = 15;
    }
    public class Wooden_Bow
    {
        public string WoodenBow_Name = "Wooden Bow";
        public int WoodenBow_RequiredWood = 5;     
        public int WoodenBow_Damage = 10;
    }
    public class Wooden_Knife 
    {
        public string WoodenKnife_Name = "Wooden Knife";
        public int WoodenKnife_RequiredWood = 7;
        public int WoodenKnife_Damage = 5;
        public int WoodenKnife = 0;
    }
}
//stonge age ....