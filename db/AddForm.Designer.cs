
namespace db
{
    partial class AddForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDate = new System.Windows.Forms.DateTimePicker();
            this.tbSex = new System.Windows.Forms.ComboBox();
            this.tbCompany = new System.Windows.Forms.ComboBox();
            this.tbDivision = new System.Windows.Forms.ComboBox();
            this.tbSphere = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbWork = new System.Windows.Forms.ComboBox();
            this.tbDirector = new System.Windows.Forms.ComboBox();
            this.contactsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.bazeDataSet = new db.BazeDataSet();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.probaDataSet = new db.BazeDataSet();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsTableAdapter = new db.BazeDataSetTableAdapters.contactsTableAdapter();
            this.contactsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contactsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.contactsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.contactsTableAdapter1 = new db.BazeDataSetTableAdapters.contactsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDate);
            this.groupBox1.Controls.Add(this.tbSex);
            this.groupBox1.Controls.Add(this.tbCompany);
            this.groupBox1.Controls.Add(this.tbDivision);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbSphere);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbWork);
            this.groupBox1.Controls.Add(this.tbDirector);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 561);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление Записей";
            // 
            // tbDate
            // 
            this.tbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbDate.Location = new System.Drawing.Point(470, 114);
            this.tbDate.Name = "tbDate";
            this.tbDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbDate.Size = new System.Drawing.Size(352, 38);
            this.tbDate.TabIndex = 22;
            // 
            // tbSex
            // 
            this.tbSex.FormattingEnabled = true;
            this.tbSex.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.tbSex.Location = new System.Drawing.Point(470, 175);
            this.tbSex.Name = "tbSex";
            this.tbSex.Size = new System.Drawing.Size(352, 42);
            this.tbSex.TabIndex = 21;
            this.tbSex.Text = "-";
            // 
            // tbCompany
            // 
            this.tbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCompany.FormattingEnabled = true;
            this.tbCompany.Items.AddRange(new object[] {
            "ООО \"Глобус\"",
            "-"});
            this.tbCompany.Location = new System.Drawing.Point(470, 478);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(352, 39);
            this.tbCompany.TabIndex = 20;
            this.tbCompany.Text = "-";
            // 
            // tbDivision
            // 
            this.tbDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDivision.FormattingEnabled = true;
            this.tbDivision.Items.AddRange(new object[] {
            "Дирекция по продажам",
            "Управление по логистике",
            "Техничиская диреция",
            "Дирекция по экономике и фининсам",
            "-"});
            this.tbDivision.Location = new System.Drawing.Point(470, 415);
            this.tbDivision.Name = "tbDivision";
            this.tbDivision.Size = new System.Drawing.Size(352, 39);
            this.tbDivision.TabIndex = 19;
            this.tbDivision.Text = "-";
            // 
            // tbSphere
            // 
            this.tbSphere.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSphere.FormattingEnabled = true;
            this.tbSphere.Items.AddRange(new object[] {
            "Отдел продаж",
            "Отдел ремонта и технического обслуживания оборудования",
            "Отдел кадров",
            "Бугалтерия",
            "Транспротный отдел",
            "Отдел закупок",
            "-"});
            this.tbSphere.Location = new System.Drawing.Point(470, 361);
            this.tbSphere.Name = "tbSphere";
            this.tbSphere.Size = new System.Drawing.Size(352, 39);
            this.tbSphere.TabIndex = 18;
            this.tbSphere.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(13, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(344, 36);
            this.label8.TabIndex = 17;
            this.label8.Text = "Название предриятия:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(398, 36);
            this.label7.TabIndex = 16;
            this.label7.Text = "Название подразделения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 36);
            this.label6.TabIndex = 15;
            this.label6.Text = "Сфера контроля:";
            // 
            // tbWork
            // 
            this.tbWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWork.FormattingEnabled = true;
            this.tbWork.Items.AddRange(new object[] {
            "Директор",
            "Руководитель подразделения",
            "Контролер",
            "Рабочий"});
            this.tbWork.Location = new System.Drawing.Point(470, 241);
            this.tbWork.Name = "tbWork";
            this.tbWork.Size = new System.Drawing.Size(352, 44);
            this.tbWork.TabIndex = 14;
            this.tbWork.Text = "-";
            // 
            // tbDirector
            // 
            this.tbDirector.DataSource = this.contactsBindingSource4;
            this.tbDirector.DisplayMember = "name";
            this.tbDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDirector.FormattingEnabled = true;
            this.tbDirector.Location = new System.Drawing.Point(470, 308);
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.Size = new System.Drawing.Size(352, 33);
            this.tbDirector.TabIndex = 13;
            this.tbDirector.ValueMember = "dd";
            // 
            // contactsBindingSource4
            // 
            this.contactsBindingSource4.DataMember = "contacts";
            this.contactsBindingSource4.DataSource = this.bazeDataSet;
            // 
            // bazeDataSet
            // 
            this.bazeDataSet.DataSetName = "BazeDataSet";
            this.bazeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(470, 60);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(352, 41);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата рождения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "Пол:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "Должность:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "ФИО руководителя:";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.AddButton.Location = new System.Drawing.Point(84, 604);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(172, 54);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBtn.Location = new System.Drawing.Point(539, 618);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(184, 53);
            this.CloseBtn.TabIndex = 12;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // probaDataSet
            // 
            this.probaDataSet.DataSetName = "ProbaDataSet";
            this.probaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataMember = "contacts";
            this.contactsBindingSource.DataSource = this.probaDataSet;
            // 
            // contactsTableAdapter
            // 
            this.contactsTableAdapter.ClearBeforeFill = true;
            // 
            // contactsBindingSource1
            // 
            this.contactsBindingSource1.DataMember = "contacts";
            this.contactsBindingSource1.DataSource = this.probaDataSet;
            // 
            // contactsTableAdapter1
            // 
            this.contactsTableAdapter1.ClearBeforeFill = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 683);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddForm";
            this.Text = "Добавить";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CloseBtn;
        private BazeDataSet probaDataSet;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private BazeDataSetTableAdapters.contactsTableAdapter contactsTableAdapter;
        private System.Windows.Forms.BindingSource contactsBindingSource1;
        private System.Windows.Forms.BindingSource contactsBindingSource2;
        private System.Windows.Forms.BindingSource contactsBindingSource3;
        private System.Windows.Forms.ComboBox tbDirector;
        private System.Windows.Forms.ComboBox tbWork;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tbCompany;
        private System.Windows.Forms.ComboBox tbDivision;
        private System.Windows.Forms.ComboBox tbSphere;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private BazeDataSet bazeDataSet;
        private System.Windows.Forms.BindingSource contactsBindingSource4;
        private BazeDataSetTableAdapters.contactsTableAdapter contactsTableAdapter1;
        private System.Windows.Forms.DateTimePicker tbDate;
        private System.Windows.Forms.ComboBox tbSex;
    }
}