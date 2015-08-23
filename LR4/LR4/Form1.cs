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

namespace LR4
{
    public partial class Form1 : Form
    {
        CompressService cs;

        public Form1()
        {
            InitializeComponent();
            cs = new CompressService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s=File.ReadAllText("test.txt");
            cs.Stringa = s;
            CompressedString g = cs.Comprimi();

        }


        
        
        
    }
}
