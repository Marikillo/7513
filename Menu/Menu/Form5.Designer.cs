namespace Menu
{
    partial class Form5
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
            this.idbludoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bludoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bludoDataSet2 = new Menu.BludoDataSet2();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bludoDataSet1 = new Menu.BludoDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.typeTableAdapter = new Menu.BludoDataSet1TableAdapters.TypeTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bludoTableAdapter = new Menu.BludoDataSet2TableAdapters.BludoTableAdapter();
            this.Racion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_bludo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bludoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bludoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bludoDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbludoDataGridViewTextBoxColumn,
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
            this.dataGridView1.Size = new System.Drawing.Size(688, 364);
            this.dataGridView1.TabIndex = 0;
            // 
            // idbludoDataGridViewTextBoxColumn
            // 
            this.idbludoDataGridViewTextBoxColumn.DataPropertyName = "id_bludo";
            this.idbludoDataGridViewTextBoxColumn.HeaderText = "id_bludo";
            this.idbludoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbludoDataGridViewTextBoxColumn.Name = "idbludoDataGridViewTextBoxColumn";
            this.idbludoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idbludoDataGridViewTextBoxColumn.Width = 125;
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
            this.bludoBindingSource.DataSource = this.bludoDataSet2;
            // 
            // bludoDataSet2
            // 
            this.bludoDataSet2.DataSetName = "BludoDataSet2";
            this.bludoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Racion,
            this.name,
            this.ves,
            this.kal,
            this.sost,
            this.cena,
            this.Photo,
            this.Data,
            this.id_bludo,
            this.id_type});
            this.dataGridView2.Location = new System.Drawing.Point(706, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(688, 364);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 451);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.typeBindingSource;
            this.comboBox1.DisplayMember = "Racion";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 401);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "id_type";
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "Type";
            this.typeBindingSource.DataSource = this.bludoDataSet1;
            // 
            // bludoDataSet1
            // 
            this.bludoDataSet1.DataSetName = "BludoDataSet1";
            this.bludoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить блюдо";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 60);
            this.button2.TabIndex = 5;
            this.button2.Text = "Сформировать меню";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(706, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 61);
            this.button3.TabIndex = 6;
            this.button3.Text = "Очисть строку";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Время питания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Дата меню";
            // 
            // bludoTableAdapter
            // 
            this.bludoTableAdapter.ClearBeforeFill = true;
            // 
            // Racion
            // 
            this.Racion.HeaderText = "Время_питания";
            this.Racion.MinimumWidth = 6;
            this.Racion.Name = "Racion";
            this.Racion.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Названия_блюда";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // ves
            // 
            this.ves.HeaderText = "Вес";
            this.ves.MinimumWidth = 6;
            this.ves.Name = "ves";
            this.ves.Width = 125;
            // 
            // kal
            // 
            this.kal.HeaderText = "Калории";
            this.kal.MinimumWidth = 6;
            this.kal.Name = "kal";
            this.kal.Width = 125;
            // 
            // sost
            // 
            this.sost.HeaderText = "Состав";
            this.sost.MinimumWidth = 6;
            this.sost.Name = "sost";
            this.sost.Width = 125;
            // 
            // cena
            // 
            this.cena.HeaderText = "Цена";
            this.cena.MinimumWidth = 6;
            this.cena.Name = "cena";
            this.cena.Width = 125;
            // 
            // Photo
            // 
            this.Photo.HeaderText = "Фото";
            this.Photo.MinimumWidth = 6;
            this.Photo.Name = "Photo";
            this.Photo.Width = 125;
            // 
            // Data
            // 
            this.Data.HeaderText = "Дата";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.Width = 125;
            // 
            // id_bludo
            // 
            this.id_bludo.HeaderText = "id_bludo";
            this.id_bludo.MinimumWidth = 6;
            this.id_bludo.Name = "id_bludo";
            this.id_bludo.Visible = false;
            this.id_bludo.Width = 125;
            // 
            // id_type
            // 
            this.id_type.HeaderText = "id_type";
            this.id_type.MinimumWidth = 6;
            this.id_type.Name = "id_type";
            this.id_type.Visible = false;
            this.id_type.Width = 125;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 523);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bludoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bludoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bludoDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private BludoDataSet1 bludoDataSet1;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private BludoDataSet1TableAdapters.TypeTableAdapter typeTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private BludoDataSet2 bludoDataSet2;
        private System.Windows.Forms.BindingSource bludoBindingSource;
        private BludoDataSet2TableAdapters.BludoTableAdapter bludoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbludoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Racion;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ves;
        private System.Windows.Forms.DataGridViewTextBoxColumn kal;
        private System.Windows.Forms.DataGridViewTextBoxColumn sost;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_bludo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_type;
    }
}