using ConsoleApp42.Enum;
using ConsoleApp42.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42.Service
{
    internal class PizzaService<T> where T : Pizza
    {
        List<T> list = new List<T>();
        

        public void Create1(T M1)
        {
           
            M1.Name = "Marqarita";
            M1.Id = 1;
            M1.Pricebig = 30;
            M1.Pricemedium = 20;
            M1.Pricelittle = 10;
            M1.Extrainfor = "Duzlu,Yagli";
            list.Add(M1);
        }
        public void Create2(T M2)
        {
            
            M2.Name = "Peperoni";
            
            M2.Id = 2;
            M2.Pricebig = 50;
            M2.Pricemedium = 30;
            M2.Pricelittle = 20;
            M2.Extrainfor = "Etli,pomidorlu";
            list.Add(M2);
        }


        public void Show()
        {
            foreach (T item in list)
            {
                Console.WriteLine("Id:" + item.Id + " " + "Name:" + item.Name+"sizeler:big,small,little");
            }
        }

        public void ExtraInfor()
        {
            while (true)
            {
                Console.WriteLine("Pizza haqqinda etrafli melumat almaq isteyirsizce pizzanin Id-ni(1,2) yazin");
                Console.WriteLine("Olcusu haqqinda ise 3-e basin");
                Console.WriteLine("cikis icin 4 e basin");
                int secim = int.Parse(Console.ReadLine());

                foreach (var item in list)
                {
                    if (secim == item.Id)
                    {
                        Console.WriteLine("Extra infor:" + item.Extrainfor);
                        break;
                    }
                    else if (secim == 3)
                    {
                        Console.WriteLine("pizzanin boyuk qiymeti:" + item.Pricebig);
                        Console.WriteLine("pizzanin orta qiymeti:" + item.Pricemedium);
                        Console.WriteLine("pizzanin kicik qiymeti:" + item.Pricelittle);
                    }

                }

                if (secim == 4)
                {
                    Console.WriteLine("cikis yapildi");
                    break;
                }

            }


        }
        public void CreatByClient()
        {
            Console.WriteLine("Almaq istediyiniz pizzanin adin daxil edin");
            string option=Console.ReadLine();
            foreach (var item in list)
            {
                if (option==item.Name)
                {
                    Console.WriteLine("Almaq istediyiniz pizzanin boyun secin");
                    Console.WriteLine(SIZE.small + " =" + item.Pricelittle);
                    Console.WriteLine(SIZE.medium + " =" + item.Pricemedium);
                    Console.WriteLine(SIZE.Big + " =" + item.Pricebig);
                    string Piiza = Console.ReadLine();
                }
            }
                
            
        }
    }
}
