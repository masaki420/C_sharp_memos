using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string answer, answer2;

            if (radioButton1.Checked == true)
            {
                answer2 = "10代";
            }
            else if (radioButton2.Checked == true)
            {
                answer2 = "20代";
            }
            else if (radioButton3.Checked == true)
            {
                answer2 = "30代";
            }
            else
            {
                answer2 = "40代";
            }

            answer = textBox1.Text;
            DialogResult result = MessageBox.Show(answer + "さんは" + answer2 + "です。");

        }
    }
