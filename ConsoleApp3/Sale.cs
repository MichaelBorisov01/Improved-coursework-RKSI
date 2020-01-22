using System;
 
namespace ConsoleApp3
{
    class Sale
    {
         DateTime dateOfSale = new DateTime();
         int kolvo_sale;

        public Sale()
        {
            int mounth = 0;
            int day = 0;
            Console.WriteLine("Введите день продажи запчасти: ");
            do
            {
                day = int.Parse(Console.ReadLine());
                if (day < 0 || day > 31)
                {
                    Console.WriteLine("Неверно задан день, введите заново");
                }
            } while (day < 0 || day > 31);


            Console.WriteLine("Введите месяц продажи запчасти: ");
            do
            {
                mounth = int.Parse(Console.ReadLine());
                if (mounth < 0 || mounth > 12)
                {
                    Console.WriteLine("Неверно задан месяц, введите заново");
                }
            } while (mounth < 0 || mounth > 12);



            dateOfSale = new DateTime(2019, mounth, day);



            Console.WriteLine("Введите кол-во проданных запчастей: ");
            do
            {
                kolvo_sale = int.Parse(Console.ReadLine());
                if (kolvo_sale < 0)
                {
                    Console.WriteLine("Неверно задано кол-во проданных запчастей, введите заново");
                }
            } while (kolvo_sale < 0);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Дата продажи запчасти: {dateOfSale.ToString("d")} \n   Кол-во проданных запчастей: {kolvo_sale}\n");
            Console.WriteLine("============================================");
        }

        public DateTime getDateOfSale()
        {
            return dateOfSale;
        }

        public int getKolvo_sale()
        {
            return kolvo_sale;
        }
    }
}
 