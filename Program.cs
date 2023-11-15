using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2;

/*Club club = new Club();
club.Age = Convert.ToInt32(Console.ReadLine());*/
class Program
{
    static void Main()
    {
        TestClass test = new TestClass();
        int age;
        do
        {
            Console.Write("Введите возраст: ");
        } while (!int.TryParse(Console.ReadLine(), out age) || age <= 0);
        test.Age = age;
        do
        {
            Console.Write("Введите имя: ");
            test.Name = Console.ReadLine();
        } while (string.IsNullOrEmpty(test.Name));
        do
        {
            Console.Write("Введите фамилию: ");
            test.LastName = Console.ReadLine();
        } while (string.IsNullOrEmpty(test.LastName));

        Console.WriteLine($"{test.Age} {test.Name} {test.LastName}");
    }
}