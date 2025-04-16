using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    class Grade
    {
        // 클래스 당 static field는 하나이다. 
        // static field = 클래스 변수
        //public static int MAX_GRADE_COUNT = 9;
        //private static int MAX_GRADE_COUNT = 9;
        // const = const + static = const는 static이랑 합쳐져있다고 생각하면 된다.
        public const int MAX_GRADE_COUNT = 9;

        // instance field = 인스턴스 필드 (대문자 public, 소문자 private)
        public string StudentNumber;
        // 필드는 설정이 유지된다. 
        // 평균값처럼 계속 달라는 건 필드로 설정하면 안되고 메소드로 만든다.


#if false
        public List<double> Scores = new List<double>();
        
        // instance method = 인스턴스 메소드
        public double Average()  // public = 공공재
        {
            if (this.Scores.Count == 0)
            {
                return -1.0;
            }

            double sum = 0.0;
            foreach (var score in this.Scores)
            {
                sum += score;
            }

            return sum / Scores.Count;
        }
#else
        private List<double> _scores = new List<double>();  // 맨 앞에 아무것도 안 붙으면 기본적으로 private으로 되어져있다.

        public int Count()
        {
            return  _scores.Count;
        }

        public double Get(int i)
        {
            return _scores[i];
        }

        // instance method = 인스턴스 메소드
        public double Average()  // public = 공공재
        {
            if (this._scores.Count == 0)
            {
                return -1.0;
            }

            return _scores.Average();
            return _scores.Sum() / _scores.Count;

            double sum = 0.0;
            foreach (var score in this._scores)
            {
                sum += score;
            }

            return sum / _scores.Count;
        }

        public void Clear()
        {
            _scores.Clear();
        }

        public bool Add(double score)
        {
            //if (_scores.Count >= MAX_GRADE_COUNT)
            //if (_scores.Count >= this.MAX_GRADE_COUNT)
            if (_scores.Count >= Grade.MAX_GRADE_COUNT)
            {
                return false;
            }

            _scores.Add(score);
            return true;
        }
#endif


    }
}
