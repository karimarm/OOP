namespace L4_OOP
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
            this.pbCircles = new System.Windows.Forms.PictureBox();
            this.cbIsCtrl = new System.Windows.Forms.CheckBox();
            this.cbSelectionCircles = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCircles)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCircles
            // 
            this.pbCircles.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pbCircles.Location = new System.Drawing.Point(0, 0);
            this.pbCircles.Name = "pbCircles";
            this.pbCircles.Size = new System.Drawing.Size(980, 545);
            this.pbCircles.TabIndex = 1;
            this.pbCircles.TabStop = false;
            this.pbCircles.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCircles_Paint);
            this.pbCircles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbCircles_MouseClick);
            // 
            // cbIsCtrl
            // 
            this.cbIsCtrl.AutoSize = true;
            this.cbIsCtrl.Checked = true;
            this.cbIsCtrl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsCtrl.Location = new System.Drawing.Point(60, 581);
            this.cbIsCtrl.Name = "cbIsCtrl";
            this.cbIsCtrl.Size = new System.Drawing.Size(100, 20);
            this.cbIsCtrl.TabIndex = 2;
            this.cbIsCtrl.Text = "CTRL on/off";
            this.cbIsCtrl.UseVisualStyleBackColor = true;
            // 
            // cbSelectionCircles
            // 
            this.cbSelectionCircles.AutoSize = true;
            this.cbSelectionCircles.Checked = true;
            this.cbSelectionCircles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSelectionCircles.Location = new System.Drawing.Point(229, 581);
            this.cbSelectionCircles.Name = "cbSelectionCircles";
            this.cbSelectionCircles.Size = new System.Drawing.Size(153, 20);
            this.cbSelectionCircles.TabIndex = 3;
            this.cbSelectionCircles.Text = "Select one/all circles";
            this.cbSelectionCircles.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.cbSelectionCircles);
            this.Controls.Add(this.cbIsCtrl);
            this.Controls.Add(this.pbCircles);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCircles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCircles;
        private System.Windows.Forms.CheckBox cbIsCtrl;
        private System.Windows.Forms.CheckBox cbSelectionCircles;
    }
}

