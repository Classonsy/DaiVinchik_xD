using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, введите свое имя для продолжения");
            string name = "";
            name = Convert.ToString(Console.ReadLine());
            string greeting = "Здравствуйте";
            string message = greeting + " " + name;

            Console.WriteLine($"{message} Рад вас видеть!!");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"{name} сколько вам лет?");
            string age = "";
            age = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"{name} напишите ваш город");
            string city = "";
            city = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"{name} здесь вы можете написать что то о себе, либо пропустить этот пункт");
            string bio = "";
            bio = Convert.ToString(Console.ReadLine());

            Console.WriteLine($"Ваша анкета: {name} {age} {city}, {bio}. Всё верно?");

            Console.ReadKey();
        }
    }
}
