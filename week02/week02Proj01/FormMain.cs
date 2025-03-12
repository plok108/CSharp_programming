using System;
using System.Windows.Forms;

namespace week02Proj01
{
    public partial class FormMain: Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnOutput01_Click(object sender, System.EventArgs e)
        {
            bool isToggle = chkToggle.Checked; // (true or false 의 값만 가짐)
            if (isToggle) {                    // if()안에는 숫자 사용 불가
                string data1 = tbxInput1.Text;
                string data2 = tbxInput2.Text;
                string result = data1 + data2; // 문자열 연결 연산자
                lblResult.Text = result;       // 대입연산자는 좌우가 동일한 타입이어야 한다.
            } else {
                int data1 = int.Parse(tbxInput1.Text);   // int형은 형을 변환해주는 Parse를 지원해준다.
                int data2 = int.Parse(tbxInput2.Text);
                int result = data1 + data2;              // 산술 연산자
                lblResult.Text = result.ToString(); // 문자열을 기본적으로 해주나 여기서는 그걸지원해주는것이 .ToString()임 
            }
        }

        private void btnOutput02_Click(object sender, System.EventArgs e)
        {
            if (chkToggle.Checked == false)   // 바로 다이렉트로 이렇게 써도 됨 
            {
                int data1 = int.Parse(tbxInput1.Text);   
                int data2 = int.Parse(tbxInput2.Text);
                int result = data1 + data2;       // 산술 연산자
                lblResult.Text = "더하기:" + result.ToString(); 
            } else {
                int data1 = int.Parse(tbxInput1.Text);
                int data2 = int.Parse(tbxInput2.Text);
                int result = data1 - data2;      // 산술 연산자
                lblResult.Text = "빼기:" + result;   // 문자열+숫자 = > 문자열 연결 연산자로 동작
            }
        }

        private void btnOutput03_Click(object sender, System.EventArgs e)
        {
            int data1 = int.Parse(tbxInput1.Text);
            int data2 = int.Parse(tbxInput2.Text);
            if (chkToggle.Checked == false)   
            {
                int result = data1 + data2;      
                lblResult.Text = string.Format("더하기:{0}", result);  
            }
            else
            {
                int result = data1 - data2;     
                lblResult.Text = $"빼기: {result}";  // 문자열보간법
            }
        }

        private void btnOutput04_Click(object sender, System.EventArgs e)
        {
            double data2 = double.Parse(tbxInput2.Text);
            double data1 = double.Parse(tbxInput1.Text);
            if (chkToggle.Checked == false)
            {
                double result = data1 + data2;
                lblResult.Text = string.Format("더하기:{0}", result);
            }
            else
            {
                double result = data1 - data2;
                lblResult.Text = $"빼기: {result}";  // 문자열보간법
            }
        }

        private void btnOutput05_Click(object sender, System.EventArgs e)
        {
            lblResult.Text = tbxInput1.Text;
            lblResult.Text += Environment.NewLine;   // "\r\n"(windows 줄바꿈) = Environment.NewLine 
            //lblResult.Text = Environment.NewLine;  // environment.newline은 문자열이다.
            lblResult.Text += tbxInput1.Text.GetType();  // GetType으로 가지고 오는건 문자열이 아니다.
            //lblResult.Text = tbxInput1.Text.GetType();   // 타입이 달라서 에러뜨는거임
            lblResult.Text += Environment.NewLine;

            lblResult.Text += tbxInput1.Text[0];  // char : 문자
            //lblResult.Text = tbxInput1.Text[0];  // 문자열과 문자는 호환이 안됨 
            lblResult.Text = Environment.NewLine;
            lblResult.Text += tbxInput1.Text[0].GetType();

            lblResult.Text += Environment.NewLine;
            char test1 = tbxInput1.Text[0];
            //  c언어  ascii char 1바이트
            // c#언어 unicode char 2바이트
            byte result1 = (byte)test1;   // 1바이트 정수형
            sbyte result4 = (sbyte)test1;   // 1바이트 정수형 (부호지원)
            short result2 = (short)test1;  // 2바이트 정수형 (부호지원) (15비트라 호환 불가) / 캐스트 연산자 적용 가능 
            ushort result3 = test1; //  2바이트 정수형
            //int, uint, long, ulong        

            lblResult.Text += $"{test1},{result1},{result2},{result3}";
        }

        private void btnOutput06_Click(object sender, EventArgs e)
        {
            // 정수 -> 실수 : OK
            // 실수 -> 정수 : 처리 필요
            // 작은 숫자 -> 큰 숫자 : OK
            // 큰 숫자 -> 작은 숫자 : 처리 필요
            int data1 = short.Parse(tbxInput1.Text);
            float data2 = (float)double.Parse(tbxInput2.Text);  // float이 더 크다
            long data3 = long.Parse(tbxInput3.Text);            // long = 8바이트
            int data4 = (int)data3;                             // 형변환 = 나머지 바이트 버린다는 말

            double result1 = data1 + data2 + data3 + data4;
            lblResult.Text = result1.ToString();
            
            // (int)1.9 + (int)1.6 => 2
            long result2 = data1 + (long)data2 + data3 + data4;
            lblResult.Text = result1.ToString();

            // (int)(1.9 + 1.6) => 3
            long result3 = (long)(data1 + data2 + data3 + data4);  // 이걸 좀 많이 쓰긴 하는데 그때그때 상황에 따라 다르다
            lblResult.Text = result1.ToString();
        }
    }
}
