using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week04Homework
{
    public partial class FormManager : System.Windows.Forms.Form
    {
        // 인스턴스 필드(변수), 멤버 변수
        Department[] departments;
        List<Professor> professor;
        Dictionary<string, Student> students;   // key값과 value값을 만들어줘야 된다.  // 빨리 찾을땐 list보단 dict를 사용하는 게 좋다.

        List<Grade> testGrades;
        TextBox[] tbxTestScores;

        // 생성자
        // 인스턴스 생성시 초기화가 필요한 코드를 넣는다. 
        public FormManager()  // 폼이 만들어질때 초기화 및 처음 세팅 
        {
            InitializeComponent();
            departments = new Department[10];
            professor = new List<Professor>();
            students = new Dictionary<string, Student>();

            for (int i = 1; i <= 4; i++)
            {
                cmbYear.Items.Add(i);
            }

            cmbClass.Items.AddRange(new object[] { "A", "B", "C" });

            cmbRegStatus.Items.Add("재학");
            cmbRegStatus.Items.Add("졸업");
            cmbRegStatus.Items.Add("휴학");
            cmbRegStatus.Items.Add("퇴학");

            testGrades = new List<Grade>();
            tbxTestScores = new TextBox[] {
                tbxTestScore1,
                tbxTestScore2,
                tbxTestScore3,
                tbxTestScore4,
                tbxTestScore5,
                tbxTestScore6,
                tbxTestScore7,
                tbxTestScore8,
                tbxTestScore9,
            };

            departments[0] = new Department()
            {
                Code = "A001",
                Name = "컴퓨터정보"
            };
            departments[1] = new Department()
            {
                Code = "A002",
                Name = "컴퓨터시스템"
            };

            for (int i = 0; i < departments.Length; i++)
            {
                if (departments[i] != null)
                {
                    lbxDepartment.Items.Add(departments[i]);
                }
            }
            professor.Add(new Professor()
            {
                DepartmentCode = departments[0].Code,
                Number = "2020001",
                Name = "김인하"
            });
            professor.Add(new Professor()
            {
                DepartmentCode = departments[0].Code,
                Number = "2023003",
                Name = "김정석"
            });
            professor.Add(new Professor()
            {
                DepartmentCode = departments[1].Code,
                Number = "2023004",
                Name = "이공전"
            });
            students.Add("20240001", new Student()
            {
                Number = "20240001",
                Name = "김미영",
                RegStatus = "재학",
                Year = 1,
                BirthInfo = new DateTime(2004, 01, 01),
                DepartmentCode = "A001",
                AdvisorNumber = "2020001",
                Class = "B",
                Address = "인천 남구 용현동 100",
                Contact = "032-870-0000"
            });

            foreach (var student in students)
            {
                if (student.Value != null)
                {
                    lbxDictionary.Items.Add(student.Value);
                }
            }

        }

        private void btnRegisterDepartment_Click(object sender, EventArgs e)
        {
            int index = -1;
            for (int i = 0; i < departments.Length; i++)
            {
                if (departments[i] == null)
                {
                    if (index < 0)   // break가 없을때 이 문법을 쓰면 앞부터 채워진다.
                    {
                        index = i;
                    }
                    //break;    // break를 안하면 마지막 부터 채워진다. / break를 하면 앞에서부터 순차적으로 진행됨
                }
                else
                {
                    if (departments[i].Code == tbxDepartmentCode.Text)
                    {
                        MessageBox.Show("동일한 학과코드 사용이 불가능합니다. 다시 입력해주세요");
                        break;
                    }
                }
            }

            if (index < 0)
            {
                // 인덱스안에 null값이 없을 때 표시
                MessageBox.Show("신규 학과정보를 입력받을 수 없습니다.(현재 입력 가능한 인덱스 값 10개입니다.)");

                return;
            }
            Department dept = new Department();
            dept.Code = tbxDepartmentCode.Text;
            dept.Name = tbxDepartmentName.Text;

            departments[index] = dept;

            lbxDepartment.Items.Add(dept);
            // 추후 아래 3문장은 지운다. (지우지 않고 주석처리 해둘 예정)
            //lbxDepartment.Items.Add(dept.Code);
            //lbxDepartment.Items.Add(dept.Name);
            //lbxDepartment.Items.Add($"[{dept.Code}] {dept.Name}");
        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            if (lbxDepartment.SelectedIndex < 0)   // 리스트박스에 있는 값이 선택되어있는지 아닌지
            {
                // 인덱스를 선택하지 않았다는 메세지 출력
                MessageBox.Show("삭제할 것을 선택하지 않았습니다. 삭제할 값을 선택하세요.");
                return;
            }

            // is는 연산자, 타입 확인용으로 사용
            if (lbxDepartment.SelectedItem is Department)
            {
                var target = (Department)lbxDepartment.SelectedItem;

                for (int i = 0; i < departments.Length; i++)
                {
                    if (departments[i] != null && departments[i] == target)
                    {
                        departments[i] = null;
                        break;
                    }
                }
                // items는 가변이다.   추가시 add, 삭제시 remove or removeAt
                lbxDepartment.Items.RemoveAt(lbxDepartment.SelectedIndex);

                lbxDepartment.SelectedIndex = -1;
            }
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabMain.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    cmbProfessorDepartment.Items.Clear();
                    foreach (var department in departments)
                    {
                        if (department != null)
                        {
                            cmbProfessorDepartment.Items.Add(department);
                        }
                    }

                    cmbProfessorDepartment.SelectedIndex = -1;
                    lbxProfessor.Items.Clear();
                    break;
                case 2:
                    cmbDepartment.Items.Clear();
                    foreach (var department in departments)
                    {
                        if (department != null)
                        {
                            cmbDepartment.Items.Add(department);
                        }
                    }
                    cmbDepartment.SelectedIndex = -1;
                    break;
                case 3:
                    tbxTestNumber.Text = "";
                    //(숙제) 성적처리(TEST)의 모든 Control을 지우는 내용을 만들 것
                    ClearTestScoreInfo();
                    break;
            }
        }

        private void ClearTestScoreInfo()
        {
            // 성적처리(TEST)의 모든 Control을 지우는 내용을 만들 것
            lblTestName.Text = "";
            lblTestTotalCount.Text = "";
            lblTestAverage.Text = ""; 
            for (int i = 0; i < tbxTestScores.Length; i++)
            {
                tbxTestScores[i].Text = "";   // string.Empty  = ""
            }
        }

        private void cmbProfessorDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            // index값 검사해서 진행여부 결정
            if (cmbProfessorDepartment.SelectedIndex < 0)
            {
                // (주의) 메세지를 실제로 띄우는 것은 좋지 않은 것으로 보인다.
                return;
            }
            lbxProfessor.Items.Clear();

            // as 형변환 연산자
            // 형변환이 정상적이지 않으면 null 반환 (클래스 계열만 가능)
            var departments = cmbProfessorDepartment.SelectedItem as Department;

            if (departments != null)
            {
                foreach (var professor in professor)
                {
                    // &&(증감연산자 조심할 것)
                    if (professor != null && professor.DepartmentCode == departments.Code)
                    {
                        lbxProfessor.Items.Add(professor);
                    }
                }
            }
        }

        private void btnRegisterProfessor_Click(object sender, EventArgs e)
        {
            foreach (var Professor in professor)
            {
                if (Professor != null && Professor.Number == tbxProfessorNumber.Text)
                {
                    MessageBox.Show("동일한 교수번호 사용이 불가능합니다. 다시 입력해주세요");
                    return;
                }
            }

            // 새 교수 객체 생성
            Professor prof = new Professor();
            Department temp = cmbProfessorDepartment.SelectedItem as Department;
            prof.Number = tbxProfessorNumber.Text;
            prof.Name = tbxProfessorName.Text;
            prof.DepartmentCode = temp.Code;

            // 교수 리스트에 새 교수 추가
            professor.Add(prof);

            // 교수 리스트박스에 새 교수 추가
            lbxProfessor.Items.Add(prof);
        }

        private void btnRemoveProfessor_Click(object sender, EventArgs e)
        {
            if (lbxProfessor.SelectedIndex < 0)   // 리스트박스에 있는 값이 선택되어있는지 아닌지
            {
                // 인덱스를 선택하지 않았다는 메세지 출력
                MessageBox.Show("삭제할 것을 선택하지 않았습니다. 삭제할 값을 선택하세요.");
                return;
            }

            var target = (Professor)lbxProfessor.SelectedItem;

            for (int i = 0; i < professor.Count; i++)
            {
                if (professor[i] != null && professor[i] == target)
                {
                    professor[i] = null;
                    break;
                }
            }

            lbxProfessor.Items.Remove(lbxProfessor.SelectedItem);
            lbxProfessor.SelectedIndex = -1;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            tbxNumber.Text = "20";
            tbxName.Text = "";
            tbxBirthYear.Text = "20";
            tbxBirthMonth.Text = "";
            tbxBirthDay.Text = "";
            cmbDepartment.SelectedIndex = -1;
            cmbAdvisor.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbRegStatus.SelectedIndex = -1;
            tbxAddress.Text = "";
            tbxContact.Text = "";

            // 숙제 (코드 4줄) 
            tbxNumber.ReadOnly = false;
            selectedStudent = null;
            btnRegister.Text = "등록";
            lbxDictionary.SelectedIndex = -1; 
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAdvisor.Items.Clear();
            if (cmbDepartment.SelectedItem != null)
            {
                var selectedDepartmnet = cmbDepartment.SelectedItem as Department;
                if (selectedDepartmnet != null)
                {
                    foreach (var professor in professor)
                    {
                        if (professor != null)
                        {
                            if (professor.DepartmentCode == selectedDepartmnet.Code)
                            {
                                cmbAdvisor.Items.Add(professor);
                            }
                        }
                    }
                }
            }
            cmbAdvisor.SelectedIndex = -1;
        }

        Student selectedStudent = null;  // 인스턴스 필드

        // 많은 코드를 분류하기 위해서 메소드를 사용함
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (selectedStudent == null)
            {
                RegisterStudent();
            }else
            {
                UpdateStudent();  // 메소드 호출 = call
            }
        }

        private void RegisterStudent()
        {
            // 숙제
            // 학번이 비었거나 8자리가 아닌경우 처리하지 않는다.
            if (tbxNumber.Text == "" || (tbxNumber.Text.Length != 8))
            {
                MessageBox.Show("학번을 8자리로 입력하세요(빈값 X)");
                return;
            }
            // 이름이 비었거나 2자 미만인 경우 처리하지 않는다.
            if (tbxName.Text == "" || tbxName.Text.Length < 2)
            {
                MessageBox.Show("이름을 2자 이상 입력하세요");
                return;
            }


            var number = tbxNumber.Text.Trim();  // trim() : 공백제거
            // 실제 많이 사용하는 방법
            if (true == students.ContainsKey(number))
            {
                tbxNumber.Focus();
                return;
            }

            Student student = new Student();
            student.Number = number;
            student.Name = tbxName.Text.Trim();

            int birthYear, birthMonth;//, birthDay;
            // int.TryParse, try가 붙으면 bool타입을 반환 (잘 안되면 false, 잘 안되면 true)
            // TryParse는 변환된 값을 return하지 않기에 지역변수를 지정해둬야됨
            // out 출력 변수? call by refference // birthYear에 참조값을 전달한다.
            if (int.TryParse(tbxBirthYear.Text, out birthYear))    // 많이 사용됨 (int.Parse처럼 안된다고 죽진 않음)
            {
                // 숙제 (1900 ~ 9000)
                if (birthYear < 1900 || birthYear > 9000)
                {
                    MessageBox.Show("1900~9000사이의 값을 입력하세요.");
                    return;
                }
            }
            else
                return;

            if (int.TryParse(tbxBirthMonth.Text, out birthMonth))
            {
                // 1 ~ 12사이에 값
                if (birthMonth < 1 || birthMonth > 12)
                {
                    MessageBox.Show("1~12사이의 값을 입력하세요.");
                    return;
                }
            }
            else
                return;

            if (int.TryParse(tbxBirthDay.Text, out int birthDay))
            {
                if (birthDay < 1 || birthDay > 31)
                {
                    MessageBox.Show("1~31사이의 값을 입력하세요.");
                    return;
                }
            }
            else
                return;

            // DateTime.Now (현재 시간)
            student.BirthInfo = new DateTime(birthYear, birthMonth, birthDay);

            // 소속학과를 설정
            if (cmbDepartment.SelectedIndex < 0)  // 선택된 것이 없을경우 (index값이 -1일 경우)
            {
                //cmbDepartment.Focus();
                //return;
                student.DepartmentCode = null;
            } else
            {
                student.DepartmentCode = (cmbDepartment.SelectedItem as Department).Code;
            }

            // 지도교수 설정
            if (cmbAdvisor.SelectedIndex < 0)
            {
                student.AdvisorNumber = null;
            } else
            {
                student.AdvisorNumber = (cmbAdvisor.SelectedItem as Professor).Number;
            }

            // 학년 설정
            if (cmbYear.SelectedIndex < 0)
            {
                MessageBox.Show("학년을 선택하세요");
                return;
            }
            else
                student.Year = (int)cmbYear.SelectedItem;  // int 형변환

            // 반 설정
            if (cmbClass.SelectedIndex < 0)
            {
                MessageBox.Show("반을 선택하세요");
                return;
            }
            else
                student.Class = cmbClass.SelectedItem.ToString(); // string 처리

            // 재적 상태 설정
            if (cmbRegStatus.SelectedIndex < 0)
            {
                MessageBox.Show("재적상태를 선택하세요");
                return;
            }
            else
                student.RegStatus = cmbRegStatus.SelectedItem.ToString(); // string 처리

            student.Address = tbxAddress.Text;   // 주소 설정
            student.Contact = tbxContact.Text;   // 연락처 설정

            students[number] = student;    // 딕셔너리에 데이터 추가방법 1     (이 코드를 한번 더 쓰면 덮어쓰기 방법이 된다.)
            //students.Add(number, student); // 딕셔너리에 데이터 추가방법 2   (Add는 중복된 키가 있으면 오류가 발생함)
            lbxDictionary.Items.Add(student);

        }

        // UpdateStudent() 코드는 숙제
        private void UpdateStudent() //define
        {
            tbxNumber.ReadOnly = true; // 학번 변경 불가

            if (tbxName.Text == "" || tbxName.Text.Length < 2)
            {
                MessageBox.Show("이름을 2자 이상 입력하세요");
                return;
            }

            // trim() : 공백제거
            var number = tbxNumber.Text.Trim();

            Student student = new Student();
            student.Number = number;
            student.Name = tbxName.Text.Trim();

            int birthYear, birthMonth;//, birthDay;

            if (int.TryParse(tbxBirthYear.Text, out birthYear))    // 많이 사용됨 (int.Parse처럼 안된다고 죽진 않음)
            {
                // 숙제 (1900 ~ 9000)
                if (birthYear < 1900 || birthYear > 9000)
                {
                    MessageBox.Show("1900~9000사이의 값을 입력하세요.");
                    return;
                }
            }
            else
                return;

            if (int.TryParse(tbxBirthMonth.Text, out birthMonth))
            {
                // 1 ~ 12사이에 값
                if (birthMonth < 1 || birthMonth > 12)
                {
                    MessageBox.Show("1~12사이의 값을 입력하세요.");
                    return;
                }
            }
            else
                return;

            if (int.TryParse(tbxBirthDay.Text, out int birthDay))
            {
                // 1 ~ 31사이에 값
                if (birthDay < 1 || birthDay > 31)
                {
                    MessageBox.Show("1~31사이의 값을 입력하세요.");
                    return;
                }
            }
            else
                return;

                student.BirthInfo = new DateTime(birthYear, birthMonth, birthDay);

            // 소속학과를 설정
            if (cmbDepartment.SelectedIndex < 0)  // 선택된 것이 없을경우 (index값이 -1일 경우)
            {
                //cmbDepartment.Focus();
                //return;
                student.DepartmentCode = null;
            }
            else
            {
                student.DepartmentCode = (cmbDepartment.SelectedItem as Department).Code;
            }

            // 지도교수 설정
            if (cmbAdvisor.SelectedIndex < 0)
            {
                student.AdvisorNumber = null;
            }
            else
            {
                student.AdvisorNumber = (cmbAdvisor.SelectedItem as Professor).Number;
            }

            // 학년 설정
            if (cmbYear.SelectedIndex < 0)
            {
                MessageBox.Show("학년을 선택하세요");
                return;
            }
            else
                student.Year = (int)cmbYear.SelectedItem;  // int 형변환

            // 반 설정
            if (cmbClass.SelectedIndex < 0)
            {
                MessageBox.Show("반을 선택하세요");
                return;
            }
            else
                student.Class = cmbClass.SelectedItem.ToString(); // string 처리

            // 재적 상태 설정
            if (cmbRegStatus.SelectedIndex < 0)
            {
                MessageBox.Show("재적상태를 선택하세요");
                return;
            }
            else
                student.RegStatus = cmbRegStatus.SelectedItem.ToString(); // string 처리

            student.Address = tbxAddress.Text;   // 주소 설정
            student.Contact = tbxContact.Text;   // 연락처 설정

            students[number] = student;    // 딕셔너리에서 기존 학생 덮어쓰기

            // 리스트박스 중복 방지 후 업데이트
            lbxDictionary.Items.Remove(selectedStudent);
            lbxDictionary.Items.Add(student);

            // 수정 완료 메시지
            MessageBox.Show("학생 정보가 성공적으로 수정되었습니다.");

            // 화면 초기화
            btnNew_Click(null, EventArgs.Empty);


        }

        private void lbxDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lbxDictionary.SelectedIndex < 0)
            {
                return;
            }

            // btnNew_Click에서 selectedStudent를 null처리하는 부분이 들어가면서 문제가 발생함
            //selectedStudent = (lbxDictionary.SelectedItem as Student);
            //
            //if (selectedStudent != null)
            //{
            //    DisplaySelectedStudent(selectedStudent);
            //}

            // 수정된 코드
            var student = (lbxDictionary.SelectedItem as Student);

            btnNew_Click(sender, EventArgs.Empty);  // clear할때 사용

            if (student != null)
            {
                DisplaySelectedStudent(student);
            }
        }

        private void DisplaySelectedStudent(Student Student)
        {
            selectedStudent = Student;
            tbxNumber.ReadOnly = true;  // 학번을 오직 읽기만 가능하게 하면 된다. / 수정 다 하면 false로 바꿔야 됨
            tbxNumber.Text = Student.Number;
            tbxBirthYear.Text = Student.BirthInfo.Year.ToString();

            //(숙제) 생년월일 중 월을 가져와 설정한다.
            tbxBirthMonth.Text = Student.BirthInfo.Month.ToString();
            //(숙제) 생년월일 중 일을 가져와 설정한다.
            tbxBirthDay.Text = Student.BirthInfo.Day.ToString();

            for (int i = 0; i < cmbDepartment.Items.Count; i++)
            {
                if ((cmbDepartment.Items[i] as Department).Code
                    == Student.DepartmentCode)
                {
                    cmbDepartment.SelectedIndex = i;
                    break;
                }
            }

            // 이름, 소속학과 정보를 가져와 설정하기
            tbxName.Text = Student.Name;
            tbxDepartmentCode.Text = Student.DepartmentCode;
            //(숙제)  
            //지도교수,학년,반,재적상태,주소,연락처의 정보를 가져와 설정한다.
            // 지도교수 정보 가져오기
            for (int i = 0; i < cmbAdvisor.Items.Count; i++)
            {
                if ((cmbAdvisor.Items[i] as Professor).Number == Student.AdvisorNumber)
                {
                    cmbAdvisor.SelectedIndex = i;
                    break;
                }
            }
            cmbYear.SelectedItem = Student.Year; // 학년 정보 가져오기
            cmbClass.SelectedItem = Student.Class; // 반 정보 가져오기
            cmbRegStatus.SelectedItem = Student.RegStatus; // 재적상태 가져오기
            tbxAddress.Text = Student.Address; // 주소 정보 가져오기
            tbxContact.Text = Student.Contact; // 연락처 정보 가져오기

            //btnRegister의 글씨를 "수정"으로 변경한다.
            btnRegister.Text = "수정";
        }

        private void btnTestSearchStudent_Click(object sender, EventArgs e)
        {
            //(숙제) ClearTestScoreInfo()를 호출해서 화면을 정리한다.
            ClearTestScoreInfo();
            //(숙제) 학번이 입력되었는지 여부를 확인하고, 그에 맞는 처리를 진행한다.
            if (tbxTestNumber.Text == "")
            {
                MessageBox.Show("학번을 입력하세요");
                return;
            }

            selectedStudent = SearchStudentByNumber(tbxTestNumber.Text);
            //(숙제) 검색한 학번이 없으면, 그에 맞는 처리를 진행한다.
            //(숙제) 학번을 통해 검색한 학생 정보에서 이름을 가져와 lblTestName에 설정한다.
            if (tbxTestNumber.Text != selectedStudent.Number)
                MessageBox.Show("검색한 학번이 존재하지 않습니다.");
            else
                lblTestName.Text = selectedStudent.Name;

            var grade = SearchGradeByNumber(selectedStudent.Number);
#if false
            if (grade != null)
            {
                for (int i = 0; i < grade.Scores.Count && i < tbxTestScores.Length; i++)
                {
                    tbxTestScores[i].Text = grade.Scores[i].ToString("0.0");  // ToString("0.0") <- 0.0 표기 형식으로 출력해준다.
                }
            }
#endif
            if (grade != null)
            {
                for (int i = 0; i < grade.Count() && i < tbxTestScores.Length; i++)
                {
                    tbxTestScores[i].Text = grade.Get(i).ToString("0.0");  // ToString("0.0") <- 0.0 표기 형식으로 출력해준다.
                }
            }

        }
        
        private Grade SearchGradeByNumber(string number)  // private ??? 
        {
            foreach (Grade grade in testGrades)
            {
                if(grade.StudentNumber == number)
                {
                    return grade;
                }
            }

            return null;
        }


        private Student SearchStudentByNumber(string number)
        {
            if (students.ContainsKey(number))
            {
                return students[number];
            } else
            {
                return null;
            }
        }

        private void btnTestRegScore_Click(object sender, EventArgs e)
        {
            if (selectedStudent == null)
            {
                tbxTestNumber.Focus();
                return;
            }

            // 성적 입력 textbox 중에 앞에 값이 없는데 뒤에 있는 경우 처리하지 않는다.
            for (int i = 1; i < tbxTestScores.Length; i++)
            {
                if (true == string.IsNullOrEmpty(tbxTestScores[i - 1].Text) && false == string.IsNullOrEmpty(tbxTestScores[i].Text))
                {
                    tbxTestScores[i - 1].Focus();
                    return;
                }
            }

            var grade = SearchGradeByNumber(selectedStudent.Number);
            if (grade == null)
            {
                grade = new Grade()
                {
                    StudentNumber = selectedStudent.Number
                };
            }
#if false
            grade.Scores.Clear();

            double temp;
            for (int i = 0; i < tbxTestScores.Length; i++)
            {
                if (string.IsNullOrEmpty(tbxTestScores[i].Text))
                {
                    break;
                }

                if (false == double.TryParse(tbxTestScores[i].Text, out temp))
                {
                    tbxTestScores[i].Focus();
                    return;
                }

                grade.Scores.Add(temp);
            }
#else
            grade.Clear();

            double temp;
            for (int i = 0; i < tbxTestScores.Length; i++)
            {
                if (string.IsNullOrEmpty(tbxTestScores[i].Text))
                {
                    break;
                }

                if (false == double.TryParse(tbxTestScores[i].Text, out temp))
                {
                    tbxTestScores[i].Focus();
                    return;
                }

                grade.Add(temp);
            }
#endif
            testGrades.Add(grade);

            //총 과목수 출력
            lblTestTotalCount.Text = grade.Count().ToString();
            //평균 출력
            double average = grade.Average();
            lblTestAverage.Text = average.ToString("0.0");
        }
    }
}
