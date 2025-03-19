namespace week03
{
    partial class Form1
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
            this.tbxData1 = new System.Windows.Forms.TextBox();
            this.tbxData2 = new System.Windows.Forms.TextBox();
            this.tbxData3 = new System.Windows.Forms.TextBox();
            this.tbxData4 = new System.Windows.Forms.TextBox();
            this.tbxData5 = new System.Windows.Forms.TextBox();
            this.chkAdd = new System.Windows.Forms.CheckBox();
            this.chkSub = new System.Windows.Forms.CheckBox();
            this.chkMul = new System.Windows.Forms.CheckBox();
            this.chkDiv = new System.Windows.Forms.CheckBox();
            this.chkOption = new System.Windows.Forms.CheckBox();
            this.pnlRadioGroup = new System.Windows.Forms.Panel();
            this.rbtAdd = new System.Windows.Forms.RadioButton();
            this.rbtSub = new System.Windows.Forms.RadioButton();
            this.rbtMul = new System.Windows.Forms.RadioButton();
            this.rbtDiv = new System.Windows.Forms.RadioButton();
            this.btnProcess01 = new System.Windows.Forms.Button();
            this.btnProcess02 = new System.Windows.Forms.Button();
            this.btnProcess03 = new System.Windows.Forms.Button();
            this.btnProcess04 = new System.Windows.Forms.Button();
            this.btnProcess05 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.cmbBeverage = new System.Windows.Forms.ComboBox();
            this.chkIce = new System.Windows.Forms.CheckBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.pnlRadioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxData1
            // 
            this.tbxData1.Location = new System.Drawing.Point(16, 16);
            this.tbxData1.Name = "tbxData1";
            this.tbxData1.Size = new System.Drawing.Size(100, 25);
            this.tbxData1.TabIndex = 0;
            // 
            // tbxData2
            // 
            this.tbxData2.Location = new System.Drawing.Point(122, 16);
            this.tbxData2.Name = "tbxData2";
            this.tbxData2.Size = new System.Drawing.Size(100, 25);
            this.tbxData2.TabIndex = 0;
            // 
            // tbxData3
            // 
            this.tbxData3.Location = new System.Drawing.Point(228, 16);
            this.tbxData3.Name = "tbxData3";
            this.tbxData3.Size = new System.Drawing.Size(100, 25);
            this.tbxData3.TabIndex = 0;
            // 
            // tbxData4
            // 
            this.tbxData4.Location = new System.Drawing.Point(334, 16);
            this.tbxData4.Name = "tbxData4";
            this.tbxData4.Size = new System.Drawing.Size(100, 25);
            this.tbxData4.TabIndex = 0;
            // 
            // tbxData5
            // 
            this.tbxData5.Location = new System.Drawing.Point(440, 16);
            this.tbxData5.Name = "tbxData5";
            this.tbxData5.Size = new System.Drawing.Size(100, 25);
            this.tbxData5.TabIndex = 0;
            // 
            // chkAdd
            // 
            this.chkAdd.AutoSize = true;
            this.chkAdd.Location = new System.Drawing.Point(16, 53);
            this.chkAdd.Name = "chkAdd";
            this.chkAdd.Size = new System.Drawing.Size(74, 19);
            this.chkAdd.TabIndex = 1;
            this.chkAdd.Text = "더하기";
            this.chkAdd.UseVisualStyleBackColor = true;
            // 
            // chkSub
            // 
            this.chkSub.AutoSize = true;
            this.chkSub.Location = new System.Drawing.Point(133, 53);
            this.chkSub.Name = "chkSub";
            this.chkSub.Size = new System.Drawing.Size(59, 19);
            this.chkSub.TabIndex = 1;
            this.chkSub.Text = "빼기";
            this.chkSub.UseVisualStyleBackColor = true;
            // 
            // chkMul
            // 
            this.chkMul.AutoSize = true;
            this.chkMul.Location = new System.Drawing.Point(228, 53);
            this.chkMul.Name = "chkMul";
            this.chkMul.Size = new System.Drawing.Size(74, 19);
            this.chkMul.TabIndex = 1;
            this.chkMul.Text = "곱하기";
            this.chkMul.UseVisualStyleBackColor = true;
            // 
            // chkDiv
            // 
            this.chkDiv.AutoSize = true;
            this.chkDiv.Location = new System.Drawing.Point(334, 53);
            this.chkDiv.Name = "chkDiv";
            this.chkDiv.Size = new System.Drawing.Size(74, 19);
            this.chkDiv.TabIndex = 1;
            this.chkDiv.Text = "나누기";
            this.chkDiv.UseVisualStyleBackColor = true;
            // 
            // chkOption
            // 
            this.chkOption.AutoSize = true;
            this.chkOption.Location = new System.Drawing.Point(440, 53);
            this.chkOption.Name = "chkOption";
            this.chkOption.Size = new System.Drawing.Size(58, 19);
            this.chkOption.TabIndex = 1;
            this.chkOption.Text = "ENG";
            this.chkOption.UseVisualStyleBackColor = true;
            // 
            // pnlRadioGroup
            // 
            this.pnlRadioGroup.Controls.Add(this.rbtDiv);
            this.pnlRadioGroup.Controls.Add(this.rbtMul);
            this.pnlRadioGroup.Controls.Add(this.rbtSub);
            this.pnlRadioGroup.Controls.Add(this.rbtAdd);
            this.pnlRadioGroup.Location = new System.Drawing.Point(16, 104);
            this.pnlRadioGroup.Name = "pnlRadioGroup";
            this.pnlRadioGroup.Size = new System.Drawing.Size(546, 51);
            this.pnlRadioGroup.TabIndex = 2;
            // 
            // rbtAdd
            // 
            this.rbtAdd.AutoSize = true;
            this.rbtAdd.Location = new System.Drawing.Point(3, 14);
            this.rbtAdd.Name = "rbtAdd";
            this.rbtAdd.Size = new System.Drawing.Size(73, 19);
            this.rbtAdd.TabIndex = 0;
            this.rbtAdd.TabStop = true;
            this.rbtAdd.Text = "더하기";
            this.rbtAdd.UseVisualStyleBackColor = true;
            // 
            // rbtSub
            // 
            this.rbtSub.AutoSize = true;
            this.rbtSub.Location = new System.Drawing.Point(117, 14);
            this.rbtSub.Name = "rbtSub";
            this.rbtSub.Size = new System.Drawing.Size(58, 19);
            this.rbtSub.TabIndex = 1;
            this.rbtSub.TabStop = true;
            this.rbtSub.Text = "빼기";
            this.rbtSub.UseVisualStyleBackColor = true;
            // 
            // rbtMul
            // 
            this.rbtMul.AutoSize = true;
            this.rbtMul.Location = new System.Drawing.Point(220, 14);
            this.rbtMul.Name = "rbtMul";
            this.rbtMul.Size = new System.Drawing.Size(73, 19);
            this.rbtMul.TabIndex = 2;
            this.rbtMul.TabStop = true;
            this.rbtMul.Text = "곱하기";
            this.rbtMul.UseVisualStyleBackColor = true;
            // 
            // rbtDiv
            // 
            this.rbtDiv.AutoSize = true;
            this.rbtDiv.Location = new System.Drawing.Point(318, 14);
            this.rbtDiv.Name = "rbtDiv";
            this.rbtDiv.Size = new System.Drawing.Size(73, 19);
            this.rbtDiv.TabIndex = 3;
            this.rbtDiv.TabStop = true;
            this.rbtDiv.Text = "나누기";
            this.rbtDiv.UseVisualStyleBackColor = true;
            // 
            // btnProcess01
            // 
            this.btnProcess01.Location = new System.Drawing.Point(22, 175);
            this.btnProcess01.Name = "btnProcess01";
            this.btnProcess01.Size = new System.Drawing.Size(75, 23);
            this.btnProcess01.TabIndex = 3;
            this.btnProcess01.Text = "연산1";
            this.btnProcess01.UseVisualStyleBackColor = true;
            this.btnProcess01.Click += new System.EventHandler(this.btnProcess01_Click);
            // 
            // btnProcess02
            // 
            this.btnProcess02.Location = new System.Drawing.Point(116, 176);
            this.btnProcess02.Name = "btnProcess02";
            this.btnProcess02.Size = new System.Drawing.Size(75, 23);
            this.btnProcess02.TabIndex = 4;
            this.btnProcess02.Text = "연산2";
            this.btnProcess02.UseVisualStyleBackColor = true;
            this.btnProcess02.Click += new System.EventHandler(this.btnProcess02_Click);
            // 
            // btnProcess03
            // 
            this.btnProcess03.Location = new System.Drawing.Point(222, 177);
            this.btnProcess03.Name = "btnProcess03";
            this.btnProcess03.Size = new System.Drawing.Size(75, 23);
            this.btnProcess03.TabIndex = 5;
            this.btnProcess03.Text = "연산3";
            this.btnProcess03.UseVisualStyleBackColor = true;
            // 
            // btnProcess04
            // 
            this.btnProcess04.Location = new System.Drawing.Point(323, 174);
            this.btnProcess04.Name = "btnProcess04";
            this.btnProcess04.Size = new System.Drawing.Size(75, 23);
            this.btnProcess04.TabIndex = 6;
            this.btnProcess04.Text = "연산4";
            this.btnProcess04.UseVisualStyleBackColor = true;
            // 
            // btnProcess05
            // 
            this.btnProcess05.Location = new System.Drawing.Point(441, 173);
            this.btnProcess05.Name = "btnProcess05";
            this.btnProcess05.Size = new System.Drawing.Size(75, 23);
            this.btnProcess05.TabIndex = 7;
            this.btnProcess05.Text = "연산5";
            this.btnProcess05.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(22, 219);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "button1";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(116, 220);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "button2";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(222, 221);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 5;
            this.button8.Text = "button3";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(323, 218);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 6;
            this.button9.Text = "button4";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(441, 217);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 7;
            this.button10.Text = "button5";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // cmbBeverage
            // 
            this.cmbBeverage.FormattingEnabled = true;
            this.cmbBeverage.Items.AddRange(new object[] {
            "아메리카노",
            "카페라떼",
            "플랫화이트"});
            this.cmbBeverage.Location = new System.Drawing.Point(22, 260);
            this.cmbBeverage.Name = "cmbBeverage";
            this.cmbBeverage.Size = new System.Drawing.Size(121, 23);
            this.cmbBeverage.TabIndex = 8;
            // 
            // chkIce
            // 
            this.chkIce.AutoSize = true;
            this.chkIce.Location = new System.Drawing.Point(152, 260);
            this.chkIce.Name = "chkIce";
            this.chkIce.Size = new System.Drawing.Size(59, 19);
            this.chkIce.TabIndex = 1;
            this.chkIce.Text = "얼음";
            this.chkIce.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Cyan;
            this.lblResult.Location = new System.Drawing.Point(24, 303);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(611, 138);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cmbBeverage);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btnProcess05);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnProcess04);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnProcess03);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnProcess02);
            this.Controls.Add(this.btnProcess01);
            this.Controls.Add(this.pnlRadioGroup);
            this.Controls.Add(this.chkOption);
            this.Controls.Add(this.chkDiv);
            this.Controls.Add(this.chkMul);
            this.Controls.Add(this.chkSub);
            this.Controls.Add(this.chkIce);
            this.Controls.Add(this.chkAdd);
            this.Controls.Add(this.tbxData5);
            this.Controls.Add(this.tbxData4);
            this.Controls.Add(this.tbxData3);
            this.Controls.Add(this.tbxData2);
            this.Controls.Add(this.tbxData1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlRadioGroup.ResumeLayout(false);
            this.pnlRadioGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxData1;
        private System.Windows.Forms.TextBox tbxData2;
        private System.Windows.Forms.TextBox tbxData3;
        private System.Windows.Forms.TextBox tbxData4;
        private System.Windows.Forms.TextBox tbxData5;
        private System.Windows.Forms.CheckBox chkAdd;
        private System.Windows.Forms.CheckBox chkSub;
        private System.Windows.Forms.CheckBox chkMul;
        private System.Windows.Forms.CheckBox chkDiv;
        private System.Windows.Forms.CheckBox chkOption;
        private System.Windows.Forms.Panel pnlRadioGroup;
        private System.Windows.Forms.RadioButton rbtDiv;
        private System.Windows.Forms.RadioButton rbtMul;
        private System.Windows.Forms.RadioButton rbtSub;
        private System.Windows.Forms.RadioButton rbtAdd;
        private System.Windows.Forms.Button btnProcess01;
        private System.Windows.Forms.Button btnProcess02;
        private System.Windows.Forms.Button btnProcess03;
        private System.Windows.Forms.Button btnProcess04;
        private System.Windows.Forms.Button btnProcess05;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ComboBox cmbBeverage;
        private System.Windows.Forms.CheckBox chkIce;
        private System.Windows.Forms.Label lblResult;
    }
}

