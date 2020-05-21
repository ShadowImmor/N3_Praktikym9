using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1_г
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Nmin.Minimum = int.MinValue;
            Nmin.Maximum = int.MaxValue;
            Nmax.Minimum = int.MinValue;
            Nmax.Maximum = int.MaxValue;
        }

        private void Pow3_Click(object sender, EventArgs e)
        {
            Pow3Even.Clear();
            if (Nmin.Value != (int)Nmin.Value)
                Nmin.Value = (int)Nmin.Value;
            if (Nmax.Value != (int)Nmax.Value)
                Nmax.Value = (int)Nmax.Value;
            FileStream file = new FileStream("..\\..\\..\\binfile.dat", FileMode.OpenOrCreate);
            BinaryWriter fBW = new BinaryWriter(file);
            for (int i = (int)Nmin.Value; i <= (int)Nmax.Value; i++)
            {
                fBW.Write(Math.Pow(3, i));
            }
            fBW.Close();
            file = new FileStream("..\\..\\..\\binfile.dat", FileMode.OpenOrCreate);
            BinaryReader fBR = new BinaryReader(file);
            long m = file.Length;
            double pow3;
            int ni = (int)Nmin.Value;
            long ifile = 0;
            if ((int)Nmin.Value % 2 != 0)
            {
                ni++;
                ifile += 8;
            }
            for (; ifile < m & ni <= (int)Nmax.Value; ifile += 16, ni += 2)
            {
                file.Seek(ifile, SeekOrigin.Begin);
                pow3 = fBR.ReadDouble();
                Pow3Even.Text += "3^" + ni + " = " + pow3 + "\n";
            }
            fBR.Close();
            file.Close();
        }
    }
}
