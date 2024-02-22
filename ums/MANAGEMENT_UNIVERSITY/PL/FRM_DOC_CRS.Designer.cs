namespace MANAGEMENT_UNIVERSITY.PL
{
    partial class FRM_DOC_CRS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DOC_CRS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CMB_TIME = new System.Windows.Forms.ComboBox();
            this.CMB_CRS_NAME = new System.Windows.Forms.ComboBox();
            this.CMB_DEP_NAME = new System.Windows.Forms.ComboBox();
            this.CMB_DEP_ID = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CMB_NAME_DOC = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CMB_DAY = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CMB_CRS_ID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CMB_ID_DOC = new System.Windows.Forms.ComboBox();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_EDIT = new System.Windows.Forms.Button();
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox1.Controls.Add(this.CMB_TIME);
            this.groupBox1.Controls.Add(this.CMB_CRS_NAME);
            this.groupBox1.Controls.Add(this.CMB_DEP_NAME);
            this.groupBox1.Controls.Add(this.CMB_DEP_ID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.CMB_NAME_DOC);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CMB_DAY);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CMB_CRS_ID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CMB_ID_DOC);
            this.groupBox1.Location = new System.Drawing.Point(25, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(697, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // CMB_TIME
            // 
            this.CMB_TIME.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_TIME.FormattingEnabled = true;
            this.CMB_TIME.Items.AddRange(new object[] {
            "8:00 ___ 11:00 ص",
            "11:00___ 2:00 م",
            "2:00___ 5:00 م"});
            this.CMB_TIME.Location = new System.Drawing.Point(12, 18);
            this.CMB_TIME.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CMB_TIME.Name = "CMB_TIME";
            this.CMB_TIME.Size = new System.Drawing.Size(138, 23);
            this.CMB_TIME.TabIndex = 25;
            // 
            // CMB_CRS_NAME
            // 
            this.CMB_CRS_NAME.FormattingEnabled = true;
            this.CMB_CRS_NAME.Location = new System.Drawing.Point(267, 93);
            this.CMB_CRS_NAME.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CMB_CRS_NAME.Name = "CMB_CRS_NAME";
            this.CMB_CRS_NAME.Size = new System.Drawing.Size(146, 21);
            this.CMB_CRS_NAME.TabIndex = 24;
            // 
            // CMB_DEP_NAME
            // 
            this.CMB_DEP_NAME.FormattingEnabled = true;
            this.CMB_DEP_NAME.Location = new System.Drawing.Point(267, 13);
            this.CMB_DEP_NAME.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CMB_DEP_NAME.Name = "CMB_DEP_NAME";
            this.CMB_DEP_NAME.Size = new System.Drawing.Size(146, 21);
            this.CMB_DEP_NAME.TabIndex = 23;
            this.CMB_DEP_NAME.SelectedIndexChanged += new System.EventHandler(this.CMB_DEP_NAME_SelectedIndexChanged);
            // 
            // CMB_DEP_ID
            // 
            this.CMB_DEP_ID.FormattingEnabled = true;
            this.CMB_DEP_ID.Location = new System.Drawing.Point(517, 14);
            this.CMB_DEP_ID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CMB_DEP_ID.Name = "CMB_DEP_ID";
            this.CMB_DEP_ID.Size = new System.Drawing.Size(82, 21);
            this.CMB_DEP_ID.TabIndex = 22;
            this.CMB_DEP_ID.SelectedIndexChanged += new System.EventHandler(this.CMB_DEP_ID_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(431, 98);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "اسم المادة : ";
            // 
            // CMB_NAME_DOC
            // 
            this.CMB_NAME_DOC.FormattingEnabled = true;
            this.CMB_NAME_DOC.Location = new System.Drawing.Point(267, 50);
            this.CMB_NAME_DOC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CMB_NAME_DOC.Name = "CMB_NAME_DOC";
            this.CMB_NAME_DOC.Size = new System.Drawing.Size(146, 21);
            this.CMB_NAME_DOC.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(158, 94);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = " يوم المحاضرة : ";
            // 
            // CMB_DAY
            // 
            this.CMB_DAY.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_DAY.FormattingEnabled = true;
            this.CMB_DAY.Items.AddRange(new object[] {
            "السبت ",
            "الأحد ",
            "الإثنين",
            "الثلاثاء",
            "الأربعاء",
            "الخميس"});
            this.CMB_DAY.Location = new System.Drawing.Point(17, 94);
            this.CMB_DAY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CMB_DAY.Name = "CMB_DAY";
            this.CMB_DAY.Size = new System.Drawing.Size(138, 23);
            this.CMB_DAY.TabIndex = 8;
            this.CMB_DAY.SelectedIndexChanged += new System.EventHandler(this.CMB_DAY_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(617, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = " رقم المادة : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CMB_CRS_ID
            // 
            this.CMB_CRS_ID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_CRS_ID.FormattingEnabled = true;
            this.CMB_CRS_ID.Location = new System.Drawing.Point(517, 96);
            this.CMB_CRS_ID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CMB_CRS_ID.Name = "CMB_CRS_ID";
            this.CMB_CRS_ID.Size = new System.Drawing.Size(82, 23);
            this.CMB_CRS_ID.TabIndex = 4;
            this.CMB_CRS_ID.SelectedIndexChanged += new System.EventHandler(this.CMB_CRS_ID_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = " وقت المحاضرة : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(415, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "اسم القسم :     ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(601, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "رقم القسم :     ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "اسم المحاضر :     ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(601, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "رقم المحاضر :     ";
            // 
            // CMB_ID_DOC
            // 
            this.CMB_ID_DOC.FormattingEnabled = true;
            this.CMB_ID_DOC.Location = new System.Drawing.Point(517, 53);
            this.CMB_ID_DOC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CMB_ID_DOC.Name = "CMB_ID_DOC";
            this.CMB_ID_DOC.Size = new System.Drawing.Size(82, 21);
            this.CMB_ID_DOC.TabIndex = 2;
            this.CMB_ID_DOC.SelectedIndexChanged += new System.EventHandler(this.CMB_ID_DOC_SelectedIndexChanged);
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ADD.ForeColor = System.Drawing.Color.Navy;
            this.BTN_ADD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_ADD.ImageIndex = 71;
            this.BTN_ADD.ImageList = this.imageList1;
            this.BTN_ADD.Location = new System.Drawing.Point(573, 181);
            this.BTN_ADD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(122, 31);
            this.BTN_ADD.TabIndex = 11;
            this.BTN_ADD.Text = "إضــافــــة ";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            this.BTN_ADD.Click += new System.EventHandler(this.button1_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 209);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Yellow;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(573, 183);
            this.dataGridView1.TabIndex = 2;
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DELETE.ForeColor = System.Drawing.Color.Navy;
            this.BTN_DELETE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_DELETE.ImageIndex = 94;
            this.BTN_DELETE.ImageList = this.imageList1;
            this.BTN_DELETE.Location = new System.Drawing.Point(377, 181);
            this.BTN_DELETE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(122, 31);
            this.BTN_DELETE.TabIndex = 26;
            this.BTN_DELETE.Text = "حـــــــــــــذف";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            this.BTN_DELETE.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_EDIT
            // 
            this.BTN_EDIT.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EDIT.ForeColor = System.Drawing.Color.Navy;
            this.BTN_EDIT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_EDIT.ImageIndex = 80;
            this.BTN_EDIT.ImageList = this.imageList1;
            this.BTN_EDIT.Location = new System.Drawing.Point(212, 181);
            this.BTN_EDIT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_EDIT.Name = "BTN_EDIT";
            this.BTN_EDIT.Size = new System.Drawing.Size(122, 31);
            this.BTN_EDIT.TabIndex = 27;
            this.BTN_EDIT.Text = "تـــــــعــــديــــــــــل";
            this.BTN_EDIT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_EDIT.UseVisualStyleBackColor = true;
            this.BTN_EDIT.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CANCEL.ForeColor = System.Drawing.Color.Navy;
            this.BTN_CANCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_CANCEL.ImageIndex = 53;
            this.BTN_CANCEL.ImageList = this.imageList1;
            this.BTN_CANCEL.Location = new System.Drawing.Point(36, 181);
            this.BTN_CANCEL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(122, 31);
            this.BTN_CANCEL.TabIndex = 28;
            this.BTN_CANCEL.Text = " إلــــــغــــــاء";
            this.BTN_CANCEL.UseVisualStyleBackColor = true;
            this.BTN_CANCEL.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.ImageIndex = 95;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(3, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 55);
            this.button1.TabIndex = 29;
            this.button1.Text = "طباعة كل المحاضرين";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(601, 216);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 178);
            this.panel1.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.ImageIndex = 95;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(3, 116);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 52);
            this.button2.TabIndex = 30;
            this.button2.Text = "طباعة المحاضر المحدد";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // FRM_DOC_CRS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_CANCEL);
            this.Controls.Add(this.BTN_EDIT);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.BTN_DELETE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRM_DOC_CRS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_DOC_CRS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CMB_NAME_DOC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CMB_DAY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CMB_CRS_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMB_ID_DOC;
        private System.Windows.Forms.ComboBox CMB_CRS_NAME;
        private System.Windows.Forms.ComboBox CMB_DEP_NAME;
        private System.Windows.Forms.ComboBox CMB_DEP_ID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CMB_TIME;
        private System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTN_EDIT;
        private System.Windows.Forms.Button BTN_CANCEL;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ImageList imageList1;
    }
}