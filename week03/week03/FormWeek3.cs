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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess01_Click(object sender, EventArgs e)
        {
            TextBox[] arrTbxData = new TextBox[5];  // ctrl + - 직전상태로 감 / f12 어떤 구조로 되어있는지 볼 수 있음
            arrTbxData[0] = tbxData1;
            arrTbxData[1] = tbxData2;
            arrTbxData[2] = tbxData3;
            arrTbxData[3] = tbxData4;
            arrTbxData[4] = tbxData5;

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
                if (arrTbxData[i].Text != null && arrTbxData[i].Text.Trim() == "")
                {
                    // 문자열이 없거나, 이상하거나 두가지 경우만 없으면 됨
                    arrIntData[i] = int.Parse(arrTbxData[i].Text);
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
                    if (arrIntData[i] != 0)    // 중간고사 넣을 수 있음
                    {
                        result /= arrIntData[i];
                    }
                    else
                    {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 안돼!");
                        return;  // 모든 명령 종료
                    }
                }
            }
            else
            {
                MessageBox.Show("연산을 선택하세요.");
                return;  // 메소드를 즉시 종료하고 호출한 곳으로 돌아간다.
            }


        }

        private void btnProcess02_Click(object sender, EventArgs e)
        {
          //  TextBox[] arrTbxData = new TextBox[5];  // ctrl + - 직전상태로 감 / f12 어떤 구조로 되어있는지 볼 수 있음
          //  arrTbxData[0] = tbxData1;
          //  arrTbxData[1] = tbxData2;
          //  arrTbxData[2] = tbxData3;
          //  arrTbxData[3] = tbxData4;
          //  arrTbxData[4] = tbxData5;
          //
          //  // 배열의 가장 큰 특징 : 고정길이(길이가 변하지 않음)
          //  // 배열 생성 시 사용할 길이(length)를 정해두고 시작해야 됨
          //  // 배열의 길이는 반드시 상수(변하지 않는) 값이 들어가야 함.
          //  // 배열의 길이는 생성 후 변하지 않기 때문에
          //  // 다른 배열의 길이로 사용해도 괜찮음
          //
          //  // 배열 요소의 초기값!
          //  // struct는 struct의 기본값 (ex : int -> 0)
          //  // class는 null
          //  //int[] arrIntData = new int[5];
          //  int[] arrIntData = new int[arrTbxData.Length];
          //
          //  for (int i = 0; i < arrTbxData.Length; i++)
          //  {
          //      // null인지 부터 물어보고 그 다음에 공백을 확인한다.
          //          // arrTbxData[i].Text != null && arrTbxData[i].Text.Trim() == ""를 단축해서 사용하는 방법
          //          // null 이거나 empty면 true로 해준다. 그래서 !(not)을 붙여서 확인한다.
          //          // 그래서 !를 안쓰고 false == 를 앞에 사용한다.
          //      if (false == string.IsNullOrEmpty(arrTbxData[i].Text))  
          //      {
          //          // 문자열이 없거나, 이상하거나 두가지 경우만 없으면 됨
          //          arrIntData[i] = int.Parse(arrTbxData[i].Text);
          //      }
          //  }
          //
          //  int result = 0;
          //  if (rbtAdd.Checked)
          //  {
          //      for (int i = 0; i < arrIntData.Length; i++)
          //      {
          //          result += arrIntData[i];
          //      }
          //  }
          //  else if (rbtSub.Checked)
          //  {
          //      result = arrIntData[0];
          //      for (int i = 1; i < arrIntData.Length; i++)
          //      {
          //          result -= arrIntData[i];
          //      }
          //  }
          //  else if (rbtMul.Checked)
          //  {
          //      result = arrIntData[0];
          //      for (int i = 1; i < arrIntData.Length; i++)
          //      {
          //          result *= arrIntData[i];
          //      }
          //  }
          //  else if (rbtDiv.Checked)
          //  {
          //      result = arrIntData[0];
          //      for (int i = 1; i < arrIntData.Length; i++)
          //      {
          //          if (arrIntData[i] != 0)    // 중간고사 넣을 수 있음
          //          {
          //              result /= arrIntData[i];
          //          }
          //          else
          //          {
          //              arrTbxData[i].Focus();
          //              MessageBox.Show("0은 안돼!");
          //              return;  // 모든 명령 종료
          //          }
          //      }
          //  }
          //  else
          //  {
          //      MessageBox.Show("연산을 선택하세요.");
          //      return;  // 메소드를 즉시 종료하고 호출한 곳으로 돌아간다.
          //  }
          //
        }
    }
}
