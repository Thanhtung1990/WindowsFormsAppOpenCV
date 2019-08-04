namespace WindowsFormsAppOpenCV
{
    partial class Form_ImageProcessing
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
            this.Btn_Image_Sepia = new System.Windows.Forms.Button();
            this.Btn_Image_EdgeDetect = new System.Windows.Forms.Button();
            this.Btn_Image_GaussianBlur = new System.Windows.Forms.Button();
            this.Btn_Image_Dilation = new System.Windows.Forms.Button();
            this.Btn_Image_Erosion = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.firebaseStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Login = new System.Windows.Forms.ToolStripMenuItem();
            this.TxB_File_Source = new System.Windows.Forms.TextBox();
            this.picBox_source_image = new System.Windows.Forms.PictureBox();
            this.picBox_des_image = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Image_Threshold = new System.Windows.Forms.Button();
            this.lbl_acc = new System.Windows.Forms.Label();
            this.lbl_display_acc = new System.Windows.Forms.Label();
            this.lbl_display_value9 = new System.Windows.Forms.Label();
            this.lbl_display_value8 = new System.Windows.Forms.Label();
            this.lbl_display_value7 = new System.Windows.Forms.Label();
            this.lbl_display_value6 = new System.Windows.Forms.Label();
            this.lbl_display_value5 = new System.Windows.Forms.Label();
            this.lbl_display_value4 = new System.Windows.Forms.Label();
            this.lbl_display_value3 = new System.Windows.Forms.Label();
            this.lbl_display_value1 = new System.Windows.Forms.Label();
            this.lbl_display_value2 = new System.Windows.Forms.Label();
            this.lbl_value_9 = new System.Windows.Forms.Label();
            this.lbl_value_8 = new System.Windows.Forms.Label();
            this.lbl_value_7 = new System.Windows.Forms.Label();
            this.lbl_value_6 = new System.Windows.Forms.Label();
            this.lbl_value_5 = new System.Windows.Forms.Label();
            this.lbl_value_4 = new System.Windows.Forms.Label();
            this.lbl_value_3 = new System.Windows.Forms.Label();
            this.lbl_value_2 = new System.Windows.Forms.Label();
            this.lbl_value_1 = new System.Windows.Forms.Label();
            this.trb_value9 = new System.Windows.Forms.TrackBar();
            this.trb_value8 = new System.Windows.Forms.TrackBar();
            this.trb_value7 = new System.Windows.Forms.TrackBar();
            this.trb_value6 = new System.Windows.Forms.TrackBar();
            this.trb_value5 = new System.Windows.Forms.TrackBar();
            this.trb_value4 = new System.Windows.Forms.TrackBar();
            this.trb_value3 = new System.Windows.Forms.TrackBar();
            this.trb_value2 = new System.Windows.Forms.TrackBar();
            this.trb_value1 = new System.Windows.Forms.TrackBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_edge_display2 = new System.Windows.Forms.Label();
            this.lbl_edge_display1 = new System.Windows.Forms.Label();
            this.trb_edge_value2 = new System.Windows.Forms.TrackBar();
            this.trb_edge_value1 = new System.Windows.Forms.TrackBar();
            this.lbl_egde_value2 = new System.Windows.Forms.Label();
            this.lbl_egde_value1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grBx_boxFiltering = new System.Windows.Forms.GroupBox();
            this.Btn_Image_BoxFilter = new System.Windows.Forms.Button();
            this.trb_boxF_value_edit2 = new System.Windows.Forms.TrackBar();
            this.trb_boxF_value_edit1 = new System.Windows.Forms.TrackBar();
            this.lbl_boxF_value_display1 = new System.Windows.Forms.Label();
            this.lbl_boxF_value_display2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grBx_blur = new System.Windows.Forms.GroupBox();
            this.Btn_Image_Blur = new System.Windows.Forms.Button();
            this.trb_blur_value_edit = new System.Windows.Forms.TrackBar();
            this.lbl_blur_value_display = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grBx_medianblur = new System.Windows.Forms.GroupBox();
            this.Btn_Image_MedianBlur = new System.Windows.Forms.Button();
            this.trb_medianblur_value_edit = new System.Windows.Forms.TrackBar();
            this.lbl_medianblur_value_display = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grBx_gaussianblur = new System.Windows.Forms.GroupBox();
            this.trb_gaussianblur_value_edit = new System.Windows.Forms.TrackBar();
            this.lbl_gaussianblur_value_display = new System.Windows.Forms.Label();
            this.lbl_blur_value = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.lbl_threshold_value1 = new System.Windows.Forms.Label();
            this.trb_threshold_edit1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.trb_dilation_value_edit = new System.Windows.Forms.TrackBar();
            this.lbl_dilation_value_display = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lbl_erosion_value_display = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.trb_erosion_value_edit = new System.Windows.Forms.TrackBar();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.Btn_Image_BilateralFilter = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trb_bitlateral_value_edit = new System.Windows.Forms.TrackBar();
            this.lbl_bilateralF_value_display = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_source_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_des_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_value9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_value8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_value7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_value6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_value5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_value4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_value3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_value2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_value1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_edge_value2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_edge_value1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.grBx_boxFiltering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_boxF_value_edit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_boxF_value_edit1)).BeginInit();
            this.grBx_blur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_blur_value_edit)).BeginInit();
            this.grBx_medianblur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_medianblur_value_edit)).BeginInit();
            this.grBx_gaussianblur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_gaussianblur_value_edit)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_threshold_edit1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_dilation_value_edit)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_erosion_value_edit)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_bitlateral_value_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Image_Sepia
            // 
            this.Btn_Image_Sepia.Location = new System.Drawing.Point(264, 21);
            this.Btn_Image_Sepia.Name = "Btn_Image_Sepia";
            this.Btn_Image_Sepia.Size = new System.Drawing.Size(67, 23);
            this.Btn_Image_Sepia.TabIndex = 0;
            this.Btn_Image_Sepia.Text = "Sepia";
            this.Btn_Image_Sepia.UseVisualStyleBackColor = true;
            this.Btn_Image_Sepia.Click += new System.EventHandler(this.Btn_Image_Sepia_Click);
            // 
            // Btn_Image_EdgeDetect
            // 
            this.Btn_Image_EdgeDetect.Location = new System.Drawing.Point(83, 138);
            this.Btn_Image_EdgeDetect.Name = "Btn_Image_EdgeDetect";
            this.Btn_Image_EdgeDetect.Size = new System.Drawing.Size(109, 23);
            this.Btn_Image_EdgeDetect.TabIndex = 1;
            this.Btn_Image_EdgeDetect.Text = "Edge Detection";
            this.Btn_Image_EdgeDetect.UseVisualStyleBackColor = true;
            this.Btn_Image_EdgeDetect.Click += new System.EventHandler(this.Btn_Image_EdgeDetect_Click);
            // 
            // Btn_Image_GaussianBlur
            // 
            this.Btn_Image_GaussianBlur.Location = new System.Drawing.Point(52, 75);
            this.Btn_Image_GaussianBlur.Name = "Btn_Image_GaussianBlur";
            this.Btn_Image_GaussianBlur.Size = new System.Drawing.Size(109, 23);
            this.Btn_Image_GaussianBlur.TabIndex = 2;
            this.Btn_Image_GaussianBlur.Text = "Gaussian Blur";
            this.Btn_Image_GaussianBlur.UseVisualStyleBackColor = true;
            this.Btn_Image_GaussianBlur.Click += new System.EventHandler(this.Btn_Image_GaussianBlur_Click);
            // 
            // Btn_Image_Dilation
            // 
            this.Btn_Image_Dilation.Location = new System.Drawing.Point(102, 64);
            this.Btn_Image_Dilation.Name = "Btn_Image_Dilation";
            this.Btn_Image_Dilation.Size = new System.Drawing.Size(109, 23);
            this.Btn_Image_Dilation.TabIndex = 3;
            this.Btn_Image_Dilation.Text = "Dilation";
            this.Btn_Image_Dilation.UseVisualStyleBackColor = true;
            this.Btn_Image_Dilation.Click += new System.EventHandler(this.Btn_Image_Dilation_Click);
            // 
            // Btn_Image_Erosion
            // 
            this.Btn_Image_Erosion.Location = new System.Drawing.Point(116, 66);
            this.Btn_Image_Erosion.Name = "Btn_Image_Erosion";
            this.Btn_Image_Erosion.Size = new System.Drawing.Size(109, 23);
            this.Btn_Image_Erosion.TabIndex = 4;
            this.Btn_Image_Erosion.Text = "Erosion";
            this.Btn_Image_Erosion.UseVisualStyleBackColor = true;
            this.Btn_Image_Erosion.Click += new System.EventHandler(this.Btn_Image_Erosion_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.firebaseStoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1303, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_OpenFile,
            this.Menu_SaveFile});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Menu_OpenFile
            // 
            this.Menu_OpenFile.Name = "Menu_OpenFile";
            this.Menu_OpenFile.Size = new System.Drawing.Size(103, 22);
            this.Menu_OpenFile.Text = "Open";
            this.Menu_OpenFile.Click += new System.EventHandler(this.Menu_OpenFile_Click);
            // 
            // Menu_SaveFile
            // 
            this.Menu_SaveFile.Name = "Menu_SaveFile";
            this.Menu_SaveFile.Size = new System.Drawing.Size(103, 22);
            this.Menu_SaveFile.Text = "Save";
            this.Menu_SaveFile.Click += new System.EventHandler(this.Menu_SaveFile_Click);
            // 
            // firebaseStoreToolStripMenuItem
            // 
            this.firebaseStoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Login});
            this.firebaseStoreToolStripMenuItem.Name = "firebaseStoreToolStripMenuItem";
            this.firebaseStoreToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.firebaseStoreToolStripMenuItem.Text = "Firebase Store";
            // 
            // Menu_Login
            // 
            this.Menu_Login.Name = "Menu_Login";
            this.Menu_Login.Size = new System.Drawing.Size(107, 22);
            this.Menu_Login.Text = "Log in";
            this.Menu_Login.Click += new System.EventHandler(this.Menu_Login_Click);
            // 
            // TxB_File_Source
            // 
            this.TxB_File_Source.Location = new System.Drawing.Point(118, 32);
            this.TxB_File_Source.Name = "TxB_File_Source";
            this.TxB_File_Source.Size = new System.Drawing.Size(112, 20);
            this.TxB_File_Source.TabIndex = 6;
            // 
            // picBox_source_image
            // 
            this.picBox_source_image.Location = new System.Drawing.Point(515, 78);
            this.picBox_source_image.Name = "picBox_source_image";
            this.picBox_source_image.Size = new System.Drawing.Size(390, 324);
            this.picBox_source_image.TabIndex = 7;
            this.picBox_source_image.TabStop = false;
            // 
            // picBox_des_image
            // 
            this.picBox_des_image.Location = new System.Drawing.Point(911, 78);
            this.picBox_des_image.Name = "picBox_des_image";
            this.picBox_des_image.Size = new System.Drawing.Size(380, 324);
            this.picBox_des_image.TabIndex = 8;
            this.picBox_des_image.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Original Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(911, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Destination Image";
            // 
            // Btn_Image_Threshold
            // 
            this.Btn_Image_Threshold.Location = new System.Drawing.Point(52, 70);
            this.Btn_Image_Threshold.Name = "Btn_Image_Threshold";
            this.Btn_Image_Threshold.Size = new System.Drawing.Size(109, 23);
            this.Btn_Image_Threshold.TabIndex = 11;
            this.Btn_Image_Threshold.Text = "Threshold";
            this.Btn_Image_Threshold.UseVisualStyleBackColor = true;
            this.Btn_Image_Threshold.Click += new System.EventHandler(this.Btn_Image_Threshold_Click);
            // 
            // lbl_acc
            // 
            this.lbl_acc.AutoSize = true;
            this.lbl_acc.Location = new System.Drawing.Point(12, 35);
            this.lbl_acc.Name = "lbl_acc";
            this.lbl_acc.Size = new System.Drawing.Size(50, 13);
            this.lbl_acc.TabIndex = 12;
            this.lbl_acc.Text = "Account:";
            this.lbl_acc.Click += new System.EventHandler(this.lbl_acc_Click);
            // 
            // lbl_display_acc
            // 
            this.lbl_display_acc.AutoSize = true;
            this.lbl_display_acc.Location = new System.Drawing.Point(68, 35);
            this.lbl_display_acc.Name = "lbl_display_acc";
            this.lbl_display_acc.Size = new System.Drawing.Size(0, 13);
            this.lbl_display_acc.TabIndex = 13;
            // 
            // lbl_display_value9
            // 
            this.lbl_display_value9.AutoSize = true;
            this.lbl_display_value9.Location = new System.Drawing.Point(212, 429);
            this.lbl_display_value9.Name = "lbl_display_value9";
            this.lbl_display_value9.Size = new System.Drawing.Size(35, 13);
            this.lbl_display_value9.TabIndex = 24;
            this.lbl_display_value9.Text = "label3";
            // 
            // lbl_display_value8
            // 
            this.lbl_display_value8.AutoSize = true;
            this.lbl_display_value8.Location = new System.Drawing.Point(212, 378);
            this.lbl_display_value8.Name = "lbl_display_value8";
            this.lbl_display_value8.Size = new System.Drawing.Size(35, 13);
            this.lbl_display_value8.TabIndex = 24;
            this.lbl_display_value8.Text = "label3";
            // 
            // lbl_display_value7
            // 
            this.lbl_display_value7.AutoSize = true;
            this.lbl_display_value7.Location = new System.Drawing.Point(212, 327);
            this.lbl_display_value7.Name = "lbl_display_value7";
            this.lbl_display_value7.Size = new System.Drawing.Size(35, 13);
            this.lbl_display_value7.TabIndex = 24;
            this.lbl_display_value7.Text = "label3";
            // 
            // lbl_display_value6
            // 
            this.lbl_display_value6.AutoSize = true;
            this.lbl_display_value6.Location = new System.Drawing.Point(212, 276);
            this.lbl_display_value6.Name = "lbl_display_value6";
            this.lbl_display_value6.Size = new System.Drawing.Size(35, 13);
            this.lbl_display_value6.TabIndex = 24;
            this.lbl_display_value6.Text = "label3";
            // 
            // lbl_display_value5
            // 
            this.lbl_display_value5.AutoSize = true;
            this.lbl_display_value5.Location = new System.Drawing.Point(212, 227);
            this.lbl_display_value5.Name = "lbl_display_value5";
            this.lbl_display_value5.Size = new System.Drawing.Size(35, 13);
            this.lbl_display_value5.TabIndex = 24;
            this.lbl_display_value5.Text = "label3";
            // 
            // lbl_display_value4
            // 
            this.lbl_display_value4.AutoSize = true;
            this.lbl_display_value4.Location = new System.Drawing.Point(212, 173);
            this.lbl_display_value4.Name = "lbl_display_value4";
            this.lbl_display_value4.Size = new System.Drawing.Size(35, 13);
            this.lbl_display_value4.TabIndex = 24;
            this.lbl_display_value4.Text = "label3";
            // 
            // lbl_display_value3
            // 
            this.lbl_display_value3.AutoSize = true;
            this.lbl_display_value3.Location = new System.Drawing.Point(213, 123);
            this.lbl_display_value3.Name = "lbl_display_value3";
            this.lbl_display_value3.Size = new System.Drawing.Size(35, 13);
            this.lbl_display_value3.TabIndex = 24;
            this.lbl_display_value3.Text = "label3";
            // 
            // lbl_display_value1
            // 
            this.lbl_display_value1.AutoSize = true;
            this.lbl_display_value1.Location = new System.Drawing.Point(212, 23);
            this.lbl_display_value1.Name = "lbl_display_value1";
            this.lbl_display_value1.Size = new System.Drawing.Size(35, 13);
            this.lbl_display_value1.TabIndex = 24;
            this.lbl_display_value1.Text = "label3";
            // 
            // lbl_display_value2
            // 
            this.lbl_display_value2.AutoSize = true;
            this.lbl_display_value2.Location = new System.Drawing.Point(212, 72);
            this.lbl_display_value2.Name = "lbl_display_value2";
            this.lbl_display_value2.Size = new System.Drawing.Size(35, 13);
            this.lbl_display_value2.TabIndex = 24;
            this.lbl_display_value2.Text = "label3";
            // 
            // lbl_value_9
            // 
            this.lbl_value_9.AutoSize = true;
            this.lbl_value_9.Location = new System.Drawing.Point(12, 429);
            this.lbl_value_9.Name = "lbl_value_9";
            this.lbl_value_9.Size = new System.Drawing.Size(43, 13);
            this.lbl_value_9.TabIndex = 22;
            this.lbl_value_9.Text = "Value 9";
            // 
            // lbl_value_8
            // 
            this.lbl_value_8.AutoSize = true;
            this.lbl_value_8.Location = new System.Drawing.Point(12, 378);
            this.lbl_value_8.Name = "lbl_value_8";
            this.lbl_value_8.Size = new System.Drawing.Size(43, 13);
            this.lbl_value_8.TabIndex = 21;
            this.lbl_value_8.Text = "Value 8";
            // 
            // lbl_value_7
            // 
            this.lbl_value_7.AutoSize = true;
            this.lbl_value_7.Location = new System.Drawing.Point(12, 327);
            this.lbl_value_7.Name = "lbl_value_7";
            this.lbl_value_7.Size = new System.Drawing.Size(43, 13);
            this.lbl_value_7.TabIndex = 20;
            this.lbl_value_7.Text = "Value 7";
            // 
            // lbl_value_6
            // 
            this.lbl_value_6.AutoSize = true;
            this.lbl_value_6.Location = new System.Drawing.Point(13, 276);
            this.lbl_value_6.Name = "lbl_value_6";
            this.lbl_value_6.Size = new System.Drawing.Size(43, 13);
            this.lbl_value_6.TabIndex = 19;
            this.lbl_value_6.Text = "Value 6";
            // 
            // lbl_value_5
            // 
            this.lbl_value_5.AutoSize = true;
            this.lbl_value_5.Location = new System.Drawing.Point(12, 227);
            this.lbl_value_5.Name = "lbl_value_5";
            this.lbl_value_5.Size = new System.Drawing.Size(43, 13);
            this.lbl_value_5.TabIndex = 18;
            this.lbl_value_5.Text = "Value 5";
            // 
            // lbl_value_4
            // 
            this.lbl_value_4.AutoSize = true;
            this.lbl_value_4.Location = new System.Drawing.Point(12, 174);
            this.lbl_value_4.Name = "lbl_value_4";
            this.lbl_value_4.Size = new System.Drawing.Size(43, 13);
            this.lbl_value_4.TabIndex = 17;
            this.lbl_value_4.Text = "Value 4";
            // 
            // lbl_value_3
            // 
            this.lbl_value_3.AutoSize = true;
            this.lbl_value_3.Location = new System.Drawing.Point(12, 127);
            this.lbl_value_3.Name = "lbl_value_3";
            this.lbl_value_3.Size = new System.Drawing.Size(43, 13);
            this.lbl_value_3.TabIndex = 16;
            this.lbl_value_3.Text = "Value 3";
            // 
            // lbl_value_2
            // 
            this.lbl_value_2.AutoSize = true;
            this.lbl_value_2.Location = new System.Drawing.Point(12, 76);
            this.lbl_value_2.Name = "lbl_value_2";
            this.lbl_value_2.Size = new System.Drawing.Size(43, 13);
            this.lbl_value_2.TabIndex = 15;
            this.lbl_value_2.Text = "Value 2";
            // 
            // lbl_value_1
            // 
            this.lbl_value_1.AutoSize = true;
            this.lbl_value_1.Location = new System.Drawing.Point(12, 28);
            this.lbl_value_1.Name = "lbl_value_1";
            this.lbl_value_1.Size = new System.Drawing.Size(43, 13);
            this.lbl_value_1.TabIndex = 15;
            this.lbl_value_1.Text = "Value 1";
            // 
            // trb_value9
            // 
            this.trb_value9.Location = new System.Drawing.Point(62, 429);
            this.trb_value9.Maximum = 1000;
            this.trb_value9.Name = "trb_value9";
            this.trb_value9.Size = new System.Drawing.Size(144, 45);
            this.trb_value9.TabIndex = 8;
            // 
            // trb_value8
            // 
            this.trb_value8.Location = new System.Drawing.Point(62, 378);
            this.trb_value8.Maximum = 1000;
            this.trb_value8.Name = "trb_value8";
            this.trb_value8.Size = new System.Drawing.Size(144, 45);
            this.trb_value8.TabIndex = 7;
            // 
            // trb_value7
            // 
            this.trb_value7.Location = new System.Drawing.Point(62, 327);
            this.trb_value7.Maximum = 1000;
            this.trb_value7.Name = "trb_value7";
            this.trb_value7.Size = new System.Drawing.Size(144, 45);
            this.trb_value7.TabIndex = 6;
            // 
            // trb_value6
            // 
            this.trb_value6.Location = new System.Drawing.Point(62, 276);
            this.trb_value6.Maximum = 1000;
            this.trb_value6.Name = "trb_value6";
            this.trb_value6.Size = new System.Drawing.Size(144, 45);
            this.trb_value6.TabIndex = 5;
            // 
            // trb_value5
            // 
            this.trb_value5.Location = new System.Drawing.Point(61, 225);
            this.trb_value5.Maximum = 1000;
            this.trb_value5.Name = "trb_value5";
            this.trb_value5.Size = new System.Drawing.Size(145, 45);
            this.trb_value5.TabIndex = 4;
            // 
            // trb_value4
            // 
            this.trb_value4.Location = new System.Drawing.Point(61, 174);
            this.trb_value4.Maximum = 1000;
            this.trb_value4.Name = "trb_value4";
            this.trb_value4.Size = new System.Drawing.Size(145, 45);
            this.trb_value4.TabIndex = 3;
            // 
            // trb_value3
            // 
            this.trb_value3.Location = new System.Drawing.Point(61, 123);
            this.trb_value3.Maximum = 1000;
            this.trb_value3.Name = "trb_value3";
            this.trb_value3.Size = new System.Drawing.Size(145, 45);
            this.trb_value3.TabIndex = 2;
            // 
            // trb_value2
            // 
            this.trb_value2.Location = new System.Drawing.Point(61, 72);
            this.trb_value2.Maximum = 1000;
            this.trb_value2.Name = "trb_value2";
            this.trb_value2.Size = new System.Drawing.Size(145, 45);
            this.trb_value2.TabIndex = 1;
            // 
            // trb_value1
            // 
            this.trb_value1.Location = new System.Drawing.Point(61, 21);
            this.trb_value1.Maximum = 1000;
            this.trb_value1.Name = "trb_value1";
            this.trb_value1.Size = new System.Drawing.Size(145, 45);
            this.trb_value1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(15, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(494, 566);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_display_value9);
            this.tabPage1.Controls.Add(this.trb_value4);
            this.tabPage1.Controls.Add(this.lbl_display_value8);
            this.tabPage1.Controls.Add(this.trb_value1);
            this.tabPage1.Controls.Add(this.lbl_display_value7);
            this.tabPage1.Controls.Add(this.trb_value2);
            this.tabPage1.Controls.Add(this.lbl_display_value6);
            this.tabPage1.Controls.Add(this.trb_value3);
            this.tabPage1.Controls.Add(this.lbl_display_value5);
            this.tabPage1.Controls.Add(this.trb_value5);
            this.tabPage1.Controls.Add(this.lbl_display_value4);
            this.tabPage1.Controls.Add(this.trb_value6);
            this.tabPage1.Controls.Add(this.lbl_display_value3);
            this.tabPage1.Controls.Add(this.Btn_Image_Sepia);
            this.tabPage1.Controls.Add(this.trb_value7);
            this.tabPage1.Controls.Add(this.lbl_display_value1);
            this.tabPage1.Controls.Add(this.trb_value8);
            this.tabPage1.Controls.Add(this.lbl_display_value2);
            this.tabPage1.Controls.Add(this.trb_value9);
            this.tabPage1.Controls.Add(this.lbl_value_9);
            this.tabPage1.Controls.Add(this.lbl_value_1);
            this.tabPage1.Controls.Add(this.lbl_value_8);
            this.tabPage1.Controls.Add(this.lbl_value_2);
            this.tabPage1.Controls.Add(this.lbl_value_7);
            this.tabPage1.Controls.Add(this.lbl_value_3);
            this.tabPage1.Controls.Add(this.lbl_value_6);
            this.tabPage1.Controls.Add(this.lbl_value_4);
            this.tabPage1.Controls.Add(this.lbl_value_5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(486, 540);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sepia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_edge_display2);
            this.tabPage2.Controls.Add(this.lbl_edge_display1);
            this.tabPage2.Controls.Add(this.trb_edge_value2);
            this.tabPage2.Controls.Add(this.trb_edge_value1);
            this.tabPage2.Controls.Add(this.lbl_egde_value2);
            this.tabPage2.Controls.Add(this.lbl_egde_value1);
            this.tabPage2.Controls.Add(this.Btn_Image_EdgeDetect);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(486, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edge Detection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_edge_display2
            // 
            this.lbl_edge_display2.AutoSize = true;
            this.lbl_edge_display2.Location = new System.Drawing.Point(272, 84);
            this.lbl_edge_display2.Name = "lbl_edge_display2";
            this.lbl_edge_display2.Size = new System.Drawing.Size(35, 13);
            this.lbl_edge_display2.TabIndex = 3;
            this.lbl_edge_display2.Text = "label3";
            // 
            // lbl_edge_display1
            // 
            this.lbl_edge_display1.AutoSize = true;
            this.lbl_edge_display1.Location = new System.Drawing.Point(272, 31);
            this.lbl_edge_display1.Name = "lbl_edge_display1";
            this.lbl_edge_display1.Size = new System.Drawing.Size(35, 13);
            this.lbl_edge_display1.TabIndex = 3;
            this.lbl_edge_display1.Text = "label3";
            // 
            // trb_edge_value2
            // 
            this.trb_edge_value2.Location = new System.Drawing.Point(83, 72);
            this.trb_edge_value2.Maximum = 200;
            this.trb_edge_value2.Name = "trb_edge_value2";
            this.trb_edge_value2.Size = new System.Drawing.Size(183, 45);
            this.trb_edge_value2.TabIndex = 2;
            // 
            // trb_edge_value1
            // 
            this.trb_edge_value1.Location = new System.Drawing.Point(83, 21);
            this.trb_edge_value1.Maximum = 200;
            this.trb_edge_value1.Name = "trb_edge_value1";
            this.trb_edge_value1.Size = new System.Drawing.Size(183, 45);
            this.trb_edge_value1.TabIndex = 1;
            // 
            // lbl_egde_value2
            // 
            this.lbl_egde_value2.AutoSize = true;
            this.lbl_egde_value2.Location = new System.Drawing.Point(23, 84);
            this.lbl_egde_value2.Name = "lbl_egde_value2";
            this.lbl_egde_value2.Size = new System.Drawing.Size(43, 13);
            this.lbl_egde_value2.TabIndex = 0;
            this.lbl_egde_value2.Text = "Value 2";
            // 
            // lbl_egde_value1
            // 
            this.lbl_egde_value1.AutoSize = true;
            this.lbl_egde_value1.Location = new System.Drawing.Point(23, 31);
            this.lbl_egde_value1.Name = "lbl_egde_value1";
            this.lbl_egde_value1.Size = new System.Drawing.Size(43, 13);
            this.lbl_egde_value1.TabIndex = 0;
            this.lbl_egde_value1.Text = "Value 1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grBx_boxFiltering);
            this.tabPage3.Controls.Add(this.grBx_blur);
            this.tabPage3.Controls.Add(this.grBx_medianblur);
            this.tabPage3.Controls.Add(this.grBx_gaussianblur);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(486, 540);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Blur";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grBx_boxFiltering
            // 
            this.grBx_boxFiltering.Controls.Add(this.Btn_Image_BoxFilter);
            this.grBx_boxFiltering.Controls.Add(this.trb_boxF_value_edit2);
            this.grBx_boxFiltering.Controls.Add(this.trb_boxF_value_edit1);
            this.grBx_boxFiltering.Controls.Add(this.lbl_boxF_value_display1);
            this.grBx_boxFiltering.Controls.Add(this.lbl_boxF_value_display2);
            this.grBx_boxFiltering.Controls.Add(this.label8);
            this.grBx_boxFiltering.Controls.Add(this.label6);
            this.grBx_boxFiltering.Location = new System.Drawing.Point(3, 375);
            this.grBx_boxFiltering.Name = "grBx_boxFiltering";
            this.grBx_boxFiltering.Size = new System.Drawing.Size(333, 154);
            this.grBx_boxFiltering.TabIndex = 6;
            this.grBx_boxFiltering.TabStop = false;
            this.grBx_boxFiltering.Text = "Box Filtering";
            // 
            // Btn_Image_BoxFilter
            // 
            this.Btn_Image_BoxFilter.Location = new System.Drawing.Point(52, 121);
            this.Btn_Image_BoxFilter.Name = "Btn_Image_BoxFilter";
            this.Btn_Image_BoxFilter.Size = new System.Drawing.Size(75, 23);
            this.Btn_Image_BoxFilter.TabIndex = 3;
            this.Btn_Image_BoxFilter.Text = "Box Filter";
            this.Btn_Image_BoxFilter.UseVisualStyleBackColor = true;
            this.Btn_Image_BoxFilter.Click += new System.EventHandler(this.Btn_Image_BoxFilter_Click);
            // 
            // trb_boxF_value_edit2
            // 
            this.trb_boxF_value_edit2.LargeChange = 1;
            this.trb_boxF_value_edit2.Location = new System.Drawing.Point(49, 70);
            this.trb_boxF_value_edit2.Maximum = 20;
            this.trb_boxF_value_edit2.Minimum = 1;
            this.trb_boxF_value_edit2.Name = "trb_boxF_value_edit2";
            this.trb_boxF_value_edit2.Size = new System.Drawing.Size(231, 45);
            this.trb_boxF_value_edit2.TabIndex = 2;
            this.trb_boxF_value_edit2.Value = 1;
            // 
            // trb_boxF_value_edit1
            // 
            this.trb_boxF_value_edit1.LargeChange = 1;
            this.trb_boxF_value_edit1.Location = new System.Drawing.Point(49, 19);
            this.trb_boxF_value_edit1.Minimum = 1;
            this.trb_boxF_value_edit1.Name = "trb_boxF_value_edit1";
            this.trb_boxF_value_edit1.Size = new System.Drawing.Size(231, 45);
            this.trb_boxF_value_edit1.TabIndex = 1;
            this.trb_boxF_value_edit1.Value = 1;
            // 
            // lbl_boxF_value_display1
            // 
            this.lbl_boxF_value_display1.AutoSize = true;
            this.lbl_boxF_value_display1.Location = new System.Drawing.Point(284, 29);
            this.lbl_boxF_value_display1.Name = "lbl_boxF_value_display1";
            this.lbl_boxF_value_display1.Size = new System.Drawing.Size(34, 13);
            this.lbl_boxF_value_display1.TabIndex = 0;
            this.lbl_boxF_value_display1.Text = "Value";
            // 
            // lbl_boxF_value_display2
            // 
            this.lbl_boxF_value_display2.AutoSize = true;
            this.lbl_boxF_value_display2.Location = new System.Drawing.Point(284, 85);
            this.lbl_boxF_value_display2.Name = "lbl_boxF_value_display2";
            this.lbl_boxF_value_display2.Size = new System.Drawing.Size(34, 13);
            this.lbl_boxF_value_display2.TabIndex = 0;
            this.lbl_boxF_value_display2.Text = "Value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Value 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Value 1";
            // 
            // grBx_blur
            // 
            this.grBx_blur.Controls.Add(this.Btn_Image_Blur);
            this.grBx_blur.Controls.Add(this.trb_blur_value_edit);
            this.grBx_blur.Controls.Add(this.lbl_blur_value_display);
            this.grBx_blur.Controls.Add(this.label5);
            this.grBx_blur.Location = new System.Drawing.Point(3, 259);
            this.grBx_blur.Name = "grBx_blur";
            this.grBx_blur.Size = new System.Drawing.Size(333, 106);
            this.grBx_blur.TabIndex = 5;
            this.grBx_blur.TabStop = false;
            this.grBx_blur.Text = "Blur";
            // 
            // Btn_Image_Blur
            // 
            this.Btn_Image_Blur.Location = new System.Drawing.Point(52, 71);
            this.Btn_Image_Blur.Name = "Btn_Image_Blur";
            this.Btn_Image_Blur.Size = new System.Drawing.Size(75, 23);
            this.Btn_Image_Blur.TabIndex = 2;
            this.Btn_Image_Blur.Text = "Blur";
            this.Btn_Image_Blur.UseVisualStyleBackColor = true;
            this.Btn_Image_Blur.Click += new System.EventHandler(this.Btn_Image_Blur_Click);
            // 
            // trb_blur_value_edit
            // 
            this.trb_blur_value_edit.LargeChange = 1;
            this.trb_blur_value_edit.Location = new System.Drawing.Point(49, 19);
            this.trb_blur_value_edit.Maximum = 20;
            this.trb_blur_value_edit.Minimum = 1;
            this.trb_blur_value_edit.Name = "trb_blur_value_edit";
            this.trb_blur_value_edit.Size = new System.Drawing.Size(231, 45);
            this.trb_blur_value_edit.TabIndex = 1;
            this.trb_blur_value_edit.Value = 1;
            // 
            // lbl_blur_value_display
            // 
            this.lbl_blur_value_display.AutoSize = true;
            this.lbl_blur_value_display.Location = new System.Drawing.Point(286, 34);
            this.lbl_blur_value_display.Name = "lbl_blur_value_display";
            this.lbl_blur_value_display.Size = new System.Drawing.Size(34, 13);
            this.lbl_blur_value_display.TabIndex = 0;
            this.lbl_blur_value_display.Text = "Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Value";
            // 
            // grBx_medianblur
            // 
            this.grBx_medianblur.Controls.Add(this.Btn_Image_MedianBlur);
            this.grBx_medianblur.Controls.Add(this.trb_medianblur_value_edit);
            this.grBx_medianblur.Controls.Add(this.lbl_medianblur_value_display);
            this.grBx_medianblur.Controls.Add(this.label4);
            this.grBx_medianblur.Location = new System.Drawing.Point(3, 136);
            this.grBx_medianblur.Name = "grBx_medianblur";
            this.grBx_medianblur.Size = new System.Drawing.Size(333, 112);
            this.grBx_medianblur.TabIndex = 4;
            this.grBx_medianblur.TabStop = false;
            this.grBx_medianblur.Text = "Median Blur";
            // 
            // Btn_Image_MedianBlur
            // 
            this.Btn_Image_MedianBlur.Location = new System.Drawing.Point(52, 73);
            this.Btn_Image_MedianBlur.Name = "Btn_Image_MedianBlur";
            this.Btn_Image_MedianBlur.Size = new System.Drawing.Size(75, 23);
            this.Btn_Image_MedianBlur.TabIndex = 2;
            this.Btn_Image_MedianBlur.Text = "Median Blur";
            this.Btn_Image_MedianBlur.UseVisualStyleBackColor = true;
            this.Btn_Image_MedianBlur.Click += new System.EventHandler(this.Btn_Image_MedianBlur_Click);
            // 
            // trb_medianblur_value_edit
            // 
            this.trb_medianblur_value_edit.LargeChange = 2;
            this.trb_medianblur_value_edit.Location = new System.Drawing.Point(52, 19);
            this.trb_medianblur_value_edit.Maximum = 99;
            this.trb_medianblur_value_edit.Minimum = 1;
            this.trb_medianblur_value_edit.Name = "trb_medianblur_value_edit";
            this.trb_medianblur_value_edit.Size = new System.Drawing.Size(228, 45);
            this.trb_medianblur_value_edit.TabIndex = 1;
            this.trb_medianblur_value_edit.Value = 1;
            // 
            // lbl_medianblur_value_display
            // 
            this.lbl_medianblur_value_display.AutoSize = true;
            this.lbl_medianblur_value_display.Location = new System.Drawing.Point(286, 33);
            this.lbl_medianblur_value_display.Name = "lbl_medianblur_value_display";
            this.lbl_medianblur_value_display.Size = new System.Drawing.Size(34, 13);
            this.lbl_medianblur_value_display.TabIndex = 0;
            this.lbl_medianblur_value_display.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Value";
            // 
            // grBx_gaussianblur
            // 
            this.grBx_gaussianblur.Controls.Add(this.trb_gaussianblur_value_edit);
            this.grBx_gaussianblur.Controls.Add(this.Btn_Image_GaussianBlur);
            this.grBx_gaussianblur.Controls.Add(this.lbl_gaussianblur_value_display);
            this.grBx_gaussianblur.Controls.Add(this.lbl_blur_value);
            this.grBx_gaussianblur.Location = new System.Drawing.Point(3, 12);
            this.grBx_gaussianblur.Name = "grBx_gaussianblur";
            this.grBx_gaussianblur.Size = new System.Drawing.Size(333, 115);
            this.grBx_gaussianblur.TabIndex = 3;
            this.grBx_gaussianblur.TabStop = false;
            this.grBx_gaussianblur.Text = "Gaussian Blur";
            // 
            // trb_gaussianblur_value_edit
            // 
            this.trb_gaussianblur_value_edit.LargeChange = 1;
            this.trb_gaussianblur_value_edit.Location = new System.Drawing.Point(52, 24);
            this.trb_gaussianblur_value_edit.Maximum = 20;
            this.trb_gaussianblur_value_edit.Minimum = 1;
            this.trb_gaussianblur_value_edit.Name = "trb_gaussianblur_value_edit";
            this.trb_gaussianblur_value_edit.Size = new System.Drawing.Size(228, 45);
            this.trb_gaussianblur_value_edit.TabIndex = 1;
            this.trb_gaussianblur_value_edit.Value = 1;
            // 
            // lbl_gaussianblur_value_display
            // 
            this.lbl_gaussianblur_value_display.AutoSize = true;
            this.lbl_gaussianblur_value_display.Location = new System.Drawing.Point(286, 34);
            this.lbl_gaussianblur_value_display.Name = "lbl_gaussianblur_value_display";
            this.lbl_gaussianblur_value_display.Size = new System.Drawing.Size(34, 13);
            this.lbl_gaussianblur_value_display.TabIndex = 0;
            this.lbl_gaussianblur_value_display.Text = "Value";
            // 
            // lbl_blur_value
            // 
            this.lbl_blur_value.AutoSize = true;
            this.lbl_blur_value.Location = new System.Drawing.Point(12, 34);
            this.lbl_blur_value.Name = "lbl_blur_value";
            this.lbl_blur_value.Size = new System.Drawing.Size(34, 13);
            this.lbl_blur_value.TabIndex = 0;
            this.lbl_blur_value.Text = "Value";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.lbl_threshold_value1);
            this.tabPage6.Controls.Add(this.trb_threshold_edit1);
            this.tabPage6.Controls.Add(this.label3);
            this.tabPage6.Controls.Add(this.Btn_Image_Threshold);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(486, 540);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Threshold";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // lbl_threshold_value1
            // 
            this.lbl_threshold_value1.AutoSize = true;
            this.lbl_threshold_value1.Location = new System.Drawing.Point(302, 21);
            this.lbl_threshold_value1.Name = "lbl_threshold_value1";
            this.lbl_threshold_value1.Size = new System.Drawing.Size(29, 13);
            this.lbl_threshold_value1.TabIndex = 3;
            this.lbl_threshold_value1.Text = "label";
            // 
            // trb_threshold_edit1
            // 
            this.trb_threshold_edit1.Location = new System.Drawing.Point(52, 9);
            this.trb_threshold_edit1.Maximum = 255;
            this.trb_threshold_edit1.Name = "trb_threshold_edit1";
            this.trb_threshold_edit1.Size = new System.Drawing.Size(244, 45);
            this.trb_threshold_edit1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Value 1";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.trb_dilation_value_edit);
            this.tabPage5.Controls.Add(this.lbl_dilation_value_display);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.Btn_Image_Dilation);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(486, 540);
            this.tabPage5.TabIndex = 7;
            this.tabPage5.Text = "Dilation";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // trb_dilation_value_edit
            // 
            this.trb_dilation_value_edit.LargeChange = 1;
            this.trb_dilation_value_edit.Location = new System.Drawing.Point(48, 13);
            this.trb_dilation_value_edit.Maximum = 30;
            this.trb_dilation_value_edit.Minimum = 1;
            this.trb_dilation_value_edit.Name = "trb_dilation_value_edit";
            this.trb_dilation_value_edit.Size = new System.Drawing.Size(244, 45);
            this.trb_dilation_value_edit.TabIndex = 5;
            this.trb_dilation_value_edit.Value = 1;
            // 
            // lbl_dilation_value_display
            // 
            this.lbl_dilation_value_display.AutoSize = true;
            this.lbl_dilation_value_display.Location = new System.Drawing.Point(302, 27);
            this.lbl_dilation_value_display.Name = "lbl_dilation_value_display";
            this.lbl_dilation_value_display.Size = new System.Drawing.Size(34, 13);
            this.lbl_dilation_value_display.TabIndex = 4;
            this.lbl_dilation_value_display.Text = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Value";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lbl_erosion_value_display);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.trb_erosion_value_edit);
            this.tabPage4.Controls.Add(this.Btn_Image_Erosion);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(486, 540);
            this.tabPage4.TabIndex = 8;
            this.tabPage4.Text = "Erosion";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lbl_erosion_value_display
            // 
            this.lbl_erosion_value_display.AutoSize = true;
            this.lbl_erosion_value_display.Location = new System.Drawing.Point(301, 27);
            this.lbl_erosion_value_display.Name = "lbl_erosion_value_display";
            this.lbl_erosion_value_display.Size = new System.Drawing.Size(34, 13);
            this.lbl_erosion_value_display.TabIndex = 6;
            this.lbl_erosion_value_display.Text = "Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Value";
            // 
            // trb_erosion_value_edit
            // 
            this.trb_erosion_value_edit.LargeChange = 1;
            this.trb_erosion_value_edit.Location = new System.Drawing.Point(48, 15);
            this.trb_erosion_value_edit.Maximum = 30;
            this.trb_erosion_value_edit.Minimum = 1;
            this.trb_erosion_value_edit.Name = "trb_erosion_value_edit";
            this.trb_erosion_value_edit.Size = new System.Drawing.Size(247, 45);
            this.trb_erosion_value_edit.TabIndex = 5;
            this.trb_erosion_value_edit.Value = 1;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.Btn_Image_BilateralFilter);
            this.tabPage7.Controls.Add(this.textBox2);
            this.tabPage7.Controls.Add(this.textBox1);
            this.tabPage7.Controls.Add(this.trb_bitlateral_value_edit);
            this.tabPage7.Controls.Add(this.lbl_bilateralF_value_display);
            this.tabPage7.Controls.Add(this.label10);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(486, 540);
            this.tabPage7.TabIndex = 9;
            this.tabPage7.Text = "Bilateral Filter";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // Btn_Image_BilateralFilter
            // 
            this.Btn_Image_BilateralFilter.Location = new System.Drawing.Point(72, 146);
            this.Btn_Image_BilateralFilter.Name = "Btn_Image_BilateralFilter";
            this.Btn_Image_BilateralFilter.Size = new System.Drawing.Size(100, 23);
            this.Btn_Image_BilateralFilter.TabIndex = 3;
            this.Btn_Image_BilateralFilter.Text = "Bilateral Filter";
            this.Btn_Image_BilateralFilter.UseVisualStyleBackColor = true;
            this.Btn_Image_BilateralFilter.Click += new System.EventHandler(this.Btn_Image_BilateralFilter_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // trb_bitlateral_value_edit
            // 
            this.trb_bitlateral_value_edit.LargeChange = 1;
            this.trb_bitlateral_value_edit.Location = new System.Drawing.Point(72, 17);
            this.trb_bitlateral_value_edit.Maximum = 30;
            this.trb_bitlateral_value_edit.Minimum = 1;
            this.trb_bitlateral_value_edit.Name = "trb_bitlateral_value_edit";
            this.trb_bitlateral_value_edit.Size = new System.Drawing.Size(228, 45);
            this.trb_bitlateral_value_edit.TabIndex = 1;
            this.trb_bitlateral_value_edit.Value = 1;
            // 
            // lbl_bilateralF_value_display
            // 
            this.lbl_bilateralF_value_display.AutoSize = true;
            this.lbl_bilateralF_value_display.Location = new System.Drawing.Point(327, 32);
            this.lbl_bilateralF_value_display.Name = "lbl_bilateralF_value_display";
            this.lbl_bilateralF_value_display.Size = new System.Drawing.Size(34, 13);
            this.lbl_bilateralF_value_display.TabIndex = 0;
            this.lbl_bilateralF_value_display.Text = "Value";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Value";
            // 
            // Form_ImageProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 656);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbl_display_acc);
            this.Controls.Add(this.lbl_acc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_des_image);
            this.Controls.Add(this.picBox_source_image);
            this.Controls.Add(this.TxB_File_Source);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_ImageProcessing";
            this.Text = "Image Processing Window";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_source_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_des_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_value9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_value8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_value7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_value6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_value5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_value4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_value3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_value2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_value1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_edge_value2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_edge_value1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.grBx_boxFiltering.ResumeLayout(false);
            this.grBx_boxFiltering.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_boxF_value_edit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_boxF_value_edit1)).EndInit();
            this.grBx_blur.ResumeLayout(false);
            this.grBx_blur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_blur_value_edit)).EndInit();
            this.grBx_medianblur.ResumeLayout(false);
            this.grBx_medianblur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_medianblur_value_edit)).EndInit();
            this.grBx_gaussianblur.ResumeLayout(false);
            this.grBx_gaussianblur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_gaussianblur_value_edit)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_threshold_edit1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_dilation_value_edit)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_erosion_value_edit)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_bitlateral_value_edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Image_Sepia;
        private System.Windows.Forms.Button Btn_Image_EdgeDetect;
        private System.Windows.Forms.Button Btn_Image_GaussianBlur;
        private System.Windows.Forms.Button Btn_Image_Dilation;
        private System.Windows.Forms.Button Btn_Image_Erosion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_OpenFile;
        private System.Windows.Forms.TextBox TxB_File_Source;
        private System.Windows.Forms.PictureBox picBox_source_image;
        private System.Windows.Forms.PictureBox picBox_des_image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Image_Threshold;
        private System.Windows.Forms.ToolStripMenuItem Menu_SaveFile;
        private System.Windows.Forms.ToolStripMenuItem firebaseStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Login;
        private System.Windows.Forms.Label lbl_acc;
        private System.Windows.Forms.Label lbl_display_acc;
        private System.Windows.Forms.TrackBar trb_value1;
        private System.Windows.Forms.TrackBar trb_value2;
        private System.Windows.Forms.TrackBar trb_value9;
        private System.Windows.Forms.TrackBar trb_value8;
        private System.Windows.Forms.TrackBar trb_value7;
        private System.Windows.Forms.TrackBar trb_value6;
        private System.Windows.Forms.TrackBar trb_value5;
        private System.Windows.Forms.TrackBar trb_value4;
        private System.Windows.Forms.TrackBar trb_value3;
        private System.Windows.Forms.Label lbl_value_9;
        private System.Windows.Forms.Label lbl_value_8;
        private System.Windows.Forms.Label lbl_value_7;
        private System.Windows.Forms.Label lbl_value_6;
        private System.Windows.Forms.Label lbl_value_5;
        private System.Windows.Forms.Label lbl_value_4;
        private System.Windows.Forms.Label lbl_value_3;
        private System.Windows.Forms.Label lbl_value_2;
        private System.Windows.Forms.Label lbl_value_1;
        private System.Windows.Forms.Label lbl_display_value9;
        private System.Windows.Forms.Label lbl_display_value8;
        private System.Windows.Forms.Label lbl_display_value7;
        private System.Windows.Forms.Label lbl_display_value6;
        private System.Windows.Forms.Label lbl_display_value5;
        private System.Windows.Forms.Label lbl_display_value4;
        private System.Windows.Forms.Label lbl_display_value3;
        private System.Windows.Forms.Label lbl_display_value2;
        private System.Windows.Forms.Label lbl_display_value1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label lbl_edge_display2;
        private System.Windows.Forms.Label lbl_edge_display1;
        private System.Windows.Forms.TrackBar trb_edge_value2;
        private System.Windows.Forms.TrackBar trb_edge_value1;
        private System.Windows.Forms.Label lbl_egde_value2;
        private System.Windows.Forms.Label lbl_egde_value1;
        private System.Windows.Forms.TrackBar trb_gaussianblur_value_edit;
        private System.Windows.Forms.Label lbl_gaussianblur_value_display;
        private System.Windows.Forms.Label lbl_blur_value;
        private System.Windows.Forms.Label lbl_threshold_value1;
        private System.Windows.Forms.TrackBar trb_threshold_edit1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox grBx_gaussianblur;
        private System.Windows.Forms.GroupBox grBx_medianblur;
        private System.Windows.Forms.Button Btn_Image_MedianBlur;
        private System.Windows.Forms.TrackBar trb_medianblur_value_edit;
        private System.Windows.Forms.Label lbl_medianblur_value_display;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grBx_blur;
        private System.Windows.Forms.Button Btn_Image_Blur;
        private System.Windows.Forms.TrackBar trb_blur_value_edit;
        private System.Windows.Forms.Label lbl_blur_value_display;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grBx_boxFiltering;
        private System.Windows.Forms.Button Btn_Image_BoxFilter;
        private System.Windows.Forms.TrackBar trb_boxF_value_edit2;
        private System.Windows.Forms.TrackBar trb_boxF_value_edit1;
        private System.Windows.Forms.Label lbl_boxF_value_display1;
        private System.Windows.Forms.Label lbl_boxF_value_display2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trb_dilation_value_edit;
        private System.Windows.Forms.Label lbl_dilation_value_display;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_erosion_value_display;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trb_erosion_value_edit;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TrackBar trb_bitlateral_value_edit;
        private System.Windows.Forms.Label lbl_bilateralF_value_display;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn_Image_BilateralFilter;
    }
}

