namespace Menu
{
    partial class Form2
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
            this.id_bludo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bludoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bludoDataSet = new Menu.BludoDataSet();
            this.bludoTableAdapter = new Menu.BludoDataSetTableAdapters.BludoTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bludoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bludoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_bludo,
            this.nameDataGridViewTextBoxColumn,
            this.vesDataGridViewTextBoxColumn,
            this.kalDataGridViewTextBoxColumn,
            this.sostDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bludoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1091, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // id_bludo
            // 
            this.id_bludo.DataPropertyName = "id_bludo";
            this.id_bludo.HeaderText = "id_bludo";
            this.id_bludo.MinimumWidth = 6;
            this.id_bludo.Name = "id_bludo";
            this.id_bludo.ReadOnly = true;
            this.id_bludo.Visible = false;
            this.id_bludo.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // vesDataGridViewTextBoxColumn
            // 
            this.vesDataGridViewTextBoxColumn.DataPropertyName = "ves";
            this.vesDataGridViewTextBoxColumn.HeaderText = "ves";
            this.vesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vesDataGridViewTextBoxColumn.Name = "vesDataGridViewTextBoxColumn";
            this.vesDataGridViewTextBoxColumn.Width = 125;
            // 
            // kalDataGridViewTextBoxColumn
            // 
            this.kalDataGridViewTextBoxColumn.DataPropertyName = "kal";
            this.kalDataGridViewTextBoxColumn.HeaderText = "kal";
            this.kalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kalDataGridViewTextBoxColumn.Name = "kalDataGridViewTextBoxColumn";
            this.kalDataGridViewTextBoxColumn.Width = 125;
            // 
            // sostDataGridViewTextBoxColumn
            // 
            this.sostDataGridViewTextBoxColumn.DataPropertyName = "sost";
            this.sostDataGridViewTextBoxColumn.HeaderText = "sost";
            this.sostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sostDataGridViewTextBoxColumn.Name = "sostDataGridViewTextBoxColumn";
            this.sostDataGridViewTextBoxColumn.Width = 125;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "cena";
            this.cenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "photo";
            this.photoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            this.photoDataGridViewTextBoxColumn.Width = 125;
            // 
            // bludoBindingSource
            // 
            this.bludoBindingSource.DataMember = "Bludo";
            this.bludoBindingSource.DataSource = this.bludoDataSet;
            // 
            // bludoDataSet
            // 
            this.bludoDataSet.DataSetName = "BludoDataSet";
            this.bludoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bludoTableAdapter
            // 
            this.bludoTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(348, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(524, 252);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 52);
            this.button4.TabIndex = 4;
            this.button4.Text = "Обновить базу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(686, 252);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(205, 52);
            this.button5.TabIndex = 5;
            this.button5.Text = "Создать меню на сегодня";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(897, 252);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(206, 52);
            this.button6.TabIndex = 6;
            this.button6.Text = "Создать отчёт по блюдам";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 328);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bludoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bludoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BludoDataSet bludoDataSet;
        private System.Windows.Forms.BindingSource bludoBindingSource;
        private BludoDataSetTableAdapters.BludoTableAdapter bludoTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_bludo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button6;
    }
}