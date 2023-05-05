namespace L4._2_OOP
{
    partial class Form1
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
            this.lbABC = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.nudA = new System.Windows.Forms.NumericUpDown();
            this.trbA = new System.Windows.Forms.TrackBar();
            this.gbA = new System.Windows.Forms.GroupBox();
            this.gbB = new System.Windows.Forms.GroupBox();
            this.trbB = new System.Windows.Forms.TrackBar();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.tbB = new System.Windows.Forms.TextBox();
            this.gbC = new System.Windows.Forms.GroupBox();
            this.trbC = new System.Windows.Forms.TrackBar();
            this.nudC = new System.Windows.Forms.NumericUpDown();
            this.tbC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbA)).BeginInit();
            this.gbA.SuspendLayout();
            this.gbB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            this.gbC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).BeginInit();
            this.SuspendLayout();
            // 
            // lbABC
            // 
            this.lbABC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbABC.AutoSize = true;
            this.lbABC.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lbABC.Location = new System.Drawing.Point(150, 100);
            this.lbABC.Name = "lbABC";
            this.lbABC.Size = new System.Drawing.Size(541, 95);
            this.lbABC.TabIndex = 0;
            this.lbABC.Text = " A <= B  <= C";
            // 
            // tbA
            // 
            this.tbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbA.Location = new System.Drawing.Point(10, 10);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(120, 26);
            this.tbA.TabIndex = 1;
            this.tbA.Text = "0";
            this.tbA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // nudA
            // 
            this.nudA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudA.Location = new System.Drawing.Point(10, 56);
            this.nudA.Name = "nudA";
            this.nudA.Size = new System.Drawing.Size(120, 26);
            this.nudA.TabIndex = 3;
            this.nudA.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // trbA
            // 
            this.trbA.Location = new System.Drawing.Point(10, 112);
            this.trbA.Maximum = 100;
            this.trbA.Name = "trbA";
            this.trbA.Size = new System.Drawing.Size(120, 56);
            this.trbA.TabIndex = 5;
            this.trbA.ValueChanged += new System.EventHandler(this.trb_ValueChanged);
            // 
            // gbA
            // 
            this.gbA.Controls.Add(this.trbA);
            this.gbA.Controls.Add(this.nudA);
            this.gbA.Controls.Add(this.tbA);
            this.gbA.Location = new System.Drawing.Point(150, 250);
            this.gbA.Name = "gbA";
            this.gbA.Size = new System.Drawing.Size(140, 180);
            this.gbA.TabIndex = 6;
            this.gbA.TabStop = false;
            // 
            // gbB
            // 
            this.gbB.Controls.Add(this.trbB);
            this.gbB.Controls.Add(this.nudB);
            this.gbB.Controls.Add(this.tbB);
            this.gbB.Location = new System.Drawing.Point(350, 250);
            this.gbB.Name = "gbB";
            this.gbB.Size = new System.Drawing.Size(140, 180);
            this.gbB.TabIndex = 7;
            this.gbB.TabStop = false;
            // 
            // trbB
            // 
            this.trbB.Location = new System.Drawing.Point(10, 112);
            this.trbB.Maximum = 100;
            this.trbB.Name = "trbB";
            this.trbB.Size = new System.Drawing.Size(120, 56);
            this.trbB.TabIndex = 5;
            this.trbB.ValueChanged += new System.EventHandler(this.trb_ValueChanged);
            // 
            // nudB
            // 
            this.nudB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudB.Location = new System.Drawing.Point(10, 56);
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(120, 26);
            this.nudB.TabIndex = 3;
            this.nudB.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // tbB
            // 
            this.tbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbB.Location = new System.Drawing.Point(10, 10);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(120, 26);
            this.tbB.TabIndex = 1;
            this.tbB.Text = "0";
            this.tbB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // gbC
            // 
            this.gbC.Controls.Add(this.trbC);
            this.gbC.Controls.Add(this.nudC);
            this.gbC.Controls.Add(this.tbC);
            this.gbC.Location = new System.Drawing.Point(551, 250);
            this.gbC.Name = "gbC";
            this.gbC.Size = new System.Drawing.Size(140, 180);
            this.gbC.TabIndex = 8;
            this.gbC.TabStop = false;
            // 
            // trbC
            // 
            this.trbC.Location = new System.Drawing.Point(10, 112);
            this.trbC.Maximum = 100;
            this.trbC.Name = "trbC";
            this.trbC.Size = new System.Drawing.Size(120, 56);
            this.trbC.TabIndex = 5;
            this.trbC.ValueChanged += new System.EventHandler(this.trb_ValueChanged);
            // 
            // nudC
            // 
            this.nudC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudC.Location = new System.Drawing.Point(10, 56);
            this.nudC.Name = "nudC";
            this.nudC.Size = new System.Drawing.Size(120, 26);
            this.nudC.TabIndex = 3;
            this.nudC.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // tbC
            // 
            this.tbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbC.Location = new System.Drawing.Point(10, 10);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(120, 26);
            this.tbC.TabIndex = 1;
            this.tbC.Text = "0";
            this.tbC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.gbC);
            this.Controls.Add(this.gbB);
            this.Controls.Add(this.gbA);
            this.Controls.Add(this.lbABC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbA)).EndInit();
            this.gbA.ResumeLayout(false);
            this.gbA.PerformLayout();
            this.gbB.ResumeLayout(false);
            this.gbB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            this.gbC.ResumeLayout(false);
            this.gbC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbABC;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.NumericUpDown nudA;
        private System.Windows.Forms.TrackBar trbA;
        private System.Windows.Forms.GroupBox gbA;
        private System.Windows.Forms.GroupBox gbB;
        private System.Windows.Forms.TrackBar trbB;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.GroupBox gbC;
        private System.Windows.Forms.TrackBar trbC;
        private System.Windows.Forms.NumericUpDown nudC;
        private System.Windows.Forms.TextBox tbC;
    }
}

