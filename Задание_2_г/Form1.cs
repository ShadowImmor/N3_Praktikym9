using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_2_г
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Kolword.Clear();
            if (!File.Exists(FilePath.Text))
                return;
            StreamReader fileIn = new StreamReader(FilePath.Text);
            string text = fileIn.ReadToEnd();
            fileIn.Close();
            int k = 0;
            string[] newText = Regex.Split(text, @"[\W\s]+");
            foreach (string b in newText)
                if (b != "")
                    if (b[0] == b[b.Length - 1])
                        k++;
            Kolword.Text = k.ToString();
        }
    }
}
