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
        void WriteObject(IWritableObject obj);
    }

    interface IWritableObject
    {
        void Write(SaveManager man);
    }

    class SaveManager: ISaveManager
    {
        FileInfo file;

        public SaveManager(string filename)
        {
            file = new FileInfo(filename);
             
        }

        public void WriteLine(string line)
        {
            StreamWriter output = file.AppendText();
            output.WriteLine(line);
            output.Close();

        }

        public void WriteObject(IWritableObject obj)
        {
            obj.Write(this);
        }
    }

}
