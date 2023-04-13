namespace CalculateScore
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Ch1 = new System.Windows.Forms.TextBox();
            this.tb_En1 = new System.Windows.Forms.TextBox();
            this.tb_Ma1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_SearchNo = new System.Windows.Forms.TextBox();
            this.btn_SearchNo = new System.Windows.Forms.Button();
            this.gv_Table = new System.Windows.Forms.DataGridView();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tb_No1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_Avg = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Ch2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_Ma2 = new System.Windows.Forms.TextBox();
            this.tb_En2 = new System.Windows.Forms.TextBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.lb_EnterResult = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_AvgResult = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Table)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Ch1
            // 
            this.tb_Ch1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Ch1.Location = new System.Drawing.Point(165, 28);
            this.tb_Ch1.Name = "tb_Ch1";
            this.tb_Ch1.Size = new System.Drawing.Size(100, 27);
            this.tb_Ch1.TabIndex = 0;
            // 
            // tb_En1
            // 
            this.tb_En1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_En1.Location = new System.Drawing.Point(271, 28);
            this.tb_En1.Name = "tb_En1";
            this.tb_En1.Size = new System.Drawing.Size(100, 27);
            this.tb_En1.TabIndex = 1;
            // 
            // tb_Ma1
            // 
            this.tb_Ma1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Ma1.Location = new System.Drawing.Point(377, 28);
            this.tb_Ma1.Name = "tb_Ma1";
            this.tb_Ma1.Size = new System.Drawing.Size(100, 27);
            this.tb_Ma1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(161, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "國文";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(267, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "英文";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(373, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "數學";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(15, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 552);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tb_SearchNo);
            this.tabPage1.Controls.Add(this.btn_SearchNo);
            this.tabPage1.Controls.Add(this.gv_Table);
            this.tabPage1.Controls.Add(this.btn_Submit);
            this.tabPage1.Controls.Add(this.tb_No1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tb_Ch1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tb_Ma1);
            this.tabPage1.Controls.Add(this.tb_En1);
            this.tabPage1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1018, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "第一題";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "查詢";
            // 
            // tb_SearchNo
            // 
            this.tb_SearchNo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_SearchNo.Location = new System.Drawing.Point(59, 73);
            this.tb_SearchNo.Name = "tb_SearchNo";
            this.tb_SearchNo.Size = new System.Drawing.Size(100, 27);
            this.tb_SearchNo.TabIndex = 32;
            // 
            // btn_SearchNo
            // 
            this.btn_SearchNo.Location = new System.Drawing.Point(165, 61);
            this.btn_SearchNo.Name = "btn_SearchNo";
            this.btn_SearchNo.Size = new System.Drawing.Size(138, 49);
            this.btn_SearchNo.TabIndex = 31;
            this.btn_SearchNo.Text = "查詢";
            this.btn_SearchNo.UseVisualStyleBackColor = true;
            this.btn_SearchNo.Click += new System.EventHandler(this.btn_SearchNo_Click);
            // 
            // gv_Table
            // 
            this.gv_Table.AllowUserToAddRows = false;
            this.gv_Table.AllowUserToDeleteRows = false;
            this.gv_Table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gv_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Table.Location = new System.Drawing.Point(10, 129);
            this.gv_Table.Name = "gv_Table";
            this.gv_Table.ReadOnly = true;
            this.gv_Table.RowHeadersWidth = 51;
            this.gv_Table.RowTemplate.Height = 27;
            this.gv_Table.Size = new System.Drawing.Size(1002, 385);
            this.gv_Table.TabIndex = 30;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(483, 6);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(138, 49);
            this.btn_Submit.TabIndex = 29;
            this.btn_Submit.Text = "輸入成績";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // tb_No1
            // 
            this.tb_No1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_No1.Location = new System.Drawing.Point(59, 28);
            this.tb_No1.Name = "tb_No1";
            this.tb_No1.Size = new System.Drawing.Size(100, 27);
            this.tb_No1.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(55, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "學號";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "KeyIn";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_Reset);
            this.tabPage3.Controls.Add(this.lb_AvgResult);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.lb_EnterResult);
            this.tabPage3.Controls.Add(this.btn_Enter);
            this.tabPage3.Controls.Add(this.btn_Avg);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.tb_Ch2);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.tb_Ma2);
            this.tabPage3.Controls.Add(this.tb_En2);
            this.tabPage3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1018, 520);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "第二題";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_Avg
            // 
            this.btn_Avg.Location = new System.Drawing.Point(615, 117);
            this.btn_Avg.Name = "btn_Avg";
            this.btn_Avg.Size = new System.Drawing.Size(138, 49);
            this.btn_Avg.TabIndex = 40;
            this.btn_Avg.Text = "計算平均";
            this.btn_Avg.UseVisualStyleBackColor = true;
            this.btn_Avg.Click += new System.EventHandler(this.btn_Avg_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(166, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "國文";
            // 
            // tb_Ch2
            // 
            this.tb_Ch2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Ch2.Location = new System.Drawing.Point(170, 74);
            this.tb_Ch2.Name = "tb_Ch2";
            this.tb_Ch2.Size = new System.Drawing.Size(100, 27);
            this.tb_Ch2.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(378, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 19);
            this.label8.TabIndex = 37;
            this.label8.Text = "數學";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(272, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 19);
            this.label9.TabIndex = 36;
            this.label9.Text = "英文";
            // 
            // tb_Ma2
            // 
            this.tb_Ma2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Ma2.Location = new System.Drawing.Point(382, 74);
            this.tb_Ma2.Name = "tb_Ma2";
            this.tb_Ma2.Size = new System.Drawing.Size(100, 27);
            this.tb_Ma2.TabIndex = 34;
            // 
            // tb_En2
            // 
            this.tb_En2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_En2.Location = new System.Drawing.Point(276, 74);
            this.tb_En2.Name = "tb_En2";
            this.tb_En2.Size = new System.Drawing.Size(100, 27);
            this.tb_En2.TabIndex = 33;
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(615, 62);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(138, 49);
            this.btn_Enter.TabIndex = 41;
            this.btn_Enter.Text = "輸入成績";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // lb_EnterResult
            // 
            this.lb_EnterResult.AutoSize = true;
            this.lb_EnterResult.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_EnterResult.Location = new System.Drawing.Point(166, 132);
            this.lb_EnterResult.Name = "lb_EnterResult";
            this.lb_EnterResult.Size = new System.Drawing.Size(0, 19);
            this.lb_EnterResult.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(91, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 19);
            this.label11.TabIndex = 43;
            this.label11.Text = "輸入結果";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(91, 356);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 19);
            this.label12.TabIndex = 44;
            this.label12.Text = "計算結果";
            // 
            // lb_AvgResult
            // 
            this.lb_AvgResult.AutoSize = true;
            this.lb_AvgResult.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_AvgResult.Location = new System.Drawing.Point(166, 356);
            this.lb_AvgResult.Name = "lb_AvgResult";
            this.lb_AvgResult.Size = new System.Drawing.Size(69, 19);
            this.lb_AvgResult.TabIndex = 45;
            this.lb_AvgResult.Text = "計算結果";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(759, 62);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(138, 49);
            this.btn_Reset.TabIndex = 46;
            this.btn_Reset.Text = "清除";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 607);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Table)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Ch1;
        private System.Windows.Forms.TextBox tb_En1;
        private System.Windows.Forms.TextBox tb_Ma1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tb_No1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_SearchNo;
        private System.Windows.Forms.Button btn_SearchNo;
        private System.Windows.Forms.DataGridView gv_Table;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Avg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Ch2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_Ma2;
        private System.Windows.Forms.TextBox tb_En2;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Label lb_EnterResult;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_AvgResult;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Reset;
    }
}

