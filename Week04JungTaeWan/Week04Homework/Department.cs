using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    // Object 클래스를 상속한 Department 클래스를 만듬
    class Department  : Object     // 자료형 설계    // 희미한 색으로 바뀌면 써도되고 안써도 된다 = default 값
    {
        public string Code;        // 변수(공개되어있는)
        public string Name;

        public override string ToString()
        {
            return $"[{Code}] {Name}";
        }

    }
}
