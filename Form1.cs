using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2._2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String arrayStr = textBox1.Text;
            String pattern = @"^-?\d+(\s-?\d+)*$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(arrayStr))
            {
                String[] arrStr = arrayStr.Split(' ');
                int[] arr = new int[arrStr.Length];
                for (int i = 0; i < arrStr.Length; i++)
                {
                    arr[i] = Convert.ToInt32(arrStr[i]);
                }
                Logic logic = new Logic(arr);
                int div = logic.CountSignChanges();
                String result = Convert.ToString(logic.CountSignChanges());
                if (div % 10 >= 2 && div % 10 <= 4)
                {
                    result = Convert.ToString(logic.CountSignChanges()) + " раза";
                }
                else
                {
                    result = Convert.ToString(logic.CountSignChanges()) + " раз";
                }
                label2.Text = result;
            } else
            {
                label2.Text = "Неверно введён массив";
            }
        }
    }
}
