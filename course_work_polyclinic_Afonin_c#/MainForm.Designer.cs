namespace course_work_polyclinic_Afonin_c_
{
    partial class MainForm
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
            this.ButtonFormPattiensAccounting = new System.Windows.Forms.Button();
            this.ButtonFormDoctorAccounting = new System.Windows.Forms.Button();
            this.ButtonCloseMainForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonFormPattiensAccounting
            // 
            this.ButtonFormPattiensAccounting.Location = new System.Drawing.Point(11, 69);
            this.ButtonFormPattiensAccounting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonFormPattiensAccounting.Name = "ButtonFormPattiensAccounting";
            this.ButtonFormPattiensAccounting.Size = new System.Drawing.Size(125, 44);
            this.ButtonFormPattiensAccounting.TabIndex = 0;
            this.ButtonFormPattiensAccounting.Text = "пациенты";
            this.ButtonFormPattiensAccounting.UseVisualStyleBackColor = true;
            this.ButtonFormPattiensAccounting.Click += new System.EventHandler(this.FormPatiens_Click);
            // 
            // ButtonFormDoctorAccounting
            // 
            this.ButtonFormDoctorAccounting.Location = new System.Drawing.Point(11, 11);
            this.ButtonFormDoctorAccounting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonFormDoctorAccounting.Name = "ButtonFormDoctorAccounting";
            this.ButtonFormDoctorAccounting.Size = new System.Drawing.Size(125, 44);
            this.ButtonFormDoctorAccounting.TabIndex = 1;
            this.ButtonFormDoctorAccounting.Text = "доктора";
            this.ButtonFormDoctorAccounting.UseVisualStyleBackColor = true;
            this.ButtonFormDoctorAccounting.Click += new System.EventHandler(this.FormDoctor_Click);
            // 
            // ButtonCloseMainForm
            // 
            this.ButtonCloseMainForm.Location = new System.Drawing.Point(11, 194);
            this.ButtonCloseMainForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonCloseMainForm.Name = "ButtonCloseMainForm";
            this.ButtonCloseMainForm.Size = new System.Drawing.Size(125, 44);
            this.ButtonCloseMainForm.TabIndex = 2;
            this.ButtonCloseMainForm.Text = "выход";
            this.ButtonCloseMainForm.UseVisualStyleBackColor = true;
            this.ButtonCloseMainForm.Click += new System.EventHandler(this.CloseMainForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(149, 249);
            this.Controls.Add(this.ButtonCloseMainForm);
            this.Controls.Add(this.ButtonFormDoctorAccounting);
            this.Controls.Add(this.ButtonFormPattiensAccounting);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonFormPattiensAccounting;
        private System.Windows.Forms.Button ButtonFormDoctorAccounting;
        private System.Windows.Forms.Button ButtonCloseMainForm;
    }
}

