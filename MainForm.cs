using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

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
    }

    private void buttonExport_Click(object sender, EventArgs e)
    {

    }

    private void buttonPrint_Click(object sender, EventArgs e)
    {

    }

  }
}
