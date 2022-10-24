using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_AdressBook.Services
{
    internal interface IFileManager
    {
        public void Save(String filePath, string content);
        public string Read(String filePath);
    }

    internal class FileManager : IFileManager
    {
        public string Read(string filePath)
        {
            using var sr = new StreamReader(filePath);
            return sr.ReadToEnd();
        }

        public void Save(string filePath, string content)
        {
            using var sw = new StreamWriter(filePath);
            sw.Write(content);
        }
    }
}
// Funktionaliteten som behövs 
