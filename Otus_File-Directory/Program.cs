using System.IO;
using System.Text;
using System.Text.Encodings;

namespace Otus_File_Directory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к созданию директорий...");

            string? _path = Console.ReadLine();

            string path = _path + "/Otus";

            if (path == null) return;
            CreateDirectory(path);
        }

        private static void CreateDirectory(string path)
        {
            for (int i = 1; i < 3; i++)
            {
                DirectoryInfo directory = new DirectoryInfo($"{path}/TestDir{i}");
                
                directory.Create();
                
                string dir = Path.Combine($"{directory}");

                CreateFile(dir);
            }
        }

        private static void CreateFile(string dir)
        {
            for (int i = 0; i < 10; i++)
            {
                string filePath = $"{dir}/File{i}.txt";
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    byte[] data = new UTF8Encoding(true).GetBytes($"{filePath}\n");
                    fs.WriteAsync(data, 0, data.Length);
                }

                using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                {
                    byte[] data = new UTF8Encoding(true).GetBytes(DateTime.Now.ToString());
                    fs.WriteAsync(data, 0, data.Length);
                }
            }


            for (int i = 0; i < 10;i++)
            {
                string filePath = $"{dir}/File{i}.txt";

                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    StreamReader sr = new StreamReader(fs);
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
        }
    }
}
