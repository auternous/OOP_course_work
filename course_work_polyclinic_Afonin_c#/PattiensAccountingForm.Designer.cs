namespace course_work_polyclinic_Afonin_c_
{
    partial class PattiensAccountingForm
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
            this.ButtonCreatePattien = new System.Windows.Forms.Button();
            this.ButtonDeleteSelectedPattien = new System.Windows.Forms.Button();
            this.ButtonDeleteAllPattiens = new System.Windows.Forms.Button();
            this.labelCountPattiens = new System.Windows.Forms.Label();
            this.textBoxCountPattiens = new System.Windows.Forms.TextBox();
            this.dataGridViewPattiens = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonClosePattiensAccountingForm = new System.Windows.Forms.Button();
            this.buttonFindPattien = new System.Windows.Forms.Button();
            this.ButtonAnalysePattiens = new System.Windows.Forms.Button();
            this.ButtonResetFiltering = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearchPattiens = new System.Windows.Forms.TextBox();
            this.comboBoxFilterPattiens = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPattiens)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCreatePattien
            // 
            this.ButtonCreatePattien.ForeColor = System.Drawing.Color.Black;
            this.ButtonCreatePattien.Location = new System.Drawing.Point(341, 279);
            this.ButtonCreatePattien.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCreatePattien.Name = "ButtonCreatePattien";
            this.ButtonCreatePattien.Size = new System.Drawing.Size(112, 45);
            this.ButtonCreatePattien.TabIndex = 1;
            this.ButtonCreatePattien.Text = "Создать пациента";
            this.ButtonCreatePattien.UseVisualStyleBackColor = true;
            this.ButtonCreatePattien.Click += new System.EventHandler(this.ButtonCreatePattien_Click);
            // 
            // ButtonDeleteSelectedPattien
            // 
            this.ButtonDeleteSelectedPattien.Location = new System.Drawing.Point(457, 279);
            this.ButtonDeleteSelectedPattien.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonDeleteSelectedPattien.Name = "ButtonDeleteSelectedPattien";
            this.ButtonDeleteSelectedPattien.Size = new System.Drawing.Size(112, 45);
            this.ButtonDeleteSelectedPattien.TabIndex = 2;
            this.ButtonDeleteSelectedPattien.Text = "Удалить пациента";
            this.ButtonDeleteSelectedPattien.UseVisualStyleBackColor = true;
            this.ButtonDeleteSelectedPattien.Click += new System.EventHandler(this.ButtonDeleteSelectedPattien_Click);
            // 
            // ButtonDeleteAllPattiens
            // 
            this.ButtonDeleteAllPattiens.Location = new System.Drawing.Point(225, 326);
            this.ButtonDeleteAllPattiens.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonDeleteAllPattiens.Name = "ButtonDeleteAllPattiens";
            this.ButtonDeleteAllPattiens.Size = new System.Drawing.Size(112, 45);
            this.ButtonDeleteAllPattiens.TabIndex = 3;
            this.ButtonDeleteAllPattiens.Text = "Удалить всех пациентов";
            this.ButtonDeleteAllPattiens.UseVisualStyleBackColor = true;
            this.ButtonDeleteAllPattiens.Click += new System.EventHandler(this.ButtonDeleteAllPattiens_Click);
            // 
            // labelCountPattiens
            // 
            this.labelCountPattiens.AutoSize = true;
            this.labelCountPattiens.Location = new System.Drawing.Point(10, 358);
            this.labelCountPattiens.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountPattiens.Name = "labelCountPattiens";
            this.labelCountPattiens.Size = new System.Drawing.Size(122, 13);
            this.labelCountPattiens.TabIndex = 4;
            this.labelCountPattiens.Text = "Количество пациентов";
            // 
            // textBoxCountPattiens
            // 
            this.textBoxCountPattiens.Location = new System.Drawing.Point(145, 355);
            this.textBoxCountPattiens.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCountPattiens.Name = "textBoxCountPattiens";
            this.textBoxCountPattiens.Size = new System.Drawing.Size(57, 20);
            this.textBoxCountPattiens.TabIndex = 5;
            // 
            // dataGridViewPattiens
            // 
            this.dataGridViewPattiens.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewPattiens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPattiens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5});
            this.dataGridViewPattiens.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewPattiens.Location = new System.Drawing.Point(13, 23);
            this.dataGridViewPattiens.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPattiens.Name = "dataGridViewPattiens";
            this.dataGridViewPattiens.RowHeadersWidth = 51;
            this.dataGridViewPattiens.RowTemplate.Height = 24;
            this.dataGridViewPattiens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPattiens.Size = new System.Drawing.Size(556, 239);
            this.dataGridViewPattiens.TabIndex = 6;
            this.dataGridViewPattiens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPattiens_CellContentClick);
            this.dataGridViewPattiens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPattiens_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фамилия";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Возраст";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Болезнь";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // buttonClosePattiensAccountingForm
            // 
            this.buttonClosePattiensAccountingForm.Location = new System.Drawing.Point(457, 326);
            this.buttonClosePattiensAccountingForm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClosePattiensAccountingForm.Name = "buttonClosePattiensAccountingForm";
            this.buttonClosePattiensAccountingForm.Size = new System.Drawing.Size(112, 45);
            this.buttonClosePattiensAccountingForm.TabIndex = 7;
            this.buttonClosePattiensAccountingForm.Text = "Закрыть форму";
            this.buttonClosePattiensAccountingForm.UseVisualStyleBackColor = true;
            this.buttonClosePattiensAccountingForm.Click += new System.EventHandler(this.ButtonClosePattiensAccountingForm_Click);
            // 
            // buttonFindPattien
            // 
            this.buttonFindPattien.Location = new System.Drawing.Point(341, 326);
            this.buttonFindPattien.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFindPattien.Name = "buttonFindPattien";
            this.buttonFindPattien.Size = new System.Drawing.Size(112, 45);
            this.buttonFindPattien.TabIndex = 8;
            this.buttonFindPattien.Text = "Найти пациента";
            this.buttonFindPattien.UseVisualStyleBackColor = true;
            this.buttonFindPattien.Click += new System.EventHandler(this.ButtonFindPattien_Click);
            // 
            // ButtonAnalysePattiens
            // 
            this.ButtonAnalysePattiens.Location = new System.Drawing.Point(225, 279);
            this.ButtonAnalysePattiens.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonAnalysePattiens.Name = "ButtonAnalysePattiens";
            this.ButtonAnalysePattiens.Size = new System.Drawing.Size(112, 45);
            this.ButtonAnalysePattiens.TabIndex = 9;
            this.ButtonAnalysePattiens.Text = "Анализ по болезням";
            this.ButtonAnalysePattiens.UseVisualStyleBackColor = true;
            this.ButtonAnalysePattiens.Click += new System.EventHandler(this.ButtonAnalysePattiens_Click);
            // 
            // ButtonResetFiltering
            // 
            this.ButtonResetFiltering.Location = new System.Drawing.Point(13, 319);
            this.ButtonResetFiltering.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonResetFiltering.Name = "ButtonResetFiltering";
            this.ButtonResetFiltering.Size = new System.Drawing.Size(189, 32);
            this.ButtonResetFiltering.TabIndex = 14;
            this.ButtonResetFiltering.Text = "Сбросить фильтрацию";
            this.ButtonResetFiltering.UseVisualStyleBackColor = true;
            this.ButtonResetFiltering.Click += new System.EventHandler(this.ButtonResetFiltering_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Фильтрация ";
            // 
            // textBoxSearchPattiens
            // 
            this.textBoxSearchPattiens.Location = new System.Drawing.Point(100, 294);
            this.textBoxSearchPattiens.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearchPattiens.Name = "textBoxSearchPattiens";
            this.textBoxSearchPattiens.Size = new System.Drawing.Size(102, 20);
            this.textBoxSearchPattiens.TabIndex = 11;
            this.textBoxSearchPattiens.TextChanged += new System.EventHandler(this.textBoxSearchPattiens_TextChanged);
            // 
            // comboBoxFilterPattiens
            // 
            this.comboBoxFilterPattiens.FormattingEnabled = true;
            this.comboBoxFilterPattiens.Items.AddRange(new object[] {
            "Имя",
            "Фамилия",
            "Возраст",
            "Район проживания",
            "Болезнь",
            "Наличие справки",
            "Месяц начала болезни"});
            this.comboBoxFilterPattiens.Location = new System.Drawing.Point(13, 292);
            this.comboBoxFilterPattiens.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFilterPattiens.Name = "comboBoxFilterPattiens";
            this.comboBoxFilterPattiens.Size = new System.Drawing.Size(64, 21);
            this.comboBoxFilterPattiens.TabIndex = 16;
            // 
            // PattiensAccountingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(588, 382);
            this.Controls.Add(this.comboBoxFilterPattiens);
            this.Controls.Add(this.ButtonResetFiltering);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSearchPattiens);
            this.Controls.Add(this.ButtonAnalysePattiens);
            this.Controls.Add(this.buttonFindPattien);
            this.Controls.Add(this.buttonClosePattiensAccountingForm);
            this.Controls.Add(this.dataGridViewPattiens);
            this.Controls.Add(this.textBoxCountPattiens);
            this.Controls.Add(this.labelCountPattiens);
            this.Controls.Add(this.ButtonDeleteAllPattiens);
            this.Controls.Add(this.ButtonDeleteSelectedPattien);
            this.Controls.Add(this.ButtonCreatePattien);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PattiensAccountingForm";
            this.Text = "PattiensAccounting";
            this.Load += new System.EventHandler(this.PattiensAccountingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPattiens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonCreatePattien;
        private System.Windows.Forms.Button ButtonDeleteSelectedPattien;
        private System.Windows.Forms.Button ButtonDeleteAllPattiens;
        private System.Windows.Forms.Label labelCountPattiens;
        private System.Windows.Forms.TextBox textBoxCountPattiens;
        private System.Windows.Forms.DataGridView dataGridViewPattiens;
        private System.Windows.Forms.Button buttonClosePattiensAccountingForm;
        private System.Windows.Forms.Button buttonFindPattien;
        private System.Windows.Forms.Button ButtonAnalysePattiens;
        private System.Windows.Forms.Button ButtonResetFiltering;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearchPattiens;
        private System.Windows.Forms.ComboBox comboBoxFilterPattiens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}