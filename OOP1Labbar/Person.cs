using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1Labbar
{
    class Person
    {
        private string birthDay;
        private string name;
        public string adress;
        public int postalCode;
        public string county;

        public Person(string _name, string _birthDay)
        {
            this.name = _name;
            this.birthDay = _birthDay;
            
            Console.WriteLine(name);
            Console.WriteLine(birthDay);

            this.adress = ChangeAdress();
            this.postalCode = ChangePostalCode();
            this.county = ChangeCounty();

            Console.ReadKey();
            Console.Clear();

        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string BirthDay
        {
            get { return this.birthDay; } 
            set { this.birthDay = value; }
        }

        public string Adress
        {
            get { return this.adress; }
            set { this.adress = value; }
        }
        public int PostalCode
        {
            get { return this.postalCode; }
            set { this.postalCode = value; }
        }
        public string County
        {
            get { return this.county; }
            set { this.county = value; }
        }


        public string ChangeAdress()
        {
            Console.WriteLine("Adress:");
            var adress = Console.ReadLine();

            return adress;
        }
        public int ChangePostalCode()
        {
            while (true)
            {
                Console.WriteLine("Postal code:");
                int postalCode = int.Parse(Console.ReadLine());
                if (postalCode> 10000 && postalCode < 99999)
                {
                    return postalCode;
                    break;
                }else
                    Console.WriteLine("Ange ett giltigt postnummer");
            }
            
            return postalCode;
        }
        public string ChangeCounty()
        {
            Console.WriteLine("County:");
            var County = Console.ReadLine();

            return County;
        }




    }
}
