namespace PDFPrint
{
  partial class MainForm
  {
    /// <summary>
    /// 必要なデザイナー変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows フォーム デザイナーで生成されたコード

    /// <summary>
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent()
    {
      this.groupBoxExportPDF = new System.Windows.Forms.GroupBox();
      this.textBoxPDFExportFolder = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.buttonExport = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxPDFTitle = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxPDFContents = new System.Windows.Forms.TextBox();
      this.groupBoxPrint = new System.Windows.Forms.GroupBox();
      this.buttonPrint = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.comboBoxPrinters = new System.Windows.Forms.ComboBox();
      this.groupBoxExportPDF.SuspendLayout();
      this.groupBoxPrint.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBoxExportPDF
      // 
      this.groupBoxExportPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxExportPDF.Controls.Add(this.label3);
      this.groupBoxExportPDF.Controls.Add(this.textBoxPDFContents);
      this.groupBoxExportPDF.Controls.Add(this.label2);
      this.groupBoxExportPDF.Controls.Add(this.textBoxPDFTitle);
      this.groupBoxExportPDF.Controls.Add(this.buttonExport);
      this.groupBoxExportPDF.Controls.Add(this.label1);
      this.groupBoxExportPDF.Controls.Add(this.textBoxPDFExportFolder);
      this.groupBoxExportPDF.Location = new System.Drawing.Point(12, 12);
      this.groupBoxExportPDF.Name = "groupBoxExportPDF";
      this.groupBoxExportPDF.Size = new System.Drawing.Size(717, 434);
      this.groupBoxExportPDF.TabIndex = 0;
      this.groupBoxExportPDF.TabStop = false;
      this.groupBoxExportPDF.Text = "Export PDF";
      // 
      // textBoxPDFExportFolder
      // 
      this.textBoxPDFExportFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxPDFExportFolder.Location = new System.Drawing.Point(109, 24);
      this.textBoxPDFExportFolder.Name = "textBoxPDFExportFolder";
      this.textBoxPDFExportFolder.Size = new System.Drawing.Size(592, 25);
      this.textBoxPDFExportFolder.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 18);
      this.label1.TabIndex = 1;
      this.label1.Text = "Folder";
      // 
      // buttonExport
      // 
      this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonExport.Location = new System.Drawing.Point(608, 397);
      this.buttonExport.Name = "buttonExport";
      this.buttonExport.Size = new System.Drawing.Size(93, 31);
      this.buttonExport.TabIndex = 2;
      this.buttonExport.Text = "Export";
      this.buttonExport.UseVisualStyleBackColor = true;
      this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 58);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(42, 18);
      this.label2.TabIndex = 4;
      this.label2.Text = "Title";
      // 
      // textBoxPDFTitle
      // 
      this.textBoxPDFTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxPDFTitle.Location = new System.Drawing.Point(109, 55);
      this.textBoxPDFTitle.Name = "textBoxPDFTitle";
      this.textBoxPDFTitle.Size = new System.Drawing.Size(592, 25);
      this.textBoxPDFTitle.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 89);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(76, 18);
      this.label3.TabIndex = 6;
      this.label3.Text = "Contents";
      // 
      // textBoxPDFContents
      // 
      this.textBoxPDFContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxPDFContents.Location = new System.Drawing.Point(109, 86);
      this.textBoxPDFContents.Multiline = true;
      this.textBoxPDFContents.Name = "textBoxPDFContents";
      this.textBoxPDFContents.Size = new System.Drawing.Size(592, 305);
      this.textBoxPDFContents.TabIndex = 5;
      // 
      // groupBoxPrint
      // 
      this.groupBoxPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxPrint.Controls.Add(this.comboBoxPrinters);
      this.groupBoxPrint.Controls.Add(this.label4);
      this.groupBoxPrint.Controls.Add(this.buttonPrint);
      this.groupBoxPrint.Location = new System.Drawing.Point(12, 452);
      this.groupBoxPrint.Name = "groupBoxPrint";
      this.groupBoxPrint.Size = new System.Drawing.Size(717, 65);
      this.groupBoxPrint.TabIndex = 1;
      this.groupBoxPrint.TabStop = false;
      this.groupBoxPrint.Text = "Print";
      // 
      // buttonPrint
      // 
      this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonPrint.Location = new System.Drawing.Point(608, 25);
      this.buttonPrint.Name = "buttonPrint";
      this.buttonPrint.Size = new System.Drawing.Size(93, 31);
      this.buttonPrint.TabIndex = 7;
      this.buttonPrint.Text = "Print";
      this.buttonPrint.UseVisualStyleBackColor = true;
      this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 31);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(59, 18);
      this.label4.TabIndex = 7;
      this.label4.Text = "Printer";
      // 
      // comboBoxPrinters
      // 
      this.comboBoxPrinters.FormattingEnabled = true;
      this.comboBoxPrinters.Location = new System.Drawing.Point(109, 28);
      this.comboBoxPrinters.Name = "comboBoxPrinters";
      this.comboBoxPrinters.Size = new System.Drawing.Size(369, 26);
      this.comboBoxPrinters.TabIndex = 8;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(741, 529);
      this.Controls.Add(this.groupBoxPrint);
      this.Controls.Add(this.groupBoxExportPDF);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.groupBoxExportPDF.ResumeLayout(false);
      this.groupBoxExportPDF.PerformLayout();
      this.groupBoxPrint.ResumeLayout(false);
      this.groupBoxPrint.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBoxExportPDF;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBoxPDFContents;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxPDFTitle;
    private System.Windows.Forms.Button buttonExport;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxPDFExportFolder;
    private System.Windows.Forms.GroupBox groupBoxPrint;
    private System.Windows.Forms.ComboBox comboBoxPrinters;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button buttonPrint;
  }
}

