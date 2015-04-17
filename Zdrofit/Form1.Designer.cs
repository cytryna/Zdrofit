namespace Zdrofit
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rezerwacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezerwacjeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.osobyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Zdrofit.DataSet1();
            this.saleTableAdapter = new Zdrofit.DataSet1TableAdapters.saleTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezerwacjeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1326, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rezerwacjeToolStripMenuItem
            // 
            this.rezerwacjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezerwacjeToolStripMenuItem1,
            this.osobyToolStripMenuItem});
            this.rezerwacjeToolStripMenuItem.Name = "rezerwacjeToolStripMenuItem";
            this.rezerwacjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.rezerwacjeToolStripMenuItem.Text = "Menu";
            this.rezerwacjeToolStripMenuItem.Click += new System.EventHandler(this.rezerwacjeToolStripMenuItem_Click);
            // 
            // rezerwacjeToolStripMenuItem1
            // 
            this.rezerwacjeToolStripMenuItem1.Name = "rezerwacjeToolStripMenuItem1";
            this.rezerwacjeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.rezerwacjeToolStripMenuItem1.Text = "Rezerwacje";
            this.rezerwacjeToolStripMenuItem1.Click += new System.EventHandler(this.rezerwacjeToolStripMenuItem1_Click);
            // 
            // osobyToolStripMenuItem
            // 
            this.osobyToolStripMenuItem.Name = "osobyToolStripMenuItem";
            this.osobyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.osobyToolStripMenuItem.Text = "Osoby";
            this.osobyToolStripMenuItem.Click += new System.EventHandler(this.osobyToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataMember = "sale";
            this.saleBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saleTableAdapter
            // 
            this.saleTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 738);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rezerwacjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezerwacjeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem osobyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private DataSet1TableAdapters.saleTableAdapter saleTableAdapter;
    }
}

