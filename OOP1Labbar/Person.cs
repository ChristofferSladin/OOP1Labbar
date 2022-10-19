using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1Labbar
{
    class Person
    {
        private DateTime birthDay;
        private string name;
        public string adress;
        public int postalCode;
        public string county;

        public int AgeInYears
        {
            get
            {
                TimeSpan TS = DateTime.Now - birthDay;

                double years = TS.TotalDays / 365.25f;  // 365 1/4 days per year
                return Convert.ToInt32(years);
            }
        }

        public Person(DateTime birthDay, string name)
        {
            this.birthDay = birthDay;
            this.name = name;
        }


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Adress
        {
            get { return this.adress; }
            
        }
        public int PostalCode
        {
            get { return this.postalCode; }
           
        }
        public string County
        {
            get { return this.county; }
           
        }

        public string ChangeAdress()
        {
            Console.Write("Adress -- ");
            var adress = Console.ReadLine();

            return adress;
        }
        public int ChangePostalCode()
        {
            while (true)
            {
                Console.Write("Postal code -- ");
                int postalCode = int.Parse(Console.ReadLine());
                if (postalCode> 10000 && postalCode < 99999)
                {
                    return postalCode;
                }else
                    Console.WriteLine("Ange ett giltigt postnummer");
            }
        }
        public string ChangeCounty()
        {
            Console.Write("County -- ");
            var County = Console.ReadLine();

            return County;
        }
    }
}
