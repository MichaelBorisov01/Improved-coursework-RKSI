using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ConsoleApp3
{
    interface ILoadManager
    {
        string ReadLine();
        IReadbleObject Read(IReadableObjectLoader loader);
    }

    interface IReadbleObject
    { }

    interface IReadableObjectLoader
    {
        IReadbleObject Load(ILoadManager man);
    }
    class LoadManager : ILoadManager
    {
        public DirectoryInfo directory;
        FileInfo file;
        StreamReader input;
        public LoadManager(string dirname)
        {
            directory = Directory.CreateDirectory(dirname);
            input = null;
        }

        public IReadbleObject Read(IReadableObjectLoader loader)
        {
            return loader.Load(this);
        }

        public void BeginRead(string filename)
        {
            if (input != null)
                throw new IOException("Load Error");

            input = file.OpenText();
        }
        public bool IsLoading
        {
            get { return input != null && !input.EndOfStream; }
        }
        public string ReadLine()
        {
            if (input == null)
                throw new IOException("Load Error");

            string line = input.ReadLine();
            return line;
        }

        public void EndRead()
        {
            if (input == null)
                throw new IOException("Load Error");

            input.Close();
        }

        public void ReadObject(string path, IReadbleObject obj)
        {
            file = new FileInfo(Path.Combine(directory.FullName, path + ".txt"));
        }
    }
}
