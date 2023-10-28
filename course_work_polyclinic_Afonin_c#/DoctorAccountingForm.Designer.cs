namespace course_work_polyclinic_Afonin_c_
{
    partial class DoctorAccountingForm
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
            this.ButtonCloseDoctorAccounting = new System.Windows.Forms.Button();
            this.ButtonCreateDoctor = new System.Windows.Forms.Button();
            this.ButtonDeleteSelectedDoctor = new System.Windows.Forms.Button();
            this.ButtonDeleteAllDoctor = new System.Windows.Forms.Button();
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCountDoctors = new System.Windows.Forms.Label();
            this.textBoxCountDoctors = new System.Windows.Forms.TextBox();
            this.textBoxSearchDoctor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonResetFiltering = new System.Windows.Forms.Button();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCloseDoctorAccounting
            // 
            this.ButtonCloseDoctorAccounting.Location = new System.Drawing.Point(463, 342);
            this.ButtonCloseDoctorAccounting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonCloseDoctorAccounting.Name = "ButtonCloseDoctorAccounting";
            this.ButtonCloseDoctorAccounting.Size = new System.Drawing.Size(93, 43);
            this.ButtonCloseDoctorAccounting.TabIndex = 0;
            this.ButtonCloseDoctorAccounting.Text = "Закрыть форму";
            this.ButtonCloseDoctorAccounting.UseVisualStyleBackColor = true;
            this.ButtonCloseDoctorAccounting.Click += new System.EventHandler(this.ButtonCloseDoctorAccounting_Click);
            // 
            // ButtonCreateDoctor
            // 
            this.ButtonCreateDoctor.Location = new System.Drawing.Point(463, 289);
            this.ButtonCreateDoctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonCreateDoctor.Name = "ButtonCreateDoctor";
            this.ButtonCreateDoctor.Size = new System.Drawing.Size(93, 43);
            this.ButtonCreateDoctor.TabIndex = 1;
            this.ButtonCreateDoctor.Text = "Добавить доктора";
            this.ButtonCreateDoctor.UseVisualStyleBackColor = true;
            this.ButtonCreateDoctor.Click += new System.EventHandler(this.ButtonCreateDoctor_Click);
            // 
            // ButtonDeleteSelectedDoctor
            // 
            this.ButtonDeleteSelectedDoctor.Location = new System.Drawing.Point(366, 289);
            this.ButtonDeleteSelectedDoctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonDeleteSelectedDoctor.Name = "ButtonDeleteSelectedDoctor";
            this.ButtonDeleteSelectedDoctor.Size = new System.Drawing.Size(93, 43);
            this.ButtonDeleteSelectedDoctor.TabIndex = 2;
            this.ButtonDeleteSelectedDoctor.Text = "Удалить доктора";
            this.ButtonDeleteSelectedDoctor.UseVisualStyleBackColor = true;
            this.ButtonDeleteSelectedDoctor.Click += new System.EventHandler(this.ButtonDeleteSelectedDoctor_Click);
            // 
            // ButtonDeleteAllDoctor
            // 
            this.ButtonDeleteAllDoctor.Location = new System.Drawing.Point(269, 289);
            this.ButtonDeleteAllDoctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonDeleteAllDoctor.Name = "ButtonDeleteAllDoctor";
            this.ButtonDeleteAllDoctor.Size = new System.Drawing.Size(93, 43);
            this.ButtonDeleteAllDoctor.TabIndex = 3;
            this.ButtonDeleteAllDoctor.Text = "Удалить всех докторов";
            this.ButtonDeleteAllDoctor.UseVisualStyleBackColor = true;
            this.ButtonDeleteAllDoctor.Click += new System.EventHandler(this.ButtonDeleteAllDoctor_Click);
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.AllowUserToAddRows = false;
            this.dataGridViewDoctors.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewDoctors.Location = new System.Drawing.Point(9, 20);
            this.dataGridViewDoctors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.ReadOnly = true;
            this.dataGridViewDoctors.RowHeadersWidth = 51;
            this.dataGridViewDoctors.RowTemplate.Height = 24;
            this.dataGridViewDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDoctors.Size = new System.Drawing.Size(547, 225);
            this.dataGridViewDoctors.TabIndex = 4;
            this.dataGridViewDoctors.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoctors_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фамилия";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Возраст";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Специализация";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // labelCountDoctors
            // 
            this.labelCountDoctors.AutoSize = true;
            this.labelCountDoctors.Location = new System.Drawing.Point(19, 369);
            this.labelCountDoctors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountDoctors.Name = "labelCountDoctors";
            this.labelCountDoctors.Size = new System.Drawing.Size(116, 13);
            this.labelCountDoctors.TabIndex = 5;
            this.labelCountDoctors.Text = "Количество докторов";
            // 
            // textBoxCountDoctors
            // 
            this.textBoxCountDoctors.Location = new System.Drawing.Point(144, 365);
            this.textBoxCountDoctors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCountDoctors.Name = "textBoxCountDoctors";
            this.textBoxCountDoctors.Size = new System.Drawing.Size(59, 20);
            this.textBoxCountDoctors.TabIndex = 6;
            // 
            // textBoxSearchDoctor
            // 
            this.textBoxSearchDoctor.Location = new System.Drawing.Point(99, 289);
            this.textBoxSearchDoctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSearchDoctor.Name = "textBoxSearchDoctor";
            this.textBoxSearchDoctor.Size = new System.Drawing.Size(102, 20);
            this.textBoxSearchDoctor.TabIndex = 7;
            this.textBoxSearchDoctor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 264);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Фильтрация";
            // 
            // ButtonResetFiltering
            // 
            this.ButtonResetFiltering.Location = new System.Drawing.Point(12, 314);
            this.ButtonResetFiltering.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonResetFiltering.Name = "ButtonResetFiltering";
            this.ButtonResetFiltering.Size = new System.Drawing.Size(189, 32);
            this.ButtonResetFiltering.TabIndex = 10;
            this.ButtonResetFiltering.Text = "Сбросить фильтрацию";
            this.ButtonResetFiltering.UseVisualStyleBackColor = true;
            this.ButtonResetFiltering.Click += new System.EventHandler(this.ButtonResetFiltering_Click);
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Items.AddRange(new object[] {
            "Имя",
            "Фамилия",
            "Возраст",
            "Специализация"});
            this.comboBoxDoctor.Location = new System.Drawing.Point(12, 287);
            this.comboBoxDoctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(70, 21);
            this.comboBoxDoctor.TabIndex = 11;
            // 
            // DoctorAccountingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(570, 401);
            this.Controls.Add(this.comboBoxDoctor);
            this.Controls.Add(this.ButtonResetFiltering);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSearchDoctor);
            this.Controls.Add(this.textBoxCountDoctors);
            this.Controls.Add(this.labelCountDoctors);
            this.Controls.Add(this.dataGridViewDoctors);
            this.Controls.Add(this.ButtonDeleteAllDoctor);
            this.Controls.Add(this.ButtonDeleteSelectedDoctor);
            this.Controls.Add(this.ButtonCreateDoctor);
            this.Controls.Add(this.ButtonCloseDoctorAccounting);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DoctorAccountingForm";
            this.Text = "DoctorAccounting";
            this.Load += new System.EventHandler(this.DoctorAccountingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCloseDoctorAccounting;
        private System.Windows.Forms.Button ButtonCreateDoctor;
        private System.Windows.Forms.Button ButtonDeleteSelectedDoctor;
        private System.Windows.Forms.Button ButtonDeleteAllDoctor;
        private System.Windows.Forms.DataGridView dataGridViewDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label labelCountDoctors;
        private System.Windows.Forms.TextBox textBoxCountDoctors;
        private System.Windows.Forms.TextBox textBoxSearchDoctor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonResetFiltering;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
    }
}