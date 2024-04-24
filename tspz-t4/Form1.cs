using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tspz_t4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Определить число с найбольшим модулем\nПоложительные числа возвести в квадрат, а отрицательние без изменений\n Зволинський Владислав","About");
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double l1) &&
                double.TryParse(textBox2.Text, out double l2) &&
                double.TryParse(textBox3.Text, out double l3))
            {
                double result1 = Math.Abs(l1);
                double result2 = Math.Abs(l2);
                double result3 = Math.Abs(l3);

                textBox4.Text = result1.ToString();
                textBox5.Text = result2.ToString();
                textBox6.Text = result3.ToString();

                double maxResult = Math.Max(result1, Math.Max(result2, result3));
                textBox7.Text = maxResult.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из приложения?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
            }
        }
    }
}
