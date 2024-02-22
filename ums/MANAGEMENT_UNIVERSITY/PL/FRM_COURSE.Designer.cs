namespace MANAGEMENT_UNIVERSITY.PL
{
    partial class FRM_COURSE
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_course = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_HOURS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_NAME_COURSE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_ID_COURCE = new System.Windows.Forms.TextBox();
            this.cLSCOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Data_G_V = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLSCOURSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_G_V)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_course);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TXT_HOURS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TXT_NAME_COURSE);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TXT_ID_COURCE);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(26, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 345);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(289, 294);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 31);
            this.button4.TabIndex = 16;
            this.button4.Text = "تعديل";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InfoText;
            this.button3.BackgroundImage = global::MANAGEMENT_UNIVERSITY.Properties.Resources.images__3_;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(156, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 32);
            this.button3.TabIndex = 15;
            this.button3.Text = "حذف";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "نوع المادة: ";
            // 
            // cmb_course
            // 
            this.cmb_course.FormattingEnabled = true;
            this.cmb_course.Items.AddRange(new object[] {
            "متطلب",
            "تخصصية"});
            this.cmb_course.Location = new System.Drawing.Point(289, 213);
            this.cmb_course.Name = "cmb_course";
            this.cmb_course.Size = new System.Drawing.Size(180, 30);
            this.cmb_course.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InfoText;
            this.button2.BackgroundImage = global::MANAGEMENT_UNIVERSITY.Properties.Resources.images__3_;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(19, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = " إلغاء";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(423, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "إضافة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "عدد الساعات : ";
            // 
            // TXT_HOURS
            // 
            this.TXT_HOURS.Location = new System.Drawing.Point(289, 160);
            this.TXT_HOURS.Name = "TXT_HOURS";
            this.TXT_HOURS.Size = new System.Drawing.Size(180, 30);
            this.TXT_HOURS.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "اسم المادة : ";
            // 
            // TXT_NAME_COURSE
            // 
            this.TXT_NAME_COURSE.Location = new System.Drawing.Point(289, 97);
            this.TXT_NAME_COURSE.Name = "TXT_NAME_COURSE";
            this.TXT_NAME_COURSE.Size = new System.Drawing.Size(180, 30);
            this.TXT_NAME_COURSE.TabIndex = 6;
            this.TXT_NAME_COURSE.Validated += new System.EventHandler(this.TXT_NAME_COURSE_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(489, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "رقم المادة : ";
            // 
            // TXT_ID_COURCE
            // 
            this.TXT_ID_COURCE.Location = new System.Drawing.Point(289, 30);
            this.TXT_ID_COURCE.Name = "TXT_ID_COURCE";
            this.TXT_ID_COURCE.Size = new System.Drawing.Size(180, 30);
            this.TXT_ID_COURCE.TabIndex = 3;
            this.TXT_ID_COURCE.Validated += new System.EventHandler(this.TXT_ID_COURCE_Validated);
            // 
            // cLSCOURSEBindingSource
            // 
            this.cLSCOURSEBindingSource.DataSource = typeof(MANAGEMENT_UNIVERSITY.BL.CLS_COURSE);
            // 
            // Data_G_V
            // 
            this.Data_G_V.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data_G_V.BackgroundColor = System.Drawing.Color.Bisque;
            this.Data_G_V.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Data_G_V.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_G_V.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Data_G_V.Location = new System.Drawing.Point(697, 16);
            this.Data_G_V.Name = "Data_G_V";
            this.Data_G_V.ReadOnly = true;
            this.Data_G_V.RowTemplate.Height = 29;
            this.Data_G_V.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data_G_V.Size = new System.Drawing.Size(650, 351);
            this.Data_G_V.TabIndex = 17;
            // 
            // FRM_COURSE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1381, 445);
            this.Controls.Add(this.Data_G_V);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FRM_COURSE";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_COURSE";
            this.Load += new System.EventHandler(this.FRM_COURSE_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLSCOURSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_G_V)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_HOURS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_NAME_COURSE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_ID_COURCE;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_course;
        private System.Windows.Forms.BindingSource cLSCOURSEBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.DataGridView Data_G_V;
    }
}