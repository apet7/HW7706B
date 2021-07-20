
namespace Homework
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reYear = new System.Windows.Forms.RadioButton();
            this.rbday = new System.Windows.Forms.RadioButton();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.cbxTypeCC = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtAns = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(122)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(69, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用期間";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(210, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "用途";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(29, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "汽缸CC數 / 馬達馬力";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(69, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "試算結果";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reYear
            // 
            this.reYear.AutoSize = true;
            this.reYear.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.reYear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(122)))));
            this.reYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(122)))));
            this.reYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reYear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reYear.Location = new System.Drawing.Point(40, 25);
            this.reYear.Name = "reYear";
            this.reYear.Size = new System.Drawing.Size(92, 29);
            this.reYear.TabIndex = 4;
            this.reYear.TabStop = true;
            this.reYear.Text = "全年度";
            this.reYear.UseVisualStyleBackColor = false;
            this.reYear.CheckedChanged += new System.EventHandler(this.reYear_CheckedChanged);
            // 
            // rbday
            // 
            this.rbday.AutoSize = true;
            this.rbday.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rbday.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(122)))));
            this.rbday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(122)))));
            this.rbday.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbday.Location = new System.Drawing.Point(199, 25);
            this.rbday.Name = "rbday";
            this.rbday.Size = new System.Drawing.Size(93, 29);
            this.rbday.TabIndex = 5;
            this.rbday.TabStop = true;
            this.rbday.Text = "依期間";
            this.rbday.UseVisualStyleBackColor = false;
            this.rbday.CheckedChanged += new System.EventHandler(this.rbday_CheckedChanged);
            // 
            // cbxType
            // 
            this.cbxType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.cbxType.Location = new System.Drawing.Point(382, 406);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(441, 33);
            this.cbxType.TabIndex = 6;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // cbxTypeCC
            // 
            this.cbxTypeCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeCC.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxTypeCC.FormattingEnabled = true;
            this.cbxTypeCC.Location = new System.Drawing.Point(382, 511);
            this.cbxTypeCC.Name = "cbxTypeCC";
            this.cbxTypeCC.Size = new System.Drawing.Size(441, 33);
            this.cbxTypeCC.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.btnCalculate.Location = new System.Drawing.Point(279, 793);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 58);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "確定送出";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            this.btnCalculate.MouseEnter += new System.EventHandler(this.btnCalculate_MouseEnter);
            this.btnCalculate.MouseLeave += new System.EventHandler(this.btnCalculate_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(30, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "從";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(275, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "至";
            this.label6.Visible = false;
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpStart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpStart.Location = new System.Drawing.Point(88, 60);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(160, 34);
            this.dtpStart.TabIndex = 13;
            this.dtpStart.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Visible = false;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpEnd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(333, 60);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(160, 34);
            this.dtpEnd.TabIndex = 14;
            this.dtpEnd.Value = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(115, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 100);
            this.panel1.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(0, 87);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(245, 100);
            this.panel5.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 105);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(122)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(115, 469);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 110);
            this.panel3.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 105);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 16;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(115, 575);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(245, 179);
            this.panel7.TabIndex = 18;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.panel8.Controls.Add(this.panel10);
            this.panel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.panel8.Location = new System.Drawing.Point(115, 374);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(245, 102);
            this.panel8.TabIndex = 19;
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(242, 1);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(496, 100);
            this.panel10.TabIndex = 21;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel9.Controls.Add(this.dtpStart);
            this.panel9.Controls.Add(this.dtpEnd);
            this.panel9.Controls.Add(this.rbday);
            this.panel9.Controls.Add(this.reYear);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Location = new System.Drawing.Point(357, 274);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(496, 100);
            this.panel9.TabIndex = 20;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel11.Location = new System.Drawing.Point(361, 374);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(492, 98);
            this.panel11.TabIndex = 21;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel12.Location = new System.Drawing.Point(361, 469);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(492, 110);
            this.panel12.TabIndex = 22;
            // 
            // panel13
            // 
            this.panel13.AutoScroll = true;
            this.panel13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel13.Controls.Add(this.txtAns);
            this.panel13.Location = new System.Drawing.Point(357, 575);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(496, 179);
            this.panel13.TabIndex = 23;
            // 
            // txtAns
            // 
            this.txtAns.AutoSize = true;
            this.txtAns.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAns.Location = new System.Drawing.Point(25, 21);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(0, 25);
            this.txtAns.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 859);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(263, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(462, 50);
            this.label8.TabIndex = 25;
            this.label8.Text = "使用牌照稅應納稅額試算";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.label9.Location = new System.Drawing.Point(121, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "貼心小叮嚀：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(121, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(814, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "1. 本表試算之稅額僅供參考之用，不做任何證明，實際應納稅額仍應以稽徵機關核定為準。";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(121, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 25);
            this.label11.TabIndex = 28;
            this.label11.Tag = "";
            this.label11.Text = "2.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.linkLabel1.Location = new System.Drawing.Point(144, 209);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(392, 25);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "使用牌照稅稅額對照表及電動車應納稅額表";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.btnReset.Location = new System.Drawing.Point(575, 793);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 58);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "取消重填";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.btnReset_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnReset_MouseLeave);
            // 
            // LicenseTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1009, 804);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cbxTypeCC);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel9);
            this.Name = "LicenseTax";
            this.Text = "LicenseTax";
            this.Load += new System.EventHandler(this.LicenseTax_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton reYear;
        private System.Windows.Forms.RadioButton rbday;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.ComboBox cbxTypeCC;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label txtAns;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnReset;
    }
}

