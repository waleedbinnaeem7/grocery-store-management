namespace Grocery_Store_Management
{
    partial class Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.cloth_datasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cloth_sale_report = new Grocery_Store_Management.cloth_sale_report();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cloth_datasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloth_sale_report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cloth_datasetBindingSource
            // 
            this.cloth_datasetBindingSource.DataMember = "cloth_dataset";
            this.cloth_datasetBindingSource.DataSource = this.cloth_sale_report;
            // 
            // cloth_sale_report
            // 
            this.cloth_sale_report.DataSetName = "cloth_sale_report";
            this.cloth_sale_report.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(468, 53);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(316, 56);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(146, 20);
            this.txt_search.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Invoice Id:";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet_sale_report";
            reportDataSource1.Value = this.cloth_datasetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Grocery_Store_Management.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 102);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(577, 394);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cloth_datasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloth_sale_report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cloth_datasetBindingSource;
        private cloth_sale_report cloth_sale_report;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}