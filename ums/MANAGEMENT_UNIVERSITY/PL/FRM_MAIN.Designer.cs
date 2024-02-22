namespace MANAGEMENT_UNIVERSITY.PL
{
    partial class FRM_MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MAIN));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.لفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.تسجيلالخروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جلبنسخةإحتياطيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حفظنسخةإحتياطيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تسجيلالخروجToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.التسجيلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jتسجيلطالبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تسجيلمحاضرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الشؤونالأكاديميةللطلابToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إدارةالطلابToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الدرجاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الحضوروالغيابToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.الشؤونالأكاديميةللموظفينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الحضوروالغيابToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الموادالمقررةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الشؤونالماليةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الكلياتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.كليةالطبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.كليةالحاسوبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.كليةالتجارةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.كليةالآدابToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.كليةالهندسةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.إضافةمادةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إضافةمادةإلىقسمToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المستخدمونToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إدارةالمستخدمينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.aCOUNTSTDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.university_DBDataSet1 = new MANAGEMENT_UNIVERSITY.University_DBDataSet1();
            this.gET_ALL_CRS_DEPSTableAdapter = new MANAGEMENT_UNIVERSITY.University_DBDataSetTableAdapters.GET_ALL_CRS_DEPSTableAdapter();
            this.aCOUNT_STDTableAdapter = new MANAGEMENT_UNIVERSITY.University_DBDataSet1TableAdapters.ACOUNT_STDTableAdapter();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.إعداداتالإتصالبالسيرفرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCOUNTSTDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.university_DBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.لفToolStripMenuItem,
            this.التسجيلToolStripMenuItem,
            this.الToolStripMenuItem,
            this.الشؤونالماليةToolStripMenuItem,
            this.الكلياتToolStripMenuItem,
            this.toolStripMenuItem1,
            this.المستخدمونToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1201, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // لفToolStripMenuItem
            // 
            this.لفToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.لفToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.تسجيلالخروجToolStripMenuItem,
            this.جلبنسخةإحتياطيةToolStripMenuItem,
            this.حفظنسخةإحتياطيةToolStripMenuItem,
            this.إعداداتالإتصالبالسيرفرToolStripMenuItem,
            this.تسجيلالخروجToolStripMenuItem1});
            this.لفToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.images__1_2;
            this.لفToolStripMenuItem.Name = "لفToolStripMenuItem";
            this.لفToolStripMenuItem.Size = new System.Drawing.Size(82, 30);
            this.لفToolStripMenuItem.Text = "ملف";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(293, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(293, 6);
            // 
            // تسجيلالخروجToolStripMenuItem
            // 
            this.تسجيلالخروجToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.images__17_;
            this.تسجيلالخروجToolStripMenuItem.Name = "تسجيلالخروجToolStripMenuItem";
            this.تسجيلالخروجToolStripMenuItem.Size = new System.Drawing.Size(296, 30);
            this.تسجيلالخروجToolStripMenuItem.Text = "تسجيل الدخول";
            this.تسجيلالخروجToolStripMenuItem.Click += new System.EventHandler(this.تسجيلالخروجToolStripMenuItem_Click_1);
            // 
            // جلبنسخةإحتياطيةToolStripMenuItem
            // 
            this.جلبنسخةإحتياطيةToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.تنزيل__1_;
            this.جلبنسخةإحتياطيةToolStripMenuItem.Name = "جلبنسخةإحتياطيةToolStripMenuItem";
            this.جلبنسخةإحتياطيةToolStripMenuItem.Size = new System.Drawing.Size(296, 30);
            this.جلبنسخةإحتياطيةToolStripMenuItem.Text = "جلب نسخة إحتياطية";
            this.جلبنسخةإحتياطيةToolStripMenuItem.Click += new System.EventHandler(this.جلبنسخةإحتياطيةToolStripMenuItem_Click);
            // 
            // حفظنسخةإحتياطيةToolStripMenuItem
            // 
            this.حفظنسخةإحتياطيةToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.تنزيل__1_1;
            this.حفظنسخةإحتياطيةToolStripMenuItem.Name = "حفظنسخةإحتياطيةToolStripMenuItem";
            this.حفظنسخةإحتياطيةToolStripMenuItem.Size = new System.Drawing.Size(296, 30);
            this.حفظنسخةإحتياطيةToolStripMenuItem.Text = "حفظ نسخة إحتياطية";
            this.حفظنسخةإحتياطيةToolStripMenuItem.Click += new System.EventHandler(this.حفظنسخةإحتياطيةToolStripMenuItem_Click);
            // 
            // تسجيلالخروجToolStripMenuItem1
            // 
            this.تسجيلالخروجToolStripMenuItem1.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.images__15_;
            this.تسجيلالخروجToolStripMenuItem1.Name = "تسجيلالخروجToolStripMenuItem1";
            this.تسجيلالخروجToolStripMenuItem1.Size = new System.Drawing.Size(296, 30);
            this.تسجيلالخروجToolStripMenuItem1.Text = "تسجيل الخروج";
            this.تسجيلالخروجToolStripMenuItem1.Click += new System.EventHandler(this.تسجيلالخروجToolStripMenuItem1_Click_1);
            // 
            // التسجيلToolStripMenuItem
            // 
            this.التسجيلToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.التسجيلToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jتسجيلطالبToolStripMenuItem,
            this.تسجيلمحاضرToolStripMenuItem});
            this.التسجيلToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.images__14_;
            this.التسجيلToolStripMenuItem.Name = "التسجيلToolStripMenuItem";
            this.التسجيلToolStripMenuItem.Size = new System.Drawing.Size(112, 30);
            this.التسجيلToolStripMenuItem.Text = "التسجيل";
            this.التسجيلToolStripMenuItem.Click += new System.EventHandler(this.التسجيلToolStripMenuItem_Click);
            // 
            // jتسجيلطالبToolStripMenuItem
            // 
            this.jتسجيلطالبToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.تنزيل__10_1;
            this.jتسجيلطالبToolStripMenuItem.Name = "jتسجيلطالبToolStripMenuItem";
            this.jتسجيلطالبToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.jتسجيلطالبToolStripMenuItem.Text = "تسجيل طالب";
            this.jتسجيلطالبToolStripMenuItem.Click += new System.EventHandler(this.jتسجيلطالبToolStripMenuItem_Click);
            // 
            // تسجيلمحاضرToolStripMenuItem
            // 
            this.تسجيلمحاضرToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.تنزيل__7_;
            this.تسجيلمحاضرToolStripMenuItem.Name = "تسجيلمحاضرToolStripMenuItem";
            this.تسجيلمحاضرToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.تسجيلمحاضرToolStripMenuItem.Text = "تسجيل محاضر";
            this.تسجيلمحاضرToolStripMenuItem.Click += new System.EventHandler(this.تسجيلمحاضرToolStripMenuItem_Click);
            // 
            // الToolStripMenuItem
            // 
            this.الToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.الToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الشؤونالأكاديميةللطلابToolStripMenuItem,
            this.الشؤونالأكاديميةللموظفينToolStripMenuItem});
            this.الToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.images__18_;
            this.الToolStripMenuItem.Name = "الToolStripMenuItem";
            this.الToolStripMenuItem.Size = new System.Drawing.Size(189, 30);
            this.الToolStripMenuItem.Text = "الشؤون الأكاديمية";
            // 
            // الشؤونالأكاديميةللطلابToolStripMenuItem
            // 
            this.الشؤونالأكاديميةللطلابToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إدارةالطلابToolStripMenuItem,
            this.الدرجاتToolStripMenuItem,
            this.الحضوروالغيابToolStripMenuItem1});
            this.الشؤونالأكاديميةللطلابToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.images__7_;
            this.الشؤونالأكاديميةللطلابToolStripMenuItem.Name = "الشؤونالأكاديميةللطلابToolStripMenuItem";
            this.الشؤونالأكاديميةللطلابToolStripMenuItem.Size = new System.Drawing.Size(317, 30);
            this.الشؤونالأكاديميةللطلابToolStripMenuItem.Text = "الشؤون الأكاديمية للطلاب";
            this.الشؤونالأكاديميةللطلابToolStripMenuItem.Click += new System.EventHandler(this.الشؤونالأكاديميةللطلابToolStripMenuItem_Click);
            // 
            // إدارةالطلابToolStripMenuItem
            // 
            this.إدارةالطلابToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.images__16_;
            this.إدارةالطلابToolStripMenuItem.Name = "إدارةالطلابToolStripMenuItem";
            this.إدارةالطلابToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.إدارةالطلابToolStripMenuItem.Text = "إدارة الطلاب";
            this.إدارةالطلابToolStripMenuItem.Click += new System.EventHandler(this.إدارةالطلابToolStripMenuItem_Click);
            // 
            // الدرجاتToolStripMenuItem
            // 
            this.الدرجاتToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.تنزيل__17_;
            this.الدرجاتToolStripMenuItem.Name = "الدرجاتToolStripMenuItem";
            this.الدرجاتToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.الدرجاتToolStripMenuItem.Text = "الدرجات";
            this.الدرجاتToolStripMenuItem.Click += new System.EventHandler(this.الدرجاتToolStripMenuItem_Click);
            // 
            // الحضوروالغيابToolStripMenuItem1
            // 
            this.الحضوروالغيابToolStripMenuItem1.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.تنزيل__13_2;
            this.الحضوروالغيابToolStripMenuItem1.Name = "الحضوروالغيابToolStripMenuItem1";
            this.الحضوروالغيابToolStripMenuItem1.Size = new System.Drawing.Size(226, 30);
            this.الحضوروالغيابToolStripMenuItem1.Text = "الحضور والغياب";
            this.الحضوروالغيابToolStripMenuItem1.Click += new System.EventHandler(this.الحضوروالغيابToolStripMenuItem1_Click);
            // 
            // الشؤونالأكاديميةللموظفينToolStripMenuItem
            // 
            this.الشؤونالأكاديميةللموظفينToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الحضوروالغيابToolStripMenuItem,
            this.الموادالمقررةToolStripMenuItem});
            this.الشؤونالأكاديميةللموظفينToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.images__1_1;
            this.الشؤونالأكاديميةللموظفينToolStripMenuItem.Name = "الشؤونالأكاديميةللموظفينToolStripMenuItem";
            this.الشؤونالأكاديميةللموظفينToolStripMenuItem.Size = new System.Drawing.Size(317, 30);
            this.الشؤونالأكاديميةللموظفينToolStripMenuItem.Text = "الشؤون الأكاديمية للموظفين";
            this.الشؤونالأكاديميةللموظفينToolStripMenuItem.Click += new System.EventHandler(this.الشؤونالأكاديميةللموظفينToolStripMenuItem_Click);
            // 
            // الحضوروالغيابToolStripMenuItem
            // 
            this.الحضوروالغيابToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.تنزيل__12_;
            this.الحضوروالغيابToolStripMenuItem.Name = "الحضوروالغيابToolStripMenuItem";
            this.الحضوروالغيابToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.الحضوروالغيابToolStripMenuItem.Text = "الحضور والغياب";
            this.الحضوروالغيابToolStripMenuItem.Click += new System.EventHandler(this.الحضوروالغيابToolStripMenuItem_Click);
            // 
            // الموادالمقررةToolStripMenuItem
            // 
            this.الموادالمقررةToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.images__5_;
            this.الموادالمقررةToolStripMenuItem.Name = "الموادالمقررةToolStripMenuItem";
            this.الموادالمقررةToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.الموادالمقررةToolStripMenuItem.Text = "المواد المقررة";
            this.الموادالمقررةToolStripMenuItem.Click += new System.EventHandler(this.الموادالمقررةToolStripMenuItem_Click);
            // 
            // الشؤونالماليةToolStripMenuItem
            // 
            this.الشؤونالماليةToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.الشؤونالماليةToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.تنزيل__14_;
            this.الشؤونالماليةToolStripMenuItem.Name = "الشؤونالماليةToolStripMenuItem";
            this.الشؤونالماليةToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.الشؤونالماليةToolStripMenuItem.Text = "الشؤون المالية";
            this.الشؤونالماليةToolStripMenuItem.Click += new System.EventHandler(this.الشؤونالماليةToolStripMenuItem_Click);
            // 
            // الكلياتToolStripMenuItem
            // 
            this.الكلياتToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.الكلياتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.كليةالطبToolStripMenuItem,
            this.كليةالحاسوبToolStripMenuItem,
            this.كليةالتجارةToolStripMenuItem,
            this.كليةالآدابToolStripMenuItem,
            this.كليةالهندسةToolStripMenuItem});
            this.الكلياتToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.images__8_;
            this.الكلياتToolStripMenuItem.Name = "الكلياتToolStripMenuItem";
            this.الكلياتToolStripMenuItem.Size = new System.Drawing.Size(103, 30);
            this.الكلياتToolStripMenuItem.Text = "الكليات";
            this.الكلياتToolStripMenuItem.Click += new System.EventHandler(this.الكلياتToolStripMenuItem_Click);
            // 
            // كليةالطبToolStripMenuItem
            // 
            this.كليةالطبToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.images__13_;
            this.كليةالطبToolStripMenuItem.Name = "كليةالطبToolStripMenuItem";
            this.كليةالطبToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.كليةالطبToolStripMenuItem.Text = "كلية الطب ";
            this.كليةالطبToolStripMenuItem.Click += new System.EventHandler(this.كليةالطبToolStripMenuItem_Click);
            // 
            // كليةالحاسوبToolStripMenuItem
            // 
            this.كليةالحاسوبToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.images__10_;
            this.كليةالحاسوبToolStripMenuItem.Name = "كليةالحاسوبToolStripMenuItem";
            this.كليةالحاسوبToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.كليةالحاسوبToolStripMenuItem.Text = "كلية الحاسوب";
            this.كليةالحاسوبToolStripMenuItem.Click += new System.EventHandler(this.كليةالحاسوبToolStripMenuItem_Click);
            // 
            // كليةالتجارةToolStripMenuItem
            // 
            this.كليةالتجارةToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.images;
            this.كليةالتجارةToolStripMenuItem.Name = "كليةالتجارةToolStripMenuItem";
            this.كليةالتجارةToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.كليةالتجارةToolStripMenuItem.Text = "كلية التجارة";
            this.كليةالتجارةToolStripMenuItem.Click += new System.EventHandler(this.كليةالتجارةToolStripMenuItem_Click);
            // 
            // كليةالآدابToolStripMenuItem
            // 
            this.كليةالآدابToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.images__4_;
            this.كليةالآدابToolStripMenuItem.Name = "كليةالآدابToolStripMenuItem";
            this.كليةالآدابToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.كليةالآدابToolStripMenuItem.Text = "كلية الآداب";
            this.كليةالآدابToolStripMenuItem.Click += new System.EventHandler(this.كليةالآدابToolStripMenuItem_Click);
            // 
            // كليةالهندسةToolStripMenuItem
            // 
            this.كليةالهندسةToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.images__3_1;
            this.كليةالهندسةToolStripMenuItem.Name = "كليةالهندسةToolStripMenuItem";
            this.كليةالهندسةToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.كليةالهندسةToolStripMenuItem.Text = "كلية الهندسة";
            this.كليةالهندسةToolStripMenuItem.Click += new System.EventHandler(this.كليةالهندسةToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Cornsilk;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إضافةمادةToolStripMenuItem,
            this.إضافةمادةإلىقسمToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.تنزيل__13_;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(93, 30);
            this.toolStripMenuItem1.Text = "المواد";
            // 
            // إضافةمادةToolStripMenuItem
            // 
            this.إضافةمادةToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.تنزيل__15_1;
            this.إضافةمادةToolStripMenuItem.Name = "إضافةمادةToolStripMenuItem";
            this.إضافةمادةToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.إضافةمادةToolStripMenuItem.Text = "إضافة مادة";
            this.إضافةمادةToolStripMenuItem.Click += new System.EventHandler(this.إضافةمادةToolStripMenuItem_Click);
            // 
            // إضافةمادةإلىقسمToolStripMenuItem
            // 
            this.إضافةمادةإلىقسمToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.تنزيل__19_;
            this.إضافةمادةإلىقسمToolStripMenuItem.Name = "إضافةمادةإلىقسمToolStripMenuItem";
            this.إضافةمادةإلىقسمToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.إضافةمادةإلىقسمToolStripMenuItem.Text = "إضافة مادة إلى قسم";
            this.إضافةمادةإلىقسمToolStripMenuItem.Click += new System.EventHandler(this.إضافةمادةإلىقسمToolStripMenuItem_Click);
            // 
            // المستخدمونToolStripMenuItem
            // 
            this.المستخدمونToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.المستخدمونToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إدارةالمستخدمينToolStripMenuItem});
            this.المستخدمونToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.تنزيل__18_;
            this.المستخدمونToolStripMenuItem.Name = "المستخدمونToolStripMenuItem";
            this.المستخدمونToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.المستخدمونToolStripMenuItem.Text = "المستخدمون";
            // 
            // إدارةالمستخدمينToolStripMenuItem
            // 
            this.إدارةالمستخدمينToolStripMenuItem.Image = global::MANAGEMENT_UNIVERSITY.Properties.Resources.images__13_5;
            this.إدارةالمستخدمينToolStripMenuItem.Name = "إدارةالمستخدمينToolStripMenuItem";
            this.إدارةالمستخدمينToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.إدارةالمستخدمينToolStripMenuItem.Text = "إدارة المستخدمين";
            this.إدارةالمستخدمينToolStripMenuItem.Click += new System.EventHandler(this.إدارةالمستخدمينToolStripMenuItem_Click);
            // 
            // aCOUNTSTDBindingSource
            // 
            this.aCOUNTSTDBindingSource.DataMember = "ACOUNT_STD";
            this.aCOUNTSTDBindingSource.DataSource = this.university_DBDataSet1;
            // 
            // university_DBDataSet1
            // 
            this.university_DBDataSet1.DataSetName = "University_DBDataSet1";
            this.university_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gET_ALL_CRS_DEPSTableAdapter
            // 
            this.gET_ALL_CRS_DEPSTableAdapter.ClearBeforeFill = true;
            // 
            // aCOUNT_STDTableAdapter
            // 
            this.aCOUNT_STDTableAdapter.ClearBeforeFill = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
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
            this.imageList1.Images.SetKeyName(96, "images (14).jpeg");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.ImageIndex = 96;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(920, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // إعداداتالإتصالبالسيرفرToolStripMenuItem
            // 
            this.إعداداتالإتصالبالسيرفرToolStripMenuItem.Name = "إعداداتالإتصالبالسيرفرToolStripMenuItem";
            this.إعداداتالإتصالبالسيرفرToolStripMenuItem.Size = new System.Drawing.Size(296, 30);
            this.إعداداتالإتصالبالسيرفرToolStripMenuItem.Text = "إعدادات الإتصال بالسيرفر";
            this.إعداداتالإتصالبالسيرفرToolStripMenuItem.Click += new System.EventHandler(this.إعداداتالإتصالبالسيرفرToolStripMenuItem_Click);
            // 
            // FRM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MANAGEMENT_UNIVERSITY.Properties.Resources.images__1_2;
            this.ClientSize = new System.Drawing.Size(1201, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FRM_MAIN";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "النافذة الرئيسية";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_MAIN_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCOUNTSTDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.university_DBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem كليةالطبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem كليةالحاسوبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem كليةالتجارةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem كليةالآدابToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem كليةالهندسةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jتسجيلطالبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تسجيلمحاضرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إضافةمادةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إضافةمادةإلىقسمToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private University_DBDataSetTableAdapters.GET_ALL_CRS_DEPSTableAdapter gET_ALL_CRS_DEPSTableAdapter;
        private University_DBDataSet1 university_DBDataSet1;
        private System.Windows.Forms.BindingSource aCOUNTSTDBindingSource;
        private University_DBDataSet1TableAdapters.ACOUNT_STDTableAdapter aCOUNT_STDTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem إدارةالمستخدمينToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem المستخدمونToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem التسجيلToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem الToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem الشؤونالماليةToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem الكلياتToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem لفToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem الشؤونالأكاديميةللموظفينToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem الحضوروالغيابToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem الموادالمقررةToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem الشؤونالأكاديميةللطلابToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem إدارةالطلابToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem الدرجاتToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem تسجيلالخروجToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem جلبنسخةإحتياطيةToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem حفظنسخةإحتياطيةToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem تسجيلالخروجToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem الحضوروالغيابToolStripMenuItem1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem إعداداتالإتصالبالسيرفرToolStripMenuItem;
    }
}