using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_Survival_RPG
{
    public class Additions
    {
        public int exception_Handling(int intNumber)
        {
            bool error_Check =int.TryParse(Console.ReadLine(),out intNumber);
            while(true){
                if (error_Check)
                {
                    return intNumber;
                }
                else
                {
                    Console.WriteLine("Please Enter only integer number !");
                    error_Check = int.TryParse(Console.ReadLine(), out intNumber);
                }
            }
        }
       
    }
}
