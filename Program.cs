using System;
namespace Zadachka
{

    class Program

        {

            static void Main(string[] args)

            {



                Student hm = new Student("Юра", "Ковалев", false);

                hm.Print();

// 2. Использование экземпляра класса Citizen

                Prepod ct = new Prepod("Виктор", "Гроо", false, "A2289123", "Бебра");

                Console.WriteLine("------------------------");

                ct.Print(); // вывести значение полей класса

// 3. Использование экземпляра класса ForeignCitizen

                ZavKafedri fc = new ZavKafedri("Евгений", "Федотов", false,

                    "Abrggegergerger", "Ионотека", "023329032JJK",

                    Convert.ToDateTime("02.02.2020"), Convert.ToDateTime("03.03.2085"));

                Console.WriteLine("------------------");

                fc.Print();

            }

        }
    }
