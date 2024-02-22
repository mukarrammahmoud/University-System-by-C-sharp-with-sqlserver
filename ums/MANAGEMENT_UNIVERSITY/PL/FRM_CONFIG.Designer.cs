namespace MANAGEMENT_UNIVERSITY.PL
{
    partial class FRM_CONFIG
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.BTN_EXIT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_PSW = new System.Windows.Forms.TextBox();
            this.TXT_USER_NM = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RD_SQL = new System.Windows.Forms.RadioButton();
            this.RD_WINDOWS = new System.Windows.Forms.RadioButton();
            this.TXT_DB_NM = new System.Windows.Forms.TextBox();
            this.TXT_SRVR_NM = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BTN_SAVE);
            this.panel1.Controls.Add(this.BTN_EXIT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TXT_PSW);
            this.panel1.Controls.Add(this.TXT_USER_NM);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TXT_DB_NM);
            this.panel1.Controls.Add(this.TXT_SRVR_NM);
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 476);
            this.panel1.TabIndex = 0;
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.Location = new System.Drawing.Point(186, 430);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(121, 39);
            this.BTN_SAVE.TabIndex = 26;
            this.BTN_SAVE.Text = "حفظ";
            this.BTN_SAVE.UseVisualStyleBackColor = true;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // BTN_EXIT
            // 
            this.BTN_EXIT.Location = new System.Drawing.Point(26, 430);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.Size = new System.Drawing.Size(121, 39);
            this.BTN_EXIT.TabIndex = 1;
            this.BTN_EXIT.Text = "خروج";
            this.BTN_EXIT.UseVisualStyleBackColor = true;
            this.BTN_EXIT.Click += new System.EventHandler(this.BTN_EXIT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(328, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "كلمة المرور : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(334, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "اسم المستخدم :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(328, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "طريقة الدخول : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(334, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "اسم قاعدة البيانات : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(334, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "اسم السيرفر :";
            // 
            // TXT_PSW
            // 
            this.TXT_PSW.Location = new System.Drawing.Point(103, 350);
            this.TXT_PSW.Name = "TXT_PSW";
            this.TXT_PSW.Size = new System.Drawing.Size(204, 23);
            this.TXT_PSW.TabIndex = 20;
            // 
            // TXT_USER_NM
            // 
            this.TXT_USER_NM.Location = new System.Drawing.Point(103, 284);
            this.TXT_USER_NM.Name = "TXT_USER_NM";
            this.TXT_USER_NM.Size = new System.Drawing.Size(204, 23);
            this.TXT_USER_NM.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel2.Controls.Add(this.RD_SQL);
            this.panel2.Controls.Add(this.RD_WINDOWS);
            this.panel2.Location = new System.Drawing.Point(26, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 110);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // RD_SQL
            // 
            this.RD_SQL.AutoSize = true;
            this.RD_SQL.ForeColor = System.Drawing.Color.Black;
            this.RD_SQL.Location = new System.Drawing.Point(5, 62);
            this.RD_SQL.Name = "RD_SQL";
            this.RD_SQL.Size = new System.Drawing.Size(193, 21);
            this.RD_SQL.TabIndex = 1;
            this.RD_SQL.Text = "SQL Server Authentication";
            this.RD_SQL.UseVisualStyleBackColor = true;
            this.RD_SQL.CheckedChanged += new System.EventHandler(this.RD_SQL_CheckedChanged);
            // 
            // RD_WINDOWS
            // 
            this.RD_WINDOWS.AutoSize = true;
            this.RD_WINDOWS.Checked = true;
            this.RD_WINDOWS.ForeColor = System.Drawing.Color.Black;
            this.RD_WINDOWS.Location = new System.Drawing.Point(30, 20);
            this.RD_WINDOWS.Name = "RD_WINDOWS";
            this.RD_WINDOWS.Size = new System.Drawing.Size(176, 21);
            this.RD_WINDOWS.TabIndex = 0;
            this.RD_WINDOWS.TabStop = true;
            this.RD_WINDOWS.Text = "Windows Authentication";
            this.RD_WINDOWS.UseVisualStyleBackColor = true;
            this.RD_WINDOWS.CheckedChanged += new System.EventHandler(this.RD_WINDOWS_CheckedChanged);
            // 
            // TXT_DB_NM
            // 
            this.TXT_DB_NM.Location = new System.Drawing.Point(103, 87);
            this.TXT_DB_NM.Name = "TXT_DB_NM";
            this.TXT_DB_NM.Size = new System.Drawing.Size(204, 23);
            this.TXT_DB_NM.TabIndex = 14;
            // 
            // TXT_SRVR_NM
            // 
            this.TXT_SRVR_NM.Location = new System.Drawing.Point(103, 21);
            this.TXT_SRVR_NM.Name = "TXT_SRVR_NM";
            this.TXT_SRVR_NM.Size = new System.Drawing.Size(204, 23);
            this.TXT_SRVR_NM.TabIndex = 12;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this.panel2;
            // 
            // FRM_CONFIG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 500);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FRM_CONFIG";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "واجهة التحكم في إعدادات الإتصال بالسيرفر";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.Button BTN_EXIT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_PSW;
        private System.Windows.Forms.TextBox TXT_USER_NM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RD_SQL;
        private System.Windows.Forms.RadioButton RD_WINDOWS;
        private System.Windows.Forms.TextBox TXT_DB_NM;
        private System.Windows.Forms.TextBox TXT_SRVR_NM;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}