 
    
using System;
using System.Collections.Generic;
 

namespace ConsoleApp3
{
    class Zap
    {
        private string name;
        private float price;
        private int kolvo_specific;

        public List<Sale> sales;
        public List<Kat> kats;

        public Zap()
        {
            Console.WriteLine("Ввод инф. о запчасти:");
            Input_date();

            Console.WriteLine("Ввод инф. о продажи:");
            createSale();

            Console.WriteLine("Ввод инф. о категории:");
            createKat();

            printInf();
            printSale();
            printKat();
        }
        void Input_date()
        {
            Console.WriteLine("Введите название автозапчасти:");
            do
            {
                name = Console.ReadLine();    //НАЗВАНИЕ ПРОДУКЦИИ И ЕГО ПРОВЕРКА
                if (String.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Не введено название запчасти, попробуйте снова");
                }
            } while (String.IsNullOrEmpty(name));


            Console.WriteLine("Введите закупочную цену:");
            do
            {                                               //ЗАКУПОЧНАЯ ЦЕНА И ЕГО ПРОВЕРКА
                price = float.Parse(Console.ReadLine());
                if (price <= 0)
                {
                    Console.WriteLine("Неправильно введена цена, попробуйте заново");
                }
            } while (price <= 0);

            Console.WriteLine("Введите кол-вo запчасти на складе:");
            do
            {
                kolvo_specific = int.Parse(Console.ReadLine());
                if (kolvo_specific < 0)
                {
                    Console.WriteLine("Неверно задано кол-во запчастей, введите заново");
                }
            } while (kolvo_specific < 0);

        }
        
        
        public void createSale()
        {
            int answer = 0;
            sales = new List<Sale>();
            do
            {
                sales.Add(new Sale());
                Console.WriteLine("Продолжить? 0 - нет");
                answer = int.Parse(Console.ReadLine());
            } while (answer != 0);
        }
        
        
         

        public void createKat()
        {
            int answer = 0;
            kats = new List<Kat>();
            do
            {
                kats.Add(new Kat());
                Console.WriteLine("Продолжить? 0 - нет");
                answer = int.Parse(Console.ReadLine());
            } while (answer != 0);
        }


        public void printSale()
        {
            int i = 0;
            foreach (var val in sales)
            {
                sales[i].PrintInfo();
                i++;
            }
        }

            public void printKat()
        {
            int i = 0;
            foreach (var val in kats)
            {
                kats[i].Print_Info();
                i++;
            }
        }
        public void printInf()
        {
            Console.WriteLine($"Hазвание автозапчасти: {name} \n   Закупочная цена: {price}\n  Кол-во запчастей на складе: {kolvo_specific}");
            Console.WriteLine("============================================");
        }
    public string getName()
    {
        return name;
    }

    public float getPrice()
    {
        return price;
    }

    public int getKolvo_specific()
    {
        return kolvo_specific;
    }








}
}
 