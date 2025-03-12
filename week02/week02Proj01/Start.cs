using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week02Proj01
{
    static class Start
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());  // Key point  , Run 이라는것도 일종에 프레임워크 구조이다. 나중에 다시 설명 들을 수 있음
        }
    }
}
