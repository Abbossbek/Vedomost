namespace Vedomost
{
    partial class New_Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCencel = new System.Windows.Forms.Button();
            this.txtImya = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFamil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOtches = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.dtpDataRoj = new System.Windows.Forms.DateTimePicker();
            this.cmbNaprav = new System.Windows.Forms.ComboBox();
            this.cmbFakul = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbKurs = new System.Windows.Forms.ComboBox();
            this.cmbOtsenka = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(254, 331);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 30);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCencel
            // 
            this.btnCencel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCencel.Location = new System.Drawing.Point(75, 331);
            this.btnCencel.Name = "btnCencel";
            this.btnCencel.Size = new System.Drawing.Size(85, 30);
            this.btnCencel.TabIndex = 12;
            this.btnCencel.Text = "ОТМЕНА";
            this.btnCencel.UseVisualStyleBackColor = true;
            // 
            // txtImya
            // 
            this.txtImya.Location = new System.Drawing.Point(143, 32);
            this.txtImya.Name = "txtImya";
            this.txtImya.Size = new System.Drawing.Size(230, 22);
            this.txtImya.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фамилия";
            // 
            // txtFamil
            // 
            this.txtFamil.Location = new System.Drawing.Point(143, 60);
            this.txtFamil.Name = "txtFamil";
            this.txtFamil.Size = new System.Drawing.Size(230, 22);
            this.txtFamil.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество";
            // 
            // txtOtches
            // 
            this.txtOtches.Location = new System.Drawing.Point(143, 88);
            this.txtOtches.Name = "txtOtches";
            this.txtOtches.Size = new System.Drawing.Size(230, 22);
            this.txtOtches.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Рост";
            // 
            // txtRost
            // 
            this.txtRost.Location = new System.Drawing.Point(144, 172);
            this.txtRost.Name = "txtRost";
            this.txtRost.Size = new System.Drawing.Size(230, 22);
            this.txtRost.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Курс";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Направление";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Факультет";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Телефон";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(143, 288);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(230, 22);
            this.txtTel.TabIndex = 10;
            // 
            // dtpDataRoj
            // 
            this.dtpDataRoj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataRoj.Location = new System.Drawing.Point(143, 144);
            this.dtpDataRoj.Name = "dtpDataRoj";
            this.dtpDataRoj.Size = new System.Drawing.Size(230, 22);
            this.dtpDataRoj.TabIndex = 5;
            // 
            // cmbNaprav
            // 
            this.cmbNaprav.FormattingEnabled = true;
            this.cmbNaprav.Location = new System.Drawing.Point(143, 258);
            this.cmbNaprav.Name = "cmbNaprav";
            this.cmbNaprav.Size = new System.Drawing.Size(230, 24);
            this.cmbNaprav.TabIndex = 9;
            // 
            // cmbFakul
            // 
            this.cmbFakul.FormattingEnabled = true;
            this.cmbFakul.Items.AddRange(new object[] {
            "Математика",
            "История",
            "Физика",
            "Химия",
            "Экономика",
            "География и гидрометереология"});
            this.cmbFakul.Location = new System.Drawing.Point(144, 228);
            this.cmbFakul.Name = "cmbFakul";
            this.cmbFakul.Size = new System.Drawing.Size(230, 24);
            this.cmbFakul.TabIndex = 8;
            this.cmbFakul.SelectedIndexChanged += new System.EventHandler(this.cmbFakul_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Оценка";
            // 
            // cmbKurs
            // 
            this.cmbKurs.FormattingEnabled = true;
            this.cmbKurs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbKurs.Location = new System.Drawing.Point(144, 200);
            this.cmbKurs.Name = "cmbKurs";
            this.cmbKurs.Size = new System.Drawing.Size(230, 24);
            this.cmbKurs.TabIndex = 25;
            // 
            // cmbOtsenka
            // 
            this.cmbOtsenka.FormattingEnabled = true;
            this.cmbOtsenka.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.cmbOtsenka.Location = new System.Drawing.Point(143, 116);
            this.cmbOtsenka.Name = "cmbOtsenka";
            this.cmbOtsenka.Size = new System.Drawing.Size(230, 24);
            this.cmbOtsenka.TabIndex = 26;
            // 
            // New_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 381);
            this.Controls.Add(this.cmbOtsenka);
            this.Controls.Add(this.cmbKurs);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbFakul);
            this.Controls.Add(this.cmbNaprav);
            this.Controls.Add(this.dtpDataRoj);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOtches);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFamil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImya);
            this.Controls.Add(this.btnCencel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCencel;
        private System.Windows.Forms.TextBox txtImya;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFamil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOtches;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.DateTimePicker dtpDataRoj;
        private System.Windows.Forms.ComboBox cmbNaprav;
        private System.Windows.Forms.ComboBox cmbFakul;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbKurs;
        private System.Windows.Forms.ComboBox cmbOtsenka;
    }
}