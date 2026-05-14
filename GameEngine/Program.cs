using Materials_for_RPG;
using System;
namespace Text_Based_Survival_RPG
{
    public class GameEngine
    {
        public  static void Main(string[] args)
        {
            while (true)
            {
                Create_for_Materials materialsObject = new Create_for_Materials();
                int lootKey = int.Parse(Console.ReadLine());
                if (lootKey == 1)
                {
                    foreach (var item in materialsObject.MaterialsAndValueLooting())
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (lootKey == 2)
                {

                }
            }
        }
    }
}
