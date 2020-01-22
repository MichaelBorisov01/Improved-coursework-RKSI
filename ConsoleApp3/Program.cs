using System;
 
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int count;
            int answer;
            int globalAnswer = 0;
            bool returnWhile = true;
            Files file = new Files();
             
            while (returnWhile)
            {
                Console.WriteLine("Выберете что сделать" +
                    "\n 1 - Прочитать значение из файла \n 2 - Записать новые значения \n 0 - ВЫХОД");
                globalAnswer = int.Parse(Console.ReadLine());
                switch (globalAnswer)
                {
                    case 1:
                        //Чтение из файлов
                        file.createDirectory();
                        readFile(file);
                        break;
                    case 2:
                        Console.WriteLine("Введите кол - во запчастей: ");
                        do
                        {
                            count = int.Parse(Console.ReadLine());
                            if (count <= 0)
                            {
                                Console.WriteLine("Введено неверное число, попробуйте заново");
                            }
                        } while (count <= 0);

                        Zap[] zap = new Zap[count];
                        for (int i = 0; i < count; i++)
                        {
                            zap[i] = new Zap();
                            Console.WriteLine("----------------------------------------");

                        }
                        Console.WriteLine("Что вы хотите сделать? \n 1 - Изменить введеную ифнормациию \n 2 - Добавить информацию \n 3 - Удалить ифнормацию \n 0 - ПРОДОЛЖИТЬ ");
                        answer = int.Parse(Console.ReadLine());
                        do
                        {
                            switch (answer)
                            {
                                //Изменение информации
                                case 1:
                                    do
                                    {
                                        answer = ChangeInfo.changeObject(zap);
                                    } while (answer != 0);
                                    break;
                                //Добавление ифнормации
                                case 2:
                                    do
                                    {
                                        answer = ChangeInfo.AddObject(zap);
                                    } while (answer != 0);
                                    break;
                                //Удаление информации
                                case 3:
                                    do
                                    {
                                        answer = ChangeInfo.DeleteObject(zap);
                                    } while (answer != 0);
                                    break;
                            }
                        } while (answer != 0);
                        //Запись в файл
                        writeInFile(count, zap, file);
                        break;

                    default:
                        returnWhile = false;
                        break;
                }
            }
        }
        static public void writeInFile(int count, Zap[] zap, Files file)
        {
            file.createDirectory();
            file.cleanDirectory();
            for (int i = 0; i < count; i++)
            {
                DirectoryInfo dir;
                dir = Directory.CreateDirectory($@"{file.dir}\DIR\zap{i}");
                file.fileWriterZap($"zap{i}\\zap{i}", zap[i]);
                 
                for (int j = 0; j < zap[i].sales.Count; j++)
                {
                    file.fileWriterSale($"zap{i}\\zap{i}sale{j}", zap[i].sales[j]);
                }
                for (int j = 0; j < zap[i].kats.Count; j++)
                {
                    file.fileWriterKat($"zap{i}\\zap{i}kat{j}", zap[i].kats[j]);
                }
            }
            Console.WriteLine("Запись завершена!");
        }
        static public void readFile(Files file)
        {

            int i = 0;
            foreach (DirectoryInfo d in file.directory.GetDirectories())
            {
                Console.WriteLine($"Автозапчасть № {i}");
                file.fileReaderZap($"zap{i}\\zap{i}");
                 
                Console.WriteLine("Продажи:");
                string[] searchSale = Directory.GetFiles($@"{file.dir}\DIR\zap{i}\", $"zap{i}sale{i}*");
                string[] searchKat = Directory.GetFiles($@"{file.dir}\DIR\zap{i}\", $"zap{i}kat{i}*");
                int j = 0;
                foreach (string f in searchSale)
                {
                    Console.WriteLine($"Продажа № {j}");
                    file.fileReaderSale($"zap{i}\\zap{i}sale{j}");
                    Console.WriteLine("******************************");
                    j++;
                }
                Console.WriteLine("Категории:");
                j = 0;
                foreach (string f in searchKat)
                {
                    Console.WriteLine($"Категория № {j}");
                    file.fileReaderKat($"zap{i}\\zap{i}kat{j}");
                    Console.WriteLine("******************************");
                    j++;
                }
                i++;
            }
            Console.WriteLine("Чтение завершено");
        }
    }
}