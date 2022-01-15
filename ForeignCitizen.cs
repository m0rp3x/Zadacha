using System;

using System.Collections.Generic;

using System.Text;

namespace Zadachka

{

    sealed class ZavKafedri : Prepod
    {

  
      

        private string foreignPassport;
        private DateTime visaOpen;
        private DateTime visaClose;







        public ZavKafedri(string _name, string _surname, bool _sex,

            string _password, string _address,

            string _foreignPassport, DateTime _visaOpen, DateTime _visaClose)

            : base(_name, _surname, _sex, _password, _address)

        {

            foreignPassport = _foreignPassport;

            visaOpen = _visaOpen;

            visaClose = _visaClose;



        }
        public string ForeignPassport

        {

            get { return foreignPassport; }

            set { foreignPassport = value; }

        }

        public DateTime VisaOpen

        {

            get { return visaOpen; }

            set { visaOpen = value; }

        }

        public DateTime VisaClose

        {

            get { return visaClose; }

            set { visaClose = value; }

        }

// 4. Метод Print() - вывод полей класса

        public new void Print()

        {

            base.Print(); // вызов метода базового класса

            Console.WriteLine("foreignPassport: {0}", foreignPassport);

            Console.WriteLine("visaOpen: {0}", visaOpen);

            Console.WriteLine("visaClose: {0}", visaClose);

        }

    }

}

    

