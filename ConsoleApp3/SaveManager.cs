using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface ISaveManager
    {
        void WriteLine(string line);
        void WriteObject(string path, IWritableObject obj);
    }

    interface IWritableObject
    {
        void Write(string path, SaveManager man);
    }

    class SaveManager : ISaveManager
    {
        FileInfo file;
        DirectoryInfo directory;

        public SaveManager(string dirname)
        {
            directory = Directory.CreateDirectory(dirname);
        }

        public void WriteLine(string line)
        {
            StreamWriter output = file.AppendText();
            output.WriteLine(line);
            output.Close();
        }

        public void WriteObject(string path, IWritableObject obj)
        {
            file = new FileInfo(Path.Combine(directory.FullName, path + ".txt"));
            file.CreateText().Close();
            obj.Write(path, this);
        }
    }

}
