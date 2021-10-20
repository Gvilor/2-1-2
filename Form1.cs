using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtx.Text = Properties.Settings.Default.x.ToString();
            txty.Text = Properties.Settings.Default.y.ToString();
        }

       

        private void txtx_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y;
            try
            {
                x = int.Parse(this.txtx.Text);
                txtx.BackColor = Color.White;
            }
            catch
            {
                txtx.BackColor = Color.Red;
                MessageBox.Show("Введено некоректное значение", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                y = int.Parse(this.txty.Text);
                txty.BackColor = Color.White;
            }
            catch
            {
                txty.BackColor = Color.Red;
                MessageBox.Show("Введено некоректное значение", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Properties.Settings.Default.x = x;
            Properties.Settings.Default.y = y;
            Properties.Settings.Default.Save();

            MessageBox.Show("Произведение равно = " + Logic.Multiply(x, y));
        }
    }

    public class Logic
    {
        public static int Multiply(int x, int y)
        {
            int b = 0;

            for (int i = 0; i < y; i++)
            {
                b = b + x;
            }
            return b;
        }
    }

}
