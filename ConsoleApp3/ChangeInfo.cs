using System;
 

namespace ConsoleApp3
{
    class ChangeInfo
    {
        static public int changeObject(Zap[] zap)
        {
            int answer = 0;
            int answerZap = 0;
            int answerSale = 0;
            int answerKat = 0;
            Console.WriteLine("Вы хотите изменить информацию о запчасти, продаже или категории запчасти? 1 - запчасть 2 - продажа, 3 - категория, 0 - выход, все кроме этого продолжить ");
            answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("Введите какую запчасть изменить?");
                    answerZap = int.Parse(Console.ReadLine()) - 1;
                    zap[answerZap] = new Zap();

                    break;
                case 2:
                    Console.WriteLine("Введите в какой запчасти изменить?");
                    answerZap = int.Parse(Console.ReadLine()) - 1;

                    Console.WriteLine("Введите какую продажу изменить?");
                    answerSale = int.Parse(Console.ReadLine()) - 1;
                    zap[answerZap].sales[answerSale] = new Sale();
                    
                    break;
                case 3:
                    Console.WriteLine("Введите в какой запчасти изменить?");
                    answerZap = int.Parse(Console.ReadLine()) - 1;

                    Console.WriteLine("Введите какую категорию изменить?");
                    answerKat = int.Parse(Console.ReadLine()) - 1;
                    zap[answerZap].kats[answerKat] = new Kat();
                     
                    break;
                default:
                    Console.WriteLine("Применение изменений....");
                    break;
            }
            return answer;
        }
        static public int AddObject(Zap[] zap)
        {

            int answer = 0;
            int answerZap = 0;
            Console.WriteLine("Вы хотите добавить информацию? 1 - запчасть 2 - продажа, 3 - категория, 0 - выход, все кроме этого продолжить ");
            answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("Добавление автозапчасти:");
                    Array.Resize(ref zap, zap.Length + 1);
                    zap[zap.Length] = new Zap();
                    break;
                case 2:
                    Console.WriteLine("Введите в какой запчасти добавить продажу?");
                    answerZap = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine("Добавление продажи:");
                    zap[answerZap].sales.Add(new Sale());
                     
                     
                    break;
                case 3:
                    Console.WriteLine("Введите в какой запчасти добавить категорию?");
                    answerZap = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine("Добавление категории?");
                    zap[answerZap].kats.Add(new Kat());
                     
                    break;
                default:
                    Console.WriteLine("Применение изменений....");
                    break;
            }
            return answer;
        }
        static public int DeleteObject(Zap[] zap)
        {

            int answer = 0;
            int answerZap = 0;
            int answerSale = 0;
            int answerKat = 0;
            Console.WriteLine("Вы хотите удалить информацию? 1 - запчасть 2 - продажа, 3 - категория, 0 - выход, все кроме этого продолжить ");
            answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("Введите какую запчасть удалить?");
                    answerZap = int.Parse(Console.ReadLine()) - 1;
                    Array.Clear(zap, answerZap, 1);
                    break;
                case 2:
                    Console.WriteLine("Введите из какой запчасти удалить?");
                    answerZap = int.Parse(Console.ReadLine()) - 1;

                    Console.WriteLine("Введите какую продажу удалить?");
                    answerSale = int.Parse(Console.ReadLine()) - 1;
                    zap[answerZap].sales.RemoveAt(answerSale);
                     
                    break;
                case 3:
                    Console.WriteLine("Введите из какой запчасти удалить?");
                    answerZap = int.Parse(Console.ReadLine()) - 1;

                    Console.WriteLine("Введите какую категорию удалить?");
                    answerKat = int.Parse(Console.ReadLine()) - 1;
                    zap[answerZap].kats.RemoveAt(answerKat);
                    
                    break;
                default:
                    Console.WriteLine("Применение изменений....");
                    break;
            }
            return answer;
        }
         
         
    }
}