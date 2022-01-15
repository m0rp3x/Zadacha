using System;

namespace Zadachka
{
    public class Student
    {



        protected string name;
        protected string surname;
        protected bool sex;




        public Student(string _name, string _surname, bool _sex)

        {

            name = _name;

            surname = _surname;

            sex = _sex;
        }
        public string Name

        {

            get { return name; }

            set { name = value; }

        }

        public string Surname

        {

            get { return surname; }

            set { surname = value; }

        }

        public bool Sex

        {

            get { return sex; }

            set { sex = value; }

        }
        public void Print()

        {

            Console.WriteLine("name: {0}", name);

            Console.WriteLine("surname: {0}", surname);

            if (sex)

                Console.WriteLine("sex: Female");

            else

                Console.WriteLine("sex: Male");

        }

    }
    
    

}
