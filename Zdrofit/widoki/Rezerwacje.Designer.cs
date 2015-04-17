namespace Zdrofit.widoki
{
    partial class Rezerwacje
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
            this.dnitygodniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Zdrofit.DataSet1();
            this.zajeciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.osobyProcownicySelectCommandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new Zdrofit.DataSet1();
            this.grafikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grafikTableAdapter = new Zdrofit.DataSet1TableAdapters.grafikTableAdapter();
            this.saleTableAdapter = new Zdrofit.DataSet1TableAdapters.saleTableAdapter();
            this.saleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dni_tygodniaTableAdapter = new Zdrofit.DataSet1TableAdapters.dni_tygodniaTableAdapter();
            this.zajeciaTableAdapter = new Zdrofit.DataSet1TableAdapters.zajeciaTableAdapter();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.osobyProcownicySelectCommandTableAdapter = new Zdrofit.DataSet1TableAdapters.OsobyProcownicySelectCommandTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.osobyProcownicySelectCommandTableAdapter1 = new Zdrofit.DataSet1TableAdapters.OsobyProcownicySelectCommandTableAdapter();
            this.dzientygodniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.godzinaodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godzinadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zajeciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.salaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instruktoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnitygodniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zajeciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobyProcownicySelectCommandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dzientygodniaDataGridViewTextBoxColumn,
            this.godzinaodDataGridViewTextBoxColumn,
            this.godzinadoDataGridViewTextBoxColumn,
            this.zajeciaDataGridViewTextBoxColumn,
            this.salaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.instruktoridDataGridViewTextBoxColumn,
            this.Button});
            this.dataGridView1.DataSource = this.grafikBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1111, 582);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dnitygodniaBindingSource
            // 
            this.dnitygodniaBindingSource.DataMember = "dni_tygodnia";
            this.dnitygodniaBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zajeciaBindingSource
            // 
            this.zajeciaBindingSource.DataMember = "zajecia";
            this.zajeciaBindingSource.DataSource = this.dataSet1;
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataMember = "sale";
            this.saleBindingSource.DataSource = this.dataSet1;
            // 
            // osobyProcownicySelectCommandBindingSource
            // 
            this.osobyProcownicySelectCommandBindingSource.DataMember = "OsobyProcownicySelectCommand";
            this.osobyProcownicySelectCommandBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grafikBindingSource
            // 
            this.grafikBindingSource.DataMember = "grafik";
            this.grafikBindingSource.DataSource = this.dataSet1;
            // 
            // grafikTableAdapter
            // 
            this.grafikTableAdapter.ClearBeforeFill = true;
            // 
            // saleTableAdapter
            // 
            this.saleTableAdapter.ClearBeforeFill = true;
            // 
            // saleBindingSource1
            // 
            this.saleBindingSource1.DataMember = "sale";
            this.saleBindingSource1.DataSource = this.dataSet1;
            // 
            // dni_tygodniaTableAdapter
            // 
            this.dni_tygodniaTableAdapter.ClearBeforeFill = true;
            // 
            // zajeciaTableAdapter
            // 
            this.zajeciaTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // osobyProcownicySelectCommandTableAdapter
            // 
            this.osobyProcownicySelectCommandTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zapisz Grafik";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1131, 650);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1123, 624);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Grafik";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1117, 618);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 24);
            this.panel1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1123, 624);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rezerwacja";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // osobyProcownicySelectCommandTableAdapter1
            // 
            this.osobyProcownicySelectCommandTableAdapter1.ClearBeforeFill = true;
            // 
            // dzientygodniaDataGridViewTextBoxColumn
            // 
            this.dzientygodniaDataGridViewTextBoxColumn.DataPropertyName = "dzien_tygodnia";
            this.dzientygodniaDataGridViewTextBoxColumn.DataSource = this.dnitygodniaBindingSource;
            this.dzientygodniaDataGridViewTextBoxColumn.DisplayMember = "dzien_tygodnia";
            this.dzientygodniaDataGridViewTextBoxColumn.HeaderText = "dzien_tygodnia";
            this.dzientygodniaDataGridViewTextBoxColumn.Name = "dzientygodniaDataGridViewTextBoxColumn";
            this.dzientygodniaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dzientygodniaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dzientygodniaDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // godzinaodDataGridViewTextBoxColumn
            // 
            this.godzinaodDataGridViewTextBoxColumn.DataPropertyName = "godzina_od";
            this.godzinaodDataGridViewTextBoxColumn.HeaderText = "godzina_od";
            this.godzinaodDataGridViewTextBoxColumn.Name = "godzinaodDataGridViewTextBoxColumn";
            // 
            // godzinadoDataGridViewTextBoxColumn
            // 
            this.godzinadoDataGridViewTextBoxColumn.DataPropertyName = "godzina_do";
            this.godzinadoDataGridViewTextBoxColumn.HeaderText = "godzina_do";
            this.godzinadoDataGridViewTextBoxColumn.Name = "godzinadoDataGridViewTextBoxColumn";
            // 
            // zajeciaDataGridViewTextBoxColumn
            // 
            this.zajeciaDataGridViewTextBoxColumn.DataPropertyName = "zajecia";
            this.zajeciaDataGridViewTextBoxColumn.DataSource = this.zajeciaBindingSource;
            this.zajeciaDataGridViewTextBoxColumn.DisplayMember = "nazwa";
            this.zajeciaDataGridViewTextBoxColumn.HeaderText = "zajecia";
            this.zajeciaDataGridViewTextBoxColumn.Name = "zajeciaDataGridViewTextBoxColumn";
            this.zajeciaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.zajeciaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.zajeciaDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // salaDataGridViewTextBoxColumn
            // 
            this.salaDataGridViewTextBoxColumn.DataPropertyName = "sala";
            this.salaDataGridViewTextBoxColumn.DataSource = this.saleBindingSource;
            this.salaDataGridViewTextBoxColumn.DisplayMember = "nazwa";
            this.salaDataGridViewTextBoxColumn.HeaderText = "sala";
            this.salaDataGridViewTextBoxColumn.Name = "salaDataGridViewTextBoxColumn";
            this.salaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.salaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.salaDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "uwagi";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // instruktoridDataGridViewTextBoxColumn
            // 
            this.instruktoridDataGridViewTextBoxColumn.DataPropertyName = "instruktor_id";
            this.instruktoridDataGridViewTextBoxColumn.DataSource = this.osobyProcownicySelectCommandBindingSource;
            this.instruktoridDataGridViewTextBoxColumn.DisplayMember = "imienazwisko";
            this.instruktoridDataGridViewTextBoxColumn.HeaderText = "instruktor_id";
            this.instruktoridDataGridViewTextBoxColumn.Name = "instruktoridDataGridViewTextBoxColumn";
            this.instruktoridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.instruktoridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.instruktoridDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // Button
            // 
            this.Button.HeaderText = "Rezerwacja";
            this.Button.Name = "Button";
            this.Button.Text = "Rezerwuj";
            this.Button.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zajęcia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // Rezerwacje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 650);
            this.Controls.Add(this.tabControl1);
            this.Name = "Rezerwacje";
            this.Text = "Rezerwacje";
            this.Load += new System.EventHandler(this.Rezerwacje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnitygodniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zajeciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobyProcownicySelectCommandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource grafikBindingSource;
        private DataSet1TableAdapters.grafikTableAdapter grafikTableAdapter;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private DataSet1TableAdapters.saleTableAdapter saleTableAdapter;
        private System.Windows.Forms.BindingSource saleBindingSource1;
        private System.Windows.Forms.BindingSource dnitygodniaBindingSource;
        private DataSet1TableAdapters.dni_tygodniaTableAdapter dni_tygodniaTableAdapter;
        private System.Windows.Forms.BindingSource zajeciaBindingSource;
        private DataSet1TableAdapters.zajeciaTableAdapter zajeciaTableAdapter;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource osobyProcownicySelectCommandBindingSource;
        private DataSet1TableAdapters.OsobyProcownicySelectCommandTableAdapter osobyProcownicySelectCommandTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private DataSet1TableAdapters.OsobyProcownicySelectCommandTableAdapter osobyProcownicySelectCommandTableAdapter1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dzientygodniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godzinaodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godzinadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn zajeciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn salaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn instruktoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}