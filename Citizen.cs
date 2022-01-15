using System;

namespace Zadachka

{



    class Prepod : Student

    {



        protected string password;

        protected string address; 



        public Prepod(string _name, string _surname, bool _sex,

            string _password, string _address) : base(_name, _surname, _sex)

        {

            password = _password;

            address = _address;

        }
        public string Password

        {

            get { return password; }

            set { password = value; }

        }

        public string Address

        {

            get { return address; }

            set { address = value; }

        }



        public new void Print()

        {

            base.Print(); 

            Console.WriteLine("password: {0}", password);

            Console.WriteLine("address: {0}", address);

        }

    }

}
    
