using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_к
{
    class Program
    {
        static void Main(string[] args)
        {
            int nmin, nmax;
            bool prov;
            do
            {
                Console.Write("Введите начальную степень:");
                prov = int.TryParse(Console.ReadLine(), out nmin);
                if (!prov)
                    Console.WriteLine("Некорректный ввод");
            } while (!prov);
            do
            {
                Console.Write("Введите конечную степень:");
                prov = int.TryParse(Console.ReadLine(), out nmax);
                if (!prov)
                    Console.WriteLine("Некорректный ввод");
                if(nmax < nmin)
                {
                    Console.WriteLine("Конечная степень не может быть меньше начальной");
                    prov = false;
                }
            } while (!prov);
            FileStream file = new FileStream("..\\..\\..\\binfile.dat", FileMode.OpenOrCreate);
            BinaryWriter fBW = new BinaryWriter(file);
            for (int i = nmin; i <= nmax; i++)
            {
                fBW.Write(Math.Pow(3,i));
            }
            fBW.Close();
            file = new FileStream("..\\..\\..\\binfile.dat", FileMode.OpenOrCreate);
            BinaryReader fBR = new BinaryReader(file);
            long m = file.Length;
            double pow3;
            int ni = nmin;
            long ifile = 0;
            if (nmin % 2 != 0)
            {
                ni++;
                ifile += 8;
            }
            for (; ifile < m & ni <= nmax; ifile += 16, ni+=2)
            {
                file.Seek(ifile, SeekOrigin.Begin);
                pow3 = fBR.ReadDouble();
                Console.WriteLine("3^{0} = {1}", ni, pow3);
            }
            fBR.Close();
            file.Close();
            Console.ReadLine();
        }
    }
}
