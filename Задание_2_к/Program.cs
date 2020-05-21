using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Задание_2_к
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("..\\..\\..\\text.txt"))
            {
                Console.WriteLine("Файл не найден.");
                Console.ReadLine();
                return;
            }
            StreamReader fileIn = new StreamReader("..\\..\\..\\text.txt");
            string text = fileIn.ReadToEnd();
            fileIn.Close();
            int k = 0;
            string[] newText = Regex.Split(text, @"[\W\s]+");
            foreach (string b in newText)
                if (b != "")
                    if (b[0] == b[b.Length - 1])
                        k++;
            Console.WriteLine("Количество слов которые начинаются и заканчиваются одной буквой: " + k);
            Console.ReadLine();
        }
    }
}