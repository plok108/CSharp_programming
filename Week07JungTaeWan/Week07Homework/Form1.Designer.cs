namespace Week07Homework
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
            this.gbxInput = new System.Windows.Forms.GroupBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.tbxInputProcuctStock = new System.Windows.Forms.TextBox();
            this.lblInputProcuctStock = new System.Windows.Forms.Label();
            this.tbxInputProductPrice = new System.Windows.Forms.TextBox();
            this.lblInputProductPrice = new System.Windows.Forms.Label();
            this.tbxInputProductName = new System.Windows.Forms.TextBox();
            this.lblInputProductName = new System.Windows.Forms.Label();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.lbxSearchProduct = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearchNameCode = new System.Windows.Forms.TextBox();
            this.lblSearchNameCode = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.tbxSearchProcuctCount = new System.Windows.Forms.TextBox();
            this.lblSearchProcuctCount = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblSearchProductName = new System.Windows.Forms.Label();
            this.lblSearchProductCode = new System.Windows.Forms.Label();
            this.lblSearchProductPrice = new System.Windows.Forms.Label();
            this.lblSearchProductSalePrice = new System.Windows.Forms.Label();
            this.lblSearchProductStock = new System.Windows.Forms.Label();
            this.lblSearchProductRegDate = new System.Windows.Forms.Label();
            this.lblSearchProductTotalPrice = new System.Windows.Forms.Label();
            this.gbxInput.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInput
            // 
            this.gbxInput.Controls.Add(this.btnInput);
            this.gbxInput.Controls.Add(this.tbxInputProcuctStock);
            this.gbxInput.Controls.Add(this.lblInputProcuctStock);
            this.gbxInput.Controls.Add(this.tbxInputProductPrice);
            this.gbxInput.Controls.Add(this.lblInputProductPrice);
            this.gbxInput.Controls.Add(this.tbxInputProductName);
            this.gbxInput.Controls.Add(this.lblInputProductName);
            this.gbxInput.Location = new System.Drawing.Point(12, 21);
            this.gbxInput.Name = "gbxInput";
            this.gbxInput.Size = new System.Drawing.Size(221, 240);
            this.gbxInput.TabIndex = 0;
            this.gbxInput.TabStop = false;
            this.gbxInput.Text = "상품등록";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(91, 166);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(99, 27);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "등록";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // tbxInputProcuctStock
            // 
            this.tbxInputProcuctStock.Location = new System.Drawing.Point(91, 121);
            this.tbxInputProcuctStock.Name = "tbxInputProcuctStock";
            this.tbxInputProcuctStock.Size = new System.Drawing.Size(100, 25);
            this.tbxInputProcuctStock.TabIndex = 1;
            this.tbxInputProcuctStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblInputProcuctStock
            // 
            this.lblInputProcuctStock.AutoSize = true;
            this.lblInputProcuctStock.Location = new System.Drawing.Point(21, 126);
            this.lblInputProcuctStock.Name = "lblInputProcuctStock";
            this.lblInputProcuctStock.Size = new System.Drawing.Size(37, 15);
            this.lblInputProcuctStock.TabIndex = 0;
            this.lblInputProcuctStock.Text = "재고";
            // 
            // tbxInputProductPrice
            // 
            this.tbxInputProductPrice.Location = new System.Drawing.Point(91, 80);
            this.tbxInputProductPrice.Name = "tbxInputProductPrice";
            this.tbxInputProductPrice.Size = new System.Drawing.Size(100, 25);
            this.tbxInputProductPrice.TabIndex = 1;
            this.tbxInputProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblInputProductPrice
            // 
            this.lblInputProductPrice.AutoSize = true;
            this.lblInputProductPrice.Location = new System.Drawing.Point(21, 85);
            this.lblInputProductPrice.Name = "lblInputProductPrice";
            this.lblInputProductPrice.Size = new System.Drawing.Size(37, 15);
            this.lblInputProductPrice.TabIndex = 0;
            this.lblInputProductPrice.Text = "가격";
            // 
            // tbxInputProductName
            // 
            this.tbxInputProductName.Location = new System.Drawing.Point(91, 42);
            this.tbxInputProductName.Name = "tbxInputProductName";
            this.tbxInputProductName.Size = new System.Drawing.Size(100, 25);
            this.tbxInputProductName.TabIndex = 1;
            // 
            // lblInputProductName
            // 
            this.lblInputProductName.AutoSize = true;
            this.lblInputProductName.Location = new System.Drawing.Point(21, 46);
            this.lblInputProductName.Name = "lblInputProductName";
            this.lblInputProductName.Size = new System.Drawing.Size(37, 15);
            this.lblInputProductName.TabIndex = 0;
            this.lblInputProductName.Text = "이름";
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.btnCal);
            this.gbxSearch.Controls.Add(this.lbxSearchProduct);
            this.gbxSearch.Controls.Add(this.btnSearch);
            this.gbxSearch.Controls.Add(this.tbxSearchNameCode);
            this.gbxSearch.Controls.Add(this.lblSearchNameCode);
            this.gbxSearch.Controls.Add(this.lblSearchProductTotalPrice);
            this.gbxSearch.Controls.Add(this.lbl7);
            this.gbxSearch.Controls.Add(this.tbxSearchProcuctCount);
            this.gbxSearch.Controls.Add(this.lblSearchProcuctCount);
            this.gbxSearch.Controls.Add(this.lblSearchProductRegDate);
            this.gbxSearch.Controls.Add(this.lblSearchProductStock);
            this.gbxSearch.Controls.Add(this.lbl6);
            this.gbxSearch.Controls.Add(this.lblSearchProductSalePrice);
            this.gbxSearch.Controls.Add(this.lbl5);
            this.gbxSearch.Controls.Add(this.lblSearchProductPrice);
            this.gbxSearch.Controls.Add(this.lbl4);
            this.gbxSearch.Controls.Add(this.lblSearchProductCode);
            this.gbxSearch.Controls.Add(this.lbl3);
            this.gbxSearch.Controls.Add(this.lblSearchProductName);
            this.gbxSearch.Controls.Add(this.lbl2);
            this.gbxSearch.Controls.Add(this.lbl);
            this.gbxSearch.Location = new System.Drawing.Point(256, 21);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(493, 371);
            this.gbxSearch.TabIndex = 1;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "상품조회";
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(420, 301);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(59, 24);
            this.btnCal.TabIndex = 2;
            this.btnCal.Text = "계산";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // lbxSearchProduct
            // 
            this.lbxSearchProduct.FormattingEnabled = true;
            this.lbxSearchProduct.ItemHeight = 15;
            this.lbxSearchProduct.Location = new System.Drawing.Point(20, 153);
            this.lbxSearchProduct.Name = "lbxSearchProduct";
            this.lbxSearchProduct.Size = new System.Drawing.Size(182, 94);
            this.lbxSearchProduct.TabIndex = 3;
            this.lbxSearchProduct.SelectedIndexChanged += new System.EventHandler(this.lbxSearchProduct_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(20, 114);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(182, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearchNameCode
            // 
            this.tbxSearchNameCode.Location = new System.Drawing.Point(20, 75);
            this.tbxSearchNameCode.Name = "tbxSearchNameCode";
            this.tbxSearchNameCode.Size = new System.Drawing.Size(182, 25);
            this.tbxSearchNameCode.TabIndex = 1;
            // 
            // lblSearchNameCode
            // 
            this.lblSearchNameCode.AutoSize = true;
            this.lblSearchNameCode.Location = new System.Drawing.Point(17, 47);
            this.lblSearchNameCode.Name = "lblSearchNameCode";
            this.lblSearchNameCode.Size = new System.Drawing.Size(86, 15);
            this.lblSearchNameCode.TabIndex = 0;
            this.lblSearchNameCode.Text = "이름 && 코드";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(236, 336);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(57, 15);
            this.lbl7.TabIndex = 0;
            this.lbl7.Text = "총 가격";
            // 
            // tbxSearchProcuctCount
            // 
            this.tbxSearchProcuctCount.Location = new System.Drawing.Point(334, 301);
            this.tbxSearchProcuctCount.Name = "tbxSearchProcuctCount";
            this.tbxSearchProcuctCount.Size = new System.Drawing.Size(80, 25);
            this.tbxSearchProcuctCount.TabIndex = 1;
            // 
            // lblSearchProcuctCount
            // 
            this.lblSearchProcuctCount.AutoSize = true;
            this.lblSearchProcuctCount.Location = new System.Drawing.Point(236, 305);
            this.lblSearchProcuctCount.Name = "lblSearchProcuctCount";
            this.lblSearchProcuctCount.Size = new System.Drawing.Size(37, 15);
            this.lblSearchProcuctCount.TabIndex = 0;
            this.lblSearchProcuctCount.Text = "수량";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(236, 235);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(67, 15);
            this.lbl6.TabIndex = 0;
            this.lbl6.Text = "등록일자";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(236, 204);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(37, 15);
            this.lbl5.TabIndex = 0;
            this.lbl5.Text = "재고";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(236, 173);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(67, 15);
            this.lbl4.TabIndex = 0;
            this.lbl4.Text = "할인가격";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(236, 142);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(37, 15);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "가격";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(236, 111);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(37, 15);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "코드";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(236, 80);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(37, 15);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "이름";
            // 
            // lblSearchProductName
            // 
            this.lblSearchProductName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchProductName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSearchProductName.Location = new System.Drawing.Point(331, 80);
            this.lblSearchProductName.Name = "lblSearchProductName";
            this.lblSearchProductName.Size = new System.Drawing.Size(119, 20);
            this.lblSearchProductName.TabIndex = 0;
            // 
            // lblSearchProductCode
            // 
            this.lblSearchProductCode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchProductCode.Location = new System.Drawing.Point(331, 111);
            this.lblSearchProductCode.Name = "lblSearchProductCode";
            this.lblSearchProductCode.Size = new System.Drawing.Size(119, 15);
            this.lblSearchProductCode.TabIndex = 0;
            // 
            // lblSearchProductPrice
            // 
            this.lblSearchProductPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchProductPrice.Location = new System.Drawing.Point(331, 142);
            this.lblSearchProductPrice.Name = "lblSearchProductPrice";
            this.lblSearchProductPrice.Size = new System.Drawing.Size(119, 15);
            this.lblSearchProductPrice.TabIndex = 0;
            // 
            // lblSearchProductSalePrice
            // 
            this.lblSearchProductSalePrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchProductSalePrice.Location = new System.Drawing.Point(331, 173);
            this.lblSearchProductSalePrice.Name = "lblSearchProductSalePrice";
            this.lblSearchProductSalePrice.Size = new System.Drawing.Size(119, 15);
            this.lblSearchProductSalePrice.TabIndex = 0;
            // 
            // lblSearchProductStock
            // 
            this.lblSearchProductStock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchProductStock.Location = new System.Drawing.Point(331, 204);
            this.lblSearchProductStock.Name = "lblSearchProductStock";
            this.lblSearchProductStock.Size = new System.Drawing.Size(119, 15);
            this.lblSearchProductStock.TabIndex = 0;
            // 
            // lblSearchProductRegDate
            // 
            this.lblSearchProductRegDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchProductRegDate.Location = new System.Drawing.Point(331, 235);
            this.lblSearchProductRegDate.Name = "lblSearchProductRegDate";
            this.lblSearchProductRegDate.Size = new System.Drawing.Size(119, 15);
            this.lblSearchProductRegDate.TabIndex = 0;
            // 
            // lblSearchProductTotalPrice
            // 
            this.lblSearchProductTotalPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchProductTotalPrice.Location = new System.Drawing.Point(331, 336);
            this.lblSearchProductTotalPrice.Name = "lblSearchProductTotalPrice";
            this.lblSearchProductTotalPrice.Size = new System.Drawing.Size(119, 15);
            this.lblSearchProductTotalPrice.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 403);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxInput);
            this.Name = "Form1";
            this.Text = "7주차 숙제";
            this.gbxInput.ResumeLayout(false);
            this.gbxInput.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInput;
        private System.Windows.Forms.Label lblInputProductName;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox tbxInputProcuctStock;
        private System.Windows.Forms.Label lblInputProcuctStock;
        private System.Windows.Forms.TextBox tbxInputProductPrice;
        private System.Windows.Forms.Label lblInputProductPrice;
        private System.Windows.Forms.TextBox tbxInputProductName;
        private System.Windows.Forms.TextBox tbxSearchNameCode;
        private System.Windows.Forms.Label lblSearchNameCode;
        private System.Windows.Forms.ListBox lbxSearchProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.TextBox tbxSearchProcuctCount;
        private System.Windows.Forms.Label lblSearchProcuctCount;
        private System.Windows.Forms.Label lblSearchProductTotalPrice;
        private System.Windows.Forms.Label lblSearchProductRegDate;
        private System.Windows.Forms.Label lblSearchProductStock;
        private System.Windows.Forms.Label lblSearchProductSalePrice;
        private System.Windows.Forms.Label lblSearchProductPrice;
        private System.Windows.Forms.Label lblSearchProductCode;
        private System.Windows.Forms.Label lblSearchProductName;
    }
}

