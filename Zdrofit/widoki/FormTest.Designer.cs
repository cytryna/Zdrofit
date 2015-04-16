namespace Zdrofit.widoki
{
    partial class FormTest
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
            this.dataSet1 = new Zdrofit.DataSet1();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafikSelectCommandBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(27, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafikSelectCommandBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
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