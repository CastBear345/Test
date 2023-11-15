using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    internal class Club
    {
        public int Age {
            set { 
               
                if (value < 34 && value > 23){
                    Console.WriteLine("Вы прошли в клуб анонимных алкоголиков!");
                }else 
                {
                    Console.WriteLine("Вас выгнали из Клуба анонимных алноголиков, вы слишком стары!");
                }
            } 
        }
    }
}
