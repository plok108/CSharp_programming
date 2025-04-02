namespace Week04Homework
{
    partial class FormManager
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumber = new System.Windows.Forms.Label();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblBirth = new System.Windows.Forms.Label();
            this.tbxBirthYear = new System.Windows.Forms.TextBox();
            this.lblBirthYear = new System.Windows.Forms.Label();
            this.lblBirthMonth = new System.Windows.Forms.Label();
            this.tbxBirthMonth = new System.Windows.Forms.TextBox();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.tbxBirthDay = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblAdvisor = new System.Windows.Forms.Label();
            this.tbxAdvisor = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblRegStatus = new System.Windows.Forms.Label();
            this.cmbRegStatus = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.tbxContact = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbxArray = new System.Windows.Forms.ListBox();
            this.lbxList = new System.Windows.Forms.ListBox();
            this.lbxDictionary = new System.Windows.Forms.ListBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpgDepartment = new System.Windows.Forms.TabPage();
            this.tpgProfessor = new System.Windows.Forms.TabPage();
            this.tpgStudent = new System.Windows.Forms.TabPage();
            this.lblDepartmentCode = new System.Windows.Forms.Label();
            this.tbxDepartmentCode = new System.Windows.Forms.TextBox();
            this.tbxDepartmentName = new System.Windows.Forms.TextBox();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.lbxDepartment = new System.Windows.Forms.ListBox();
            this.btnRegisterDepartment = new System.Windows.Forms.Button();
            this.btnRemoveDepartment = new System.Windows.Forms.Button();
            this.lbxProfessor = new System.Windows.Forms.ListBox();
            this.btnRemoveProfessor = new System.Windows.Forms.Button();
            this.btnRegisterProfessor = new System.Windows.Forms.Button();
            this.lblProfessorNumber = new System.Windows.Forms.Label();
            this.tbxProfessorNumber = new System.Windows.Forms.TextBox();
            this.tbxProfessorName = new System.Windows.Forms.TextBox();
            this.lblProfessorName = new System.Windows.Forms.Label();
            this.lblProfessorDepartment = new System.Windows.Forms.Label();
            this.cmbProfessorDepartment = new System.Windows.Forms.ComboBox();
            this.tabMain.SuspendLayout();
            this.tpgDepartment.SuspendLayout();
            this.tpgProfessor.SuspendLayout();
            this.tpgStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(25, 18);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(37, 15);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "학번";
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(117, 13);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(100, 25);
            this.tbxNumber.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(256, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "이름";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(348, 13);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 25);
            this.tbxName.TabIndex = 1;
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(25, 58);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(67, 15);
            this.lblBirth.TabIndex = 0;
            this.lblBirth.Text = "생년월일";
            // 
            // tbxBirthYear
            // 
            this.tbxBirthYear.Location = new System.Drawing.Point(117, 53);
            this.tbxBirthYear.Name = "tbxBirthYear";
            this.tbxBirthYear.Size = new System.Drawing.Size(100, 25);
            this.tbxBirthYear.TabIndex = 1;
            // 
            // lblBirthYear
            // 
            this.lblBirthYear.AutoSize = true;
            this.lblBirthYear.Location = new System.Drawing.Point(227, 58);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(22, 15);
            this.lblBirthYear.TabIndex = 0;
            this.lblBirthYear.Text = "년";
            // 
            // lblBirthMonth
            // 
            this.lblBirthMonth.AutoSize = true;
            this.lblBirthMonth.Location = new System.Drawing.Point(330, 59);
            this.lblBirthMonth.Name = "lblBirthMonth";
            this.lblBirthMonth.Size = new System.Drawing.Size(22, 15);
            this.lblBirthMonth.TabIndex = 0;
            this.lblBirthMonth.Text = "년";
            // 
            // tbxBirthMonth
            // 
            this.tbxBirthMonth.Location = new System.Drawing.Point(271, 53);
            this.tbxBirthMonth.Name = "tbxBirthMonth";
            this.tbxBirthMonth.Size = new System.Drawing.Size(50, 25);
            this.tbxBirthMonth.TabIndex = 1;
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.Location = new System.Drawing.Point(426, 58);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(22, 15);
            this.lblBirthDay.TabIndex = 0;
            this.lblBirthDay.Text = "년";
            // 
            // tbxBirthDay
            // 
            this.tbxBirthDay.Location = new System.Drawing.Point(367, 52);
            this.tbxBirthDay.Name = "tbxBirthDay";
            this.tbxBirthDay.Size = new System.Drawing.Size(50, 25);
            this.tbxBirthDay.TabIndex = 1;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(25, 99);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(67, 15);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "소속학과";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(117, 96);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(331, 23);
            this.cmbDepartment.TabIndex = 2;
            // 
            // lblAdvisor
            // 
            this.lblAdvisor.AutoSize = true;
            this.lblAdvisor.Location = new System.Drawing.Point(25, 141);
            this.lblAdvisor.Name = "lblAdvisor";
            this.lblAdvisor.Size = new System.Drawing.Size(67, 15);
            this.lblAdvisor.TabIndex = 0;
            this.lblAdvisor.Text = "지도교수";
            // 
            // tbxAdvisor
            // 
            this.tbxAdvisor.Location = new System.Drawing.Point(117, 136);
            this.tbxAdvisor.Name = "tbxAdvisor";
            this.tbxAdvisor.Size = new System.Drawing.Size(331, 25);
            this.tbxAdvisor.TabIndex = 1;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(25, 179);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(37, 15);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "학년";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(117, 176);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(100, 23);
            this.cmbYear.TabIndex = 2;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(256, 179);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(37, 15);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "분반";
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(348, 176);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(100, 23);
            this.cmbClass.TabIndex = 2;
            // 
            // lblRegStatus
            // 
            this.lblRegStatus.AutoSize = true;
            this.lblRegStatus.Location = new System.Drawing.Point(25, 217);
            this.lblRegStatus.Name = "lblRegStatus";
            this.lblRegStatus.Size = new System.Drawing.Size(67, 15);
            this.lblRegStatus.TabIndex = 0;
            this.lblRegStatus.Text = "재적상태";
            // 
            // cmbRegStatus
            // 
            this.cmbRegStatus.FormattingEnabled = true;
            this.cmbRegStatus.Location = new System.Drawing.Point(117, 214);
            this.cmbRegStatus.Name = "cmbRegStatus";
            this.cmbRegStatus.Size = new System.Drawing.Size(100, 23);
            this.cmbRegStatus.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(25, 257);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(37, 15);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "주소";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(117, 252);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(331, 25);
            this.tbxAddress.TabIndex = 1;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(25, 297);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(52, 15);
            this.lblContact.TabIndex = 0;
            this.lblContact.Text = "연락처";
            // 
            // tbxContact
            // 
            this.tbxContact.Location = new System.Drawing.Point(117, 292);
            this.tbxContact.Name = "tbxContact";
            this.tbxContact.Size = new System.Drawing.Size(331, 25);
            this.tbxContact.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(40, 340);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(74, 56);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "신규";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(117, 340);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(331, 56);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "등록";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // lbxArray
            // 
            this.lbxArray.FormattingEnabled = true;
            this.lbxArray.ItemHeight = 15;
            this.lbxArray.Location = new System.Drawing.Point(463, 15);
            this.lbxArray.Name = "lbxArray";
            this.lbxArray.Size = new System.Drawing.Size(177, 109);
            this.lbxArray.TabIndex = 4;
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.ItemHeight = 15;
            this.lbxList.Location = new System.Drawing.Point(463, 143);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(177, 109);
            this.lbxList.TabIndex = 4;
            // 
            // lbxDictionary
            // 
            this.lbxDictionary.FormattingEnabled = true;
            this.lbxDictionary.ItemHeight = 15;
            this.lbxDictionary.Location = new System.Drawing.Point(463, 272);
            this.lbxDictionary.Name = "lbxDictionary";
            this.lbxDictionary.Size = new System.Drawing.Size(177, 124);
            this.lbxDictionary.TabIndex = 4;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpgDepartment);
            this.tabMain.Controls.Add(this.tpgProfessor);
            this.tabMain.Controls.Add(this.tpgStudent);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.ItemSize = new System.Drawing.Size(64, 30);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(682, 463);
            this.tabMain.TabIndex = 5;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tpgDepartment
            // 
            this.tpgDepartment.Controls.Add(this.lbxDepartment);
            this.tpgDepartment.Controls.Add(this.btnRemoveDepartment);
            this.tpgDepartment.Controls.Add(this.btnRegisterDepartment);
            this.tpgDepartment.Controls.Add(this.lblDepartmentCode);
            this.tpgDepartment.Controls.Add(this.tbxDepartmentCode);
            this.tpgDepartment.Controls.Add(this.tbxDepartmentName);
            this.tpgDepartment.Controls.Add(this.lblDepartmentName);
            this.tpgDepartment.Location = new System.Drawing.Point(4, 34);
            this.tpgDepartment.Name = "tpgDepartment";
            this.tpgDepartment.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDepartment.Size = new System.Drawing.Size(674, 425);
            this.tpgDepartment.TabIndex = 0;
            this.tpgDepartment.Text = "학과정보";
            this.tpgDepartment.UseVisualStyleBackColor = true;
            // 
            // tpgProfessor
            // 
            this.tpgProfessor.Controls.Add(this.lblProfessorDepartment);
            this.tpgProfessor.Controls.Add(this.cmbProfessorDepartment);
            this.tpgProfessor.Controls.Add(this.lbxProfessor);
            this.tpgProfessor.Controls.Add(this.btnRemoveProfessor);
            this.tpgProfessor.Controls.Add(this.btnRegisterProfessor);
            this.tpgProfessor.Controls.Add(this.lblProfessorNumber);
            this.tpgProfessor.Controls.Add(this.tbxProfessorNumber);
            this.tpgProfessor.Controls.Add(this.tbxProfessorName);
            this.tpgProfessor.Controls.Add(this.lblProfessorName);
            this.tpgProfessor.Location = new System.Drawing.Point(4, 34);
            this.tpgProfessor.Name = "tpgProfessor";
            this.tpgProfessor.Padding = new System.Windows.Forms.Padding(3);
            this.tpgProfessor.Size = new System.Drawing.Size(674, 425);
            this.tpgProfessor.TabIndex = 1;
            this.tpgProfessor.Text = "교수정보";
            this.tpgProfessor.UseVisualStyleBackColor = true;
            // 
            // tpgStudent
            // 
            this.tpgStudent.Controls.Add(this.lblNumber);
            this.tpgStudent.Controls.Add(this.lbxDictionary);
            this.tpgStudent.Controls.Add(this.tbxNumber);
            this.tpgStudent.Controls.Add(this.lbxList);
            this.tpgStudent.Controls.Add(this.lblBirth);
            this.tpgStudent.Controls.Add(this.lbxArray);
            this.tpgStudent.Controls.Add(this.lblBirthYear);
            this.tpgStudent.Controls.Add(this.btnRegister);
            this.tpgStudent.Controls.Add(this.lblAdvisor);
            this.tpgStudent.Controls.Add(this.btnNew);
            this.tpgStudent.Controls.Add(this.lblDepartment);
            this.tpgStudent.Controls.Add(this.cmbClass);
            this.tpgStudent.Controls.Add(this.lblAddress);
            this.tpgStudent.Controls.Add(this.cmbRegStatus);
            this.tpgStudent.Controls.Add(this.lblBirthMonth);
            this.tpgStudent.Controls.Add(this.cmbYear);
            this.tpgStudent.Controls.Add(this.lblContact);
            this.tpgStudent.Controls.Add(this.cmbDepartment);
            this.tpgStudent.Controls.Add(this.lblYear);
            this.tpgStudent.Controls.Add(this.tbxName);
            this.tpgStudent.Controls.Add(this.lblBirthDay);
            this.tpgStudent.Controls.Add(this.lblName);
            this.tpgStudent.Controls.Add(this.lblRegStatus);
            this.tpgStudent.Controls.Add(this.tbxBirthDay);
            this.tpgStudent.Controls.Add(this.lblClass);
            this.tpgStudent.Controls.Add(this.tbxBirthMonth);
            this.tpgStudent.Controls.Add(this.tbxBirthYear);
            this.tpgStudent.Controls.Add(this.tbxContact);
            this.tpgStudent.Controls.Add(this.tbxAdvisor);
            this.tpgStudent.Controls.Add(this.tbxAddress);
            this.tpgStudent.Location = new System.Drawing.Point(4, 34);
            this.tpgStudent.Name = "tpgStudent";
            this.tpgStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tpgStudent.Size = new System.Drawing.Size(674, 425);
            this.tpgStudent.TabIndex = 2;
            this.tpgStudent.Text = "학생정보";
            this.tpgStudent.UseVisualStyleBackColor = true;
            // 
            // lblDepartmentCode
            // 
            this.lblDepartmentCode.AutoSize = true;
            this.lblDepartmentCode.Location = new System.Drawing.Point(24, 18);
            this.lblDepartmentCode.Name = "lblDepartmentCode";
            this.lblDepartmentCode.Size = new System.Drawing.Size(67, 15);
            this.lblDepartmentCode.TabIndex = 2;
            this.lblDepartmentCode.Text = "학과코드";
            // 
            // tbxDepartmentCode
            // 
            this.tbxDepartmentCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxDepartmentCode.Location = new System.Drawing.Point(116, 13);
            this.tbxDepartmentCode.Name = "tbxDepartmentCode";
            this.tbxDepartmentCode.Size = new System.Drawing.Size(100, 25);
            this.tbxDepartmentCode.TabIndex = 4;
            // 
            // tbxDepartmentName
            // 
            this.tbxDepartmentName.Location = new System.Drawing.Point(116, 51);
            this.tbxDepartmentName.Name = "tbxDepartmentName";
            this.tbxDepartmentName.Size = new System.Drawing.Size(100, 25);
            this.tbxDepartmentName.TabIndex = 5;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Location = new System.Drawing.Point(24, 56);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(67, 15);
            this.lblDepartmentName.TabIndex = 3;
            this.lblDepartmentName.Text = "학과이름";
            // 
            // lbxDepartment
            // 
            this.lbxDepartment.FormattingEnabled = true;
            this.lbxDepartment.ItemHeight = 15;
            this.lbxDepartment.Location = new System.Drawing.Point(27, 93);
            this.lbxDepartment.Name = "lbxDepartment";
            this.lbxDepartment.Size = new System.Drawing.Size(639, 229);
            this.lbxDepartment.TabIndex = 7;
            // 
            // btnRegisterDepartment
            // 
            this.btnRegisterDepartment.Location = new System.Drawing.Point(234, 13);
            this.btnRegisterDepartment.Name = "btnRegisterDepartment";
            this.btnRegisterDepartment.Size = new System.Drawing.Size(77, 63);
            this.btnRegisterDepartment.TabIndex = 6;
            this.btnRegisterDepartment.Text = "등록";
            this.btnRegisterDepartment.UseVisualStyleBackColor = true;
            this.btnRegisterDepartment.Click += new System.EventHandler(this.btnRegisterDepartment_Click);
            // 
            // btnRemoveDepartment
            // 
            this.btnRemoveDepartment.Location = new System.Drawing.Point(568, 345);
            this.btnRemoveDepartment.Name = "btnRemoveDepartment";
            this.btnRemoveDepartment.Size = new System.Drawing.Size(77, 63);
            this.btnRemoveDepartment.TabIndex = 6;
            this.btnRemoveDepartment.Text = "삭제";
            this.btnRemoveDepartment.UseVisualStyleBackColor = true;
            this.btnRemoveDepartment.Click += new System.EventHandler(this.btnRemoveDepartment_Click);
            // 
            // lbxProfessor
            // 
            this.lbxProfessor.FormattingEnabled = true;
            this.lbxProfessor.ItemHeight = 15;
            this.lbxProfessor.Location = new System.Drawing.Point(27, 128);
            this.lbxProfessor.Name = "lbxProfessor";
            this.lbxProfessor.Size = new System.Drawing.Size(639, 229);
            this.lbxProfessor.TabIndex = 14;
            // 
            // btnRemoveProfessor
            // 
            this.btnRemoveProfessor.Location = new System.Drawing.Point(589, 363);
            this.btnRemoveProfessor.Name = "btnRemoveProfessor";
            this.btnRemoveProfessor.Size = new System.Drawing.Size(77, 57);
            this.btnRemoveProfessor.TabIndex = 12;
            this.btnRemoveProfessor.Text = "삭제";
            this.btnRemoveProfessor.UseVisualStyleBackColor = true;
            // 
            // btnRegisterProfessor
            // 
            this.btnRegisterProfessor.Location = new System.Drawing.Point(234, 48);
            this.btnRegisterProfessor.Name = "btnRegisterProfessor";
            this.btnRegisterProfessor.Size = new System.Drawing.Size(77, 63);
            this.btnRegisterProfessor.TabIndex = 13;
            this.btnRegisterProfessor.Text = "등록";
            this.btnRegisterProfessor.UseVisualStyleBackColor = true;
            // 
            // lblProfessorNumber
            // 
            this.lblProfessorNumber.AutoSize = true;
            this.lblProfessorNumber.Location = new System.Drawing.Point(24, 53);
            this.lblProfessorNumber.Name = "lblProfessorNumber";
            this.lblProfessorNumber.Size = new System.Drawing.Size(67, 15);
            this.lblProfessorNumber.TabIndex = 8;
            this.lblProfessorNumber.Text = "교수번호";
            // 
            // tbxProfessorNumber
            // 
            this.tbxProfessorNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxProfessorNumber.Location = new System.Drawing.Point(116, 48);
            this.tbxProfessorNumber.Name = "tbxProfessorNumber";
            this.tbxProfessorNumber.Size = new System.Drawing.Size(100, 25);
            this.tbxProfessorNumber.TabIndex = 10;
            // 
            // tbxProfessorName
            // 
            this.tbxProfessorName.Location = new System.Drawing.Point(116, 86);
            this.tbxProfessorName.Name = "tbxProfessorName";
            this.tbxProfessorName.Size = new System.Drawing.Size(100, 25);
            this.tbxProfessorName.TabIndex = 11;
            // 
            // lblProfessorName
            // 
            this.lblProfessorName.AutoSize = true;
            this.lblProfessorName.Location = new System.Drawing.Point(24, 91);
            this.lblProfessorName.Name = "lblProfessorName";
            this.lblProfessorName.Size = new System.Drawing.Size(67, 15);
            this.lblProfessorName.TabIndex = 9;
            this.lblProfessorName.Text = "교수이름";
            // 
            // lblProfessorDepartment
            // 
            this.lblProfessorDepartment.AutoSize = true;
            this.lblProfessorDepartment.Location = new System.Drawing.Point(24, 17);
            this.lblProfessorDepartment.Name = "lblProfessorDepartment";
            this.lblProfessorDepartment.Size = new System.Drawing.Size(67, 15);
            this.lblProfessorDepartment.TabIndex = 15;
            this.lblProfessorDepartment.Text = "소속학과";
            // 
            // cmbProfessorDepartment
            // 
            this.cmbProfessorDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfessorDepartment.FormattingEnabled = true;
            this.cmbProfessorDepartment.Location = new System.Drawing.Point(116, 14);
            this.cmbProfessorDepartment.Name = "cmbProfessorDepartment";
            this.cmbProfessorDepartment.Size = new System.Drawing.Size(331, 23);
            this.cmbProfessorDepartment.TabIndex = 16;
            this.cmbProfessorDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbProfessorDepartment_SelectedIndexChanged);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 463);
            this.Controls.Add(this.tabMain);
            this.Name = "FormManager";
            this.Text = "학생관리";
            this.tabMain.ResumeLayout(false);
            this.tpgDepartment.ResumeLayout(false);
            this.tpgDepartment.PerformLayout();
            this.tpgProfessor.ResumeLayout(false);
            this.tpgProfessor.PerformLayout();
            this.tpgStudent.ResumeLayout(false);
            this.tpgStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.TextBox tbxBirthYear;
        private System.Windows.Forms.Label lblBirthYear;
        private System.Windows.Forms.Label lblBirthMonth;
        private System.Windows.Forms.TextBox tbxBirthMonth;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.TextBox tbxBirthDay;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblAdvisor;
        private System.Windows.Forms.TextBox tbxAdvisor;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblRegStatus;
        private System.Windows.Forms.ComboBox cmbRegStatus;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox tbxContact;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ListBox lbxArray;
        private System.Windows.Forms.ListBox lbxList;
        private System.Windows.Forms.ListBox lbxDictionary;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpgDepartment;
        private System.Windows.Forms.TabPage tpgProfessor;
        private System.Windows.Forms.TabPage tpgStudent;
        private System.Windows.Forms.ListBox lbxDepartment;
        private System.Windows.Forms.Button btnRemoveDepartment;
        private System.Windows.Forms.Button btnRegisterDepartment;
        private System.Windows.Forms.Label lblDepartmentCode;
        private System.Windows.Forms.TextBox tbxDepartmentCode;
        private System.Windows.Forms.TextBox tbxDepartmentName;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label lblProfessorDepartment;
        private System.Windows.Forms.ComboBox cmbProfessorDepartment;
        private System.Windows.Forms.ListBox lbxProfessor;
        private System.Windows.Forms.Button btnRemoveProfessor;
        private System.Windows.Forms.Button btnRegisterProfessor;
        private System.Windows.Forms.Label lblProfessorNumber;
        private System.Windows.Forms.TextBox tbxProfessorNumber;
        private System.Windows.Forms.TextBox tbxProfessorName;
        private System.Windows.Forms.Label lblProfessorName;
    }
}

