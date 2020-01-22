using System;
 

namespace ConsoleApp3
{
    class Kat
    {
        private int numberOfKat;
        private float proc;

        public Kat()
        {
            Console.WriteLine("Введите номер категории автозапчасти:");
            do
            {
                numberOfKat = int.Parse(Console.ReadLine());
                if (numberOfKat < 0 || numberOfKat > 4)
                {
                    Console.WriteLine("Неверно задан номер категории (1-4), введите заново");
                }
            } while (numberOfKat < 0 || numberOfKat > 4);



            Console.WriteLine("Введите процент надбавки к цене:");
            do
            {
                proc = float.Parse(Console.ReadLine());
                if (proc <= 0)
                {
                    Console.WriteLine("Неправильно введена надбавка, попробуйте заново");
                }
            } while (proc <= 0);
        }
        public void Print_Info()
        {
            Console.WriteLine($"Номер категории запчасти: {numberOfKat} \n   Процент надбавки к цене: {proc}\n");
            Console.WriteLine("============================================");
        }
        public int GetNumberOfKat()
        {
            return numberOfKat;
        }

        public float getProc()
        {
            return proc;
        }
    }

    
}

