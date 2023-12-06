using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class Club
    {
        public int Age { get; }
        public char Gender { get; }

        public Club(int age, char gender)
        {
            Age = age;
            Gender = gender;
        }

        public void CheckAge()
        {
            if ((Gender == 'М' && Age >= 23 && Age <= 34) || (Gender == 'Ж' && Age >= 18 && Age <= 34))
            {
                Console.WriteLine("Вы прошли в клуб анонимных алкоголиков!");
            }
            else
            {
                Console.WriteLine("Вас выгнали из Клуба анонимных алкоголиков, вы не подходите по возрасту! Мир слишком привязался к вам чтобы расставаться с вами!");
            }
        }
    }

    public class Men : Club
    {
        public Men(int age) : base(age, 'М') { }
    }

    public class Women : Club
    {
        public Women(int age) : base(age, 'Ж') { }
    }
}
