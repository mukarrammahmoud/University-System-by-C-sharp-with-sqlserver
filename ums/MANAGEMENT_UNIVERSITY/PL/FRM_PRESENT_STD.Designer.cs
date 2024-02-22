namespace MANAGEMENT_UNIVERSITY.PL
{
    partial class FRM_PRESENT_STD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PRESENT_STD));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.CMB_CRS_NM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CMB_CRS_ID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CMB_DEP_NM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GreenYellow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.CMB_CRS_NM);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CMB_CRS_ID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CMB_DEP_NM);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(48, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 346);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.ImageIndex = 94;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(460, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "إلــغـاء";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CMB_CRS_NM
            // 
            this.CMB_CRS_NM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_CRS_NM.FormattingEnabled = true;
            this.CMB_CRS_NM.Location = new System.Drawing.Point(186, 187);
            this.CMB_CRS_NM.Name = "CMB_CRS_NM";
            this.CMB_CRS_NM.Size = new System.Drawing.Size(222, 27);
            this.CMB_CRS_NM.TabIndex = 7;
            this.CMB_CRS_NM.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(460, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "اسم المادة : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CMB_CRS_ID
            // 
            this.CMB_CRS_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_CRS_ID.FormattingEnabled = true;
            this.CMB_CRS_ID.Location = new System.Drawing.Point(186, 109);
            this.CMB_CRS_ID.Name = "CMB_CRS_ID";
            this.CMB_CRS_ID.Size = new System.Drawing.Size(222, 27);
            this.CMB_CRS_ID.TabIndex = 5;
            this.CMB_CRS_ID.SelectedIndexChanged += new System.EventHandler(this.CMB_CRS_ID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "رقم المادة :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CMB_DEP_NM
            // 
            this.CMB_DEP_NM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_DEP_NM.FormattingEnabled = true;
            this.CMB_DEP_NM.Location = new System.Drawing.Point(186, 31);
            this.CMB_DEP_NM.Name = "CMB_DEP_NM";
            this.CMB_DEP_NM.Size = new System.Drawing.Size(222, 27);
            this.CMB_DEP_NM.TabIndex = 3;
            this.CMB_DEP_NM.SelectedIndexChanged += new System.EventHandler(this.CMB_DEP_NM_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم القسم :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.ImageIndex = 95;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(26, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "طباعة";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // FRM_PRESENT_STD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 418);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FRM_PRESENT_STD";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_PRESENT_STD";
            this.Load += new System.EventHandler(this.FRM_PRESENT_STD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CMB_DEP_NM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CMB_CRS_NM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CMB_CRS_ID;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ImageList imageList1;
    }
}