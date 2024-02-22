namespace MANAGEMENT_UNIVERSITY.PL
{
    partial class FRM_EDIT_PR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_EDIT_PR));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXT_DATE = new System.Windows.Forms.TextBox();
            this.txt_doc_name = new System.Windows.Forms.TextBox();
            this.txt_dep_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CMB_PA2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CMB_DAYS2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TXT_DATE);
            this.panel1.Controls.Add(this.txt_doc_name);
            this.panel1.Controls.Add(this.txt_dep_name);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CMB_PA2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CMB_DAYS2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(23, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 269);
            this.panel1.TabIndex = 0;
            // 
            // TXT_DATE
            // 
            this.TXT_DATE.Location = new System.Drawing.Point(16, 45);
            this.TXT_DATE.Name = "TXT_DATE";
            this.TXT_DATE.ReadOnly = true;
            this.TXT_DATE.Size = new System.Drawing.Size(160, 28);
            this.TXT_DATE.TabIndex = 24;
            // 
            // txt_doc_name
            // 
            this.txt_doc_name.Location = new System.Drawing.Point(562, 168);
            this.txt_doc_name.Name = "txt_doc_name";
            this.txt_doc_name.Size = new System.Drawing.Size(160, 28);
            this.txt_doc_name.TabIndex = 23;
            // 
            // txt_dep_name
            // 
            this.txt_dep_name.Location = new System.Drawing.Point(562, 45);
            this.txt_dep_name.Name = "txt_dep_name";
            this.txt_dep_name.Size = new System.Drawing.Size(160, 28);
            this.txt_dep_name.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 27);
            this.label6.TabIndex = 21;
            this.label6.Text = "التاريخ : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(411, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = " الحضور والغياب : ";
            // 
            // CMB_PA2
            // 
            this.CMB_PA2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_PA2.FormattingEnabled = true;
            this.CMB_PA2.Items.AddRange(new object[] {
            "حاضر",
            "غائب"});
            this.CMB_PA2.Location = new System.Drawing.Point(225, 160);
            this.CMB_PA2.Name = "CMB_PA2";
            this.CMB_PA2.Size = new System.Drawing.Size(164, 28);
            this.CMB_PA2.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(415, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "أيام المحاضرة : ";
            // 
            // CMB_DAYS2
            // 
            this.CMB_DAYS2.FormattingEnabled = true;
            this.CMB_DAYS2.Items.AddRange(new object[] {
            "السبت ",
            "الأحد ",
            "الإثنين",
            "الثلاثاء",
            "الأربعاء",
            "الخميس"});
            this.CMB_DAYS2.Location = new System.Drawing.Point(225, 42);
            this.CMB_DAYS2.Name = "CMB_DAYS2";
            this.CMB_DAYS2.Size = new System.Drawing.Size(164, 28);
            this.CMB_DAYS2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(744, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "اسم المحاضر : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(738, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "اسم القسم : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.ImageIndex = 63;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(698, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "تـعــــــديـــــــــل";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.ImageIndex = 94;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(150, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = " إلـــغـــــاء";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "636393427463296084.jpg");
            this.imageList1.Images.SetKeyName(1, "images (1).jpeg");
            this.imageList1.Images.SetKeyName(2, "images (1).jpg");
            this.imageList1.Images.SetKeyName(3, "images (1).png");
            this.imageList1.Images.SetKeyName(4, "images (2).jpeg");
            this.imageList1.Images.SetKeyName(5, "images (2).jpg");
            this.imageList1.Images.SetKeyName(6, "images (2).png");
            this.imageList1.Images.SetKeyName(7, "images (3).jpeg");
            this.imageList1.Images.SetKeyName(8, "images (3).jpg");
            this.imageList1.Images.SetKeyName(9, "images (3).png");
            this.imageList1.Images.SetKeyName(10, "images (4).jpeg");
            this.imageList1.Images.SetKeyName(11, "images (4).jpg");
            this.imageList1.Images.SetKeyName(12, "images (4).png");
            this.imageList1.Images.SetKeyName(13, "images (5).jpeg");
            this.imageList1.Images.SetKeyName(14, "images (5).png");
            this.imageList1.Images.SetKeyName(15, "images (6).jpeg");
            this.imageList1.Images.SetKeyName(16, "images (6).png");
            this.imageList1.Images.SetKeyName(17, "images (7).jpeg");
            this.imageList1.Images.SetKeyName(18, "images (7).png");
            this.imageList1.Images.SetKeyName(19, "images (8).jpeg");
            this.imageList1.Images.SetKeyName(20, "images (8).png");
            this.imageList1.Images.SetKeyName(21, "images (9).jpeg");
            this.imageList1.Images.SetKeyName(22, "images (9).png");
            this.imageList1.Images.SetKeyName(23, "images (10).jpeg");
            this.imageList1.Images.SetKeyName(24, "images (10).png");
            this.imageList1.Images.SetKeyName(25, "images (11).jpeg");
            this.imageList1.Images.SetKeyName(26, "images (11).png");
            this.imageList1.Images.SetKeyName(27, "images (12).jpeg");
            this.imageList1.Images.SetKeyName(28, "images (12).png");
            this.imageList1.Images.SetKeyName(29, "images (13).jpeg");
            this.imageList1.Images.SetKeyName(30, "images (13).png");
            this.imageList1.Images.SetKeyName(31, "images (14).png");
            this.imageList1.Images.SetKeyName(32, "images (15).png");
            this.imageList1.Images.SetKeyName(33, "images (16).png");
            this.imageList1.Images.SetKeyName(34, "images (17).png");
            this.imageList1.Images.SetKeyName(35, "images (18).png");
            this.imageList1.Images.SetKeyName(36, "images (19).png");
            this.imageList1.Images.SetKeyName(37, "images (20).png");
            this.imageList1.Images.SetKeyName(38, "images (21).png");
            this.imageList1.Images.SetKeyName(39, "images (22).png");
            this.imageList1.Images.SetKeyName(40, "images (23).png");
            this.imageList1.Images.SetKeyName(41, "images.jpeg");
            this.imageList1.Images.SetKeyName(42, "images.jpg");
            this.imageList1.Images.SetKeyName(43, "images.png");
            this.imageList1.Images.SetKeyName(44, "kipers.jpg");
            this.imageList1.Images.SetKeyName(45, "map10.jpg");
            this.imageList1.Images.SetKeyName(46, "png-clipart-computer-icons-man-icon-logo-silhouette.png");
            this.imageList1.Images.SetKeyName(47, "pngtree-luxury-golden-islamic-banner-set-title-frame-png-transparent-background-w" +
        "ith-png-image_7599852.png");
            this.imageList1.Images.SetKeyName(48, "Yemen_Road.jpg");
            this.imageList1.Images.SetKeyName(49, "اليمن.jpg");
            this.imageList1.Images.SetKeyName(50, "تنزيل (1).jpeg");
            this.imageList1.Images.SetKeyName(51, "تنزيل (1).jpg");
            this.imageList1.Images.SetKeyName(52, "تنزيل (1).png");
            this.imageList1.Images.SetKeyName(53, "تنزيل (2).jpeg");
            this.imageList1.Images.SetKeyName(54, "تنزيل (2).png");
            this.imageList1.Images.SetKeyName(55, "تنزيل (3).jpeg");
            this.imageList1.Images.SetKeyName(56, "تنزيل (3).png");
            this.imageList1.Images.SetKeyName(57, "تنزيل (4).jpeg");
            this.imageList1.Images.SetKeyName(58, "تنزيل (4).png");
            this.imageList1.Images.SetKeyName(59, "تنزيل (5).jpeg");
            this.imageList1.Images.SetKeyName(60, "تنزيل (5).png");
            this.imageList1.Images.SetKeyName(61, "تنزيل (6).jpeg");
            this.imageList1.Images.SetKeyName(62, "تنزيل (6).png");
            this.imageList1.Images.SetKeyName(63, "تنزيل (7).jpeg");
            this.imageList1.Images.SetKeyName(64, "تنزيل (7).png");
            this.imageList1.Images.SetKeyName(65, "تنزيل (8).jpeg");
            this.imageList1.Images.SetKeyName(66, "تنزيل (8).png");
            this.imageList1.Images.SetKeyName(67, "تنزيل (9).jpeg");
            this.imageList1.Images.SetKeyName(68, "تنزيل (9).png");
            this.imageList1.Images.SetKeyName(69, "تنزيل (10).jpeg");
            this.imageList1.Images.SetKeyName(70, "تنزيل (10).png");
            this.imageList1.Images.SetKeyName(71, "تنزيل (11).jpeg");
            this.imageList1.Images.SetKeyName(72, "تنزيل (11).png");
            this.imageList1.Images.SetKeyName(73, "تنزيل (12).jpeg");
            this.imageList1.Images.SetKeyName(74, "تنزيل (12).png");
            this.imageList1.Images.SetKeyName(75, "تنزيل (13).jpeg");
            this.imageList1.Images.SetKeyName(76, "تنزيل (13).png");
            this.imageList1.Images.SetKeyName(77, "تنزيل (14).jpeg");
            this.imageList1.Images.SetKeyName(78, "تنزيل (14).png");
            this.imageList1.Images.SetKeyName(79, "تنزيل (15).jpeg");
            this.imageList1.Images.SetKeyName(80, "تنزيل (15).png");
            this.imageList1.Images.SetKeyName(81, "تنزيل (16).jpeg");
            this.imageList1.Images.SetKeyName(82, "تنزيل (16).png");
            this.imageList1.Images.SetKeyName(83, "تنزيل (17).jpeg");
            this.imageList1.Images.SetKeyName(84, "تنزيل (17).png");
            this.imageList1.Images.SetKeyName(85, "تنزيل (18).jpeg");
            this.imageList1.Images.SetKeyName(86, "تنزيل (18).png");
            this.imageList1.Images.SetKeyName(87, "تنزيل (19).jpeg");
            this.imageList1.Images.SetKeyName(88, "تنزيل (19).png");
            this.imageList1.Images.SetKeyName(89, "تنزيل (20).jpeg");
            this.imageList1.Images.SetKeyName(90, "تنزيل (20).png");
            this.imageList1.Images.SetKeyName(91, "تنزيل (21).png");
            this.imageList1.Images.SetKeyName(92, "تنزيل (22).png");
            this.imageList1.Images.SetKeyName(93, "تنزيل.jpeg");
            this.imageList1.Images.SetKeyName(94, "تنزيل.jpg");
            this.imageList1.Images.SetKeyName(95, "تنزيل.png");
            // 
            // FRM_EDIT_PR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 400);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FRM_EDIT_PR";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_EDIT_PR";
            this.Load += new System.EventHandler(this.FRM_EDIT_PR_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox CMB_PA2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox CMB_DAYS2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_dep_name;
        public System.Windows.Forms.TextBox txt_doc_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox TXT_DATE;
        public System.Windows.Forms.ImageList imageList1;
    }
}