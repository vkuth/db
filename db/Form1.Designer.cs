
namespace db
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sphereOfControlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazeDataSet = new db.BazeDataSet();
            this.contactsTableAdapter = new db.BazeDataSetTableAdapters.contactsTableAdapter();
            this.Save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SavetoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.AddtoolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.FindtoolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExittoolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.ControltoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.AbouttoolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Raise = new System.Windows.Forms.Button();
            this.Raising = new System.Windows.Forms.ToolStripMenuItem();
            this.Editbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazeDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ddDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.birthDayDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.directorDataGridViewTextBoxColumn,
            this.sphereOfControlDataGridViewTextBoxColumn,
            this.divisionDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contactsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1422, 404);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // ddDataGridViewTextBoxColumn
            // 
            this.ddDataGridViewTextBoxColumn.DataPropertyName = "dd";
            this.ddDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.ddDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ddDataGridViewTextBoxColumn.Name = "ddDataGridViewTextBoxColumn";
            this.ddDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthDayDataGridViewTextBoxColumn
            // 
            this.birthDayDataGridViewTextBoxColumn.DataPropertyName = "BirthDay";
            this.birthDayDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthDayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthDayDataGridViewTextBoxColumn.Name = "birthDayDataGridViewTextBoxColumn";
            this.birthDayDataGridViewTextBoxColumn.Width = 125;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.Width = 125;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.Width = 125;
            // 
            // directorDataGridViewTextBoxColumn
            // 
            this.directorDataGridViewTextBoxColumn.DataPropertyName = "Director";
            this.directorDataGridViewTextBoxColumn.HeaderText = "ФИО руководителя";
            this.directorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.directorDataGridViewTextBoxColumn.Name = "directorDataGridViewTextBoxColumn";
            this.directorDataGridViewTextBoxColumn.Width = 125;
            // 
            // sphereOfControlDataGridViewTextBoxColumn
            // 
            this.sphereOfControlDataGridViewTextBoxColumn.DataPropertyName = "Sphere of control";
            this.sphereOfControlDataGridViewTextBoxColumn.HeaderText = "Сфера контроля";
            this.sphereOfControlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sphereOfControlDataGridViewTextBoxColumn.Name = "sphereOfControlDataGridViewTextBoxColumn";
            this.sphereOfControlDataGridViewTextBoxColumn.Width = 125;
            // 
            // divisionDataGridViewTextBoxColumn
            // 
            this.divisionDataGridViewTextBoxColumn.DataPropertyName = "Division";
            this.divisionDataGridViewTextBoxColumn.HeaderText = "Название подразделения";
            this.divisionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.divisionDataGridViewTextBoxColumn.Name = "divisionDataGridViewTextBoxColumn";
            this.divisionDataGridViewTextBoxColumn.Width = 125;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Название предприятия";
            this.companyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataMember = "contacts";
            this.contactsBindingSource.DataSource = this.bazeDataSet;
            // 
            // bazeDataSet
            // 
            this.bazeDataSet.DataSetName = "BazeDataSet";
            this.bazeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactsTableAdapter
            // 
            this.contactsTableAdapter.ClearBeforeFill = true;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(27, 467);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(200, 59);
            this.Save.TabIndex = 1;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(249, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(474, 467);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(200, 59);
            this.Search.TabIndex = 3;
            this.Search.Text = "Найти";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem6});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1463, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SavetoolStripMenuItem2,
            this.AddtoolStripMenuItem3,
            this.FindtoolStripMenuItem4,
            this.Raising,
            this.ExittoolStripMenuItem5});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 26);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // SavetoolStripMenuItem2
            // 
            this.SavetoolStripMenuItem2.Name = "SavetoolStripMenuItem2";
            this.SavetoolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.SavetoolStripMenuItem2.Text = "Сохранить";
            this.SavetoolStripMenuItem2.Click += new System.EventHandler(this.SavetoolStripMenuItem2_Click);
            // 
            // AddtoolStripMenuItem3
            // 
            this.AddtoolStripMenuItem3.Name = "AddtoolStripMenuItem3";
            this.AddtoolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.AddtoolStripMenuItem3.Text = "Добавить";
            this.AddtoolStripMenuItem3.Click += new System.EventHandler(this.AddtoolStripMenuItem3_Click);
            // 
            // FindtoolStripMenuItem4
            // 
            this.FindtoolStripMenuItem4.Name = "FindtoolStripMenuItem4";
            this.FindtoolStripMenuItem4.Size = new System.Drawing.Size(224, 26);
            this.FindtoolStripMenuItem4.Text = "Найти";
            this.FindtoolStripMenuItem4.Click += new System.EventHandler(this.FindtoolStripMenuItem4_Click);
            // 
            // ExittoolStripMenuItem5
            // 
            this.ExittoolStripMenuItem5.Name = "ExittoolStripMenuItem5";
            this.ExittoolStripMenuItem5.Size = new System.Drawing.Size(224, 26);
            this.ExittoolStripMenuItem5.Text = "Выход";
            this.ExittoolStripMenuItem5.Click += new System.EventHandler(this.ExittoolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ControltoolStripMenuItem2,
            this.AbouttoolStripMenuItem3});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(83, 26);
            this.toolStripMenuItem6.Text = "Помощь";
            // 
            // ControltoolStripMenuItem2
            // 
            this.ControltoolStripMenuItem2.Name = "ControltoolStripMenuItem2";
            this.ControltoolStripMenuItem2.Size = new System.Drawing.Size(177, 26);
            this.ControltoolStripMenuItem2.Text = "Управление";
            this.ControltoolStripMenuItem2.Click += new System.EventHandler(this.ControltoolStripMenuItem2_Click);
            // 
            // AbouttoolStripMenuItem3
            // 
            this.AbouttoolStripMenuItem3.Name = "AbouttoolStripMenuItem3";
            this.AbouttoolStripMenuItem3.Size = new System.Drawing.Size(177, 26);
            this.AbouttoolStripMenuItem3.Text = "Об авторе";
            this.AbouttoolStripMenuItem3.Click += new System.EventHandler(this.AbouttoolStripMenuItem3_Click);
            // 
            // Raise
            // 
            this.Raise.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Raise.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Raise.Location = new System.Drawing.Point(689, 467);
            this.Raise.Name = "Raise";
            this.Raise.Size = new System.Drawing.Size(200, 59);
            this.Raise.TabIndex = 5;
            this.Raise.Text = "Повысить";
            this.Raise.UseVisualStyleBackColor = false;
            this.Raise.Click += new System.EventHandler(this.Raise_Click);
            // 
            // Raising
            // 
            this.Raising.Name = "Raising";
            this.Raising.Size = new System.Drawing.Size(224, 26);
            this.Raising.Text = "Повысить";
            this.Raising.Click += new System.EventHandler(this.Raising_Click);
            // 
            // Editbtn
            // 
            this.Editbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Editbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Editbtn.Location = new System.Drawing.Point(931, 467);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(200, 59);
            this.Editbtn.TabIndex = 6;
            this.Editbtn.Text = "Изменить";
            this.Editbtn.UseVisualStyleBackColor = false;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Exitbtn.Location = new System.Drawing.Point(1166, 467);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(200, 59);
            this.Exitbtn.TabIndex = 7;
            this.Exitbtn.Text = "Выход";
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 538);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.Raise);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "База";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazeDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public BazeDataSet bazeDataSet;
        public System.Windows.Forms.BindingSource contactsBindingSource;
        public BazeDataSetTableAdapters.contactsTableAdapter contactsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sphereOfControlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn divisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SavetoolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem AddtoolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem FindtoolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem ExittoolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem ControltoolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem AbouttoolStripMenuItem3;
        private System.Windows.Forms.Button Raise;
        private System.Windows.Forms.ToolStripMenuItem Raising;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.Button Exitbtn;
    }
}