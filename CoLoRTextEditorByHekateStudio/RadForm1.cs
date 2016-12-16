using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinForms.Documents.FormatProviders;
using Telerik.WinForms.Documents.FormatProviders.OpenXml.Docx;
using Telerik.WinForms.Documents.Model;

namespace CoLoRTextEditorByHekateStudio
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            txt_Hekate.LayoutMode = DocumentLayoutMode.Flow;
            txt_Hekate.Document.SectionDefaultPageMargin = new Telerik.WinForms.Documents.Layout.Padding(0, 20, 100, 60);
            txt_Hekate.RichTextBoxElement.BackColor = System.Drawing.Color.Black;
            txt_Hekate.RichTextBoxElement.Font = new Font("Times New Roman", 50);//new FontFamily("Inconsolata");
            txt_Hekate.CaretColor = Color.WhiteSmoke;
            txt_Hekate.ChangeTextForeColor(Color.WhiteSmoke);
            txt_Hekate.Focus();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                txt_Hekate.CaretColor = Color.WhiteSmoke;
                txt_Hekate.ChangeTextForeColor(Color.WhiteSmoke);
                txt_Hekate.Focus();
            }
            if (keyData == (Keys.F2))
            {
                txt_Hekate.CaretColor = Color.Green;
                txt_Hekate.ChangeTextForeColor(Color.GreenYellow);
                txt_Hekate.Focus();
            }
            if (keyData == (Keys.F3))
            {
                txt_Hekate.CaretColor = Color.Red;
                txt_Hekate.ChangeTextForeColor(Color.Red);
                txt_Hekate.Focus();
            }
            if (keyData == (Keys.F4))
            {
                txt_Hekate.CaretColor = Color.Yellow;
                txt_Hekate.ChangeTextForeColor(Color.Yellow);
                txt_Hekate.Focus();
            }
            if (keyData == (Keys.F5))
            {
                txt_Hekate.CaretColor = Color.Silver;
                txt_Hekate.ChangeTextForeColor(Color.Silver);
                txt_Hekate.Focus();
            }
            if (keyData == (Keys.F6))
            {
                txt_Hekate.CaretColor = Color.Orange;
                txt_Hekate.ChangeTextForeColor(Color.Orange);
                txt_Hekate.Focus();
            }
            if (keyData == (Keys.F7))
            {
                txt_Hekate.CaretColor = Color.Violet;
                txt_Hekate.ChangeTextForeColor(Color.Violet);
                txt_Hekate.Focus();
            }
            if (keyData == (Keys.F8))
            {
                txt_Hekate.CaretColor = Color.SteelBlue;
                txt_Hekate.ChangeTextForeColor(Color.SteelBlue);
                txt_Hekate.Focus();
            }
            if (keyData == (Keys.F11))
            {
                ImportDocx();
            }
            if (keyData == (Keys.F12))
            {
                ExportToDocx(txt_Hekate.Document);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        //Save File
        public void ExportToDocx(RadDocument document)
        {
            DocxFormatProvider provider = new DocxFormatProvider();
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = ".hcx";
            saveDialog.Filter = "Documents|*.hcx";
            DialogResult dialogResult = saveDialog.ShowDialog();
            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                using (Stream output = saveDialog.OpenFile())
                {
                    provider.Export(document, output);
                    MessageBox.Show("Saved Successfuly!");
                }
            }
        }
        public RadDocument ImportDocx()
        {
            RadDocument document = null;
            txt_Hekate.RichTextBoxElement.BackColor = System.Drawing.Color.Black;
            IDocumentFormatProvider provider = new DocxFormatProvider();
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Documents|*.hcx";
            openDialog.Multiselect = false;
            DialogResult dialogResult = openDialog.ShowDialog();
            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                using (Stream stream = openDialog.OpenFile())
                {
                    txt_Hekate.RichTextBoxElement.Document = provider.Import(stream);
                    txt_Hekate.Focus();
                }
            }
            return document;
        }
        private void RadForm1_Load(object sender, EventArgs e)
        {
            if ((ModifierKeys & Keys.Shift) == 0)
            {
                string initLocation = Properties.Settings.Default.Location;
                Point il = new Point(0, 0);
                Size sz = Size;
                if (!string.IsNullOrWhiteSpace(initLocation))
                {
                    string[] parts = initLocation.Split(',');
                    if (parts.Length >= 2)
                    {
                        il = new Point(int.Parse(parts[0]), int.Parse(parts[1]));
                    }
                    if (parts.Length >= 4)
                    {
                        sz = new Size(int.Parse(parts[2]), int.Parse(parts[3]));
                    }
                }
                Size = sz;
                Location = il;
            }
        }

        private void RadForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((ModifierKeys & Keys.Shift) == 0)
            {
                Point location = Location;
                Size size = Size;
                if (WindowState != FormWindowState.Normal)
                {
                    location = RestoreBounds.Location;
                    size = RestoreBounds.Size;
                }
                string initLocation = string.Join(",", location.X, location.Y, size.Width, size.Height);
                Properties.Settings.Default.Location = initLocation;
                Properties.Settings.Default.Save();
            }
        }
    }
}
