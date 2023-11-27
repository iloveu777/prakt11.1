using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace prakt11._1
{
    internal class Address
    {
        public int Index {get; set;}
        public string Country { get; set;}
        public string City { get; set;}
        public string Street{ get; set;}
        public int House { get; set;}
        public int Apartament{ get; set;}
        public Address(int index, string country, string city,string street, int house, int apartament) 
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            House = house;
            Apartament = apartament;

            
        }
        public void Print()
        {
            WriteLine($"Индекс - {Index}, страна - {Country}, город - {City}, улица - {Street}, номер дома - {House}, номер квартиры - {Apartament}.");
        }

    }
}
