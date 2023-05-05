using System.Drawing;

namespace L1_OOP
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbX = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.btDeleteEllipses = new System.Windows.Forms.Button();
            this.pnlDrawing = new System.Windows.Forms.Panel();
            this.pbTimer = new System.Windows.Forms.ProgressBar();
            this.tmPbTimer = new System.Windows.Forms.Timer(this.components);
            this.rbPbOn = new System.Windows.Forms.RadioButton();
            this.rbPbOff = new System.Windows.Forms.RadioButton();
            this.gbProgressBar = new System.Windows.Forms.GroupBox();
            this.nudPbSpeed = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbMenuChoice = new System.Windows.Forms.TextBox();
            this.picbImage1 = new System.Windows.Forms.PictureBox();
            this.picbImage2 = new System.Windows.Forms.PictureBox();
            this.picbImage3 = new System.Windows.Forms.PictureBox();
            this.picbImage4 = new System.Windows.Forms.PictureBox();
            this.gbImage = new System.Windows.Forms.GroupBox();
            this.chbImage4 = new System.Windows.Forms.CheckBox();
            this.chbImage3 = new System.Windows.Forms.CheckBox();
            this.chbImage2 = new System.Windows.Forms.CheckBox();
            this.chbImage1 = new System.Windows.Forms.CheckBox();
            this.mtbPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.mtbName = new System.Windows.Forms.MaskedTextBox();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.gbMaskedTextBox = new System.Windows.Forms.GroupBox();
            this.datetpDate = new System.Windows.Forms.DateTimePicker();
            this.lbDateDay = new System.Windows.Forms.Label();
            this.lbDateMonth = new System.Windows.Forms.Label();
            this.lbDateYear = new System.Windows.Forms.Label();
            this.gbDate = new System.Windows.Forms.GroupBox();
            this.btnAutosize = new System.Windows.Forms.Button();
            this.gbElipses = new System.Windows.Forms.GroupBox();
            this.gbProgressBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPbSpeed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbImage4)).BeginInit();
            this.gbImage.SuspendLayout();
            this.gbMaskedTextBox.SuspendLayout();
            this.gbDate.SuspendLayout();
            this.gbElipses.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(6, 21);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(14, 16);
            this.lbX.TabIndex = 0;
            this.lbX.Text = "0";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(6, 46);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(14, 16);
            this.lbY.TabIndex = 1;
            this.lbY.Text = "0";
            // 
            // btDeleteEllipses
            // 
            this.btDeleteEllipses.Location = new System.Drawing.Point(109, 284);
            this.btDeleteEllipses.Name = "btDeleteEllipses";
            this.btDeleteEllipses.Size = new System.Drawing.Size(100, 45);
            this.btDeleteEllipses.TabIndex = 2;
            this.btDeleteEllipses.Text = "Delete elipses";
            this.btDeleteEllipses.UseVisualStyleBackColor = true;
            this.btDeleteEllipses.Click += new System.EventHandler(this.btnDeleteEllipses_Click);
            // 
            // pnlDrawing
            // 
            this.pnlDrawing.Location = new System.Drawing.Point(7, 28);
            this.pnlDrawing.Name = "pnlDrawing";
            this.pnlDrawing.Size = new System.Drawing.Size(300, 250);
            this.pnlDrawing.TabIndex = 3;
            this.pnlDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrawing_Paint);
            this.pnlDrawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDrawing_MouseDown);
            this.pnlDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDrawing_MouseMove);
            this.pnlDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDrawing_MouseUp);
            // 
            // pbTimer
            // 
            this.pbTimer.Enabled = false;
            this.pbTimer.Location = new System.Drawing.Point(76, 51);
            this.pbTimer.MarqueeAnimationSpeed = 10;
            this.pbTimer.Name = "pbTimer";
            this.pbTimer.Size = new System.Drawing.Size(257, 43);
            this.pbTimer.Step = 1;
            this.pbTimer.TabIndex = 4;
            // 
            // tmPbTimer
            // 
            this.tmPbTimer.Tick += new System.EventHandler(this.tmPbTimer_Tick);
            // 
            // rbPbOn
            // 
            this.rbPbOn.AutoSize = true;
            this.rbPbOn.Location = new System.Drawing.Point(13, 51);
            this.rbPbOn.Name = "rbPbOn";
            this.rbPbOn.Size = new System.Drawing.Size(45, 20);
            this.rbPbOn.TabIndex = 9;
            this.rbPbOn.Text = "On";
            this.rbPbOn.UseVisualStyleBackColor = true;
            this.rbPbOn.CheckedChanged += new System.EventHandler(this.rbPbOn_Off_CheckedChanged);
            // 
            // rbPbOff
            // 
            this.rbPbOff.AutoSize = true;
            this.rbPbOff.Location = new System.Drawing.Point(13, 86);
            this.rbPbOff.Name = "rbPbOff";
            this.rbPbOff.Size = new System.Drawing.Size(44, 20);
            this.rbPbOff.TabIndex = 10;
            this.rbPbOff.Text = "Off";
            this.rbPbOff.UseVisualStyleBackColor = true;
            this.rbPbOff.CheckedChanged += new System.EventHandler(this.rbPbOn_Off_CheckedChanged);
            // 
            // gbProgressBar
            // 
            this.gbProgressBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.gbProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.gbProgressBar.Controls.Add(this.nudPbSpeed);
            this.gbProgressBar.Controls.Add(this.rbPbOff);
            this.gbProgressBar.Controls.Add(this.rbPbOn);
            this.gbProgressBar.Controls.Add(this.pbTimer);
            this.gbProgressBar.Location = new System.Drawing.Point(265, 511);
            this.gbProgressBar.Name = "gbProgressBar";
            this.gbProgressBar.Size = new System.Drawing.Size(348, 160);
            this.gbProgressBar.TabIndex = 14;
            this.gbProgressBar.TabStop = false;
            this.gbProgressBar.Text = "ProgressBar";
            // 
            // nudPbSpeed
            // 
            this.nudPbSpeed.Location = new System.Drawing.Point(147, 117);
            this.nudPbSpeed.Name = "nudPbSpeed";
            this.nudPbSpeed.Size = new System.Drawing.Size(76, 22);
            this.nudPbSpeed.TabIndex = 34;
            this.nudPbSpeed.ValueChanged += new System.EventHandler(this.nudPbSpeed_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbY);
            this.groupBox1.Controls.Add(this.lbX);
            this.groupBox1.Location = new System.Drawing.Point(12, 511);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(70, 70);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coords";
            // 
            // msMenu
            // 
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1006, 28);
            this.msMenu.TabIndex = 22;
            this.msMenu.Text = "msMenu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem6,
            this.toolStripMenuItem10});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem3.Text = "11";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem4.Text = "12";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem5.Text = "13";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem6.Text = "2";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem7.Text = "21";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem8.Text = "22";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem9.Text = "23";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13});
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem10.Text = "3";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem11.Text = "31";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem12.Text = "32";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem13.Text = "33";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // tbMenuChoice
            // 
            this.tbMenuChoice.Location = new System.Drawing.Point(78, 6);
            this.tbMenuChoice.Name = "tbMenuChoice";
            this.tbMenuChoice.Size = new System.Drawing.Size(223, 22);
            this.tbMenuChoice.TabIndex = 23;
            // 
            // picbImage1
            // 
            this.picbImage1.BackColor = System.Drawing.Color.OrangeRed;
            this.picbImage1.Location = new System.Drawing.Point(17, 22);
            this.picbImage1.Name = "picbImage1";
            this.picbImage1.Size = new System.Drawing.Size(100, 100);
            this.picbImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbImage1.TabIndex = 24;
            this.picbImage1.TabStop = false;
            // 
            // picbImage2
            // 
            this.picbImage2.BackColor = System.Drawing.Color.Chartreuse;
            this.picbImage2.Location = new System.Drawing.Point(123, 22);
            this.picbImage2.Name = "picbImage2";
            this.picbImage2.Size = new System.Drawing.Size(100, 100);
            this.picbImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbImage2.TabIndex = 25;
            this.picbImage2.TabStop = false;
            // 
            // picbImage3
            // 
            this.picbImage3.BackColor = System.Drawing.Color.DodgerBlue;
            this.picbImage3.Location = new System.Drawing.Point(18, 128);
            this.picbImage3.Name = "picbImage3";
            this.picbImage3.Size = new System.Drawing.Size(100, 100);
            this.picbImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbImage3.TabIndex = 26;
            this.picbImage3.TabStop = false;
            // 
            // picbImage4
            // 
            this.picbImage4.BackColor = System.Drawing.Color.Gold;
            this.picbImage4.Location = new System.Drawing.Point(123, 128);
            this.picbImage4.Name = "picbImage4";
            this.picbImage4.Size = new System.Drawing.Size(100, 100);
            this.picbImage4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbImage4.TabIndex = 27;
            this.picbImage4.TabStop = false;
            // 
            // gbImage
            // 
            this.gbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbImage.Controls.Add(this.chbImage4);
            this.gbImage.Controls.Add(this.chbImage3);
            this.gbImage.Controls.Add(this.chbImage2);
            this.gbImage.Controls.Add(this.chbImage1);
            this.gbImage.Controls.Add(this.picbImage4);
            this.gbImage.Controls.Add(this.picbImage3);
            this.gbImage.Controls.Add(this.picbImage2);
            this.gbImage.Controls.Add(this.picbImage1);
            this.gbImage.Location = new System.Drawing.Point(265, 197);
            this.gbImage.Name = "gbImage";
            this.gbImage.Size = new System.Drawing.Size(348, 247);
            this.gbImage.TabIndex = 28;
            this.gbImage.TabStop = false;
            this.gbImage.Text = "Image";
            // 
            // chbImage4
            // 
            this.chbImage4.AutoSize = true;
            this.chbImage4.Checked = true;
            this.chbImage4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbImage4.Location = new System.Drawing.Point(255, 154);
            this.chbImage4.Name = "chbImage4";
            this.chbImage4.Size = new System.Drawing.Size(56, 20);
            this.chbImage4.TabIndex = 31;
            this.chbImage4.Text = "Blue";
            this.chbImage4.UseVisualStyleBackColor = true;
            this.chbImage4.CheckedChanged += new System.EventHandler(this.chbImage_CheckedChanged);
            // 
            // chbImage3
            // 
            this.chbImage3.AutoSize = true;
            this.chbImage3.Checked = true;
            this.chbImage3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbImage3.Location = new System.Drawing.Point(255, 128);
            this.chbImage3.Name = "chbImage3";
            this.chbImage3.Size = new System.Drawing.Size(69, 20);
            this.chbImage3.TabIndex = 30;
            this.chbImage3.Text = "Yellow";
            this.chbImage3.UseVisualStyleBackColor = true;
            this.chbImage3.CheckedChanged += new System.EventHandler(this.chbImage_CheckedChanged);
            // 
            // chbImage2
            // 
            this.chbImage2.AutoSize = true;
            this.chbImage2.Checked = true;
            this.chbImage2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbImage2.Location = new System.Drawing.Point(255, 102);
            this.chbImage2.Name = "chbImage2";
            this.chbImage2.Size = new System.Drawing.Size(66, 20);
            this.chbImage2.TabIndex = 29;
            this.chbImage2.Text = "Green";
            this.chbImage2.UseVisualStyleBackColor = true;
            this.chbImage2.CheckedChanged += new System.EventHandler(this.chbImage_CheckedChanged);
            // 
            // chbImage1
            // 
            this.chbImage1.AutoSize = true;
            this.chbImage1.Checked = true;
            this.chbImage1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbImage1.Location = new System.Drawing.Point(255, 76);
            this.chbImage1.Name = "chbImage1";
            this.chbImage1.Size = new System.Drawing.Size(55, 20);
            this.chbImage1.TabIndex = 28;
            this.chbImage1.Text = "Red";
            this.chbImage1.UseVisualStyleBackColor = true;
            this.chbImage1.CheckedChanged += new System.EventHandler(this.chbImage_CheckedChanged);
            // 
            // mtbPhoneNumber
            // 
            this.mtbPhoneNumber.Location = new System.Drawing.Point(120, 24);
            this.mtbPhoneNumber.Mask = "+7 (000) 000-00-00";
            this.mtbPhoneNumber.Name = "mtbPhoneNumber";
            this.mtbPhoneNumber.Size = new System.Drawing.Size(211, 22);
            this.mtbPhoneNumber.TabIndex = 29;
            // 
            // mtbName
            // 
            this.mtbName.Location = new System.Drawing.Point(120, 64);
            this.mtbName.Mask = "L.L.LLLLLLLLLLLLLLLLLLLLLLLLLLLl";
            this.mtbName.Name = "mtbName";
            this.mtbName.Size = new System.Drawing.Size(211, 22);
            this.mtbName.TabIndex = 30;
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(10, 24);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(94, 16);
            this.lbPhoneNumber.TabIndex = 31;
            this.lbPhoneNumber.Text = "Phone number";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(10, 64);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 16);
            this.lbName.TabIndex = 32;
            this.lbName.Text = "Name";
            // 
            // gbMaskedTextBox
            // 
            this.gbMaskedTextBox.Controls.Add(this.lbName);
            this.gbMaskedTextBox.Controls.Add(this.lbPhoneNumber);
            this.gbMaskedTextBox.Controls.Add(this.mtbName);
            this.gbMaskedTextBox.Controls.Add(this.mtbPhoneNumber);
            this.gbMaskedTextBox.Location = new System.Drawing.Point(646, 197);
            this.gbMaskedTextBox.Name = "gbMaskedTextBox";
            this.gbMaskedTextBox.Size = new System.Drawing.Size(348, 103);
            this.gbMaskedTextBox.TabIndex = 33;
            this.gbMaskedTextBox.TabStop = false;
            this.gbMaskedTextBox.Text = "MaskedTextBox";
            // 
            // datetpDate
            // 
            this.datetpDate.Location = new System.Drawing.Point(9, 21);
            this.datetpDate.Name = "datetpDate";
            this.datetpDate.Size = new System.Drawing.Size(204, 22);
            this.datetpDate.TabIndex = 34;
            this.datetpDate.ValueChanged += new System.EventHandler(this.datetpDate_ValueChanged);
            // 
            // lbDateDay
            // 
            this.lbDateDay.AutoSize = true;
            this.lbDateDay.Location = new System.Drawing.Point(9, 60);
            this.lbDateDay.Name = "lbDateDay";
            this.lbDateDay.Size = new System.Drawing.Size(32, 16);
            this.lbDateDay.TabIndex = 35;
            this.lbDateDay.Text = "Day";
            // 
            // lbDateMonth
            // 
            this.lbDateMonth.AutoSize = true;
            this.lbDateMonth.Location = new System.Drawing.Point(9, 86);
            this.lbDateMonth.Name = "lbDateMonth";
            this.lbDateMonth.Size = new System.Drawing.Size(43, 16);
            this.lbDateMonth.TabIndex = 36;
            this.lbDateMonth.Text = "Month";
            // 
            // lbDateYear
            // 
            this.lbDateYear.AutoSize = true;
            this.lbDateYear.Location = new System.Drawing.Point(9, 112);
            this.lbDateYear.Name = "lbDateYear";
            this.lbDateYear.Size = new System.Drawing.Size(36, 16);
            this.lbDateYear.TabIndex = 37;
            this.lbDateYear.Text = "Year";
            // 
            // gbDate
            // 
            this.gbDate.Controls.Add(this.lbDateYear);
            this.gbDate.Controls.Add(this.lbDateMonth);
            this.gbDate.Controls.Add(this.lbDateDay);
            this.gbDate.Controls.Add(this.datetpDate);
            this.gbDate.Location = new System.Drawing.Point(12, 301);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(224, 143);
            this.gbDate.TabIndex = 38;
            this.gbDate.TabStop = false;
            this.gbDate.Text = "Date";
            // 
            // btnAutosize
            // 
            this.btnAutosize.Location = new System.Drawing.Point(646, 82);
            this.btnAutosize.Name = "btnAutosize";
            this.btnAutosize.Size = new System.Drawing.Size(170, 58);
            this.btnAutosize.TabIndex = 39;
            this.btnAutosize.Text = "Autosize button";
            this.btnAutosize.UseVisualStyleBackColor = true;
            // 
            // gbElipses
            // 
            this.gbElipses.Controls.Add(this.pnlDrawing);
            this.gbElipses.Controls.Add(this.btDeleteEllipses);
            this.gbElipses.Location = new System.Drawing.Point(646, 360);
            this.gbElipses.Name = "gbElipses";
            this.gbElipses.Size = new System.Drawing.Size(317, 349);
            this.gbElipses.TabIndex = 41;
            this.gbElipses.TabStop = false;
            this.gbElipses.Text = "Elipses";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.gbElipses);
            this.Controls.Add(this.btnAutosize);
            this.Controls.Add(this.gbDate);
            this.Controls.Add(this.gbMaskedTextBox);
            this.Controls.Add(this.gbImage);
            this.Controls.Add(this.tbMenuChoice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbProgressBar);
            this.Controls.Add(this.msMenu);
            this.Name = "mainForm";
            this.Text = "Form";
            this.SizeChanged += new System.EventHandler(this.mainForm_SizeChanged);
            this.Click += new System.EventHandler(this.Form_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.gbProgressBar.ResumeLayout(false);
            this.gbProgressBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPbSpeed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbImage4)).EndInit();
            this.gbImage.ResumeLayout(false);
            this.gbImage.PerformLayout();
            this.gbMaskedTextBox.ResumeLayout(false);
            this.gbMaskedTextBox.PerformLayout();
            this.gbDate.ResumeLayout(false);
            this.gbDate.PerformLayout();
            this.gbElipses.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Button btDeleteEllipses;
        private System.Windows.Forms.Panel pnlDrawing;
        private System.Windows.Forms.ProgressBar pbTimer;
        private System.Windows.Forms.Timer tmPbTimer;
        private System.Windows.Forms.RadioButton rbPbOn;
        private System.Windows.Forms.RadioButton rbPbOff;
        private System.Windows.Forms.GroupBox gbProgressBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.TextBox tbMenuChoice;
        private System.Windows.Forms.PictureBox picbImage1;
        private System.Windows.Forms.PictureBox picbImage2;
        private System.Windows.Forms.PictureBox picbImage3;
        private System.Windows.Forms.PictureBox picbImage4;
        private System.Windows.Forms.GroupBox gbImage;
        private System.Windows.Forms.CheckBox chbImage4;
        private System.Windows.Forms.CheckBox chbImage3;
        private System.Windows.Forms.CheckBox chbImage2;
        private System.Windows.Forms.CheckBox chbImage1;
        private System.Windows.Forms.MaskedTextBox mtbPhoneNumber;
        private System.Windows.Forms.MaskedTextBox mtbName;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.GroupBox gbMaskedTextBox;
        private System.Windows.Forms.NumericUpDown nudPbSpeed;
        private System.Windows.Forms.DateTimePicker datetpDate;
        private System.Windows.Forms.Label lbDateDay;
        private System.Windows.Forms.Label lbDateMonth;
        private System.Windows.Forms.Label lbDateYear;
        private System.Windows.Forms.GroupBox gbDate;
        private System.Windows.Forms.Button btnAutosize;
        private System.Windows.Forms.GroupBox gbElipses;
    }
}

