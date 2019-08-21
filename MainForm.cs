using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Drawing.Printing;
using System.Drawing;

namespace PDFPrint
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      // Printerの一覧をComboboxに表示する
      comboBoxPrinters.DataSource = System.Drawing.Printing.PrinterSettings.InstalledPrinters.Cast<string>().ToList();

      // 前回保存を復帰
      textBoxPDFExportFolder.Text = Properties.Settings.Default.ExportFolder;
      textBoxPDFTitle.Text = Properties.Settings.Default.Title;
      textBoxPDFContents.Text = Properties.Settings.Default.Contents;
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Properties.Settings.Default.ExportFolder = textBoxPDFExportFolder.Text;
      Properties.Settings.Default.Title = textBoxPDFTitle.Text;
      Properties.Settings.Default.Contents = textBoxPDFContents.Text;
      Properties.Settings.Default.Save();
    }

    private void buttonExport_Click(object sender, EventArgs e)
    {
      var contents = textBoxPDFContents.Text;
      var title = textBoxPDFTitle.Text;
      var outFolder = textBoxPDFExportFolder.Text;
      try
      {
        if (textBoxPDFTitle.Text == "")
        {
          MessageBox.Show("No Title is input.", Properties.Resources.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }
        if (!System.IO.Directory.Exists(outFolder))
        {
          MessageBox.Show("Export folder is not exist.", Properties.Resources.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }
        ExportPDF(title, contents, outFolder);
        MessageBox.Show("PDF file is exported.", Properties.Resources.Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception exp)
      {
        MessageBox.Show(exp.Message, Properties.Resources.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void buttonPrint_Click(object sender, EventArgs e)
    {
      var contents = textBoxPDFContents.Text;
      var title = textBoxPDFTitle.Text;
      var outFolder = textBoxPDFExportFolder.Text;
      var printerName = comboBoxPrinters.SelectedItem.ToString();
      try
      {
        if (textBoxPDFTitle.Text == "")
        {
          MessageBox.Show("No Title is input.", Properties.Resources.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }
        if (!System.IO.Directory.Exists(outFolder))
        {
          MessageBox.Show("Export folder is not exist.", Properties.Resources.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        var src = ExportPDF(title, contents, outFolder);
        var folder = System.IO.Path.GetDirectoryName(src);
        var fileName = System.IO.Path.GetFileNameWithoutExtension(src);
        var dst = System.IO.Path.Combine(folder, fileName + ".tif");
        var pc = new ConvertPDF.PDFConvert();
        pc.OutputFormat = "tifflzw";  // TIFF
        pc.Convert(src, dst);

        using (var pd = new PrintDocument())
        {
          pd.DocumentName = "sample";
          pd.PrinterSettings.PrinterName = printerName;
          pd.PrintPage += new PrintPageEventHandler((s, eventArg) =>
          {
            using (var img = Image.FromFile(dst))
            {
              eventArg.Graphics.DrawImage(img, eventArg.MarginBounds);
            }
            eventArg.HasMorePages = false;
          });
          pd.Print();
        }
        System.IO.File.Delete(dst);
      }
      catch (Exception exp)
      {
        MessageBox.Show(exp.Message, Properties.Resources.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private static string ExportPDF(string title, string contents, string outFolder)
    {
      using (var document = new PdfDocument())
      {
        document.Info.Title = title;

        // 白紙をつくる（Ａ４縦）
        PdfPage page = document.AddPage();
        page.Size = PageSize.A4;
        page.Orientation = PageOrientation.Portrait;

        // XGraphicsオブジェクトを取得
        XGraphics gfx = XGraphics.FromPdfPage(page);

        // フォント
        XFont font = new XFont("游明朝", 20, XFontStyle.Regular);

        // 文字列描画
        gfx.DrawString(
            contents,
            font,
            XBrushes.Black,
            new XRect(0, 0, page.Width, page.Height),
            XStringFormats.TopLeft
            );

        // PDF保存
        var filepath = System.IO.Path.Combine(outFolder, title + ".pdf");
        document.Save(filepath);
        return filepath;
      }
    }

  }
}
