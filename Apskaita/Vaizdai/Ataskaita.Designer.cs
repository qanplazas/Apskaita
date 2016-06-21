namespace Apskaita.Vaizdai
{
    partial class Ataskaita
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
            this.AtaskaitosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ikiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tiekejasComboBox = new System.Windows.Forms.ComboBox();
            this.padalinysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nuoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saskaitosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apskaitaDataSet = new Apskaita.DataAccessLayer.ApskaitaDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tiekejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AtaskaitosDataSetBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.padalinysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saskaitosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apskaitaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiekejasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AtaskaitosDataSetBindingSource
            // 
            this.AtaskaitosDataSetBindingSource.DataMember = "likuciai";
            this.AtaskaitosDataSetBindingSource.DataSource = typeof(Apskaita.DataAccessLayer.AtaskaitosDataSet);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ikiDateTimePicker, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.tiekejasComboBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nuoDateTimePicker, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(680, 87);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Laikotarpis";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Iki:";
            // 
            // ikiDateTimePicker
            // 
            this.ikiDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ikiDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ikiDateTimePicker.Location = new System.Drawing.Point(361, 55);
            this.ikiDateTimePicker.Name = "ikiDateTimePicker";
            this.ikiDateTimePicker.Size = new System.Drawing.Size(316, 20);
            this.ikiDateTimePicker.TabIndex = 7;
            // 
            // tiekejasComboBox
            // 
            this.tiekejasComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tiekejasComboBox, 3);
            this.tiekejasComboBox.DataSource = this.padalinysBindingSource;
            this.tiekejasComboBox.DisplayMember = "Pavadinimas";
            this.tiekejasComboBox.FormattingEnabled = true;
            this.tiekejasComboBox.Location = new System.Drawing.Point(128, 11);
            this.tiekejasComboBox.Name = "tiekejasComboBox";
            this.tiekejasComboBox.Size = new System.Drawing.Size(549, 21);
            this.tiekejasComboBox.TabIndex = 2;
            this.tiekejasComboBox.ValueMember = "Id";
            // 
            // padalinysBindingSource
            // 
            this.padalinysBindingSource.DataMember = "padalinys";
            this.padalinysBindingSource.DataSource = typeof(Apskaita.DataAccessLayer.ApskaitaDataSet);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Padalinys:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nuo:";
            // 
            // nuoDateTimePicker
            // 
            this.nuoDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nuoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nuoDateTimePicker.Location = new System.Drawing.Point(128, 55);
            this.nuoDateTimePicker.Name = "nuoDateTimePicker";
            this.nuoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.nuoDateTimePicker.TabIndex = 6;
            // 
            // saskaitosBindingSource
            // 
            this.saskaitosBindingSource.DataMember = "saskaita";
            this.saskaitosBindingSource.DataSource = this.apskaitaDataSet;
            // 
            // apskaitaDataSet
            // 
            this.apskaitaDataSet.DataSetName = "ApskaitaDataSet";
            this.apskaitaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(617, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pateikti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AtaskaitosDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Apskaita.Raportai.likuciai.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 134);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(677, 417);
            this.reportViewer1.TabIndex = 3;
            // 
            // tiekejasBindingSource
            // 
            this.tiekejasBindingSource.DataMember = "tiekejas";
            this.tiekejasBindingSource.DataSource = this.apskaitaDataSet;
            // 
            // NupirktaPagalTiekeja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 564);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NupirktaPagalTiekeja";
            this.Text = "Ataskaita";
            this.Load += new System.EventHandler(this.NupirktaPagalTiekeja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AtaskaitosDataSetBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.padalinysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saskaitosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apskaitaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiekejasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker nuoDateTimePicker;
        private System.Windows.Forms.DateTimePicker ikiDateTimePicker;
        private System.Windows.Forms.ComboBox tiekejasComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private DataAccessLayer.ApskaitaDataSet apskaitaDataSet;
        private System.Windows.Forms.BindingSource saskaitosBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tiekejasBindingSource;
        private System.Windows.Forms.BindingSource AtaskaitosDataSetBindingSource;
        private System.Windows.Forms.BindingSource padalinysBindingSource;
    }
}