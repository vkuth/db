
namespace db
{
    partial class RaisingForm
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
            this.tbWork = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.probaDataSet = new db.BazeDataSet();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsTableAdapter = new db.BazeDataSetTableAdapters.contactsTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCompany = new System.Windows.Forms.ComboBox();
            this.tbDivision = new System.Windows.Forms.ComboBox();
            this.tbSphere = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDirector = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.probaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbCompany);
            this.groupBox1.Controls.Add(this.tbDivision);
            this.groupBox1.Controls.Add(this.tbSphere);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbDirector);
            this.groupBox1.Controls.Add(this.tbWork);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(18, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Повышение";
            // 
            // tbWork
            // 
            this.tbWork.FormattingEnabled = true;
            this.tbWork.Items.AddRange(new object[] {
            "Директор",
            "Руководитель продразделения ",
            "Контролер",
            "Рабочий"});
            this.tbWork.Location = new System.Drawing.Point(364, 56);
            this.tbWork.Name = "tbWork";
            this.tbWork.Size = new System.Drawing.Size(492, 38);
            this.tbWork.TabIndex = 1;
            this.tbWork.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Должность:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(101, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Повысить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(536, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(27, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 36);
            this.label5.TabIndex = 21;
            this.label5.Text = "ФИО руководителя:";
            // 
            // tbCompany
            // 
            this.tbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCompany.FormattingEnabled = true;
            this.tbCompany.Items.AddRange(new object[] {
            "ООО \"Глобус\"",
            "-"});
            this.tbCompany.Location = new System.Drawing.Point(463, 253);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(395, 39);
            this.tbCompany.TabIndex = 28;
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
            this.tbDivision.Location = new System.Drawing.Point(463, 203);
            this.tbDivision.Name = "tbDivision";
            this.tbDivision.Size = new System.Drawing.Size(393, 39);
            this.tbDivision.TabIndex = 27;
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
            this.tbSphere.Location = new System.Drawing.Point(364, 152);
            this.tbSphere.Name = "tbSphere";
            this.tbSphere.Size = new System.Drawing.Size(492, 39);
            this.tbSphere.TabIndex = 26;
            this.tbSphere.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(27, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(344, 36);
            this.label8.TabIndex = 25;
            this.label8.Text = "Название предриятия:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(27, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(398, 36);
            this.label7.TabIndex = 24;
            this.label7.Text = "Название подразделения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(27, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 36);
            this.label6.TabIndex = 23;
            this.label6.Text = "Сфера контроля:";
            // 
            // tbDirector
            // 
            this.tbDirector.DisplayMember = "name";
            this.tbDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDirector.FormattingEnabled = true;
            this.tbDirector.Location = new System.Drawing.Point(364, 112);
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.Size = new System.Drawing.Size(492, 33);
            this.tbDirector.TabIndex = 22;
            this.tbDirector.Text = "-";
            this.tbDirector.ValueMember = "dd";
            // 
            // RaisingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 455);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "RaisingForm";
            this.Text = "Повысить";
            this.Load += new System.EventHandler(this.RaisingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.probaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tbWork;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private BazeDataSet probaDataSet;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private BazeDataSetTableAdapters.contactsTableAdapter contactsTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tbCompany;
        private System.Windows.Forms.ComboBox tbDivision;
        private System.Windows.Forms.ComboBox tbSphere;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tbDirector;
    }
}