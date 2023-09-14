using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp79
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    listBox1.Items.Add(arr[i, j]);
        }
    }
}
