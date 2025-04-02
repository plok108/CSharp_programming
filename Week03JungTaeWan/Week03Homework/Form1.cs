using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Week03JungTaeWan
{
    public partial class FormMain : Form
    {
        int num1 = 0;            // 첫 번째 숫자
        int num2 = 0;            // 두 번째 숫자
        string oppr1 = "";       // 연산자 저장

        public FormMain()
        {
            InitializeComponent();
            num1 = 0;
            num2 = 0;
            string oppr1 = "";
        }


        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button target = (Button)sender;
            if (oppr1 == "")  // 연산자가 입력되기 전에
            {
                num1 = num1 * 10 + int.Parse(target.Text); // 첫 번째 숫자 저장
                lblNumbers.Text = num1.ToString(); // 숫자 표현
                lblExpression.Text = lblNumbers.Text; // 계산식에 숫자 표현
            }
            else   // 연산자가 입력된 후
            {
                num2 = num2 * 10 + int.Parse(target.Text); // 두 번째 숫자 저장
                lblNumbers.Text = num2.ToString(); // 숫자 표현
                lblExpression.Text = lblExpression.Text + " " + num2.ToString(); // 계산식에 표현
            }
        }


        private void btnOper_Click(object sender, EventArgs e)
        {
            Button target = (Button)sender;

            if (num1 != 0 && num2 == 0) // 첫 번째 숫자가 입력된 상태에서 연산자 입력 시
            {
                oppr1 = target.Text; // 연산자 저장
                lblExpression.Text += " " + oppr1 + " "; // 계산식 표현
            }

            if (num2 == 0 && oppr1 != "")  // 결과를 이미 출력하고 새로운 연산자를 입력할 때
            {
                // 이전 결과와 새 연산자만 이어서 표시
                lblExpression.Text = lblNumbers.Text + " " + target.Text;
            }

        }


        private void btnCal_Click(object sender, EventArgs e)
        {
            int result = 0;

            switch (oppr1)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("0으로 나눌 수 없습니다.");
                        return;
                    }
                    break;
                default:
                    MessageBox.Show("연산자를 선택하세요.");
                    return;
            }


            num1 = result; // 결과를 num1에 저장
            num2 = 0;      // 두 번째 숫자 초기화
            oppr1 = "";    // 연산자 초기화

            lblExpression.Text = lblExpression.Text + " = " + result.ToString();
            lblNumbers.Text = result.ToString();
        }
    }
}
