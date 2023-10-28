namespace course_work_polyclinic_Afonin_c_
{
    partial class FormDoctors
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
            this.textNameDoctor = new System.Windows.Forms.TextBox();
            this.nameActor = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.textLastNameDoctor = new System.Windows.Forms.TextBox();
            this.specialization = new System.Windows.Forms.Label();
            this.textSpecializationDoctor = new System.Windows.Forms.TextBox();
            this.ageDoctor = new System.Windows.Forms.Label();
            this.numericAgeDoctor = new System.Windows.Forms.NumericUpDown();
            this.ButtonCloseFormDoctor = new System.Windows.Forms.Button();
            this.ButtonCreateDoctor = new System.Windows.Forms.Button();
            this.labelHelpDoctorName = new System.Windows.Forms.Label();
            this.labelHelpDoctorLastName = new System.Windows.Forms.Label();
            this.labelHelpDoctorSpecialisation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericAgeDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // textNameDoctor
            // 
            this.textNameDoctor.Location = new System.Drawing.Point(118, 32);
            this.textNameDoctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNameDoctor.Name = "textNameDoctor";
            this.textNameDoctor.Size = new System.Drawing.Size(124, 20);
            this.textNameDoctor.TabIndex = 0;
            // 
            // nameActor
            // 
            this.nameActor.AutoSize = true;
            this.nameActor.Location = new System.Drawing.Point(13, 37);
            this.nameActor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameActor.Name = "nameActor";
            this.nameActor.Size = new System.Drawing.Size(73, 13);
            this.nameActor.TabIndex = 1;
            this.nameActor.Text = "Имя доктора";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(13, 57);
            this.lastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 13);
            this.lastName.TabIndex = 3;
            this.lastName.Text = "Фамилия доктора";
            // 
            // textLastNameDoctor
            // 
            this.textLastNameDoctor.Location = new System.Drawing.Point(118, 52);
            this.textLastNameDoctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textLastNameDoctor.Name = "textLastNameDoctor";
            this.textLastNameDoctor.Size = new System.Drawing.Size(124, 20);
            this.textLastNameDoctor.TabIndex = 2;
            // 
            // specialization
            // 
            this.specialization.AutoSize = true;
            this.specialization.Location = new System.Drawing.Point(13, 80);
            this.specialization.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.specialization.Name = "specialization";
            this.specialization.Size = new System.Drawing.Size(86, 13);
            this.specialization.TabIndex = 5;
            this.specialization.Text = "Специализация";
            // 
            // textSpecializationDoctor
            // 
            this.textSpecializationDoctor.Location = new System.Drawing.Point(118, 75);
            this.textSpecializationDoctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textSpecializationDoctor.Name = "textSpecializationDoctor";
            this.textSpecializationDoctor.Size = new System.Drawing.Size(124, 20);
            this.textSpecializationDoctor.TabIndex = 4;
            // 
            // ageDoctor
            // 
            this.ageDoctor.AutoSize = true;
            this.ageDoctor.Location = new System.Drawing.Point(13, 103);
            this.ageDoctor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ageDoctor.Name = "ageDoctor";
            this.ageDoctor.Size = new System.Drawing.Size(49, 13);
            this.ageDoctor.TabIndex = 7;
            this.ageDoctor.Text = "Возраст";
            // 
            // numericAgeDoctor
            // 
            this.numericAgeDoctor.Location = new System.Drawing.Point(118, 98);
            this.numericAgeDoctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericAgeDoctor.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericAgeDoctor.Name = "numericAgeDoctor";
            this.numericAgeDoctor.Size = new System.Drawing.Size(123, 20);
            this.numericAgeDoctor.TabIndex = 8;
            this.numericAgeDoctor.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // ButtonCloseFormDoctor
            // 
            this.ButtonCloseFormDoctor.Location = new System.Drawing.Point(136, 323);
            this.ButtonCloseFormDoctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonCloseFormDoctor.Name = "ButtonCloseFormDoctor";
            this.ButtonCloseFormDoctor.Size = new System.Drawing.Size(105, 32);
            this.ButtonCloseFormDoctor.TabIndex = 9;
            this.ButtonCloseFormDoctor.Text = "Выйти";
            this.ButtonCloseFormDoctor.UseVisualStyleBackColor = true;
            this.ButtonCloseFormDoctor.Click += new System.EventHandler(this.ButtonCloseFormDoctor_Click);
            // 
            // ButtonCreateDoctor
            // 
            this.ButtonCreateDoctor.Location = new System.Drawing.Point(9, 323);
            this.ButtonCreateDoctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonCreateDoctor.Name = "ButtonCreateDoctor";
            this.ButtonCreateDoctor.Size = new System.Drawing.Size(105, 32);
            this.ButtonCreateDoctor.TabIndex = 10;
            this.ButtonCreateDoctor.Text = "Создать ";
            this.ButtonCreateDoctor.UseVisualStyleBackColor = true;
            this.ButtonCreateDoctor.Click += new System.EventHandler(this.ButtonCreateDoctor_Click);
            // 
            // labelHelpDoctorName
            // 
            this.labelHelpDoctorName.AutoSize = true;
            this.labelHelpDoctorName.Location = new System.Drawing.Point(255, 34);
            this.labelHelpDoctorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHelpDoctorName.Name = "labelHelpDoctorName";
            this.labelHelpDoctorName.Size = new System.Drawing.Size(0, 13);
            this.labelHelpDoctorName.TabIndex = 11;
            // 
            // labelHelpDoctorLastName
            // 
            this.labelHelpDoctorLastName.AutoSize = true;
            this.labelHelpDoctorLastName.Location = new System.Drawing.Point(255, 57);
            this.labelHelpDoctorLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHelpDoctorLastName.Name = "labelHelpDoctorLastName";
            this.labelHelpDoctorLastName.Size = new System.Drawing.Size(0, 13);
            this.labelHelpDoctorLastName.TabIndex = 12;
            // 
            // labelHelpDoctorSpecialisation
            // 
            this.labelHelpDoctorSpecialisation.AutoSize = true;
            this.labelHelpDoctorSpecialisation.Location = new System.Drawing.Point(255, 80);
            this.labelHelpDoctorSpecialisation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHelpDoctorSpecialisation.Name = "labelHelpDoctorSpecialisation";
            this.labelHelpDoctorSpecialisation.Size = new System.Drawing.Size(0, 13);
            this.labelHelpDoctorSpecialisation.TabIndex = 13;
            // 
            // FormDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(260, 366);
            this.Controls.Add(this.labelHelpDoctorSpecialisation);
            this.Controls.Add(this.labelHelpDoctorLastName);
            this.Controls.Add(this.labelHelpDoctorName);
            this.Controls.Add(this.ButtonCreateDoctor);
            this.Controls.Add(this.ButtonCloseFormDoctor);
            this.Controls.Add(this.numericAgeDoctor);
            this.Controls.Add(this.ageDoctor);
            this.Controls.Add(this.specialization);
            this.Controls.Add(this.textSpecializationDoctor);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.textLastNameDoctor);
            this.Controls.Add(this.nameActor);
            this.Controls.Add(this.textNameDoctor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDoctors";
            this.Text = "FormDoctor";
            this.Load += new System.EventHandler(this.FormDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericAgeDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNameDoctor;
        private System.Windows.Forms.Label nameActor;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox textLastNameDoctor;
        private System.Windows.Forms.Label specialization;
        private System.Windows.Forms.TextBox textSpecializationDoctor;
        private System.Windows.Forms.Label ageDoctor;
        private System.Windows.Forms.NumericUpDown numericAgeDoctor;
        private System.Windows.Forms.Button ButtonCloseFormDoctor;
        private System.Windows.Forms.Button ButtonCreateDoctor;
        private System.Windows.Forms.Label labelHelpDoctorName;
        private System.Windows.Forms.Label labelHelpDoctorLastName;
        private System.Windows.Forms.Label labelHelpDoctorSpecialisation;
    }
}