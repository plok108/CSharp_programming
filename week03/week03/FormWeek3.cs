using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week03
{
    // class의 구성요소 : 값(변수) + 기능(메소드)    // ctrl + m + m
    public partial class Form1 : Form
    {
        // 멤버 변수 or 인스턴스 변수
        // C#에서는 instance field라고 지칭
        TextBox[] arrTbxData; 
        
        // 생성자
        // (1) 이름은 반드시 클래스 이름과 동일할 것
        // (2) 반환 타입을 표시하면 안됨
        // 인스턴스 생성 시 무조건 1번만 호출됨. (*)

        public Form1()
        {
            InitializeComponent();   // InitializeComponent(); 앞에 코드를 작성하면 안됨

            arrTbxData = new TextBox[5];
            arrTbxData[0] = tbxData1;
            arrTbxData[1] = tbxData2;
            arrTbxData[2] = tbxData3;
            arrTbxData[3] = tbxData4;
            arrTbxData[4] = tbxData5;
        }

        private void btnProcess01_Click(object sender, EventArgs e)
        {
            //arrTbxData = new TextBox[5];  // ctrl + - 직전상태로 감 / f12 어떤 구조로 되어있는지 볼 수 있음
            //arrTbxData[0] = tbxData1;
            //arrTbxData[1] = tbxData2;
            //arrTbxData[2] = tbxData3;
            //arrTbxData[3] = tbxData4;
            //arrTbxData[4] = tbxData5;

            // 배열의 가장 큰 특징 : 고정길이(길이가 변하지 않음)
            // 배열 생성 시 사용할 길이(length)를 정해두고 시작해야 됨
            // 배열의 길이는 반드시 상수(변하지 않는) 값이 들어가야 함.
            // 배열의 길이는 생성 후 변하지 않기 때문에
            // 다른 배열의 길이로 사용해도 괜찮음

            // 배열 요소의 초기값!
            // struct는 struct의 기본값 (ex : int -> 0)
            // class는 null
            //int[] arrIntData = new int[5];
            int[] arrIntData = new int[arrTbxData.Length];

            for (int i = 0; i < arrTbxData.Length; i++)
            {
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text))
                {
                    // 문자열이 없거나, 이상하거나 두가지 경우만 없으면 됨
                    arrIntData[i] = int.Parse(arrTbxData[i].Text);
                } else {
                    //arrIntData[i] = 0; -> 과 동일함.... 왜?
                }
            }

            int result = 0;
            if (rbtAdd.Checked) {
                for (int i = 0; i < arrIntData.Length; i++) {
                    result += arrIntData[i];
                }
            } else if (rbtSub.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++) {
                    result -= arrIntData[i];
                }
            } else if (rbtMul.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++) {
                    result *= arrIntData[i];
                }
            } else if (rbtDiv.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++) {
                    if (arrIntData[i] == 0)
                    {     // 중간고사 넣을 수 있음
                        arrTbxData[i].Focus();    // Focus가 뭔데 ??
                        MessageBox.Show("0은 안돼!");
                        return;
                    }
                    result /= arrIntData[i];
                }
            } else {
                    MessageBox.Show("연산자를 선택하세요");
                    return;  // 메소드를 즉시 종료하고 호출한 곳으로 돌아간다. / 모든 명령 종료
            }

            lblResult.Text = result.ToString();
        }

        private void btnProcess02_Click(object sender, EventArgs e)
        {
            //TextBox[] arrTbxData = new TextBox[5];  // ctrl + - 직전상태로 감 / f12 어떤 구조로 되어있는지 볼 수 있음
            //arrTbxData[0] = tbxData1;
            //arrTbxData[1] = tbxData2;
            //arrTbxData[2] = tbxData3;
            //arrTbxData[3] = tbxData4;
            //arrTbxData[4] = tbxData5;
          
            // 배열의 가장 큰 특징 : 고정길이(길이가 변하지 않음)
            // 배열 생성 시 사용할 길이(length)를 정해두고 시작해야 됨
            // 배열의 길이는 반드시 상수(변하지 않는) 값이 들어가야 함.
            // 배열의 길이는 생성 후 변하지 않기 때문에
            // 다른 배열의 길이로 사용해도 괜찮음
          
            // 배열 요소의 초기값!
            // struct는 struct의 기본값 (ex : int -> 0)
            // class는 null
            //int[] arrIntData = new int[5];
            int[] arrIntData = new int[arrTbxData.Length];
          
            for (int i = 0; i < arrTbxData.Length; i++)
            {
                // null인지 부터 물어보고 그 다음에 공백을 확인한다.
                    // arrTbxData[i].Text != null && arrTbxData[i].Text.Trim() == ""를 단축해서 사용하는 방법
                    // null 이거나 empty면 true로 해준다. 그래서 !(not)을 붙여서 확인한다.
                    // 그래서 !를 안쓰고 false == 를 앞에 사용한다.
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text))  
                {
                    // 문자열이 없거나, 이상하거나 두가지 경우만 없으면 됨
                    arrIntData[i] = int.Parse(arrTbxData[i].Text);
                } else
                {
                    //arrIntData[i] = 0;  -> 동일함... 왜?
                }
            }
          
            int result = 0;
            if (rbtAdd.Checked)
            {
                for (int i = 0; i < arrIntData.Length; i++)
                {
                    result += arrIntData[i];
                }
            }
            else if (rbtSub.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    result -= arrIntData[i];
                }
            }
            else if (rbtMul.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    result *= arrIntData[i];
                }
            }
            else if (rbtDiv.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    if (arrIntData[i] == 0)    // 중간고사 넣을 수 있음
                    {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 안돼");
                        return;
                    }
                    result /= arrIntData[i];
                }
            }
            else
            {
                MessageBox.Show("연산을 선택하세요.");
                return;  // 메소드를 즉시 종료하고 호출한 곳으로 돌아간다.
            }

            lblResult.Text = result.ToString();
          
        }

        private void btnProcess03_Click(object sender, EventArgs e)
        {
            // 배열 vs. 리스트
            // 고정길이 = 가변길이
            // Length = Count
            // 공통점 : 요소 접근 방법 [index]
            // string a = "11";
            // int b = a.Length;  // 문자열은 고정길이다.
            // a += "b";         // 문자열은 증가하지 않고 별도의 문자열이 생긴다.
            // b = a.Length;  

            //TextBox[] arrTbxData = new TextBox[5];   // 기본값이 null로 채워짐
            //arrTbxData[0] = tbxData1;
            //arrTbxData[1] = tbxData2;
            //arrTbxData[2] = tbxData3;
            //arrTbxData[3] = tbxData4;
            //arrTbxData[4] = tbxData5;

            //int[] arrIntData = new int[arrTbxData.Length]; // struct는 기본값이 0으로 채워짐
            // <> Generic(일반화) 지원 자료형       <--- 중간고사 이후 범위
            List<int> arrIntData = new List<int>();

            for (int i = 0; i < arrTbxData.Length; i++)
            {
                
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text))
                {
                    // Add(), Insert(), Remove(), RemoveAt()
                    arrIntData.Add(int.Parse(arrTbxData[i].Text));   // .Add로 코드로 변경
                }
                else
                {

                }
            }

            int result = 0;
            if (rbtAdd.Checked)
            {
                for (int i = 0; i < arrIntData.Count; i++)
                {
                    result += arrIntData[i];
                }
            }
            else if (rbtSub.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++)
                {
                    result -= arrIntData[i];
                }
            }
            else if (rbtMul.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++)
                {
                    result *= arrIntData[i];
                }
            }
            else if (rbtDiv.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++)
                {
                    if (arrIntData[i] == 0)   
                    {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 안돼");
                        return;
                    }
                    result /= arrIntData[i];
                }
            }
            else
            {
                MessageBox.Show("연산을 선택하세요.");
                return; 
            }

            lblResult.Text = result.ToString();
        }

        private void btnProcess04_Click(object sender, EventArgs e)
        {

            //TextBox[] arrTbxData = new TextBox[5];
            //arrTbxData[0] = tbxData1;
            //arrTbxData[1] = tbxData2;
            //arrTbxData[2] = tbxData3;
            //arrTbxData[3] = tbxData4;
            //arrTbxData[4] = tbxData5;

            List<int> arrIntData = new List<int>();

            for (int i = 0; i < arrTbxData.Length; i++)
            {

                if (false == string.IsNullOrEmpty(arrTbxData[i].Text))
                {
                    arrIntData.Add(int.Parse(arrTbxData[i].Text)); 
                }
                else
                {

                }
            }
            if (!chkAdd.Checked
                && !chkSub.Checked
                && !chkMul.Checked
                && !chkDiv.Checked)
            {
                MessageBox.Show("연산을 선택하세요");
                return;
            }
            int result = 0;
            string totalResult =  "";

            if (chkAdd.Checked)
            {
                for (int i = 0; i < arrIntData.Count; i++)
                {
                    result += arrIntData[i];
                }

                totalResult += $"더하기:{result}";
                totalResult += Environment.NewLine;
            }
            if (chkSub.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++)
                {
                    result -= arrIntData[i];
                }

                totalResult += $"빼기:{result}";
                totalResult += Environment.NewLine;
            }
            if (chkMul.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++)
                {
                    result *= arrIntData[i];
                }

                totalResult += $"곱하기:{result}";
                totalResult += Environment.NewLine;
            }
            if (chkDiv.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++)
                {
                    if (arrIntData[i] == 0)
                    {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 안돼");
                        return;
                    }
                    result /= arrIntData[i];
                }
                totalResult += $"나누기:{result}";
                totalResult += Environment.NewLine;
            }
            lblResult.Text = totalResult.ToString();
        }

        private void chkOption_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton[] radioButtons = new RadioButton[] {
                rbtAdd,
                rbtSub,
                rbtMul,
                rbtDiv,
            };

            List<CheckBox> checkBoxes = new List<CheckBox> {
                chkAdd,
                chkSub,
                chkMul,
                chkDiv,
            };

            var isEng = chkOption.Checked;
            string word;

            for (int i = 0; i < radioButtons.Length; i++) {
                switch (i) {
                    case 0:
                        word = (isEng ? "Add" : "더하기"); break;
                    case 1:
                        word = (isEng ? "Sub" : "빼기"); break;
                    case 2:
                        word = (isEng ? "Mul" : "곱하기"); break;
                    case 3:
                        word = (isEng ? "DIV" : "나누기"); break;
                    default: continue; // break는 switch 만 나가짐
                }

                radioButtons[i].Text = word;
                checkBoxes[i].Text = word;
            }
        }

        private void btnProcess06_Click(object sender, EventArgs e)
        {
            if (cmbBeverage.SelectedIndex < 0) {         // cmb의 인덱스값이 음수일 경우 기본적으로 처리하는 것이 아님
                MessageBox.Show("음료를 선택하세요.");
                return;
            }

            //cmbBeverage.Items.Length;    // 고정길이가 아니고 가변길이 이다.

            int price = 0;
            //switch (cmbBeverage.Items[cmbBeverage.SelectedIndex].ToString()) {   // cmbBeverage.SelectedIndex가 0, 1, 2가 출력 됨
            switch (cmbBeverage.SelectedItem.ToString()) {   // 위에 줄을 대신 쓰는 것
                case "아메리카노": price = 2500; break;
                case "카페라떼": price = 3500; break;
                case "플랫화이트": price = 3800; break;
                default: return;
            }

            // var = 타입을 명시적으로 작성하지 않아도 되므로, 길고 반복적인 타입 선언을 생략할 수 있다.
            //       코드량을 줄일 때 사용함
            var iceoption = chkIce.Checked ? "아이스" : "";
            var iceprice = chkIce.Checked ? 500 : 0;
            //iceprice = "0";

            lblResult.Text =
                $"{iceoption}{cmbBeverage.SelectedItem}: " + $"{price + iceprice}";
        }

        private void btnProcess07_Click(object sender, EventArgs e)
        {
            if (cmbBeverage.SelectedIndex < 0)
            {         
                MessageBox.Show("음료를 선택하세요.");
                return;
            }

            int price = 0;
            switch (cmbBeverage.SelectedIndex)   // index로 정해져있으면 숫자를 받아오는 방법도 있다.
            {
                case 0: 
                    price = 2500; 
                    break;
                case 1: 
                    price = 3500; 
                    break;
                case 2: 
                    price = 3800; 
                    break;
                default: 
                    return;
            }

            var iceoption = chkIce.Checked ? "아이스" : "";
            var iceprice = chkIce.Checked ? 500 : 0;

            lblResult.Text =
                $"{iceoption}{cmbBeverage.SelectedItem}: " + $"{price + iceprice}";
        }

        private void btnProcess08_Click(object sender, EventArgs e)
        {
            if (cmbBeverage.SelectedIndex < 0)
            {
                MessageBox.Show("음료를 선택하세요.");
                return;
            }

            var prices = new int[] { 
                2500,
                3500,
                3800,
            };

            int price = 0;
            if (cmbBeverage.SelectedIndex < prices.Length) {   // 항상 index 값보다 -1이어야 한다. 
                price = prices[cmbBeverage.SelectedIndex];
            } else {
                return;
            }

            var iceoption = chkIce.Checked ? "아이스" : "";
            var iceprice = chkIce.Checked ? 500 : 0;

            lblResult.Text =
                $"{iceoption}{cmbBeverage.SelectedItem}: " + $"{price + iceprice}";
        }
    }
}
