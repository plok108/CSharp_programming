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

        private void btnOutput07_Click(object sender, EventArgs e)
        {
            // 관계 연산자 이용
            bool result1 = (tbxInput1.Text == tbxInput2.Text);
            bool result2 = (tbxInput2.Text == tbxInput3.Text);
            bool result3 = (tbxInput1.Text == tbxInput3.Text);

            // 논리 연산자 이용
            if (result1 && result2 && result3)
            {
                lblResult.Text = "모두 일치";
            } else if (result1 || result2 || result3)
            {
                lblResult.Text = "적어도 일치하는 데이터가 있음";
            } else
            {
                lblResult.Text = "모두 불일치";
            }
        }

        private void btnOutput08_Click(object sender, EventArgs e)
        {
            var data1 = int.Parse(tbxInput1.Text);
            var data2 = int.Parse(tbxInput2.Text);

            string result;  // 지역변수 - 초기화가 자동으로 안됩니다. (else 사용 안함으로 인한 오류)
            if (data1 == data2)
            {
                result = "같아요"; 
            } else if (data1 < data2)
            {
                result = "뒤가 커요";
            } else  // if (data1 > data2)     <-- 이건 붙일 이유조차 없다. (쓰면 오류 발생)
            {
                result = "앞이 커요";
            }

            lblResult.Text = result;
        }

        private void btnOutput09_Click(object sender, EventArgs e)
        {
            //lblResult.Text = int.MinValue.ToString() + "\r\n";
        }

        private void btnOutput10_Click(object sender, EventArgs e) // 이거 중요함(이해 안되면 외울 것)
        {
            // 배열 array
            // TextBox  textBoxes[5];    
            TextBox[] textBoxes;           // 배열변수 선언
            textBoxes = new TextBox[5];    // 배열생성 후 위치 할당 (textBoxes에 위치 저장)

            textBoxes[0] = tbxInput1;
            textBoxes[1] = tbxInput2;
            textBoxes[2] = tbxInput3;
            textBoxes[3] = tbxInput4;
            textBoxes[4] = tbxInput5;

            // 객체지향 언어의 특징 중 하나는
            // 자료형을 class(or struct)로 만든다.
            // class = (값 + 추가 meta data) + 기능   <-- 배열은 자신의 길이(갯수)을/를 알고 있다.
            int sum = 0;
            for (int i = 0; i < textBoxes.Length; i++)
            {
                // class로 만들어진 것은 기본값이 null이다.
                // python에서 strip과 같은 공백을 없애는 함수 : Trim()
                if (textBoxes[i].Text != null && textBoxes[i].Text.Trim() != "")   
                {
                    sum += int.Parse(textBoxes[i].Text);
                }
            }
            lblResult.Text = "총합 : " + sum;
        }

        private void btnOutput11_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes;         
            textBoxes = new TextBox[5];  

            textBoxes[0] = tbxInput1;
            textBoxes[1] = tbxInput2;
            textBoxes[2] = tbxInput3;
            textBoxes[3] = tbxInput4;
            textBoxes[4] = tbxInput5;

            int sum = 0;
            int count = 0;
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (textBoxes[i].Text != null && textBoxes[i].Text.Trim() != "")
                {
                    sum += int.Parse(textBoxes[i].Text);
                    count++;   // 모든 값이 없을경우 오류 뜸
                }
            }
            lblResult.Text = "평균 : " + (sum  / count);
        }
    }
}
