using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42.Model
{
    internal class Pizza
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Pricelittle { get; set; }
        public int Pricemedium { get; set; }
        public int Pricebig { get; set; }
        public string Extrainfor { get; set; }  
        public static int count { get; set; }

       

    }
}
