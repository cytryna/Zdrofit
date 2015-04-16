namespace Zdrofit
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grafikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Zdrofit.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleTableAdapter = new Zdrofit.DataSet1TableAdapters.saleTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grafikSelectCommandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grafikSelectCommandTableAdapter = new Zdrofit.DataSet1TableAdapters.GrafikSelectCommandTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dzientygodniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godzinaodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godzinadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zajeciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instruktoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafikSelectCommandBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(977, 432);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(969, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Grafik";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.208426F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.79157F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1056, 451);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(969, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rezerwacje";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grafikBindingSource
            // 
            this.grafikBindingSource.DataMember = "grafik";
            this.grafikBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataMember = "sale";
            this.saleBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // saleTableAdapter
            // 
            this.saleTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dzientygodniaDataGridViewTextBoxColumn,
            this.godzinaodDataGridViewTextBoxColumn,
            this.godzinadoDataGridViewTextBoxColumn,
            this.zajeciaDataGridViewTextBoxColumn,
            this.salaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.instruktoridDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.grafikSelectCommandBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(878, 287);
            this.dataGridView1.TabIndex = 1;
            // 
            // grafikSelectCommandBindingSource
            // 
            this.grafikSelectCommandBindingSource.DataMember = "GrafikSelectCommand";
            this.grafikSelectCommandBindingSource.DataSource = this.dataSet1;
            // 
            // grafikSelectCommandTableAdapter
            // 
            this.grafikSelectCommandTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dzientygodniaDataGridViewTextBoxColumn
            // 
            this.dzientygodniaDataGridViewTextBoxColumn.DataPropertyName = "dzien_tygodnia";
            this.dzientygodniaDataGridViewTextBoxColumn.HeaderText = "dzien_tygodnia";
            this.dzientygodniaDataGridViewTextBoxColumn.Name = "dzientygodniaDataGridViewTextBoxColumn";
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
            this.zajeciaDataGridViewTextBoxColumn.HeaderText = "zajecia";
            this.zajeciaDataGridViewTextBoxColumn.Name = "zajeciaDataGridViewTextBoxColumn";
            // 
            // salaDataGridViewTextBoxColumn
            // 
            this.salaDataGridViewTextBoxColumn.DataPropertyName = "sala";
            this.salaDataGridViewTextBoxColumn.HeaderText = "sala";
            this.salaDataGridViewTextBoxColumn.Name = "salaDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // instruktoridDataGridViewTextBoxColumn
            // 
            this.instruktoridDataGridViewTextBoxColumn.DataPropertyName = "instruktor_id";
            this.instruktoridDataGridViewTextBoxColumn.HeaderText = "instruktor_id";
            this.instruktoridDataGridViewTextBoxColumn.Name = "instruktoridDataGridViewTextBoxColumn";
            // 
            // Rezerwacje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 432);
            this.Controls.Add(this.tabControl1);
            this.Name = "Rezerwacje";
            this.Text = "Rezerwacje";
            this.Load += new System.EventHandler(this.Rezerwacje_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grafikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafikSelectCommandBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource grafikBindingSource;
        
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private DataSet1TableAdapters.saleTableAdapter saleTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource grafikSelectCommandBindingSource;
        private DataSet1TableAdapters.GrafikSelectCommandTableAdapter grafikSelectCommandTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dzientygodniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godzinaodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godzinadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zajeciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instruktoridDataGridViewTextBoxColumn;

    }
}