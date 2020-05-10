using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            if (ofdFile.ShowDialog()==DialogResult.OK)
            {
                LoadToEditor(ofdFile.FileName);
            }
        }

        private String currentFileName;

        private void LoadToEditor(string fileName)
        {
            try
            {
                string s = System.IO.File.ReadAllText(fileName);
                richTextBox.Text = s;
                richTextBox.Enabled = true;
                mnuSave.Enabled = true;
                mnuSaveAs.Enabled = true;
                currentFileName = fileName;
                tsFileName.Text = currentFileName;
            } catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveToFile(string fileName)
        {
            try
            {
                System.IO.File.WriteAllText(fileName, richTextBox.Text);
                String msg = String.Format("Zapisano do pliku: {0}", fileName);
                MessageBox.Show(msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            SaveToFile(currentFileName);
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            if (sfdFile.ShowDialog() == DialogResult.OK)
            {
                SaveToFile(sfdFile.FileName);
                currentFileName = sfdFile.FileName;
                tsFileName.Text = currentFileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tsFileName.Text = "";
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
