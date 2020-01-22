using System;
 
using System.IO;
 

namespace ConsoleApp3
{
    class Files
    {
        public string dir;
        public DirectoryInfo directory;
        public void createDirectory()
        {
            dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
            directory = Directory.CreateDirectory("DIR");
        }
        public void cleanDirectory()
        {
            foreach (DirectoryInfo d in directory.GetDirectories())
            {
                cleanFiles(d);
                d.Delete();
            }
        }
        public void cleanFiles(DirectoryInfo dir)
        {
            foreach (FileInfo f in dir.GetFiles())
            {
                f.Delete();
            }
        }
         
        public void fileWriterZap(string filePath, Zap zap)
        {
            StreamWriter sw = new StreamWriter("DIR\\" + filePath + ".txt", false, System.Text.Encoding.UTF8);
            sw.WriteLine($"Наименование запчасти: {zap.getName()}");
            sw.WriteLine($"Цена запчасти: {zap.getPrice()}");
            sw.WriteLine($"Кол - во запчастей на складе: {zap.getKolvo_specific()}");
            sw.Close();
        }
        public void fileWriterSale(string filePath, Sale sale)
        {
            StreamWriter sw = new StreamWriter("DIR\\" + filePath + ".txt", false, System.Text.Encoding.UTF8);
            sw.WriteLine($"Дата продажи запчасти: {sale.getDateOfSale() }");
            sw.WriteLine($"Кол-во проданных запчастей: {sale.getKolvo_sale()}");
            sw.Close();
        }
        public void fileWriterKat(string filePath, Kat kat)
        {
            StreamWriter sw = new StreamWriter("DIR\\" + filePath + ".txt", false, System.Text.Encoding.UTF8);
            sw.WriteLine($"Наименование категории: {kat.GetNumberOfKat()}");
            sw.WriteLine($"Процент надбавки к цене запчасти: {kat.getProc()}");
            sw.Close();
        }
        //READ
        
         

        public void fileReaderZap(string filePath)
        {
            StreamReader sr = new StreamReader("DIR\\"+filePath + ".txt");
            Console.WriteLine("==========Запчасть==========");
            Console.WriteLine(sr.ReadToEnd());


            sr.Close();
        }
        public void fileReaderSale(string filePath)
        {
            StreamReader sr = new StreamReader("DIR\\" + filePath + ".txt");
            Console.WriteLine("============Продажа===========");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }

        public void fileReaderKat(string filePath)
        {
            StreamReader sr = new StreamReader("DIR\\" + filePath + ".txt");
            Console.WriteLine("====Информация о категориях====");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }
    }
}