using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstForm
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);      // .Parse를 이용하면 문자형식을 숫자로 앞에 형식으로 바꾸어줌
            a *= 2;
            label1.Text = a.ToString();           // .ToString을 이용하면 문자로 바꾸어 출력해줌
        }
    }
}
